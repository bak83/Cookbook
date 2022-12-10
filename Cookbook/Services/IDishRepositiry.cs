using Cookbook.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cookbook.Services
{
	public interface IDishRepositiry
	{
		void AddNewDish(DishAddDto dishAdd);
		ActionResult<DishDto> GetDish(int id);
		ActionResult<IEnumerable<DishDto>> GetDishes();
		void JoinDishes(JoinDishDto joinDishes);
	}
}