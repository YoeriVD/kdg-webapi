using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManlyManFood.Models
{
	public class Recipe
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public IEnumerable<Ingredient> Ingredients { get; set; } 
	}
}
