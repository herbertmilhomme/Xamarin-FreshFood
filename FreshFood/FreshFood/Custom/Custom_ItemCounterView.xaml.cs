using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FreshFood.Custom
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Custom_ItemCounterView : ContentView
    {
        public Custom_ItemCounterView()
        {
            InitializeComponent();
            BindingContext = new Custom_ItemCounterViewModel();
        }
    }
}