//using Cookbook.Models;
using AutoMapper;
using Cookbook.Entities;
using Cookbook.Exceptions;
using Cookbook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Cookbook.Services
{
	public class DishRepositiry : IDishRepositiry
	{
		private readonly IMapper _mapper;
		private readonly CookBookDbContext _dbContext;
		private readonly ILogger<DishRepositiry> _logger;

		public DishRepositiry(IMapper mapper, CookBookDbContext dbContext, ILogger<DishRepositiry> logger)
		{
			_mapper = mapper;
			_dbContext = dbContext;
			_logger = logger;
		}

		public IEnumerable<DishDto> GetDishes()
		{
			var dishes = _dbContext
				.Dishes
				.Include(a => a.Ingredients)
				.Include(a => a.KindOfDiet)
				.Include(a => a.KindOfDishes)
				.ToList();
			
			var DishesDto = _mapper.Map<List<DishDto>>(dishes);

			return DishesDto;
		}
		public DishDto GetDish(int id)
		{
			var dish = _dbContext
				.Dishes
				.Include(a => a.Ingredients)
				.Include(a => a.KindOfDiet)
				.Include(a => a.KindOfDishes)
				.FirstOrDefault(c => c.Id == id);

			if (dish is null)
				throw new NotFoundExcteption("Dish not found");

			var result = _mapper.Map<DishDto>(dish);
			return result;
		}

		public int AddNewDish(DishAddDto dishAddDto)
		{
			var dish = _mapper.Map<Entities.Dishes>(dishAddDto);
			if (dishAddDto.ListOfDishes.IsNullOrEmpty())
			{				
				_dbContext.Dishes.Add(dish);
				_dbContext.SaveChanges();
			}
			else
			{
				JoinDishes(dishAddDto);
			}

			return dish.Id;
		}

		public void JoinDishes(DishAddDto joinDishes)
		{
			var existsDishesList = _dbContext
				.Dishes
				.Include(a => a.Ingredients)
				.Include(a => a.KindOfDiet)
				.Include(a => a.KindOfDishes)
				.Where(x => joinDishes.ListOfDishes.Contains(x.Id))
				.ToList();

			if (existsDishesList.Count() == 0)
				throw new NotFoundExcteption("Dish not found");

			var Ingredients = new List<Ingredients>();
			string elem = null;

			foreach (var dish in existsDishesList)
			{
				foreach (var ingredient in dish.Ingredients)
				{
					elem += ingredient.Name;
				}
				Ingredients.Add
					(
					new Ingredients
					{
						Name = dish.Name,
						Description = elem
					}
					);
				elem = null;
			}
			
			var Name = joinDishes.Name;
			var kindOfDiet = _mapper.Map<Entities.KindOfDiet>(joinDishes.KindOfDiet);
			var kindOfDishes = _mapper.Map<Entities.KindOfDishes>(joinDishes.KindOfDishes);
			var igredients = _mapper.Map<List<Entities.Ingredients>>(joinDishes.Ingredients);
			if (igredients != null)
			{
				Ingredients.AddRange(igredients);
			}
			var newDish = new Dishes()
			{
				Name = Name,
				KindOfDiet = kindOfDiet,
				KindOfDishes = kindOfDishes,
				Ingredients = Ingredients
			};

			_dbContext.Dishes.Add(newDish);
			_dbContext.SaveChanges();
		}
	}
}
