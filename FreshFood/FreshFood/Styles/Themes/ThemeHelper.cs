using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FreshFood.Styles.Themes
{
	public static class ThemeHelper
	{
		//public static string CurrentTheme;
		public static bool IsDarkMode { get; private set; }

		public static bool ToggleAppTheme()
		{
			IsDarkMode = !IsDarkMode;
			return SetAppTheme();
		}

		public static bool ToggleAppTheme(bool enableDarkMode)
		{
			if (enableDarkMode == IsDarkMode)
				return false;
			IsDarkMode = enableDarkMode;
			return SetAppTheme();
		}

		private static bool SetAppTheme()
		{
			ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
			if (mergedDictionaries != null)
			{
				mergedDictionaries.Clear();
				if(IsDarkMode)
					mergedDictionaries.Add(new DarkTheme());
				else
					mergedDictionaries.Add(new LightTheme());
				return true;
			}
			return false;
		}

		//public static bool SetAppTheme(Theme selectedTheme)
		//{
		//	ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
		//	if (mergedDictionaries != null)
		//	{
		//		mergedDictionaries.Clear();
		//		switch (selectedTheme)
		//		{
		//			case Theme.Dark:
		//				mergedDictionaries.Add(new DarkTheme());
		//				break;
		//			case Theme.Light:
		//				mergedDictionaries.Add(new LightTheme());
		//				break;
		//			case Theme.Pink:
		//				mergedDictionaries.Add(new PinkTheme());
		//				break;
		//			case Theme.Gold:
		//				mergedDictionaries.Add(new GoldTheme());
		//				break;
		//			case Theme.Blue:
		//				mergedDictionaries.Add(new BlueTheme());
		//				break;
		//			default:
		//				mergedDictionaries.Add(new LightTheme());
		//				break;
		//		}
		//		return true;
		//	}
		//	return false;
		//}

		//public static void Toggle()
		//{
		//	string newTheme = (CurrentTheme == "light") ? "dark" : "light";
		//	ChangeTheme(newTheme);
		//}
		//public static void ChangeTheme(string theme)
		//{
		//	if (theme == CurrentTheme) return;
		//
		//	App.Current.Resources.MergedDictionaries.Clear();
		//	App.Current.Resources.Clear();
		//	ResourceDictionary applicationResourceDictionary = App.Current.Resources;
		//	ResourceDictionary newTheme = null;
		//	switch (theme.ToLowerInvariant())
		//	{
		//		case "light":
		//			newTheme = new LightTheme();
		//			break;
		//		case "dark":
		//			newTheme = new DarkTheme();
		//			break;
		//		default:break;
		//	}
		//
		//	foreach (var merged in newTheme.MergedDictionaries)
		//	{
		//		applicationResourceDictionary.MergedDictionaries.Add(merged);
		//	}
		//	ManuallyCopyThemes(newTheme, applicationResourceDictionary);
		//	CurrentTheme = theme;
		//}
		//private static void ManuallyCopyThemes(ResourceDictionary fromResource, ResourceDictionary toResource)
		//{
		//	foreach (var item in fromResource.Keys)
		//	{
		//		toResource[item] = fromResource[item];
		//	}
		//}
	}
}