using Cookbook.Entities;

namespace Cookbook.Models
{
	public class DishAddDto
	{
		public string Name { get; set; } = string.Empty;

		public KindOfDietDto KindOfDiet { get; set; } = new KindOfDietDto();
		public KindOfDishesDto KindOfDishes { get; set; } = new KindOfDishesDto();

		public ICollection<IngredientsDto> Ingredients { get; set; }
			= new List<IngredientsDto>();

		

	}
}
