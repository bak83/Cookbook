﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cookbook.Entities
{

	
	public class KindOfDishes
	{
		public int Id { get; set; }
		public string KindOfDish { get; set; }
		public Dishes Dishes { get; set; }
		public int DishesId { get; set; }
	}
}
