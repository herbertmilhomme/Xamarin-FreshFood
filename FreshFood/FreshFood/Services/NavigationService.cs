using FreshFood.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreshFood.Services
{
    public class NavigationService
    {
        public delegate void OnMainScreenChange();
        public delegate void OnQuickStorePressed();
        public delegate void OnStoreItemChange(StoreItem item);
        
        public event OnMainScreenChange MainScreenChangedEvent;
        public event OnQuickStorePressed QuickStoreChangedEvent;
        public event OnStoreItemChange MainStoreItemChangedEvent;

        private static NavigationService _instance;

        public static NavigationService Instance
        {
            get
            {
                if (_instance == null) _instance = new NavigationService();
                return _instance;
            }
        }

        public void ChangeMainScreen()
        {
            MainScreenChangedEvent?.Invoke();
        }

        public void GoToPreviousScreen()
        {
            App.Current.MainPage.Navigation.PopAsync();
        }

        public void ShowQuickShop()
        {
            QuickStoreChangedEvent?.Invoke();
        }
        internal void OnStoreItemChanged(StoreItem item)
        {
            MainStoreItemChangedEvent?.Invoke(item);
        }
    }
}
