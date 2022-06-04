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
    /// <summary>
    /// Логика взаимодействия для General.xaml
    /// </summary>
    public partial class GeneralPage : Page
    {
        public GeneralPage()
        {
            InitializeComponent();
            collectionView = new PageCollectionView(Startup.GetAll().ToList(), 10);
            DataContext = collectionView;
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
            //AssetsModel asset = (AssetsModel)dataGrid.SelectedItem;
            NavigationService.Navigate(new PageDetails());

        }
    }
}
