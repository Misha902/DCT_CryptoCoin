using System.Net.Http;
using System.Text.Json;
using System;
using System.Security.Policy;
using System.Windows;
using System.Collections.Generic;

namespace DCT_CryptoCoin
{
    public partial class MainWindow
    {
        public class Startup
        {
            public static List<AssetsModel> GetAll()
            {
                var client = new HttpClient
                {
                    BaseAddress = new Uri("https://www.cryptingup.com/api/assets")
                };
                HttpResponseMessage response = client.GetAsync("assets").Result;
                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    AssetsViewModel obj = JsonSerializer.Deserialize<AssetsViewModel>(result);
                    return obj.assets;
                }
                return null;
            }
        }
    }
}
