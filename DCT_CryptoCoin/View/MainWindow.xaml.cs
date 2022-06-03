using DCT_CryptoCoin.View;
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
            Cryptingup obj = GetAll("https://www.cryptingup.com/api/assets", "assets");
            
            collectionView = new PageCollectionView(obj.assets.ToList(), 10);
            DataContext =  collectionView;

            //Cryptingup obj = GetAll("https://www.cryptingup.com/api/exchanges", "exchanges");

            //Cryptingup obj = GetAll("https://www.cryptingup.com/api/markets", "markets");


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
        private void OnNextClicked(object sender, RoutedEventArgs e)
        {
            collectionView.GoToNextPage();
        }

        private void OnPreviousClicked(object sender, RoutedEventArgs e)
        {
            collectionView.GoToPreviousPage();
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            //DataGridRow row = sender as DataGridRow;
            AssetsModel asset = (AssetsModel)dataGrid.SelectedItem;
            FramePageDetails.NavigationService.Navigate(new PageDetails(asset));

        }
    }
}
