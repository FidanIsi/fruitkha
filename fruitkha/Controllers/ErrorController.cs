using Microsoft.AspNetCore.Mvc;

namespace fruitkha.Controllers
{
	public class ErrorController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
