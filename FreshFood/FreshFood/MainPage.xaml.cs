using FreshFood.Models;
using FreshFood.Services;
using FreshFood.ViewModels;
using FreshFood.Views;
using Plugin.SharedTransitions;
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
            NavigationService.Instance.MainStoreItemChangedEvent += OnStoreItemChange;
            NavigationService.Instance.QuickStoreChangedEvent += OnQuickShopPressed;
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

        async void OnStoreItemChange(StoreItem newItem)
        {
            SetPageAnimation(BackgroundAnimation.Fade, 300);
            SharedTransitionNavigationPage.SetTransitionSelectedGroup(this, newItem.Name);
            await Navigation.PushAsync(new Content_DetailedStoreItemPage(newItem));
        }

        private void SetPageAnimation(BackgroundAnimation animation, long time)
        {
            SharedTransitionNavigationPage.SetBackgroundAnimation(this, animation);
            SharedTransitionNavigationPage.SetTransitionDuration(this, time);
        }
        async void OnQuickShopPressed()
        {
            SetPageAnimation(BackgroundAnimation.SlideFromBottom, 300);
            await Navigation.PushAsync(new QuickShopPage());
        }
    }
}