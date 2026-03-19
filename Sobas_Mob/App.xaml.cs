using System.Net.Http;
using System.Net.Http.Json;

namespace Sobas_Mob
{
    public partial class App : Application
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public App(IHttpClientFactory httpClientFactory/*IServiceProvider _services*/)
        {
            InitializeComponent();

            Application.Current.UserAppTheme = AppTheme.Light;  // Force Light mode
            _httpClientFactory = httpClientFactory;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Provide required constructor parameters
            var mainPage = new NavigationPage(
                new MainPage(string.Empty, string.Empty)
            );

            return new Window(new PartyDropdown(_httpClientFactory));
        } 


    }
}