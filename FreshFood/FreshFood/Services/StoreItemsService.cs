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
                new StoreItem() { BackgroundColor = Xamarin.Forms.Color.Yellow, Name="Lemon"},
                new StoreItem() { BackgroundColor = Xamarin.Forms.Color.LightGoldenrodYellow, Name="Avocado" },
                new StoreItem() { BackgroundColor = Xamarin.Forms.Color.GreenYellow, Name="banana"},
                new StoreItem() { BackgroundColor = Xamarin.Forms.Color.LightYellow, Name="grapes" },
                new StoreItem() { BackgroundColor = Xamarin.Forms.Color.Green, Name="kiwi" },
                new StoreItem() { BackgroundColor = Xamarin.Forms.Color.Orange, Name="orange" },
                new StoreItem() { BackgroundColor = Xamarin.Forms.Color.OrangeRed, Name="peach" },
                new StoreItem() { BackgroundColor = Xamarin.Forms.Color.GreenYellow, Name="pear" },
                new StoreItem() { BackgroundColor = Xamarin.Forms.Color.Red, Name="pineapple" },
                new StoreItem() { BackgroundColor = Xamarin.Forms.Color.Red, Name="strawberry" },
                new StoreItem() { BackgroundColor = Xamarin.Forms.Color.Red, Name="watermelon" }
            };
        }
    }
}