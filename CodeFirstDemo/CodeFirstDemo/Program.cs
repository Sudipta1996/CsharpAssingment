using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;


namespace CodeFirstDemo
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime Date { get; set; }
        public string Address { get; set; }

    }

    public class StudentDbContext : DbContext
    {
        public StudentDbContext() : base("StudentDbContext")
        {

        }
        public DbSet<Post> Posts { get; set; }
    }

     public class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new StudentDbContext())
            {

                var std = new Post()
                {
                    Id = 1,
                    Name = "Raju",
                    Address = "Uttarpara",
                    Date = DateTime.Now
                };
                ctx.Posts.Add(std);
                ctx.SaveChanges();
                Console.WriteLine("Student saved");
            }
        }
        
    }
}
