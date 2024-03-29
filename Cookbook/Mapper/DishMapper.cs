﻿using AutoMapper;

namespace Cookbook.Mapper
{
	public class DishMapper : Profile
	{
		public DishMapper()
		{
			CreateMap<Entities.Dishes, Models.DishDto>()
				.ForMember(dest => dest.NumberOfIngredients, act => act.MapFrom(src => src.Ingredients.Count));
			CreateMap<Models.DishDto, Entities.Dishes>();
			CreateMap<Models.DishAddDto, Entities.Dishes>();

			CreateMap<Entities.Ingredients, Models.IngredientsDto>();
			CreateMap<Entities.KindOfDiet, Models.KindOfDietDto>();
			CreateMap<Entities.KindOfDishes, Models.KindOfDishesDto>();
			CreateMap<Models.IngredientsDto, Entities.Ingredients>();
			CreateMap<Models.KindOfDietDto, Entities.KindOfDiet>();
			CreateMap<Models.KindOfDishesDto, Entities.KindOfDishes>();


		}
	}
}
