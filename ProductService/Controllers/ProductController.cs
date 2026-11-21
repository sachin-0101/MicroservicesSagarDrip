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
				new Product { Id = 1, ProductName = "Product 1", Price = 10.0m },
				new Product { Id = 2, ProductName = "Product 2", Price = 20.0m },
				new Product { Id = 3, ProductName = "Product 3", Price = 30.0m }
			};
			return Ok(products);
		}
	}
}
