using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ManlyManFood.Models
{
	public class Recipe
	{
		public int Id { get; set; }
		[Required]
		[MinLength(3)]
		public string Name { get; set; }
		public IEnumerable<Ingredient> Ingredients { get; set; } 
	}
}
