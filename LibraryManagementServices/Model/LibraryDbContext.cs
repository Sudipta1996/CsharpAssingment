using Microsoft.EntityFrameworkCore;

namespace LibraryManagementServices.Model
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Library> Librarys { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
