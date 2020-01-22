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

        public event PropertyChangedEventHandler PropertyChanged;

        void OnButtonPressed(string id)
        {
            Application.Current.MainPage.DisplayAlert("Alert", "Button pressed: " + id, "Ok");
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
