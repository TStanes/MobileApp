using CommunityToolkit.Maui.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Sobas_Mob.Popups
{
    public partial class OrderHistoryPopup : Popup
    {
        public ObservableCollection<OrderHistoryItem> OrderHistory { get; }
        private readonly HttpClient _httpClient;
        private readonly IHttpClientFactory? _httpClientFactory;
        private readonly HttpClient _http;

        private HttpClient GetHttpClient() => _httpClientFactory?.CreateClient() ?? new HttpClient();
        public OrderHistoryPopup(OrderEntryViewModel vm ,/*HttpClient httpClient, */IHttpClientFactory factory)
        {
            InitializeComponent();
            //_httpClient = httpClient; // ✅ DI client (BaseAddress already set)
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://172.18.72.71:5134/"), // This is for physical device (tab/mobile)
                //BaseAddress = new Uri("http://192.168.29.159:5134/"), // This is for physical device (tab/mobile)
                //BaseAddress = new Uri("http://10.0.2.2:5134/")  // This for Android Emulator  
                //Real device: http://YOUR_PC_IP:5134/
            };
            _http = factory.CreateClient("ApiClient");
            BindingContext = vm;
            this.Opened += OrderHistoryPopup_Opened;

        }
        private async void OrderHistoryPopup_Opened(object? sender, EventArgs e)
        {
            if (BindingContext is not OrderEntryViewModel vm)
                return;

            await LoadOrderHistoryAsync(
                vm.OrderDate ?? DateTime.Today,
                vm.PartyCode,
                vm.PartyName
            );
        }

        private async Task LoadOrderHistoryAsync(DateTime orderDate, string partyCode, string partyName)
        {
            try
            {
                //var displayItems= new OrderEntryViewModel();
                var vm = BindingContext as OrderEntryViewModel;
                //if (vm == null || string.IsNullOrWhiteSpace(vm.OrderNo)) return;


               // using var httpClient = GetHttpClient();

                var datePart = orderDate.ToString("yyyy-MM-dd");

                //Token Generate
                var tokenResponse = await _http.GetAsync("Token/GenerateToken");
                var jsontok = await tokenResponse.Content.ReadAsStringAsync();

                var tokenObj = JsonSerializer.Deserialize<TokenResponse>(jsontok);
                // Bind token to header
                _http.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenObj.token);

                var url =
                    $"OrderEntry/GetOrderbyPartyForDay/{Uri.EscapeDataString(datePart)}" +
                    //$"http://192.168.29.159:5134/api/OrderEntry/GetOrderbyPartyForDay/{Uri.EscapeDataString(datePart)}" +
                    $"?PartyCode={Uri.EscapeDataString(partyCode ?? string.Empty)}" +
                    $"&PartyName={Uri.EscapeDataString(partyName ?? string.Empty)}";

                var response = await _http.GetAsync(url); // ✅ FIXED

                if (!response.IsSuccessStatusCode)
                    return;

                var json = await response.Content.ReadAsStringAsync();

                var items = JsonSerializer.Deserialize<List<SaleOrderMobileDto>>(json,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                // 3️⃣ Validate items
                if (items == null || items.Count == 0)
                    return;

                // 4️⃣ Add items safely
                //vm.AddedItems.Clear();
                vm.OrderHistory.Clear();

                foreach (var item in items)
                {
                    if (item == null) continue;

                    vm.OrderHistory.Add(new OrderEntryItemViewModel
                    {
                        ItemCode = item.ItemCode ?? string.Empty,
                        ItemDescription = item.ItemDescription ?? string.Empty,
                        Quantity = item.Quantity,
                        Remarks = item.Remarks
                    });

                }
                
               

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    ex.Message,
                    "OK");
            }
            //return null;
        }

        private void OnCloseClicked(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class OrderHistoryItem
    {
        public string OrderNo { get; set; }
    }
}
