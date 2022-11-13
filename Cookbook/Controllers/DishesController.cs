using Microsoft.AspNetCore.Mvc;

namespace Cookbook.Controllers
{
	public class DishesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
