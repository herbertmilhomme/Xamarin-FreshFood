using FreshFood.Services;
using FreshFood.ViewModels;
using FreshFood.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FreshFood
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationService.Instance.MainScreenChangedEvent += OnScreenChange;
        }

        async void OnScreenChange()
        {
            var vm = (FooterMenu.BindingContext as FooterMenuViewModel);
            var old_screen = MainContent.Children[vm.PreviousScreen];
            await old_screen.FadeTo(0, 250);
            old_screen.IsVisible = false;

            var new_screen = MainContent.Children[vm.CurrentScreen];
            await new_screen.FadeTo(1, 250);
            new_screen.IsVisible = true;
        }
    }
}
