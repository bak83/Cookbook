using AutoMapper;
using Cookbook.Models;
using Cookbook.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cookbook.Controllers
{
	[ApiController]
	[Route("api/dishes")]
	public class DishesController : ControllerBase
	{
		private readonly IDishRepositiry _dishRepositiry;
		private readonly IMapper _mapper;

		public DishesController(IDishRepositiry dishRepositiry, IMapper mapper)
		{
			_dishRepositiry = dishRepositiry ??
				throw new ArgumentNullException(nameof(dishRepositiry));
			_mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
		}
		[HttpGet]
		public ActionResult<IEnumerable<DishDto>> GetDishes()
		{
			var dishesList = _dishRepositiry.GetDishes();
			
			return Ok(_mapper.Map<IEnumerable<DishDto>>(dishesList));
		}

		[HttpGet("{id}")]
		public ActionResult<DishDto> GetDish(int id)
		{

			var dish = _dishRepositiry.GetDish(id);

			if (dish == null)
			{
				return NotFound();
			}

			return Ok(_mapper.Map<DishDto>(dish));
		}

		[HttpPost]
		public ActionResult<DishDto> AddNewDish(DishAddDto dishAdd)
		{
			var result = _mapper.Map<Entities.Dishes>(dishAdd);
			_dishRepositiry.AddNewDish(result);

			return Ok();
		}

		//[HttpPost("join")]
		//public ActionResult<DishDto> JoinDishes(JoinDishDto joinDishes)
		//{

		//	_dishRepositiry.JoinDishes(joinDishes);
		//	return Ok();
		//}

	}
}
