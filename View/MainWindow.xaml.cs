using DCT_CryptoCoin.View;
using System;
using System.Windows;
using System.Windows.Controls;

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
