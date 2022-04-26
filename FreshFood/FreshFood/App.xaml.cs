using Plugin.SharedTransitions;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FreshFood
{
	public partial class App : Application
	{
		//public string ColorPrimary { get; set; }
		//public string ColorBackground { get; set; }
		public const string ColorPrimary = "PrimaryColor";
		public const string ColorBackground = "BackgroundColor";

		public App()
		{
			InitializeComponent();

			//Load theme colors...
			MainPage = new SplashScreenPage();
			//MainPage = new AppShell();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}