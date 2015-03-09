using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ManlyManFood.DataProvider;
using ManlyManFood.Models;

namespace ManlyManFood.Controllers
{
	[RoutePrefix("ingredients")]
	public class IngredientController : ApiController
	{
		private readonly IngredientsProvider _ingredientsProvider;

		public IngredientController()
		{
			_ingredientsProvider = new IngredientsProvider();
		}

		//GET
		[Route("")]
		public IEnumerable<Ingredient> Get()
		{
			return _ingredientsProvider.Ingredients;
		}
		[Route("{id}")]
		public Ingredient Get(int id)
		{
			return _ingredientsProvider.Ingredients.Single(rec => rec.Id == id);
		}
	}
}