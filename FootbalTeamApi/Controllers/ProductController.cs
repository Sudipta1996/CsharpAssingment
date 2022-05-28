using FootbalTeamApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FootbalTeamApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductDbContext context = new ProductDbContext();
        [HttpGet]
        public IEnumerable<Product> Get()
        {

                return context.Products.ToList();
            
        }
        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest("Employee is null.");
            }
            context.Add(product);
            return CreatedAtRoute(
                  "Get",
                  new { Id = product.ProductId },
                  product);
        }
    }
}
