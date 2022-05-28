using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UserAuthenticationServices.Model
{
    public class UserDbContext : IdentityDbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ApplicationUser> applicationUsers { get; set; }
    }
}
