using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Sobas_Mob
{
    public class ApiConstants
    {
        //        public static string BaseUrl
        //        {
        //            get
        //            {
        //#if ANDROID
        //                        // Android Emulator
        //                        if (DeviceInfo.DeviceType == DeviceType.Virtual)
        //                            return "http://10.0.2.2:5134/api/";

        //                        // Real Android device (same Wi-Fi)
        //                        return "http://172.18.72.71:5134/api/";

        //#elif IOS
        //                // iOS Simulator
        //                if (DeviceInfo.DeviceType == DeviceType.Virtual)
        //                    return "http://localhost:5134/api/";

        //                // Real iOS device
        //                return "http://172.18.72.71:5134/api/";
        //#else
        //                            // Windows / Mac
        //                            return "http://localhost:5134/api/";
        //#endif
        //            }
        //        }





        // Stored key for dynamic base URL (do NOT duplicate this anywhere else)
        private const string PrefKey = "ApiBaseUrl";

        // Default port of your API
        //private const int ApiPort = 5134;

        // Default base path
        private const string ApiPath = "api";

        /// <summary>
        /// Returns the API base URL.
        /// Priority:
        /// 1) Saved URL from Preferences (dynamic)
        /// 2) Emulator/simulator default URLs
        /// 3) Fallback localhost (desktop)
        /// </summary>
        public static string BaseUrl
        {
            get
            {
                // 1) If user has saved a URL, use it (works with dynamic networks)
                var saved = Preferences.Get(PrefKey, string.Empty);
                if (!string.IsNullOrWhiteSpace(saved))
                    return Normalize(saved);

#if ANDROID
                // Android Emulator -> host machine
                if (DeviceInfo.DeviceType == DeviceType.Virtual)
                    //return $"http://10.0.2.2:{ApiPort}/{ApiPath}/";
                    //return $"http://10.10.1.6:8080/api/";
                    return $"http://172.18.72.71:5134/api/";

                // Physical Android device:
                // We cannot reliably guess your PC IP on every network.
                // So keep a placeholder that forces you to set it once via SetBaseUrl().
                //return $"http://10.10.1.6:80/api/"; // <-- replace OR set dynamically
                //return $"http://172.18.72.58:5134/api/"; // <-- replace OR set dynamically  Testing purpose use this ip
              
                 //return $"https://qrcode.sytes.net/api/";   // <-- replace OR set dynamically
                  return $"https://qrcode.tstanesit.com/api/";


#elif IOS
                // iOS Simulator
                if (DeviceInfo.DeviceType == DeviceType.Virtual)
                    //return $"http://localhost:{ApiPort}/{ApiPath}/";
                    return $"http://localhost:5134/api/";

                // Physical iOS device:
                //return $"http://192.168.0.2:{ApiPort}/{ApiPath}/"; // <-- replace OR set dynamically
                return $"https://qrcode.sytes.net/api/"; // <-- replace OR set dynamically
#else
                // Windows / Mac (app and API on same machine)
                //return $"http://localhost:{ApiPort}/{ApiPath}/";
                return $"http://localhost:5134/api/";
#endif
            }
        }

        /// <summary>
        /// Save base URL dynamically (call this whenever network/IP changes)
        /// Example: ApiConstants.SetBaseUrl("http://192.168.1.25:5134/api/");
        /// </summary>
        public static void SetBaseUrl(string url)
        {
            Preferences.Set(PrefKey, Normalize(url));
        }

        /// <summary>
        /// Clear saved URL and revert to platform defaults.
        /// </summary>
        public static void ClearBaseUrl()
        {
            Preferences.Remove(PrefKey);
        }

        private static string Normalize(string url)
        {
            url = (url ?? string.Empty).Trim();

            if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
                !url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                url = "http://" + url;
            }

            url = url.TrimEnd('/');

            // Ensure it ends with /api
            if (!url.EndsWith("/api", StringComparison.OrdinalIgnoreCase))
                url += "/api";

            return url + "/";
        }
        
    public static HttpClient GetClient(string token)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);

            client.DefaultRequestHeaders.Add("AppToken", "MyMobileSecretToken");

            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

            return client;
        }
    }

    }
