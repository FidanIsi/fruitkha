using Microsoft.AspNetCore.Mvc;

namespace fruitkha.Controllers
{
	public class CartController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
