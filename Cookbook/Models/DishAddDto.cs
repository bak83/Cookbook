namespace Cookbook.Models
{
	public class DishAddDto
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public int NumberOfIngredients
		{
			get
			{
				return Ingredients.Count;
			}
		}

		public KindOfDietDto KindOfDiet { get; set; } = new KindOfDietDto();
		public KindOfDishesDto KindOfDishes { get; set; } = new KindOfDishesDto();

		//public IngredientsDto Ingredient { get; set; } = new IngredientsDto();

		public ICollection<IngredientsDto> Ingredients { get; set; }
			= new List<IngredientsDto>();

	}
}
