using Cookbook.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cookbook.Controllers
{
	[ApiController]
	[Route("api/dishes")]
	public class DishesController : ControllerBase
	{
		[HttpGet]
		public ActionResult<IEnumerable<DishDto>> GetDishes()
		{
			return Ok(DishesDataStore.Current.Dishes);
		}

		[HttpGet("{id}")]
		public ActionResult<DishDto> GetDishes(int id)
		{
			
			var dish = DishesDataStore.Current.Dishes
				.FirstOrDefault(c => c.Id == id);

			if (dish == null)
			{
				return NotFound();
			}

			return Ok(dish);
		}

		[HttpPost]
		public ActionResult<DishDto> AddNewDish(DishAddDto dishAdd)
		{
			
			var maxDishId = DishesDataStore.Current.Dishes.Max(p => p.Id);
			
			var newDish = new DishDto()
			{
				Id = ++maxDishId,
				Name = dishAdd.Name,
				KindOfDiet = dishAdd.KindOfDiet,
				KindOfDishes = dishAdd.KindOfDishes,
				Ingredients = dishAdd.Ingredients
			};

			DishesDataStore.Current.Dishes.Add(newDish);
			

			return Ok();
		}

	}
}
