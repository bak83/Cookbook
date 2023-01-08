namespace Cookbook.Models
{
	public interface IDishAddDto
	{
		ICollection<IngredientsDto> Ingredients { get; set; }
		KindOfDietDto KindOfDiet { get; set; }
		KindOfDishesDto KindOfDishes { get; set; }
		string Name { get; set; }
	}
}