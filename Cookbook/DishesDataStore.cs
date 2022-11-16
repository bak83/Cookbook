using Cookbook.Models;

namespace Cookbook
{
	public class DishesDataStore
	{
		public List<DishDto> Dishes { get; set; }
		public static DishesDataStore Current { get; } = new DishesDataStore();

		public DishesDataStore()
		{
			// init dummy data
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
						 new IngredientsDto() {
							 //Id = 1,
							 Name = "Flower",
							 Description = "1 cup" },
						  new IngredientsDto() {
							 //Id = 2,
							 Name = "Water",
							 Description = "1 cup" },
					 }
				},
				new DishDto()
				{
					Id = 2,
					Name = "Toast",
					Ingredients = new List<IngredientsDto>()
					 {
						 new IngredientsDto() {
							 //Id = 3,
							 Name = "Bread",
							 Description = "Slice" },
						  new IngredientsDto() {
							 //Id = 4,
							 Name = "Chees",
							 Description = "Slice" },
					 }
				},
				new DishDto()
				{
					Id= 3,
					Name = "Cacao",
					Ingredients = new List<IngredientsDto>()
					 {
						 new IngredientsDto() {
							 //Id = 5,
							 Name = "Milk",
							 Description = "1 cup" },
						  new IngredientsDto() {
							 //Id = 6,
							 Name = "Cacao",
							 Description = "1 tbs" },
					 }
				}
			};

		}
	}
}
