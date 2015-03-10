using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;
using ManlyManFood.DataProvider;
using ManlyManFood.Models;

namespace ManlyManFood.Controllers
{
	[RoutePrefix("recipes")]
    public class RecipeController : ApiController
    {
	    private readonly RecipesProvider _recipesProvider;

	    public RecipeController()
	    {
			_recipesProvider = new RecipesProvider();
	    }

		//GET
		[Route("")]
	    public IEnumerable<Recipe> Get()
	    {
		    return _recipesProvider.AllRecipes;
	    }
		[Route("{id:int}", Name = "GetRecipeById")]
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
		[Route("")]
		public IHttpActionResult Post(Recipe recipe)
		{
			if (!ModelState.IsValid) return BadRequest(ModelState);

			_recipesProvider.Add(recipe);
			var url = Url.Link("GetRecipeById", new {recipe.Id});
			return Created(url, recipe);
		}
    }
}
