using Cookbook.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Cookbook.Controllers
{
	[ApiController]
	[Route("api/Ingrediens")]
	public class IngrediensController : ControllerBase
	{
		private readonly DbCookBookContext _context;

		public IngrediensController(DbCookBookContext context)
		{
			_context = context;
		}

			public IActionResult Index(Ingredients ingredients)
		{
			_context.Add(ingredients);
			_context.SaveChanges();

			return Ok();
		}

		[HttpGet]
		public ActionResult<IEnumerable<Ingredients>> GetIngredients()
		{
			
			return Ok();
		}

	}
}
