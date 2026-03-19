using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading.Tasks;

namespace Sobas_Mob
{
    public partial class RemarksPopupPage : ContentPage
    {
        // Collections
        private readonly HttpClient _http;

        //public ObservableCollection<string> Categories { get; set; }
        public ObservableCollection<int> Sizes { get; set; } = new();
        public ObservableCollection<string> GroupSizes { get; set; } = new();
        public ObservableCollection<string> Colors { get; set; } = new();

        // Order items added from popup
        public ObservableCollection<SizeSelectionDto> OrderItems { get; set; } = new();

        // Selected values
        private string _selectedCategory;
        public string SelectedCategory
        {
            get => _selectedCategory;
            set
            {
                if (_selectedCategory == value) return;
                _selectedCategory = value;
                OnPropertyChanged();

                // Load sizes and colors whenever category changes
                if (!string.IsNullOrEmpty(_selectedCategory))
                {
                    _ = LoadGroupSizesFromApi(_selectedCategory);
                   // _ = LoadSizesFromApi(_selectedCategory);
                    _ = LoadColorsFromApi(_selectedCategory);
                }
            }
        }

        private int _selectedSize;
        public int SelectedSize
        {
            get => _selectedSize;
            set { _selectedSize = value; OnPropertyChanged(); }
        }
        private string _selectedGroupSize;
        public string SelectedGroupSize
        {
            get => _selectedGroupSize;
            set { _selectedGroupSize = value; OnPropertyChanged();  }
        }
        private string _selectedColor;
        public string SelectedColor
        {
            get => _selectedColor;
            set { _selectedColor = value; OnPropertyChanged(); }
        }

        private int _quantity = 1;
        public int Quantity
        {
            get => _quantity;
            set { _quantity = value; OnPropertyChanged(); }
        }

        private string _remarks;
        public string Remarks
        {
            get => _remarks;
            set { _remarks = value; OnPropertyChanged(); }
        }

        private bool _isCategoryLocked;
        private bool _isColorLocked;
        public bool IsCategoryEnabled => !_isCategoryLocked;
        public bool IsColorEnabled => !_isColorLocked;

        private readonly Action<string, int, string, string> _onSave;
        private readonly Action? _onItemAdded;
        //private readonly Action<SizeSelectionDto>? _onItemAdded;
        private readonly OrderEntryViewModel _viewModel;
        private readonly OrderEntryViewModel _parentViewModel;
        public OrderEntryViewModel ViewModel { get; }
        public ObservableCollection<string> Categories { get; } =
           new ObservableCollection<string> { "Children", "Women", "Men" };


        public RemarksPopupPage(/*HttpClient httpClient,*/  IHttpClientFactory factory, Action<string, int, string, string> onSave, OrderEntryViewModel? viewModel, Action onItemAdded = null)
        {
            InitializeComponent();

            _http = factory.CreateClient("ApiClient");
           

            _onSave = onSave;
            _onItemAdded = onItemAdded;

           

            // ✅ ONE BindingContext ONLY
            BindingContext = this;

            //ViewModel =
            //    viewModel
            //    ?? Application.Current?.MainPage?.BindingContext as OrderEntryViewModel
            //    ?? new OrderEntryViewModel();

            // ✅ Parent VM stored separately
            //ViewModel = viewModel
            //    ?? throw new ArgumentNullException(nameof(viewModel));
            _parentViewModel = viewModel;

            BindingContext = _parentViewModel;

            _parentViewModel = viewModel
       ?? throw new ArgumentNullException(nameof(viewModel));

            //_httpClient = new HttpClient
            //{
            //    BaseAddress = new Uri("http://172.18.72.71:5134/")
            //    //BaseAddress = new Uri("http://192.168.29.159:5134/")
            //};

            System.Diagnostics.Debug.WriteLine($"Categories count: {Categories.Count}");

            // Load Sizes and Colors from API
            _ = LoadGroupSizesFromApi(_selectedCategory);
           // _ = LoadSizesFromApi(_selectedCategory);
            _ = LoadColorsFromApi(_selectedCategory);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            // ✅ ONE BindingContext ONLY
            BindingContext = this;
            // Automatically inherit parent BindingContext
            if (BindingContext == null &&
                Application.Current?.MainPage?.BindingContext is OrderEntryViewModel vm)
            {
                BindingContext = vm;
            }
        }


