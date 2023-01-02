using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cookbook.Entities
{
	public class KindOfDiet
	{
		public int Id { get; set; }
		public string kindOfDiet { get; set; }
	}
}
