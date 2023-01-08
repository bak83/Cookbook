using Cookbook.Entities;

namespace Cookbook.Models
{
	public class DishAddDto : IDishAddDto
	{
		public string Name { get; set; } = string.Empty;

		public KindOfDietDto KindOfDiet { get; set; } = new KindOfDietDto();
		public KindOfDishesDto KindOfDishes { get; set; } = new KindOfDishesDto();
		public ICollection<int> ListOfDishes { get; set; } = new List<int>();
		public ICollection<IngredientsDto> Ingredients { get; set; }
			= new List<IngredientsDto>();



	}
}
