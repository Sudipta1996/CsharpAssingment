using System;
using System.Linq;
using System.Data.Entity;


namespace StudentDemo
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; }
         public DateTime Date { get; set; }
        public string Address { get; set; }
         
        public int Marks { get; set; }

        
    }

    
    public class StudentDbContext : DbContext
    {
        
        public DbSet<Post> Posts { get; set; }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            StudentDbContext ctx = new StudentDbContext();
            //Create and insert data//
            //Console.WriteLine("Enter Student Id");
            //var id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Student Name");
            //var name = Console.ReadLine();
            //Console.WriteLine("Enter Student Adress");
            //var address = Console.ReadLine();
            //Console.WriteLine("Enter Student Marks");
            //var marks = Convert.ToInt32(Console.ReadLine());
            //Post post = new Post()
            //{
            //    Id = id,
            //    Name = name,  
            //    Date = DateTime.Now,
            //    Address = address,
            //    Marks = marks
            //};
            //ctx.Posts.Add(post);
            //ctx.SaveChanges();

            //Update one Colum element//
            //var post = ctx.Posts.Where(x => x.Id == id ).First();
            //post.Address = "tamilNadu";
            //ctx.SaveChanges();
            //Console.WriteLine("Student Updated");

            //Remove one Coloumn//
            //var post = ctx.Posts.Where(x => x.Id == id).FirstOrDefault();
            //ctx.Posts.Remove(post);
            //ctx.SaveChanges();
            //Console.WriteLine("Student Removed");

            //Retrive full table//
            //var query = (from s in ctx.Posts
            //             select s);
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Name+" "+item.Date+" " +item.Id +" "+ item.Marks);
            //}

            //var query = (from s in ctx.Posts
            //             select s).Sum(e=>e.Marks);

            //Console.WriteLine("Lowest Marks" + query);
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Name);
            //}
            Console.WriteLine("Student fetched");
            Console.ReadKey();
           
        }
    }
}
