using Microsoft.AspNetCore.Mvc;

namespace fruitkha.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