        //Select GroupSize
        private async Task LoadGroupSizesFromApi(string category)
        {

            try
            {
                if (string.IsNullOrEmpty(category))
                    //await DisplayAlert("Validation", "Please Select Category", "OK");
                    return;

                var tokenResponse = await _http.GetAsync("Token/GenerateToken");
                var json = await tokenResponse.Content.ReadAsStringAsync();

                var tokenObj = JsonSerializer.Deserialize<TokenResponse>(json);
                // Bind token to header
                _http.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenObj.token);


                string apiUrl = $"OrderEntry/GetGroupSizesByCategory?category={Uri.EscapeDataString(category)}";

                var response = await _http.GetAsync(apiUrl);

                if (!response.IsSuccessStatusCode)
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();

                    await DisplayAlert(
                        "Server Error",
                        $"Status: {response.StatusCode}\n{errorMessage}",
                        "OK");

                    return;
                }
                var groupsizeFromApi = await _http.GetFromJsonAsync<string[]>(apiUrl);


                if (groupsizeFromApi != null)
                {
                    GroupSizes.Clear();
                    foreach (var groupsize in groupsizeFromApi)
                        GroupSizes.Add(groupsize);
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Failed to load colors: {ex.Message}", "OK");
            }
        }

        // Async API call to fetch Sizes
        private async Task LoadSizesFromApi(string category, string groupSize)
        {


            try
            {
                if (string.IsNullOrEmpty(category))
                    //await DisplayAlert("Validation", "Please Select Category", "OK");
                    return;

                var tokenResponse = await _http.GetAsync("Token/GenerateToken");
                var json = await tokenResponse.Content.ReadAsStringAsync();

                var tokenObj = JsonSerializer.Deserialize<TokenResponse>(json);
                // Bind token to header
                _http.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenObj.token);

                // Append the selected category as a query parameter

                string apiUrl = $"OrderEntry/GetSizesByCategory?category={Uri.EscapeDataString(category)}";
                var response = await _http.GetAsync(apiUrl);
                //var responseText = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    await DisplayAlert(
                        "Error",
                        $"Server returned {response.StatusCode}",
                        "OK");
                    return;
                }

                //var sizesFromApi = await _http.GetFromJsonAsync<int[]>(apiUrl);
                var sizesFromApi = await response.Content.ReadFromJsonAsync<int[]>();


                if (sizesFromApi != null)
                {
                    Sizes.Clear();
                    foreach (var size in sizesFromApi)
                        Sizes.Add(size);

                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Failed to load sizes: {ex.Message}", "OK");
            }
        }

        // Async API call to fetch Colors
        private async Task LoadColorsFromApi(string category)
        {

            try
            {
                if (string.IsNullOrEmpty(category))
                    //await DisplayAlert("Validation", "Please Select Category", "OK");
                return;

                //Token Generate
                var tokenResponse = await _http.GetAsync("Token/GenerateToken");
                var json = await tokenResponse.Content.ReadAsStringAsync();

                var tokenObj = JsonSerializer.Deserialize<TokenResponse>(json);
                // Bind token to header
                _http.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenObj.token);

                string apiUrl = $"OrderEntry/GetColorsByCategory?category={Uri.EscapeDataString(category)}";

                var response = await _http.GetAsync(apiUrl);

                if (!response.IsSuccessStatusCode)
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();

                    await DisplayAlert(
                        "Server Error",
                        $"Status: {response.StatusCode}\n{errorMessage}",
                        "OK");

                    return;
                }
                var colorsFromApi = await _http.GetFromJsonAsync<string[]>(apiUrl);


            if (colorsFromApi != null)
            { 
                Colors.Clear();
                foreach (var color in colorsFromApi)
                        Colors.Add(color);
            }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Failed to load colors: {ex.Message}", "OK");
            }
        }

        private void IncreaseQty(object sender, EventArgs e)
        {
            Quantity++;
            OnPropertyChanged(nameof(Quantity));
        }

        private void DecreaseQty(object sender, EventArgs e)
        {
            if (Quantity > 1)
                Quantity--;

            OnPropertyChanged(nameof(Quantity));
        }

        private async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

       

        private void RecalculateTotalQuantity()
        {
            Quantity = OrderItems.Sum(x => x.Quantity);
        }
        public Action<string>? ShowMessage { get; set; }

        private async void AddItemClicked(object sender, EventArgs e)
        {
            await AddItemAsync();
        }
        private  async Task AddItemAsync()
        {
            if (string.IsNullOrWhiteSpace(SelectedGroupSize) || string.IsNullOrWhiteSpace(SelectedColor))
            {
                await DisplayAlert("Validation","Please select size and color.","OK");
                return;
            }

            if (Quantity <= 0)
            {
                await DisplayAlert("Validation", "You have to add minimum 1 quantity.", "OK");
                return;
            }

            // 🔹 DUPLICATE CHECK (same Category + Size + Color)
            bool alreadyExists = OrderItems.Any(x =>
               // x.Size == SelectedSize && x.Quantity == Quantity
                x.GroupSize == SelectedGroupSize && x.Quantity == Quantity 
               
            );

            if (alreadyExists)
            {
                await DisplayAlert(
                    "Duplicate item",
                    $"Size {SelectedGroupSize} with color {SelectedColor} is already added.",
                    "OK"
                );
                // 🔹 Reset Quantity even if duplicate
                Quantity = 1;
                OnPropertyChanged(nameof(Quantity));
                return;
            }

            // Add item to OrderItems
            OrderItems.Add(new SizeSelectionDto
            {
                Category = SelectedCategory, // store once
                //Size = SelectedSize,
                //Size = int.Parse(SelectedGroupSize),
                GroupSize = SelectedGroupSize,
                Color = SelectedColor,
                Quantity = Quantity,


                 // ✅ FROM PARENT VM
                PartyCode = _parentViewModel.PartyCode,
                PartyName = _parentViewModel.PartyName
            });


            // Lock after first add
            _isCategoryLocked = true;
            _isColorLocked = true;

            Quantity = 1;
            SelectedSize = 0;

            OnPropertyChanged(nameof(IsCategoryEnabled));
            OnPropertyChanged(nameof(IsColorEnabled));
            OnPropertyChanged(nameof(SelectedSize));
            OnPropertyChanged(nameof(SelectedGroupSize));
            OnPropertyChanged(nameof(Quantity));


            // Notify parent page
            _onItemAdded?.Invoke();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private async void OnClickedSave(object sender, EventArgs e)
        {
            if (!OrderItems.Any())
            {
                await DisplayAlert("Alert", "No items added", "OK");
                return;
            }

            string categoryShort = SelectedCategory.Substring(0, 1).ToUpper();
            string color = SelectedColor;

           // var sizeQtyList = OrderItems.Select(x => $"{x.Size}-{x.Quantity}");
            var sizeQtyList = OrderItems.Select(x => $"{x.GroupSize}-{x.Quantity}");

            string remarks = $"{categoryShort}/{color} = {string.Join(", ", sizeQtyList)}";
            int totalQty = OrderItems.Sum(x => x.Quantity);

            _onSave?.Invoke(remarks, totalQty, _parentViewModel.PartyCode,
    _parentViewModel.PartyName);

            await Navigation.PopModalAsync();
       
        }


        private async void OnScanClicked(object sender, EventArgs e)
        {

           // BindingContext = new OrderEntryViewModel();
            //OrderEntryViewModel vm = BindingContext as OrderEntryViewModel;

            // ALWAYS use parent VM
            if (_parentViewModel == null)
            {
                await DisplayAlert("Error", "Party details not available", "OK");
                return;
            }

            await Navigation.PushModalAsync(
                new MainPage(
                    _parentViewModel.PartyCode,
                    _parentViewModel.PartyName
                )
            );

            
        }

        private async void OnCloseClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }

    // DTO for size-color-quantity selection
    public class SizeSelectionDto
    {
        public string Category { get; set; }
       // public int Size { get; set; }
        public string GroupSize { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }

        // ✅ ADD THESE
        public string PartyCode { get; set; }
        public string PartyName { get; set; }
    }
 
}
