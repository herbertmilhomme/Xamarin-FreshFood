using System;
using System.Collections.Generic;
using System.Text;

namespace FreshFood.Models
{
    public class StoreItem
    {
        public Xamarin.Forms.Color BackgroundColor { get; set; }
        public string ImageSource { get; set; }
        public string BlackWhiteImageSource { get; set; }
        private string _name;
        public string Name { 
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                ImageSource = "icon_colour_" + _name.ToLower();
                BlackWhiteImageSource = "icon_" + _name.ToLower();
            }
        }
    }
}
