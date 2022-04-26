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
                new RecipeItem() { Image="images_recipe_1", Title="Mixed Berry Melody", Subtitle="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris vel felis at dolor vulputate condimentum. Praesent eleifend pretium nunc vitae gravida. Quisque vitae diam enim. Donec eu ornare ex. Sed imperdiet vitae ipsum vel auctor. Phasellus non orci scelerisque metus dignissim placerat ac quis metus. Curabitur tincidunt urna nec nisi faucibus consequat vel vel lacus. Vivamus vulputate urna vel cursus vulputate. Ut consectetur eget diam eget hendrerit. Maecenas pretium lectus vestibulum mauris dictum, at pellentesque diam vulputate. Donec gravida elit at nibh mollis volutpat id ut tortor. Integer condimentum augue ut condimentum scelerisque. Donec arcu tellus, elementum ultricies augue vel, posuere rhoncus nisl. Ut pretium aliquet molestie." },
                new RecipeItem() { Image="images_recipe_1", Title="Mixed Berry Melody", Subtitle="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris vel felis at dolor vulputate condimentum. Praesent eleifend pretium nunc vitae gravida. Quisque vitae diam enim. Donec eu ornare ex. Sed imperdiet vitae ipsum vel auctor. Phasellus non orci scelerisque metus dignissim placerat ac quis metus. Curabitur tincidunt urna nec nisi faucibus consequat vel vel lacus. Vivamus vulputate urna vel cursus vulputate. Ut consectetur eget diam eget hendrerit. Maecenas pretium lectus vestibulum mauris dictum, at pellentesque diam vulputate. Donec gravida elit at nibh mollis volutpat id ut tortor. Integer condimentum augue ut condimentum scelerisque. Donec arcu tellus, elementum ultricies augue vel, posuere rhoncus nisl. Ut pretium aliquet molestie." },
                new RecipeItem() { Image="images_recipe_1", Title="Mixed Berry Melody", Subtitle="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris vel felis at dolor vulputate condimentum. Praesent eleifend pretium nunc vitae gravida. Quisque vitae diam enim. Donec eu ornare ex. Sed imperdiet vitae ipsum vel auctor. Phasellus non orci scelerisque metus dignissim placerat ac quis metus. Curabitur tincidunt urna nec nisi faucibus consequat vel vel lacus. Vivamus vulputate urna vel cursus vulputate. Ut consectetur eget diam eget hendrerit. Maecenas pretium lectus vestibulum mauris dictum, at pellentesque diam vulputate. Donec gravida elit at nibh mollis volutpat id ut tortor. Integer condimentum augue ut condimentum scelerisque. Donec arcu tellus, elementum ultricies augue vel, posuere rhoncus nisl. Ut pretium aliquet molestie." },
                new RecipeItem() { Image="images_recipe_1", Title="Mixed Berry Melody", Subtitle="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris vel felis at dolor vulputate condimentum. Praesent eleifend pretium nunc vitae gravida. Quisque vitae diam enim. Donec eu ornare ex. Sed imperdiet vitae ipsum vel auctor. Phasellus non orci scelerisque metus dignissim placerat ac quis metus. Curabitur tincidunt urna nec nisi faucibus consequat vel vel lacus. Vivamus vulputate urna vel cursus vulputate. Ut consectetur eget diam eget hendrerit. Maecenas pretium lectus vestibulum mauris dictum, at pellentesque diam vulputate. Donec gravida elit at nibh mollis volutpat id ut tortor. Integer condimentum augue ut condimentum scelerisque. Donec arcu tellus, elementum ultricies augue vel, posuere rhoncus nisl. Ut pretium aliquet molestie." },
                new RecipeItem() { Image="images_recipe_1", Title="Mixed Berry Melody", Subtitle="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris vel felis at dolor vulputate condimentum. Praesent eleifend pretium nunc vitae gravida. Quisque vitae diam enim. Donec eu ornare ex. Sed imperdiet vitae ipsum vel auctor. Phasellus non orci scelerisque metus dignissim placerat ac quis metus. Curabitur tincidunt urna nec nisi faucibus consequat vel vel lacus. Vivamus vulputate urna vel cursus vulputate. Ut consectetur eget diam eget hendrerit. Maecenas pretium lectus vestibulum mauris dictum, at pellentesque diam vulputate. Donec gravida elit at nibh mollis volutpat id ut tortor. Integer condimentum augue ut condimentum scelerisque. Donec arcu tellus, elementum ultricies augue vel, posuere rhoncus nisl. Ut pretium aliquet molestie." }
            };
        }
    }
}