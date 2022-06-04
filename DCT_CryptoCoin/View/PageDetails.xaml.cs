using System.Windows.Controls;

namespace DCT_CryptoCoin.View
{
    public partial class PageDetails : Page
    {
        public PageDetails()
        {
            InitializeComponent();
        }

        private void BackButton(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
