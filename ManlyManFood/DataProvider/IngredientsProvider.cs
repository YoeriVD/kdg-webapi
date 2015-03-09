using System.Collections.Generic;
using System.Linq;
using ManlyManFood.Models;

namespace ManlyManFood.DataProvider
{
	class IngredientsProvider
	{
		public IEnumerable<Ingredient> Ingredients { get; private set; }

		public IngredientsProvider()
		{
			this.Ingredients = new List<Ingredient>()
			{
				new Ingredient(){Id = 1, Name="Salt"},
				new Ingredient(){Id = 2, Name="Pepper"},
				new Ingredient(){Id = 3, Name="Butter"},
				new Ingredient(){Id = 4, Name="Tomatoes"},
				new Ingredient(){Id = 5, Name="Potatoes"},
				new Ingredient(){Id = 6, Name="Lemon juice"},
				new Ingredient(){Id = 7, Name="Rice"},
				new Ingredient(){Id = 8, Name="Cinnamon"},
			};
		}

		public IEnumerable<Ingredient> GetIngredientsByIndex(params int[] ids)
		{
			return ids.Select(id => Ingredients.Single(ing => ing.Id == id));
		}
	}
}