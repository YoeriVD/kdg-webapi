using System.Collections.Generic;

namespace ManlyManFood.Models
{
	public class Recipe
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public IEnumerable<Ingredient> Ingredients { get; set; } 
	}
}
