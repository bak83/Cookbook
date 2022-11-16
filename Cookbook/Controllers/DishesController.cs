using Cookbook.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cookbook.Controllers
{
	[ApiController]
	[Route("api/dishes")]
	public class DishesController : ControllerBase
	{
		[HttpGet]
		public ActionResult<IEnumerable<DishesDto>> GetDishes()
		{
			return Ok(DishesDataStore.Current.Dishes);
		}

		[HttpGet("{id}")]
		public ActionResult<DishesDto> GetDishes(int id)
		{
			
			var dish = DishesDataStore.Current.Dishes
				.FirstOrDefault(c => c.Id == id);

			if (dish == null)
			{
				return NotFound();
			}

			return Ok(dish);
		}
	}
}
