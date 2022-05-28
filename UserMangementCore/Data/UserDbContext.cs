using Microsoft.EntityFrameworkCore;
using UserMangementCore.Models;

namespace UserMangementCore.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options ):base(options)
        {

        }
        public DbSet<User> user { get; set; }
    }
}
