using FreshFood.Models;
using FreshFood.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace FreshFood.ViewModels
{
    public class Content_StoreViewModel : BindableObject
    {
        public Content_StoreViewModel()
        {
            LoadData();
        }

        private StoreItem _selectedItem;
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
        public StoreItem SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged();
            }
        }
        private void LoadData()
        {
            StoreItems = new ObservableCollection<StoreItem>(StoreItemsService.Instance.GetItems());
        }
    }
}
