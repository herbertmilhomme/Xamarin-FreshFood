using System;
using System.Collections.Generic;
using System.Text;

namespace FreshFood.Services
{
    public class CartService
    {
        private static CartService _instance;
        public static CartService Instance
        {
            get
            {
                if (_instance == null) _instance = new CartService();
                return _instance;
            }
        }
        public void AddItem()
        {
            
        }
    }
}
