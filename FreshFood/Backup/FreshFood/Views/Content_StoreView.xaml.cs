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
    public partial class Content_StoreView : ContentView
    {
        public Content_StoreView()
        {
            InitializeComponent();
            BindingContext = new Content_StoreViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}