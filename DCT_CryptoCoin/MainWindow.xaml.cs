using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DCT_CryptoCoin
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Cryptingup obj = GetAll("https://www.cryptingup.com/api/exchanges", "exchanges");
            dataGrid.ItemsSource = obj.exchanges;

            Cryptingup obj1 = GetAll("https://www.cryptingup.com/api/markets", "markets");
            dataGrid1.ItemsSource = obj1.markets;

            Cryptingup obj2 = GetAll("https://www.cryptingup.com/api/assets", "assets");
            dataGrid2.ItemsSource = obj2.assets;
        }
        private Cryptingup GetAll(string uri, string clientResult)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(uri)
            };
            HttpResponseMessage response = client.GetAsync(clientResult).Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var obj = JsonSerializer.Deserialize<Cryptingup>(result);
                return obj;
            }
            return null;
        }
    }
}
