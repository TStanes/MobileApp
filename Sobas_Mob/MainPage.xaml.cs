using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;
using ZXing.Net.Maui.Controls;
using System.Linq;
using ZXing.Net.Maui;

namespace Sobas_Mob
{

    public partial class MainPage : ContentPage
        //private readonly CommonDB_TestDbContext _dbcontext;
    {
        string lastDetectedBarcode = string.Empty;
        DateTime lastDetectedTime = DateTime.MinValue;
        private readonly HttpClient _httpClient;
        private OrderEntryViewModel _orderVm;
        public static IServiceProvider Services { get; set; }

        // private IHttpClientFactory apiClientOptions;


        public string PartyCode { get; }
        public string PartyName { get; }

        public MainPage(string partyCode, string partyName)
        {
            InitializeComponent();

            // ✅ Resolve HttpClient from MAUI DI
            _httpClient = App.Current.Handler.MauiContext.Services
                .GetRequiredService<HttpClient>();
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://172.18.72.71:5134/"), // This is for physical device (tab/mobile)
                //BaseAddress = new Uri("http://10.0.2.2:5134/")  // This for Android Emulator  
                //Real device: http://YOUR_PC_IP:5134/
            };

            //cameraBarcodeReaderView.Options = new ZXing.Net.Maui.BarcodeReaderOptions
            //{
            //    Formats = ZXing.Net.Maui.BarcodeFormat.QrCode,
            //    AutoRotate = true,
            //    Multiple = false,
            //   // TryHarder = true
            //    TryHarder = false
            //};  //Commanded for testing 

            cameraBarcodeReaderView.Options = new BarcodeReaderOptions
            {
                Formats =  BarcodeFormat.QrCode,
                AutoRotate = false,
                Multiple = false,
                TryHarder = false,
                TryInverted = true   // improves detection for bright/light QR
                

            };  // Added for testing 
            //cameraBarcodeReaderView.IsDetecting = true; // commandted for testing 
            cameraBarcodeReaderView.CameraLocation = CameraLocation.Rear;  // Added for testing 
            cameraBarcodeReaderView.IsDetecting = false;

            // Force low resolution for faster scanning



            PartyCode = partyCode;
            PartyName = partyName;

            // Example usage
            // PartyNameLabel.Text = partyName;
        }

        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();

        //    var status = await Permissions.CheckStatusAsync<Permissions.Camera>();
        //    if (status != PermissionStatus.Granted)
        //        status = await Permissions.RequestAsync<Permissions.Camera>();

        //    cameraBarcodeReaderView.IsDetecting = (status == PermissionStatus.Granted);
        //    //cameraBarcodeReaderView.IsDetecting = true;  //Commanded for testing 


        //}  // Commanded for testing 


        //Added for testing from
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Ask permission early
            var status = await Permissions.CheckStatusAsync<Permissions.Camera>();
            if (status != PermissionStatus.Granted)
                status = await Permissions.RequestAsync<Permissions.Camera>();

            // Configure before enabling detection
            cameraBarcodeReaderView.IsDetecting = false;
            cameraBarcodeReaderView.CameraLocation = CameraLocation.Rear;

            cameraBarcodeReaderView.Options = new BarcodeReaderOptions
            {
                // Keep it laser-focused on QR only
                Formats = BarcodeFormat.QrCode,

                // QR is orientation-invariant. Turning this off saves cycles.
                AutoRotate = false,

                // Faster than true in most cases
                TryHarder = false,

                // Only one result per frame
                Multiple = false,

                // Optional: if some codes have inverted colors, turn this on to improve reliability
                // (Note: enabling can add a small overhead; keep it false unless you need it)
                // TryInverted = true
            };

