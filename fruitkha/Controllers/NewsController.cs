using Microsoft.AspNetCore.Mvc;

namespace fruitkha.Controllers
{
	public class NewsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult NewsDetail()
		{
			return View();
		}
	}
}
