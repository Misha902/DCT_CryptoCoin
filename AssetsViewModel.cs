using System;
using System.Collections.Generic;

namespace DCT_CryptoCoin
{
    public class AssetsViewModel
    {
        public List<AssetsModel> assets { get; set; }
        public List<MarketsModel> markets { get; set; }

        public AssetsModel SelectedAsset { get; set; }
    }
}
