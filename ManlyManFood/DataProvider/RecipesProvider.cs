using System.Collections.Generic;
using ManlyManFood.Models;

namespace ManlyManFood.DataProvider
{
	class RecipesProvider
	{
		private readonly List<Recipe> _allRecipes;
		public RecipesProvider()
		{
			var ingredientsProvider = new IngredientsProvider();
			_allRecipes = new List<Recipe>
			{
					new Recipe(){Id = 1 ,  Name = "Ranzig gerecht", Ingredients = ingredientsProvider.GetIngredientsByIndex(1,2)},
					new Recipe(){Id = 2 ,  Name = "Vies gerecht", Ingredients = ingredientsProvider.GetIngredientsByIndex(2,6,5)},
					new Recipe(){Id = 3 ,  Name = "Random gerecht", Ingredients = ingredientsProvider.GetIngredientsByIndex(1,5,3,6)},
					new Recipe(){Id = 4 ,  Name = "Wansmakelijk gerecht", Ingredients = ingredientsProvider.GetIngredientsByIndex(5,6,7,8)},
					new Recipe(){Id = 5 ,  Name = "Is dit zelfs een gerecht?", Ingredients = ingredientsProvider.GetIngredientsByIndex(3,6)},
					new Recipe(){Id = 6 ,  Name = "Gerecht zonder naam", Ingredients = ingredientsProvider.GetIngredientsByIndex(4,7)},
					new Recipe(){Id = 7 ,  Name = "KdG Special", Ingredients = ingredientsProvider.GetIngredientsByIndex(1,4,7)},
					new Recipe(){Id = 8 ,  Name = "Shizzle", Ingredients = ingredientsProvider.GetIngredientsByIndex(6,3,7)},
					new Recipe(){Id = 9 ,  Name = "Nizzle", Ingredients = ingredientsProvider.GetIngredientsByIndex(2,5,2,6)},
					new Recipe(){Id = 10 , Name = "Drizzle", Ingredients = ingredientsProvider.GetIngredientsByIndex(3,5)},
					new Recipe(){Id = 11 , Name = "Niveau", Ingredients = ingredientsProvider.GetIngredientsByIndex(7,5)},
					new Recipe(){Id = 12 , Name = "Ver", Ingredients = ingredientsProvider.GetIngredientsByIndex(2,6)},
					new Recipe(){Id = 13 , Name = "TeZoeken", Ingredients = ingredientsProvider.GetIngredientsByIndex(4,3)},
					new Recipe(){Id = 14 , Name = "Einde!", Ingredients = ingredientsProvider.GetIngredientsByIndex(5,1)},
				};
		}
		public IEnumerable<Recipe> AllRecipes
		{
			get
			{
				return _allRecipes;
			}
		}
		public void Add(Recipe recipe)
		{
			recipe.Id = _allRecipes.Count + 1;
			_allRecipes.Add(recipe);
		}
	}
}
