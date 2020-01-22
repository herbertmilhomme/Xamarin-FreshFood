using FreshFood.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreshFood.Services
{
    public class StoreItemsService
    {
        private static StoreItemsService _instance;

        public static StoreItemsService Instance
        {
            get
            {
                if (_instance == null) _instance = new StoreItemsService();
                return _instance;
            }
        }

        public List<StoreItem> GetItems()
        {
            return new List<StoreItem>
            {
                new StoreItem() { BackgroundColor = Xamarin.Forms.Color.Yellow, Name="Lemon", ImageSource = "icon_colour_lemon" },
                new StoreItem() { BackgroundColor = Xamarin.Forms.Color.LightGoldenrodYellow, Name="Avocado", ImageSource = "icon_colour_avocado" },
                new StoreItem() { BackgroundColor = Xamarin.Forms.Color.GreenYellow, Name="banana", ImageSource = "icon_colour_banana" },
                new StoreItem() { BackgroundColor = Xamarin.Forms.Color.LightYellow, Name="grapes", ImageSource = "icon_colour_grapes" },
                new StoreItem() { BackgroundColor = Xamarin.Forms.Color.Green, Name="kiwi", ImageSource = "icon_colour_kiwi" },
                new StoreItem() { BackgroundColor = Xamarin.Forms.Color.Orange, Name="orange", ImageSource = "icon_colour_orange" },
                new StoreItem() { BackgroundColor = Xamarin.Forms.Color.OrangeRed, Name="peach", ImageSource = "icon_colour_peach" },
                new StoreItem() { BackgroundColor = Xamarin.Forms.Color.GreenYellow, Name="pear", ImageSource = "icon_colour_pear" },
                new StoreItem() { BackgroundColor = Xamarin.Forms.Color.Red, Name="pineapple", ImageSource = "icon_colour_pineapple" },
                new StoreItem() { BackgroundColor = Xamarin.Forms.Color.Red, Name="strawberry", ImageSource = "icon_colour_strawberry" },
                new StoreItem() { BackgroundColor = Xamarin.Forms.Color.Red, Name="watermelon", ImageSource = "icon_colour_watermelon" },
            };
        }
    }
}