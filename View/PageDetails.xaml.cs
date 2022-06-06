using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System;
using System.Windows.Controls;
using static DCT_CryptoCoin.MainWindow;
using System.Linq;

namespace DCT_CryptoCoin.View
{
    public partial class PageDetails : Page
    {
        private PageCollectionView _vm;
        public PageDetails(PageCollectionView vm)
        {
            InitializeComponent();
            _vm = vm;
            DataContext = vm;
        }

        private void BackButton(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        private void LoadMarkets(object sender, System.Windows.RoutedEventArgs e)
        {
            _vm.markets = GetAll(_vm.SelectedAsset.asset_id)
                .Where(x => x.base_asset == _vm.SelectedAsset.asset_id)
                .GroupBy(x => x.exchange_id).Select(x => x.First())
                .ToList();



            MarketsDG.Visibility = Visibility;
            MarketsDG.ItemsSource = _vm.markets;
        }
        public static List<MarketsModel> GetAll(string id)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri($"https://www.cryptingup.com/api/assets/{id}/markets")
            };
            HttpResponseMessage response = client.GetAsync("markets").Result;
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                AssetsViewModel obj = JsonSerializer.Deserialize<AssetsViewModel>(result);
                return obj.markets;
            }
            return null;
        }
    }
}
