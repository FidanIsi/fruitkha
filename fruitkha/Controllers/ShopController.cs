using fruitkha.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace fruitkha.Controllers
{
	public class ShopController : Controller
	{
		public IActionResult Index()
		{
			List<Product> products = new()
			{
				new Product()
				{
					ProductName = "Strawberry",
					ProductImage = "product-img-1.jpg",
					ProductPrice = 85.00m,
					ProductQuantity = "Per Kg"
				},

				new Product()
				{
					ProductName = "Berry",
					ProductImage = "product-img-2.jpg",
					ProductPrice = 70.00m,
					ProductQuantity = "Per Kg"
				},

				new Product()
				{
					ProductName = "Lemon",
					ProductImage = "product-img-3.jpg",
					ProductPrice = 35.00m,
					ProductQuantity = "Per Kg"
				},

				new Product()
				{
					ProductName = "Avocado",
					ProductImage = "product-img-4.jpg",
					ProductPrice = 50.00m,
					ProductQuantity = "Per Kg"
				},

				new Product()
				{
					ProductName = "Green Apple",
					ProductImage = "product-img-5.jpg",
					ProductPrice = 45.00m,
					ProductQuantity = "Per Kg"
				},

				new Product()
				{
					ProductName = "Strawberry",
					ProductImage = "product-img-6.jpg",
					ProductPrice = 80.00m,
					ProductQuantity = "Per Kg"
				},
			};
			return View(products);
		}

		public IActionResult ProductDetail()
		{
			return View();
		}
	}
}
