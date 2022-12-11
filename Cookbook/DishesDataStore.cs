using Cookbook.Entities;

namespace Cookbook
{
	public class DishesDataStore
	{
		public List<Dishes> Dishes { get; set; }
		public static DishesDataStore Current { get; } = new DishesDataStore();

		public DishesDataStore()
		{

			Dishes = new List<Dishes>()
			{
				new Dishes()
				{

					 Id = 1,
					 Name = "Cake",
					 KindOfDiet = new KindOfDiet()
					 {
						 //Id = 1,
						 kindOfDiet = "vege"
					 },
					 KindOfDishes = new KindOfDishes()
					 {
						 //Id = 1,
						 KindOfDish = "dessert"
					 },
					 Ingredients = new List<Ingredients>()
					 {

						 new Ingredients()
						 {
							 Name = "Flower",
							 Description = "1 cup"
						 },
						 new Ingredients()
						 {
							  Name = "Water",
							 Description = "1 cup"
						 }
					 }
				},
				new Dishes()
				{
					 Id = 2,
					 Name = "Toast",
					Ingredients = new List<Ingredients>()
					 {
						 new Ingredients() 
						 {
							 Name = "Bread",
							 Description = "Slice" 
						 },
						 new Ingredients() 
						 {
							 Name = "Chees",
							 Description = "Slice" 
						 }
					 }
				},
				new Dishes()
				{

					 Id = 3,
					 Name = "Cacao",
					Ingredients = new List<Ingredients>()
					 {
						 new Ingredients()
						 {
							Name = "Milk",
							Description = "1 cup"							 
						 },
						  new Ingredients()
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
