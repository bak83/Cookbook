//using Cookbook.Models;
using Cookbook.Entities;

namespace Cookbook.Services
{
	public class DishRepositiry : IDishRepositiry
	{
		public IEnumerable<Dishes> GetDishes()
		{
			return DishesDataStore.Current.Dishes;
		}

		public Dishes GetDish(int id)
		{

			var dish = DishesDataStore.Current.Dishes
				.FirstOrDefault(c => c.Id == id);

			return dish;
		}

		public void AddNewDish(Dishes dishAdd)
		{

			var maxDishId = DishesDataStore.Current.Dishes.Max(p => p.Id);

			var newDish = new Dishes()
			{
				Id = ++maxDishId,
				Name = dishAdd.Name,
				KindOfDiet = dishAdd.KindOfDiet,
				KindOfDishes = dishAdd.KindOfDishes,
				Ingredients = dishAdd.Ingredients
			};

			DishesDataStore.Current.Dishes.Add(newDish);
		}

		public void JoinDishes(IEnumerable<int> joinDishes, string Name, KindOfDiet kindOfDiet, KindOfDishes kindOfDishes, IEnumerable<Ingredients> ingredients = null)
		{
			var existsDishes = DishesDataStore.Current.Dishes;
			var maxDishId = existsDishes.Max(p => p.Id);
			var existsDishesList = new List<Dishes>();

			foreach (var dish in joinDishes)
			{
				existsDishesList.Add(DishesDataStore.Current.Dishes.FirstOrDefault(c => c.Id == dish));

			}

			var Ingredients = new List<Ingredients>();
			string elem = null;

			foreach (var dish in existsDishesList)
			{
				foreach (var ingredient in dish.Ingredients)
				{
					elem += ingredient.Name;
				}
				Ingredients.Add
					(
					new Ingredients
					{
						Name = dish.Name,
						Description = elem
					}
					);
				elem = null;
			}
			if (ingredients != null)
			{
				Ingredients.AddRange(ingredients);
			}
			var newDish = new Dishes()
			{

				Id = ++maxDishId,
				Name = Name,
				KindOfDiet = kindOfDiet,
				KindOfDishes = kindOfDishes,
				Ingredients = Ingredients
			};

			DishesDataStore.Current.Dishes.Add(newDish);
		}
	}
}
