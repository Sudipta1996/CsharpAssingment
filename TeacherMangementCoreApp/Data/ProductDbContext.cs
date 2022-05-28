using Microsoft.EntityFrameworkCore;
using TeacherMangementCoreApp.Models;

namespace TeacherMangementCoreApp.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
