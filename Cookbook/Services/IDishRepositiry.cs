//using Cookbook.Models;
using Cookbook.Entities;
using Cookbook.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cookbook.Services
{
	public interface IDishRepositiry
	{
		int AddNewDish(DishAddDto dishAddDto);
		void Delete(int id);
		DishDto GetDish(int id);
		IEnumerable<DishDto> GetDishes();
	}
}