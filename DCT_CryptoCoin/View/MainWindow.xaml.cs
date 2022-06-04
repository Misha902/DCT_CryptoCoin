using DCT_CryptoCoin.View;
using System.Windows;

namespace DCT_CryptoCoin
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameGeneral.Content = new GeneralPage();
        }

    }
}
