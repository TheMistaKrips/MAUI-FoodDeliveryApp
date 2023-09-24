using FoodDeliveryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Services
{
    public class FoodService
    {
        public IEnumerable<string> GetFoodSources() 
        {
            return new List<string>
            {
                "Dostawka",
                "In Restourant"
            };
        }

        public IEnumerable<string> GetFoodCategories()
        {
            return new List<string>
            {
                "Vegetarian",
                "Meat",
                "Fish",
                "Salats",
                "Soup",
                "Drinks"
            };
        }

        public IEnumerable<Food> GetFoods()
        {
            var categories = new List<string>
            {
                "Vegetarian",
                "Meat",
                "Fish",
                "Salats",
                "Soup",
                "Drinks"
            };

            var ingredients = new List<Ingridients>
            {
                new Ingridients {Name = "Meat", Image =""},
                new Ingridients {Name = "Fish", Image =""},
                new Ingridients {Name = "Cucumber", Image =""},
                new Ingridients {Name = "Pomidor", Image =""},
            };

            return new List<Food>
            {
                new Food {Title = "Stake", Cover = "", Rating = 9.5, Summary = "Meat fucked"},
                new Food {Title = "Hot Fish", Cover = "", Rating = 7.5, Summary = "Fish fucked"},
                new Food {Title = "Sezar Salad", Cover = "", Rating = 8.2, Summary = "Salad fucked"},
                new Food {Title = "Chaban Salad", Cover = "", Rating = 9.3, Summary = "Meat fucked"},
            };
        }
    }
}
