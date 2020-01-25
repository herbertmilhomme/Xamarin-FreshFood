using Plugin.SharedTransitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FreshFood
{
    public class SplashScreenPage : ContentPage
    {
        Image splashImage;
        public SplashScreenPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                Source = "icon_colour_strawberry",
                WidthRequest = 100,
                HeightRequest = 100
            };

            AbsoluteLayout.SetLayoutFlags(splashImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);

            this.BackgroundColor = Color.FromHex("#404E5A");
            this.Content = sub;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await splashImage.ScaleTo(1, 2000);
            await splashImage.ScaleTo(0.8, 1500, Easing.Linear);
            await splashImage.ScaleTo(150, 500, Easing.BounceOut);
            Application.Current.MainPage = new SharedTransitionNavigationPage(new MainPage());

        }
    }
}