using FreshFood.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreshFood.Services
{
    public class RecipeItemsService
    {
        private static RecipeItemsService _instance;
        public static RecipeItemsService Instance
        {
            get
            {
                if (_instance == null) _instance = new RecipeItemsService();
                return _instance;
            }
        }
        public List<RecipeItem> GetItems()
        {
            return new List<RecipeItem>
            {
                new RecipeItem() { Image="images_recipe_1", Title="Mixed Berry Melody", Subtitle="Berries mixed together to make a tasty dish."},
                new RecipeItem() { Image="images_recipe_1", Title="Mixed Berry Melody", Subtitle="Berries mixed together to make a tasty dish."},
                new RecipeItem() { Image="images_recipe_1", Title="Mixed Berry Melody", Subtitle="Berries mixed together to make a tasty dish."},
                new RecipeItem() { Image="images_recipe_1", Title="Mixed Berry Melody", Subtitle="Berries mixed together to make a tasty dish."},
                new RecipeItem() { Image="images_recipe_1", Title="Mixed Berry Melody", Subtitle="Berries mixed together to make a tasty dish."},
                new RecipeItem() { Image="images_recipe_1", Title="Mixed Berry Melody", Subtitle="Berries mixed together to make a tasty dish."},
            };
        }
    }
}
