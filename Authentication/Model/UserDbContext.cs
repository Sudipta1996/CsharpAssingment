using Microsoft.EntityFrameworkCore;

namespace Authentication.Model
{
    public class UserDbConetext : DbContext
    {
        public UserDbConetext(DbContextOptions<UserDbConetext> options) : base(options)
        {

        }
        public DbSet<SignUp> signUps { get; set; }

    }
}
