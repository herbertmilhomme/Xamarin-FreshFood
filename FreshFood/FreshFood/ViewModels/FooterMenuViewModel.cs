using FreshFood.Services;
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
        public FooterMenuViewModel()
        {
            ImageClickCommand = new Command<string>(OnButtonPressed);
        }
        public ICommand ImageClickCommand { get; set; }

        public int PreviousScreen { get; private set; }
        public int CurrentScreen { get; private set; }


        public event PropertyChangedEventHandler PropertyChanged;

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

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
