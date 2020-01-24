using FreshFood.Themes;
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
    public partial class Content_SettingsView : ContentView
    {
        public Content_SettingsView()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ThemeHelper.Toggle();
        }
    }
}