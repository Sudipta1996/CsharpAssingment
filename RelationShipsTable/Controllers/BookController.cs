using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RelationShipsTable.Data;

namespace RelationShipsTable.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly DataContext _context;

        public BookController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get(int userId)
        {
            var products = await _context.Products.Where(p => p.UserId == userId).Include(c=>c.Orders)
                .ToListAsync();
            return products;
        }
        [HttpPost]
        public async Task<ActionResult<List<Product>>> Create(CreateProduct request)
        {
            var user = await _context.Users.FindAsync(request.UserId);
            if (user == null) return NotFound();

            var newProduct = new Product
            {
                productName = request.productName,
                price = request.price,
                ProductUser = user,
 


            };
            _context.Products.Add(newProduct);
            await _context.SaveChangesAsync();

            return await Get(newProduct.UserId);

        }
    }
}
