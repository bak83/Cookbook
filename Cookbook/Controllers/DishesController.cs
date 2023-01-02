using AutoMapper;
using Cookbook.Entities;
using Cookbook.Models;
using Cookbook.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
			var result = _dishRepositiry.GetDishes();
			
			return Ok(result);
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

		[HttpPost("join")]
		public ActionResult<DishDto> JoinDishes(JoinDishDto joinDishes)
		{
			var joinDish = joinDishes.ListOfDishes;
			var Name = joinDishes.Name;
			var kindOfDiet = _mapper.Map<Entities.KindOfDiet>(joinDishes.KindOfDiet);
			var kindOfDishes = _mapper.Map<Entities.KindOfDishes>(joinDishes.KindOfDishes);
			var igredients = _mapper.Map<IEnumerable<Entities.Ingredients>>(joinDishes.Ingredients);
			_dishRepositiry.JoinDishes(joinDish, Name, kindOfDiet, kindOfDishes, igredients);
			return Ok();
		}

	}
}
