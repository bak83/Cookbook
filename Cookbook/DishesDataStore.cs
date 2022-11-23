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
					 dishes = new Entities.Dishes()
					 {
					 Id = 1,
					 Name = "Cake"
					 },
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

						 new IngredientsDto() {
							 ingredients = new Ingredients()
							 { Name = "Flower",
							 Description = "1 cup" } },
						  new IngredientsDto() {
							 ingredients =  new Entities.Ingredients()
							 {Name = "Water",
							 Description = "1 cup" } },
					 }
				},
				new DishDto()
				{
					dishes = new Entities.Dishes()
					 {
					 Id = 2,
					 Name = "Toast"
					 },
					Ingredients = new List<IngredientsDto>()
					 {
						 new IngredientsDto() {
							 ingredients =  new Ingredients()
							 {Name = "Bread",
							 Description = "Slice" } },
						  new IngredientsDto() {
							 ingredients =  new Ingredients()
							 {Name = "Chees",
							 Description = "Slice" } },
					 }
				},
				new DishDto()
				{
					dishes = new Entities.Dishes()
					 {
					 Id = 3,
					 Name = "Cacao"
					 },
					Ingredients = new List<IngredientsDto>()
					 {
						 new IngredientsDto() 
						 {
						ingredients = new Ingredients()
							 {
								Name = "Milk",
								Description = "1 cup"
							 } 
						 },
						  new IngredientsDto() 
						  {
							ingredients = new Ingredients()
							 {
								Name = "Cacao",
								Description = "1 tbs"
							 } 
						  },
					 }
				}
			};

		}
	}
}
