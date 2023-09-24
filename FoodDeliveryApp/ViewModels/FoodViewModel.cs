using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using FoodDeliveryApp.Services;
using FoodDeliveryApp.Models;

namespace FoodDeliveryApp.ViewModels
{
    public partial class FoodViewModel : ObservableObject
    {
        readonly FoodService _foodService; 

        public FoodViewModel (FoodService foodService)
        {
            _foodService = foodService;
            LoadData();
        }

        public ObservableCollection<string> Source { get; } = new();

        [ObservableProperty]
        string selectedSource;
        public ObservableCollection<string> Categories { get; } = new();

        public ObservableCollection<string> Food { get; } = new();

        [ObservableProperty]
        string selectedFood;

        [RelayCommand]
        async Task GoToDetails (Food food)
        {
            if (food == null)
                return;

            await Shell.Current.GoToAsync(nameof(FoodDetailViews), true, new Dictionary<string, object>
            {
                { "Food", food }
            });
    }

    void LoadData ()
        {
            var sources = _foodService.GetFoodSources();

            if (Sources.Count != 0)
                Sources.Clear();

            foreach (var source in sources) 
                Sources.Add(sources);

            SelectedSource = sources.First();

            var categories = _foodService.GetFoodCategories();

            if (Categories.Count != 0)
                Categories.Clear();

            foreach (var category in categories)
                Categories.Add(category);

            var foods = _foodService.GetFoods();

            if (Food.Count != 0)
                Food.Clear();

            foreach (var food in foods)
                Food.Add(food);

            SelectedFood = foods.First(m => m.Title == "Stake");

        }
}
