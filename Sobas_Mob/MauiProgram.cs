using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using System.Buffers.Text;
using System.Net.Http.Headers;
using ZXing.Net.Maui.Controls;


namespace Sobas_Mob
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();


            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseBarcodeReader()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });




            builder.Services.AddHttpClient("ApiClient", client =>
            {
                client.BaseAddress = new Uri(ApiConstants.BaseUrl);
                client.DefaultRequestHeaders.Accept.Add(
              new MediaTypeWithQualityHeaderValue("application/json"));
            });


            //Added for testing
            //            builder.Services.AddHttpClient("ApiClient", client =>
            //            {
            //                client.BaseAddress = new Uri(ApiConstants.BaseUrl);
            //            })
            //.ConfigurePrimaryHttpMessageHandler(() =>
            //    new HttpClientHandler
            //    {
            //        ServerCertificateCustomValidationCallback =
            //            HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            //    });



            //            builder.Services.AddHttpClient("ApiClient", client =>
            //            {
            //                client.BaseAddress = new Uri(ApiConstants.BaseUrl);
            //                client.DefaultRequestHeaders.Accept.Clear();
            //                client.DefaultRequestHeaders.Accept.Add(
            //                    new MediaTypeWithQualityHeaderValue("application/json"));
            //            });
            //#if DEBUG
            //.ConfigurePrimaryHttpMessageHandler(() =>
            //{
            //    return new HttpClientHandler
            //    {
            //        // ⚠️ Development only – bypass SSL certificate validation
            //        ServerCertificateCustomValidationCallback =
            //            HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            //    };
            //});
            //#endif


            // Add HttpClientFactory with a named client

            builder.Services.AddTransient<OrderEntryViewModel>();
            builder.Services.AddTransient<OrderEntryPage>();
            builder.Services.AddTransient<PartyDropdown>();
            builder.Services.AddTransient<RemarksPopupPage>();
            builder.Services.AddSingleton<MainPage>();







#if DEBUG
            builder.Logging.AddDebug();
#endif


            return builder.Build();
            //var app = builder.Build();

            //// Save the service provider in App class
            //App.Services = app.Services;

            //return app;
        }
    }
}
