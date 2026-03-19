using CommunityToolkit.Maui.Views;
using Microsoft.Extensions.DependencyInjection;
using Sobas_Mob.Popups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sobas_Mob
{   
    public partial class OrderEntryPage : ContentPage
    {
        private readonly OrderEntryViewModel _viewModel;
        private readonly IHttpClientFactory? _httpClientFactory;
        private string _apiBaseAddress = string.Empty;
        private readonly HttpClient _httpClient;
        private readonly HttpClient _http;

        public OrderEntryViewModel ViewModel { get; }
        private  bool _openRemarksPopupOnce;
        public static IServiceProvider Services { get; set; }

        public OrderEntryPage(IHttpClientFactory factory, OrderEntryViewModel viewModel,  bool openRemarksPopupOnce = false)
        {
            InitializeComponent();

            _http = factory.CreateClient("ApiClient");

            //_httpClient = new HttpClient
            //{
            //    BaseAddress = new Uri("http://172.18.72.71:5134/api/"), // This is for physical device (tab/mobile)
            //    //BaseAddress = new Uri("http://192.168.29.159:5134/"), // This is for physical device (tab/mobile)
            //    //BaseAddress = new Uri("http://10.0.2.2:5134/")  // This for Android Emulator  
            //    //Real device: http://YOUR_PC_IP:5134/
            //};
            BindingContext = viewModel;
            _openRemarksPopupOnce = openRemarksPopupOnce;
            _viewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
            BindingContext = _viewModel; // ✅ single assignment
            
            //BindingContext = new OrderEntryViewModel(); // Uncommanded for testing 

            var services = Application.Current?.Handler?.MauiContext?.Services;
            if (services is not null)
            {
                _httpClientFactory = services.GetService<IHttpClientFactory>();
                var opts = services.GetService<ApiClientOptions>();
                _apiBaseAddress = opts?.ApiBaseAddress ?? GetDefaultBaseUrl();
            }
            else
            {
                _apiBaseAddress = GetDefaultBaseUrl();
            }
        }




        private bool _isRemarksPopupOpened = false;




        protected override void OnHandlerChanged()
          {
            base.OnHandlerChanged();

            if (!_openRemarksPopupOnce || Handler == null)
                return;

            _openRemarksPopupOnce = false;

            Dispatcher.Dispatch(async () =>
            {
                await Task.Delay(200); 
                var popup = new RemarksPopupPage(App.Current.Handler.MauiContext.Services
    .GetRequiredService<IHttpClientFactory>(),


        onSave: ( remarks, totalQty, partyCode, partyName) =>
                {
                    if (BindingContext is OrderEntryViewModel vm)
                    {
                        vm.Remarks = remarks;
                        vm.Quantity = totalQty;

                        vm.PartyCode = partyCode;
                        vm.PartyName = partyName;

                    }
                    // 🔥 NOW CALL YOUR EXISTING SAVE METHOD
                    OnSaveClicked(this, EventArgs.Empty);
                },

                 (OrderEntryViewModel)BindingContext
                );
                // Optionally inherit the current page's VM
               popup.BindingContext = this.BindingContext;


                await Navigation.PushModalAsync(popup);
            });
        }


      
        private HttpClient GetHttpClient() => _httpClientFactory?.CreateClient() ?? new HttpClient();

        private static string GetDefaultBaseUrl()
        {
            return DeviceInfo.Platform == DevicePlatform.Android
                ? "http://10.0.2.2:5134"
                : "http://localhost:5134";
        }

     

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            try
            {
                var vm = BindingContext as OrderEntryViewModel;
                if (vm == null || string.IsNullOrWhiteSpace(vm.ItemCode))
                {
                    await DisplayAlert("Warning", "No current item to save", "OK");
                    return;
                }


                // 1) Save the current item
                var order = new SaleOrderMobileDto
                {
                    SalesOrderUid = Guid.NewGuid(),

                    OrderNo = string.Empty,
                    OrderDate = DateTime.Now,
                    PartyCode = vm.PartyCode,
                    PartyName = vm.PartyName,
                    ItemCode = vm.ItemCode,
                    ItemDescription = vm.ItemDescription,
                    Quantity = vm.Quantity,
                    Rate = vm.Amount,
                    Remarks = vm.Remarks,
                    CreatedDate = DateTime.Now,
                    CreatedBy = vm.PartyName,
                    ModifiedDate = DateTime.Now,
                    ModifiedBy = vm.PartyName
                    
                };
                var jsonContent = JsonSerializer.Serialize(order);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                //Token Generate
                var tokenResponse = await _http.GetAsync("Token/GenerateToken");
                var json = await tokenResponse.Content.ReadAsStringAsync();

                var tokenObj = JsonSerializer.Deserialize<TokenResponse>(json);
                // Bind token to header
                _http.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenObj.token);

                var response = await _http.PostAsJsonAsync(
                    "OrderEntry/Create",
                    order
                );

                var responseContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseContent);

                var cleanMessage = responseContent.Trim('"');

                if (cleanMessage.Contains("Multiple categories are not allowed"))
                {
                    await DisplayAlert("Error",
                        "Multiple categories are not allowed in the same order",
                        "OK");
                    return;
                }

                response.EnsureSuccessStatusCode();



                // 2) Read Order ID from response
                var savedOrder = await response.Content.ReadFromJsonAsync<SaleOrderMobileDto>();
                if (!string.IsNullOrWhiteSpace(savedOrder?.OrderNo))
                    vm.OrderNo = savedOrder.OrderNo;

                // 3) Validate Order ID
                if (string.IsNullOrWhiteSpace(vm.OrderNo))
                {
                    await DisplayAlert("Error", "Order ID not generated", "OK");
                    return;
                }

                // 4) Load order items from API
                await LoadOrderItemsAsync();

                // 5) Reset input fields
                vm.CurrentItem = new OrderEntryItemViewModel();
                
                vm.Quantity = 0;
                vm.Remarks = string.Empty;

                //await DisplayAlert("Success", "Order saved successfully", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
            await LoadOrderItemsAsync();
        }

        private async Task LoadOrderItemsAsync()
        {
            var vm = BindingContext as OrderEntryViewModel;
            if (vm == null || string.IsNullOrWhiteSpace(vm.OrderNo)) return;

            //Token Generate
            var tokenResponse = await _http.GetAsync("Token/GenerateToken");
            var jsontok = await tokenResponse.Content.ReadAsStringAsync();

            var tokenObj = JsonSerializer.Deserialize<TokenResponse>(jsontok);
            // Bind token to header
            _http.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenObj.token);


            //using var httpClient = GetHttpClient();
            var url =
                $"OrderEntry/GetByOrderId/{Uri.EscapeDataString(vm.OrderNo)}" +
                $"?PartyCode={Uri.EscapeDataString(vm.PartyCode ?? string.Empty)}" +
                $"&PartyName={Uri.EscapeDataString(vm.PartyName ?? string.Empty)}";

            //var response = await _httpClient.GetAsync(url);
            //if (!response.IsSuccessStatusCode) return;
            var response = await _http.GetAsync(url);
            if (!response.IsSuccessStatusCode) return;

            var json = await response.Content.ReadAsStringAsync();

            var items = JsonSerializer.Deserialize<List<SaleOrderMobileDto>>(json,
                                   new JsonSerializerOptions
                                   {
                                    PropertyNameCaseInsensitive = true
                                   });

            vm.AddedItems.Clear();
            if (items == null) return;

            foreach (var item in items)
            {
                vm.AddedItems.Add(new OrderEntryItemViewModel
                {
                    SalesOrderUid = item.SalesOrderUid,
                    ItemCode = item.ItemCode,
                    ItemDescription = item.ItemDescription,
                    Quantity = item.Quantity,

                });
            }
        }

        private async void OnScanClicked(object sender, EventArgs e)
        {
            if (BindingContext is OrderEntryViewModel vm)
            {
                await Navigation.PushAsync(new MainPage(vm.PartyCode, vm.PartyName));
            }
        }

        private async void UpdateActive(object sender, EventArgs e)
        {
            try
            {
                var vm = BindingContext as OrderEntryViewModel;
                if (vm == null || string.IsNullOrWhiteSpace(vm.OrderNo))
                {
                    //await DisplayAlert("Error", "Order ID not found", "OK");
                    await DisplayAlert("Order Required","Please add at least one item before placing the order.","OK");

                    return;
                }

                //Token Generate
                var tokenResponse = await _http.GetAsync("Token/GenerateToken");
                var json = await tokenResponse.Content.ReadAsStringAsync();

                var tokenObj = JsonSerializer.Deserialize<TokenResponse>(json);
                // Bind token to header
                _http.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenObj.token);

                var url = $"OrderEntry/ActivateOrder/{Uri.EscapeDataString(vm.OrderNo)}";
                //var response = await _httpClient.PutAsync(url, null);
                var response = await _http.PutAsync(url, null);

                if (!response.IsSuccessStatusCode)
                {
                    var error = await response.Content.ReadAsStringAsync();
                    await DisplayAlert("Error", error, "OK");
                    return;
                }
                vm.AddedItems.Clear();
                vm.OrderNo = string.Empty;
                await DisplayAlert("Success", "Order activated successfully", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void DeleteOrder(object sender, EventArgs e)
        {
            try
            {
                var button = sender as ImageButton;
                var item = button?.BindingContext as OrderEntryItemViewModel;

                if (item == null)
                    return;
                var vm = BindingContext as OrderEntryViewModel;
                if (vm == null || string.IsNullOrWhiteSpace(vm.OrderNo) )//&&  vm.Sno == 0)
                {
                    await DisplayAlert("Delete Failed", "Unable to delete the order because it could not be found.","OK");

                    //await DisplayAlert("Error", "Order ID not found", "OK");
                    return;
                }

                bool confirm = await DisplayAlert("Confirm Delete", "Are you sure you want to delete this Item ?","Yes","No");
                if (!confirm) return;

                //Token Generate
                var tokenResponse = await _http.GetAsync("Token/GenerateToken");
                var json = await tokenResponse.Content.ReadAsStringAsync();

                var tokenObj = JsonSerializer.Deserialize<TokenResponse>(json);
                // Bind token to header
                _http.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenObj.token);

                //using var httpClient = GetHttpClient();
                var url = $"OrderEntry/DeleteOrder/{Uri.EscapeDataString(vm.OrderNo)}/{item.SalesOrderUid}";
                

                //var response = await _httpClient.DeleteAsync(url);
                var response = await _http.DeleteAsync(url);
                 if (!response.IsSuccessStatusCode)
                {
                    var error = await response.Content.ReadAsStringAsync();
                    await DisplayAlert("Error", error, "OK");
                    return;
                }
                //vm.OrderHistory.Remove(item);
                vm.AddedItems.Clear();
                await LoadOrderItemsAsync();
                await DisplayAlert("Success", "Order deleted successfully", "OK");
                //await LoadOrderItemsAsync();
                

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void OnOrderHistoryClicked(object sender, EventArgs e)
        {
            var vm = BindingContext as OrderEntryViewModel;

            if (vm == null) return;

            var factory = App.Current.Handler.MauiContext.Services
       .GetRequiredService<IHttpClientFactory>();

            await this.ShowPopupAsync(new OrderHistoryPopup(vm,factory));
            //await this.ShowPopupAsync(new OrderHistoryPopup(/*_httpClient,*/ DateTime.Now, vm.PartyCode, vm.PartyName));

            //await this.ShowPopupAsync(new OrderHistoryPopup(DateTime.Now, vm.PartyCode, vm.PartyName));
        }

        /// <summary>
        /// Remarks for binding 
        /// </summary>
        private string _remarks;
        public string Remarks
        {
            get => _remarks;
            set
            {
                _remarks = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// Order for binding
        /// </summary>
        private int _quantity;
        public int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged();
            }
        }

        private bool _isPopupOpen;
        public bool IsRemarksPopupReturn { get; set; }

        
        private async void Remarks_Tapped(object sender, EventArgs e)
        {
            if (BindingContext is not OrderEntryViewModel vm)
                return;

            var httpClient = App.Current.Handler.MauiContext.Services
                .GetRequiredService<IHttpClientFactory>(); 

            var popup = new RemarksPopupPage(httpClient,
                (remarks, totalQty, partyCode, partyName) =>
                {
                    if (BindingContext is OrderEntryViewModel vm)
                    {
                        vm.Remarks = remarks;
                        vm.Quantity = totalQty;

                        vm.PartyCode = partyCode;
                        vm.PartyName = partyName; 

                    }
                    // 🔥 NOW CALL YOUR EXISTING SAVE METHOD
                    OnSaveClicked(this, EventArgs.Empty);
                },//,
                
                 (OrderEntryViewModel)BindingContext

            );

            popup.ShowMessage = async msg =>
            {
                await DisplayAlert("Validation", msg, "OK");
            };

            // Share SAME ViewModel
     

             await Navigation.PushModalAsync(popup);
        }


        private async void ExitClicked(object sender, EventArgs e)
        {
            bool confirm = await DisplayAlert(
                "Exit App",
                "Are you sure you want to exit?",
                "Yes",
                "No");

            if (!confirm) return;

#if ANDROID
            Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
#elif WINDOWS
    Application.Current?.Quit();
#endif
        }
    }
}
