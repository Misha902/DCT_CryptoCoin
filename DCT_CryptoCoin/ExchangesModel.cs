namespace DCT_CryptoCoin
{
    public partial class MainWindow
    {
        public class ExchangesModel
        {
            public string exchange_id { get; set; }
            public string name { get; set; }
            public string website { get; set; }
            public double volume_24h { get; set; }
        }
    }
}
