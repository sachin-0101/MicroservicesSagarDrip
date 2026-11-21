using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductService.Models;

namespace ProductService.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		[HttpGet]
		public IActionResult GetProducts()
		{
			var products = new List<Product>
			{
				new Product { Id = 1, ProductName = "Dell Laptop", Price = 68000 },
				new Product { Id = 2, ProductName = "Mobile", Price = 25000 },
				new Product { Id = 3, ProductName = "Macbook M4", Price = 90000 },
				new Product { Id = 4, ProductName = "Gaming PC", Price = 120000 },
				new Product { Id = 5, ProductName = "Headphones", Price = 2000 },
				new Product { Id = 6, ProductName = "Smartwatch", Price = 15000 }	
			};
			return Ok(products);
		}
	}
}
