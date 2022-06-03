using System.Windows.Controls;
using System.Windows;
using System.Collections.ObjectModel;

namespace DCT_CryptoCoin
{
    public partial class MainWindow
    {
        public class Cryptingup
        {
            public ExchangesModel[] exchanges { get; set; }
            public MarketsModel[] markets { get; set; }
            public AssetsModel[] assets { get; set; }
        }
    }
}