            if (status == PermissionStatus.Granted)
            {
                // Give the camera a moment to start, settle exposure, and focus
                await Task.Delay(250);   // 200–400ms works well in practice
                cameraBarcodeReaderView.IsDetecting = true;
            }
        }
        //Added for testing to


        public void BarcodeDetected(object sender, BarcodeDetectionEventArgs e)
        {
            var first = e.Results?.FirstOrDefault();
            if (first == null)
                return;

            //if (first.Value == lastDetectedBarcode && (DateTime.Now - lastDetectedTime).TotalSeconds < 1)
            if (first.Value == lastDetectedBarcode && (DateTime.Now - lastDetectedTime).TotalMilliseconds < 800)
                return;

            lastDetectedBarcode = first.Value;
            lastDetectedTime = DateTime.Now;
            
            // 🔥 Stop scanning immediately
            cameraBarcodeReaderView.IsDetecting = false;

            //Dispatcher.DispatchAsync(async () =>
            //{
            //    await DisplayAlert("Barcode Detected", first.Value, "OK");
            //    OnBarcodeDetected(first.Value);
            //});  // commandted for testing 

            Dispatcher.Dispatch(() =>
            {
                _ = OnBarcodeDetected(first.Value);
            });  //Added for testing
        }

        private async Task<bool> CheckItemExistsInBackend(int orderId,string partyCode,string itemCode)
        {
            // Call API
            var response = await _httpClient.GetAsync(
                $"api/OrderEntry/GetAllOrder?orderId={orderId}&partyCode={partyCode}&itemCode={itemCode}");

            return response.IsSuccessStatusCode;
        }

        private OrderEntryItemViewModel CreateItem( string code, string desc, decimal rate, int qty, string remarks)
        {
            return new OrderEntryItemViewModel
            {
                ItemCode = code,
                ItemDescription = desc,
                Quantity = qty,
                Rate = rate,
                Remarks = remarks,
                PartyCode = this.PartyCode,
                PartyName = this.PartyName
            };
        }
        private async Task OnBarcodeDetected(string detectedQrString)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(detectedQrString))
                    return;

                var parts = detectedQrString
                    .Split(new[] { '^', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => p.Trim())
                    .ToArray();

                string itemCode = parts.ElementAtOrDefault(0);
                string itemDescription = parts.ElementAtOrDefault(1);
                decimal rate = Convert.ToDecimal(parts.ElementAtOrDefault(2));
                // string qty = parts.ElementAtOrDefault(3) ?? "0";
                int qty = int.TryParse(parts.ElementAtOrDefault(3), out var q) ? q : 0;
                string remarks = parts.ElementAtOrDefault(4) ?? "";

                // 🔹 FIRST SCAN
                if (_orderVm == null)
                {
                    //_orderVm = new OrderEntryViewModel
                    //{
                    //    PartyCode = PartyCode,
                    //    PartyName = PartyName
                    //};
                    //_orderVm = App.Current.Services.GetRequiredService<OrderEntryViewModel>();
                    _orderVm = App.Current.Handler.MauiContext.Services.GetRequiredService<OrderEntryViewModel>();

                    _orderVm.PartyCode = PartyCode;
                    _orderVm.PartyName = PartyName;

                    _orderVm.ItemCode = itemCode;
                    _orderVm.ItemDescription = itemDescription; 
                    _orderVm.Rate = rate;
                    _orderVm.Quantity = qty;
                    _orderVm.Remarks = remarks;

                    var services = App.Current.Handler.MauiContext.Services;

                    var orderPage = services.GetRequiredService<OrderEntryPage>();

                    //await Navigation.PushModalAsync(orderPage);
                    var factory = App.Current.Handler.MauiContext.Services.GetRequiredService<IHttpClientFactory>();


                    await Navigation.PushModalAsync(new OrderEntryPage(factory, _orderVm, true));
                    //await Navigation.PushModalAsync(serviceProvider.GetRequiredService<OrderEntryPage>());
                    return;
                }

                // 🔹 SUBSEQUENT SCANS
                if (_orderVm.AddedItems.Any(x => x.ItemCode == itemCode))
                {
                    await DisplayAlert("Duplicate",
                        "This item already exists in this order.",
                        "OK");
                    return;
                }

              

                _orderVm.AddedItems.Add(new OrderEntryItemViewModel
                {
                    ItemCode = itemCode,
                    ItemDescription = itemDescription,
                    Quantity = qty,
                    Rate = rate,
                    Remarks = remarks,
                   
                });
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }






    }
}
