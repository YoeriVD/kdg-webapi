using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
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
		[Route("{id}")]
	    public Recipe Get(int id)
	    {
		    return _recipesProvider.AllRecipes.Single(rec => rec.Id == id);
	    }
    }
}
