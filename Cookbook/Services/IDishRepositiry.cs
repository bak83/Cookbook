//using Cookbook.Models;
using Cookbook.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Cookbook.Services
{
	public interface IDishRepositiry
	{
		//void AddNewDish(Dishes dishAdd);
		ActionResult<Dishes> GetDish(int id);
		ActionResult<IEnumerable<Dishes>> GetDishes();
		//void JoinDishes(IEnumerable<Dishes> joinDishes);
	}
}