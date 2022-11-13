using Microsoft.AspNetCore.Mvc;

namespace Cookbook.Controllers
{
	public class IngrediensController : Controller
	{
		private readonly DbCookBookContext _context;

		public IngrediensController(DbCookBookContext context)
		{
			_context = context;
		}

			public IActionResult Index()
		{
			//_context.Ingredients.Add
			return View();
		}
	}
}
