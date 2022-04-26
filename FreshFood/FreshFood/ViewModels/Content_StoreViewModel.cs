using FreshFood.Models;
using FreshFood.Services;
using Plugin.SharedTransitions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace FreshFood.ViewModels
{
    public class Content_StoreViewModel : BindableObject
    {
        private StoreItem _currentItem;
        private ObservableCollection<StoreItem> _storeItems;
        public ObservableCollection<StoreItem> StoreItems
        {
            get { return _storeItems; }
            set
            {
                _storeItems = value;
                OnPropertyChanged();
            }
        }
        public StoreItem CurrentItem
        {
            get { return _currentItem; }
            set
            {
                _currentItem = value;
                OnPropertyChanged();
                NavigationService.Instance.OnStoreItemChanged(CurrentItem);
            }
        }

        public Content_StoreViewModel()
        {
            LoadData();
        }

        private void LoadData()
        {
            StoreItems = new ObservableCollection<StoreItem>(StoreItemsService.Instance.GetItems());
        }
    }
}