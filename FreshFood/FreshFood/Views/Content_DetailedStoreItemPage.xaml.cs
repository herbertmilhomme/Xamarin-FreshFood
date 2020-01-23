using FreshFood.Models;
using FreshFood.Services;
using Plugin.SharedTransitions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FreshFood.Views
{
    public partial class Content_DetailedStoreItemPage : ContentPage, INotifyPropertyChanged
    {
        private uint AnimationTime = 300;
        private StoreItem _item;
        public StoreItem Item
        {
            get
            {
                return _item;
            }
            set
            {
                _item = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public Content_DetailedStoreItemPage(StoreItem item)
        {
            Item = item;
            InitializeComponent();
            BindingContext = this;
            SharedTransitionNavigationPage.SetTransitionDuration(this, AnimationTime);
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnAddToCartPressed(object sender, EventArgs e)
        {
            CartService.Instance.AddItem();
        }
    }
}