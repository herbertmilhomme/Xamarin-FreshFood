using FreshFood.Models;
using FreshFood.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FreshFood.ViewModels
{
    public class Content_RecipesViewModel : BindableObject
    {
        public Content_RecipesViewModel()
        {
            LoadData();
            SelectedRecipeChangedCommand = new Command(OnRecipeChanged);
        }
        private ICommand SelectedRecipeChangedCommand { get; set; }

        private RecipeItem _currentItem;
        private ObservableCollection<RecipeItem> _recipes;
        public ObservableCollection<RecipeItem> Recipes
        {
            get { return _recipes; }
            set
            {
                _recipes = value;
                OnPropertyChanged();
            }
        }
        public RecipeItem CurrentItem
        {
            get { return _currentItem; }
            set
            {
                _currentItem = value;
                OnPropertyChanged();
                OnRecipeChanged();
            }
        }
        private void LoadData()
        {
            Recipes = new ObservableCollection<RecipeItem>(RecipeItemsService.Instance.GetItems());
        }
        public void OnRecipeChanged()
        {
            NavigationService.Instance.OnRecipeChanged(CurrentItem);
        }
    }
}
