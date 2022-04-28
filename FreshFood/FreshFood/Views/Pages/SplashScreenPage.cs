using Plugin.SharedTransitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FreshFood.Views.Pages
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
				WidthRequest = 180,
				HeightRequest = 180
			};

			AbsoluteLayout.SetLayoutFlags(splashImage, AbsoluteLayoutFlags.PositionProportional);
			AbsoluteLayout.SetLayoutBounds(splashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

			sub.Children.Add(splashImage);

			//this.BackgroundColor = Color.FromHex("#404E5A");
			this.BackgroundColor = (Color)App.Current.Resources["PageBackgroundColor"];
			this.Content = sub;
		}
		protected override async void OnAppearing()
		{
			base.OnAppearing();
			await splashImage.ScaleTo(1, 2000);
			await splashImage.ScaleTo(0.8, 1500, Easing.Linear);
			await splashImage.ScaleTo(150, 500, Easing.BounceOut);
			//First page seen is the login page...
			Application.Current.MainPage = new SharedTransitionNavigationPage(new OnboardingPage());
			//Application.Current.MainPage = new SharedTransitionNavigationPage(new AppShell());
		}
	}
}