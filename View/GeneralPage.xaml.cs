using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
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
using static DCT_CryptoCoin.MainWindow;

namespace DCT_CryptoCoin.View
{
    public partial class GeneralPage : Page
    {
        private readonly PageCollectionView collectionView;
        public GeneralPage()
        {
            InitializeComponent();
            collectionView = new PageCollectionView(Startup.GetAll().ToList(), 10);
            DataContext = collectionView;
        }
        
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
            collectionView.SelectedAsset = (AssetsModel)AssetsGrid.SelectedItem;

            NavigationService.Navigate(new PageDetails(collectionView));
        }
        private void Search(object sender, TextChangedEventArgs e)
        {
            var tbxSearch = sender as TextBox;
            if (tbxSearch.Text != "")
            {
                var filteredList = PageCollectionView.assets.Where(x => x.name.ToLower().Contains(tbxSearch.Text.ToLower()) 
                    || x.asset_id.ToLower().Contains(tbxSearch.Text.ToLower()));

                DataContext = new PageCollectionView(filteredList.ToList(), 10);
            }
            else
            {
                DataContext = collectionView;
            }
        }
    }
}
