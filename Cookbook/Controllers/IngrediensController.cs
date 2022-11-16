
using Cookbook.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cookbook.Controllers
{
	[ApiController]
	[Route("api/dishes/{dishId}/ingrediens")]
	public class IngrediensController : ControllerBase
	{
		[HttpGet]
		public ActionResult<IEnumerable<DishDto>> GetIngredients(int dishId)
		{
			var dish = DishesDataStore.Current.Dishes.FirstOrDefault(c => c.Id == dishId);

			if (dish == null)
			{
				return NotFound();
			}

			return Ok(dish.Ingredients);
		}

		[HttpGet("{ingrediensname}")]
		public ActionResult<DishDto> GetIngredients(
			int dishId, string ingrediensName)
		{
			var dish = DishesDataStore.Current.Dishes
				.FirstOrDefault(c => c.Id == dishId);
			if (dish == null)
			{
				return NotFound();
			}

			// find point of interest
			var ingredients = dish.Ingredients
				.FirstOrDefault(c => c.Name == ingrediensName);
			if (ingredients == null)
			{
				return NotFound();
			}

			return Ok(ingredients);
		}

	}
}
