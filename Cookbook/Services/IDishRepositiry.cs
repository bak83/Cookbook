//using Cookbook.Models;
using Cookbook.Entities;
using Cookbook.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cookbook.Services
{
	public interface IDishRepositiry
	{
		void AddNewDish(Dishes dishAdd);
		Dishes GetDish(int id);
		IEnumerable<DishDto> GetDishes();
		void JoinDishes(IEnumerable<int> joinDishes, string Name, KindOfDiet kindOfDiet, KindOfDishes kindOfDishes, IEnumerable<Ingredients> ingredients = null);
	}
}