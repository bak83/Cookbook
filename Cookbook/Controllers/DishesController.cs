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

		[HttpPost("join")]
		public ActionResult<DishDto> JoinDishes(JoinDishDto joinDishes)
		{

			var maxDishId = DishesDataStore.Current.Dishes.Max(p => p.Id);
			var existsDishes = new List<DishDto>();

			foreach (var dish in joinDishes.ListOfDishes)
			{
				existsDishes.Add(DishesDataStore.Current.Dishes.FirstOrDefault(c => c.Id == dish));

			}

			var Ingredients = new List<IngredientsDto>();
			string elem = null;

			foreach (var dish in existsDishes)
			{
				foreach (var ingredient in dish.Ingredients)
				{
					elem += ingredient.Name;
				}	
				Ingredients.Add(
					new IngredientsDto
					{
						Name = dish.Name,
						//Description = dish.Ingredients.ToString() //string.Join(",", list.ToArray())
						Description = elem,

					}
					);
			}	

			var newDish = new DishDto()
			{
				Id = ++maxDishId,
				Name = joinDishes.Name,
				KindOfDiet = joinDishes.KindOfDiet,
				KindOfDishes = joinDishes.KindOfDishes,
				Ingredients = Ingredients
			};

			DishesDataStore.Current.Dishes.Add(newDish);


			return Ok();
		}

	}
}
