using Microsoft.AspNetCore.Mvc;

namespace fruitkha.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
