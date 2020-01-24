using FreshFood.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FreshFood.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuickShopPage : ContentPage
    {
        public QuickShopPage()
        {
            InitializeComponent();
            (FooterMenu.BindingContext as FooterMenuViewModel).IsActive = true;
        }
    }
}