using Microsoft.EntityFrameworkCore;

namespace UserSignUp.Model
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }
        public DbSet<SignUp> signUps { get; set; }
    }
}
