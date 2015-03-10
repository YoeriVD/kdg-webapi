using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ManlyManFood.DataProvider;
using ManlyManFood.Models;

namespace ManlyManFood.Controllers
{
	[RoutePrefix("auth/recipes")]
	[Authorize]
	public class RecipeAuthController : ApiController
	{
		private readonly RecipesProvider _recipesProvider;

		public RecipeAuthController()
		{
			_recipesProvider = new RecipesProvider();
		}

		//GET
		[Route("")]
		public IEnumerable<Recipe> Get()
		{
			return _recipesProvider.AllRecipes;
		}
		[Route("{id:int}")]
		public Recipe Get(int id)
		{
			return _recipesProvider.AllRecipes.Single(rec => rec.Id == id);
		}
		[Route("{name}")]
		public IHttpActionResult Get(string name)
		{
			var recipe = _recipesProvider.AllRecipes.SingleOrDefault(rec => rec.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));
			if (recipe == null) return NotFound();
			return Ok(recipe);
		}
		[Route("{id}/ingredients")]
		public IEnumerable<Ingredient> GetIngredientsForRecipe(int id)
		{
			return Get(id).Ingredients;
		}
	}
}