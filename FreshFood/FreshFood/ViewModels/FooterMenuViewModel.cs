﻿using FreshFood.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FreshFood.ViewModels
{
    public class FooterMenuViewModel : INotifyPropertyChanged
    {
        private bool isActive;
        public bool IsActive
        {
            get
            {
                return isActive;
            }
            set
            {
                isActive = value;
                QuickShopIcon = (isActive) ? "icon_quick_shop_1" : "icon_quick_shop";
            }
        }
        public ICommand ImageClickCommand { get; set; }
        public ICommand QuickShopCommand { get; set; }

        private string _quickShopIcon;
        public string QuickShopIcon {
            get
            {
                return _quickShopIcon;
            }
            set
            {
                _quickShopIcon = value;
                OnPropertyChanged();
            }
        }

        public int PreviousScreen { get; private set; }
        public int CurrentScreen { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public FooterMenuViewModel()
        {
            ImageClickCommand = new Command<string>(OnButtonPressed);
            QuickShopCommand = new Command(OnQuickShopPressed);
            QuickShopIcon = "icon_quick_shop";
        }

        void OnButtonPressed(string id)
        {
            int old_screen = CurrentScreen;
            int new_screen = int.Parse(id);
            if (old_screen == new_screen)
                return;

            PreviousScreen = CurrentScreen;
            CurrentScreen = new_screen;
            OnPropertyChanged("PreviousScreen");
            OnPropertyChanged("CurrentScreen");
            NavigationService.Instance.ChangeMainScreen();
        }

        void OnQuickShopPressed()
        {
            if (IsActive)
            {
                NavigationService.Instance.GoToPreviousScreen();
            }
            else
            {
                NavigationService.Instance.ShowQuickShop();
            }
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}