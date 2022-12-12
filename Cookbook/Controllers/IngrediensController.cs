
using AutoMapper;
using Cookbook.Models;
using Cookbook.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cookbook.Controllers
{
	[ApiController]
	[Route("api/dishes/{dishId}/ingrediens")]
	public class IngrediensController : ControllerBase
	{
		private readonly IDishRepositiry _dishRepositiry;
		private readonly IMapper _mapper;

		public IngrediensController(IDishRepositiry dishRepositiry, IMapper mapper)
		{
			_dishRepositiry = dishRepositiry ??
				throw new ArgumentNullException(nameof(dishRepositiry));
			_mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
		}

		[HttpGet]
		public ActionResult<IEnumerable<DishDto>> GetIngredients(int dishId)
		{
			var dish = _dishRepositiry.GetDish(dishId);
			if (dish == null)
			{
				return NotFound();
			}
			
			return Ok(_mapper.Map<IEnumerable<IngredientsDto>>(dish.Ingredients));
		}

		

	}
}
