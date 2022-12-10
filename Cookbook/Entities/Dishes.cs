using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cookbook.Entities
{
	public class Dishes
	{
		
		public int Id { get; set; }

		public string? Name { get; set; }

		public int NumberOfIngredients
		{
			get
			{
				return Ingredients.Count;
			}
		}

		public KindOfDiet KindOfDiet { get; set; } = new KindOfDiet();
		public KindOfdishes KindOfDishes { get; set; } = new KindOfdishes();

		public ICollection<Ingredients> Ingredients { get; set; }
			= new List<Ingredients>();


	}
}
