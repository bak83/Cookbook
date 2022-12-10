using Cookbook.Entities;

namespace Cookbook.Models
{
	public class DishDto
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		//public Dishes dishes { get; set; } = new Dishes();
		public int NumberOfIngredients
		{
			get
			{
				return Ingredients.Count;
			}
		}

		public KindOfDietDto KindOfDiet { get; set; } = new KindOfDietDto();
		public KindOfDishesDto KindOfDishes { get; set; } = new KindOfDishesDto();

		public ICollection<IngredientsDto> Ingredients { get; set; }
			= new List<IngredientsDto>();
	}
}
