using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ManlyManFood.Models;

namespace ManlyManFood.DataProvider
{
	class RecipesProvider
	{
		private readonly IngredientsProvider _ingredientsProvider;

		public RecipesProvider()
		{
			_ingredientsProvider = new IngredientsProvider();
		}

		public IEnumerable<Recipe> AllRecipes
		{
			get
			{
				return new[]
				{
					new Recipe(){Id = 1 ,  Name = "Ranzig gerecht", Ingredients = _ingredientsProvider.GetIngredientsByIndex(1,2)},
					new Recipe(){Id = 2 ,  Name = "Vies gerecht", Ingredients = _ingredientsProvider.GetIngredientsByIndex(2,6,5)},
					new Recipe(){Id = 3 ,  Name = "Random gerecht", Ingredients = _ingredientsProvider.GetIngredientsByIndex(1,5,3,6)},
					new Recipe(){Id = 4 ,  Name = "Wansmakelijk gerecht", Ingredients = _ingredientsProvider.GetIngredientsByIndex(5,6,7,8)},
					new Recipe(){Id = 5 ,  Name = "Is dit zelfs een gerecht?", Ingredients = _ingredientsProvider.GetIngredientsByIndex(3,6)},
					new Recipe(){Id = 6 ,  Name = "Gerecht zonder naam", Ingredients = _ingredientsProvider.GetIngredientsByIndex(4,7)},
					new Recipe(){Id = 7 ,  Name = "KdG Special", Ingredients = _ingredientsProvider.GetIngredientsByIndex(1,4,7)},
					new Recipe(){Id = 8 ,  Name = "Shizzle", Ingredients = _ingredientsProvider.GetIngredientsByIndex(6,3,7)},
					new Recipe(){Id = 9 ,  Name = "Nizzle", Ingredients = _ingredientsProvider.GetIngredientsByIndex(2,5,2,6)},
					new Recipe(){Id = 10 , Name = "Drizzle", Ingredients = _ingredientsProvider.GetIngredientsByIndex(3,5)},
					new Recipe(){Id = 11 , Name = "Niveau", Ingredients = _ingredientsProvider.GetIngredientsByIndex(7,5)},
					new Recipe(){Id = 12 , Name = "Ver", Ingredients = _ingredientsProvider.GetIngredientsByIndex(2,6)},
					new Recipe(){Id = 13 , Name = "TeZoeken", Ingredients = _ingredientsProvider.GetIngredientsByIndex(4,3)},
					new Recipe(){Id = 14 , Name = "Einde!", Ingredients = _ingredientsProvider.GetIngredientsByIndex(5,1)},
				};
			}
		} 
	}
}
