﻿using FreshFood.Models;
using FreshFood.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace FreshFood.ViewModels
{

    public class Content_QuickShopViewModel : BindableObject
    {
        public Content_QuickShopViewModel()
        {
            LoadData();
        }

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
        private void LoadData()
        {
            StoreItems = new ObservableCollection<StoreItem>(StoreItemsService.Instance.GetItems());
        }
    }

}
