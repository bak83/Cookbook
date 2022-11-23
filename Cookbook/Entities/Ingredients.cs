using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cookbook.Entities
{
	public class Ingredients
	{
		public string Name { get; set; } = string.Empty;
		public string? Description { get; set; }
	}
}
