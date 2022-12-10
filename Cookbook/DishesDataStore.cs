using Cookbook.Entities;
using Cookbook.Models;

namespace Cookbook
{
	public class DishesDataStore
	{
		public List<DishDto> Dishes { get; set; }
		public static DishesDataStore Current { get; } = new DishesDataStore();

		public DishesDataStore()
		{

			Dishes = new List<DishDto>()
			{
				new DishDto()
				{

					 Id = 1,
					 Name = "Cake",
					 KindOfDiet = new KindOfDietDto()
					 {
						 //Id = 1,
						 KindOfDiet = "vege"
					 },
					 KindOfDishes = new KindOfDishesDto()
					 {
						 //Id = 1,
						 KindOfDish = "dessert"
					 },
					 Ingredients = new List<IngredientsDto>()
					 {

						 new IngredientsDto()
						 {
							 Name = "Flower",
							 Description = "1 cup"
						 },
						 new IngredientsDto()
						 {
							  Name = "Water",
							 Description = "1 cup"
						 }
					 }
				},
				new DishDto()
				{
					 Id = 2,
					 Name = "Toast",
					Ingredients = new List<IngredientsDto>()
					 {
						 new IngredientsDto() 
						 {
							 Name = "Bread",
							 Description = "Slice" 
						 },
						 new IngredientsDto() 
						 {
							 Name = "Chees",
							 Description = "Slice" 
						 }
					 }
				},
				new DishDto()
				{

					 Id = 3,
					 Name = "Cacao",
					Ingredients = new List<IngredientsDto>()
					 {
						 new IngredientsDto()
						 {
							Name = "Milk",
							Description = "1 cup"							 
						 },
						  new IngredientsDto()
						  {
							Name = "Cacao",
							Description = "1 tbs"							 
						  },
					 }
				}
			};

		}
	}
}
