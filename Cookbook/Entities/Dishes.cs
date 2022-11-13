using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cookbook.Entities
{
	public class Dishes
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public string? NameOfDish { get; set; }

		public int? IngredientId { get; set; } // albo jako lista składników

		public int? KindOfDietId { get; set; }

		public int KindOfDishesId { get; set; }

	}
}
