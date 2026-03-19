using System.Net.Http.Json;

namespace Sobas_Mob.Views;

public partial class PartyDropdown : ContentPage
{
    private readonly HttpClient _httpClient;

    public PartyDropdown()
    {
        InitializeComponent();

        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("http://10.0.2.2:5134/")
            // Real device: http://YOUR_PC_IP:5134/
        };

        LoadPartyDropdown();
    }

    private async void LoadPartyDropdown()
    {
        try
        {
            var parties = await _httpClient
                .GetFromJsonAsync<List<PartyDto>>("api/OrderEntry/GetItemCode");

            PartyPicker.ItemsSource = parties;
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "OK");
        }
    }

    private void PartyPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (PartyPicker.SelectedItem is PartyDto selectedParty)
        {
            string partyCode = selectedParty.PartyCode;
            string partyName = selectedParty.PartyName;

            Console.WriteLine($"{partyCode} - {partyName}");
        }
    }
}
