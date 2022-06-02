using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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
            Cryptingup obj = GetAll("https://www.cryptingup.com/api/markets", "markets");
            // dataGrid.ItemsSource = obj.markets;

            //Cryptingup obj1 = GetAll("https://www.cryptingup.com/api/exchanges", "exchanges");
            //    dataGrid1.ItemsSource = obj1.exchanges;

            //    //Cryptingup obj2 = GetAll("https://www.cryptingup.com/api/assets", "assets");
            //    //dataGrid2.ItemsSource = obj2.assets;

            collectionView = new PageCollectionView(obj.markets.ToList(), 10);
            DataContext = collectionView;
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

        private readonly PageCollectionView collectionView;
        public void OnNextClicked(object sender, RoutedEventArgs e)
        {
            collectionView.GoToNextPage();
        }

        public void OnPreviousClicked(object sender, RoutedEventArgs e)
        {
            collectionView.GoToPreviousPage();
        }
    }
}
