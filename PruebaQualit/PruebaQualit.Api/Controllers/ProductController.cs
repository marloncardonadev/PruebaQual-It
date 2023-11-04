using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaQualit.Infrastructure.Repositories;

namespace PruebaQualit.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductController()
        {
            
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = new ProductRepository().GetProducts();
            return Ok(products);
        }
    }
}
