using System;
using System.Collections.Generic;
using System.Text;

namespace FreshFood.Services
{
    public class NavigationService
    {
        public delegate void OnMainScreenChange();
        public event OnMainScreenChange MainScreenChangedEvent;

        private static NavigationService _instance;

        public static NavigationService Instance
        {
            get
            {
                if (_instance == null) _instance = new NavigationService();
                return _instance;
            }
        }

        public void ChangeMainScreen()
        {
            MainScreenChangedEvent?.Invoke();
        }


    }
}
