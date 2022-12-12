//using Cookbook.Models;
using Cookbook.Entities;
using Microsoft.AspNetCore.Mvc;

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

		//public void AddNewDish(Dishes dishAdd)
		//{

		//	var maxDishId = DishesDataStore.Current.Dishes.Max(p => p.Id);

		//	var newDish = new Dishes()
		//	{
		//		Id = ++maxDishId,
		//		Name = dishAdd.Name,
		//		KindOfDiet = dishAdd.KindOfDiet,
		//		KindOfDishes = dishAdd.KindOfDishes,
		//		Ingredients = dishAdd.Ingredients
		//	};

		//	DishesDataStore.Current.Dishes.Add(newDish);
		//}

		//public void JoinDishes(IEnumerable<Dishes> joinDishes)
		//{

		//	var maxDishId = DishesDataStore.Current.Dishes.Max(p => p.Id);
		//	var existsDishes = new List<DishDto>();

		//	foreach (var dish in joinDishes.ListOfDishes)
		//	{
		//		existsDishes.Add(DishesDataStore.Current.Dishes.FirstOrDefault(c => c.Id == dish));

		//	}

		//	var Ingredients = new List<IngredientsDto>();
		//	string elem = null;

		//	foreach (var dish in existsDishes)
		//	{
		//		foreach (var ingredient in dish.Ingredients)
		//		{
		//			elem += ingredient.Name;
		//		}
		//		Ingredients.Add(
		//			new IngredientsDto
		//			{
		//				Name = dish.Name,
		//				Description = elem
		//			}
		//			);
		//	}

		//	var newDish = new DishDto()
		//	{

		//		Id = ++maxDishId,
		//		Name = joinDishes.Name,
		//		KindOfDiet = joinDishes.KindOfDiet,
		//		KindOfDishes = joinDishes.KindOfDishes,
		//		Ingredients = Ingredients
		//	};

		//	DishesDataStore.Current.Dishes.Add(newDish);			
		//}
	}
}
