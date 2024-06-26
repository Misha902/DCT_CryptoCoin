﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;

namespace DCT_CryptoCoin
{
    public class PageCollectionView : CollectionView
    {
        private int currentPage = 1;
        public readonly IList _objectsOnPageList;
        private readonly int _countObjectsOnPage;
        public AssetsModel SelectedAsset { get; set; }
        public static List<AssetsModel> assets { get; set; }
        public List<MarketsModel> markets { get; set; }

        public int CurrentPage
        {
            get => currentPage;
            set
            {
                currentPage = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentPage)));
            }
        }
        public override int Count
        {
            get
            {
                if (_objectsOnPageList.Count == 0)
                {
                    return 0;
                }
                if (currentPage < CountPage)
                {
                    return _countObjectsOnPage;
                }
                else
                {
                    int objectsLeft = _objectsOnPageList.Count % _countObjectsOnPage;
                    if (0 == objectsLeft)
                    {
                        return _countObjectsOnPage;
                    }
                    else
                    {
                        return objectsLeft;
                    }
                }
            }
        }
        private int CurrentIndex => (currentPage - 1) * _countObjectsOnPage;

        public int CountPage => (_objectsOnPageList.Count + _countObjectsOnPage - 1) / _countObjectsOnPage;

        public PageCollectionView(IList objectsOnPageList, int objectsOnPage) : base(objectsOnPageList)
        {
            _objectsOnPageList = objectsOnPageList;
            _countObjectsOnPage = objectsOnPage;

            if (assets is null)
            {
                assets = (List<AssetsModel>)objectsOnPageList;
            }
        }
        public void GoToNextPage()
        {
            if (currentPage < CountPage)
            {
                CurrentPage += 1;
            }
            Refresh();
        }
        public void GoToPreviousPage()
        {
            if (currentPage > 1)
            {
                CurrentPage -= 1;
            }
            Refresh();
        }
        public override object GetItemAt(int index)
        {
            return _objectsOnPageList[(index % _countObjectsOnPage) + CurrentIndex];
        }

    }
}
