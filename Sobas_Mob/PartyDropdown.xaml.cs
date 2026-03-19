using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
//using ThreadNetwork;

namespace Sobas_Mob
{
    public partial class PartyDropdown : ContentPage
    {
        private readonly HttpClient _http;
        private List<PartyDto> _allParties = new();
        private List<string> _partyDisplayList = new();

        public  PartyDropdown(IHttpClientFactory factory)
        {

            InitializeComponent();
           
            _http = factory.CreateClient("ApiClient");

            LoadPartyDropdown();
           
        }
    
        private async void LoadPartyDropdown()
        {
            try
            {
                // Get token
                var tokenResponse = await _http.GetAsync("Token/GenerateToken");
                var json = await tokenResponse.Content.ReadAsStringAsync();

                var tokenObj = JsonSerializer.Deserialize<TokenResponse>(json);
                // Bind token to header
                _http.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenObj.token);

                var response = await _http.GetAsync("OrderEntry/GetItemCode");
                if (!response.IsSuccessStatusCode)
                {
                    await DisplayAlert("Error",
                        $"Server returned {response.StatusCode}", "OK");
                    return;
                }

                var parties = await response.Content
                    .ReadFromJsonAsync<List<PartyDto>>();

                if (parties == null || parties.Count == 0)
                {
                    await DisplayAlert("Info", "No parties found", "OK");
                    return;
                }

                // Keep full list if needed later
                //_allParties = parties;  // Commanded for testing 

                // Sort A-Z
                _allParties = parties
                    .OrderBy(x => x.PartyName)
                    .ToList();

                // Bind CollectionView (NOT Picker)
                PartyList.ItemsSource = _allParties;
                    //.Select(x => $"{x.PartyName} - {x.PartyCode}")
                    //.ToList();  // Commanded for testing 

                //// Bind Picker
                //PartyPicker.ItemsSource = parties
                //    .Select(x => $"{x.PartyName} - {x.PartyCode}")
                //    .ToList();  // Commanded for testing 
            }

            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
        // Added for filteration from 
        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = e.NewTextValue?.ToLower() ?? "";

            var filtered = _allParties
                .Where(x => x.PartyName.ToLower().Contains(searchText))
                .ToList();

            PartyList.ItemsSource = filtered;
            PartyList.IsVisible = true;
        }

        private void OnEntryFocused(object sender, FocusEventArgs e)
        {
            PartyList.IsVisible = true;
        }

        private async void OnPartySelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is not PartyDto selected)
                return;

            PartyEntry.Text = selected.DisplayText;
            PartyList.IsVisible = false;

            await Navigation.PushModalAsync(
                new MainPage( selected.PartyCode, selected.PartyName)
            );
        }
        //private void BindPicker(List<PartyDto> partyList)
        //{
        //    PartyPicker.ItemsSource = partyList
        //        .Select(x => $"{x.PartyName} - {x.PartyCode}")
        //        .ToList();
        //}
        //private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        //{
        //    string searchText = e.NewTextValue?.ToLower() ?? "";

        //    var filteredList = _allParties
        //        .Where(x => x.PartyName.ToLower().Contains(searchText))
        //        .ToList();

        //    BindPicker(filteredList);
        //}


        //private async void PartyPicker_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (sender is not Picker picker)
        //        return;

        //    if (picker.SelectedIndex == -1)
        //        return;

        //    string selectedValue = picker.SelectedItem?.ToString();
        //    if (string.IsNullOrWhiteSpace(selectedValue))
        //        return;

        //    var parts = selectedValue.Split(" - ", 2);
        //    if (parts.Length < 2)
        //        return;

        //    string partyName = parts[0];
        //    string partyCode = parts[1];

        //    await Navigation.PushModalAsync(
        //        new MainPage(partyCode, partyName)
        //    );

        //    picker.SelectedIndex = -1;
        //}

        // Added for filteration To   // commanted for thesting 

        //      private async void PartyPicker_SelectedIndexChanged(object sender, EventArgs e)
        //      {
        //          if (sender is not Picker picker)
        //              return;

        //          if (picker.SelectedIndex == -1)
        //              return;

        //          // Selected item is STRING
        //          string selectedValue = picker.SelectedItem.ToString();
        //          if (string.IsNullOrWhiteSpace(selectedValue))
        //              return;

        //          // Split "PartyCode - PartyName"
        //          var parts = selectedValue.Split(" - ", 2);
        //          if (parts.Length < 2)
        //              return;

        //          string partyName = parts[0];
        //          string partyCode = parts[1];

        //          //string partyCode = parts[0];
        //          //string partyName = parts[1];

        //          //await Navigation.PushAsync(
        //          //    new MainPage(partyCode, partyName)
        //          //);
        //          await Navigation.PushModalAsync(
        //    new MainPage(partyCode, partyName)
        //);
        //          picker.SelectedIndex = -1; // optional
        //      }


    }
}
