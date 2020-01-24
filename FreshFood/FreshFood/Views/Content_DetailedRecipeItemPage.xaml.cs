using FreshFood.Models;
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
    public partial class Content_DetailedRecipeItemPage : ContentPage
    {
        public RecipeItem Item;
        public Content_DetailedRecipeItemPage(RecipeItem item)
        {
            InitializeComponent();
            Item = item;
        }
    }
}