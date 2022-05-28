using LibraryManagementServices.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryManagementServices.Controllers
{

    [Route("api/[controller]")]
    [ApiController]


    public class LibraryController : ControllerBase
    {
        private readonly LibraryDbContext context;

        public LibraryController(LibraryDbContext db)
        {
            context = db;
        }
        [HttpGet]
        public async Task<ActionResult>Get()
        {
            return Ok(await context.Librarys.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult> AddBook(Library library)
        {
            context.Librarys.Add(library);  
            await context.SaveChangesAsync();
            return Ok(await context.Librarys.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
           var libr = await context.Librarys.FindAsync(id);
            if(libr == null)
            {
                return BadRequest("Books Not Found");
            }
            return Ok(libr);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Library request)
        {
            var dbLibr = await context.Librarys.FindAsync(request.BookId);
            if (dbLibr == null)
            {
                return BadRequest("Books Not Found");
            }
            dbLibr.BookId = request.BookId;
            dbLibr.BookName = request.BookName;
            dbLibr.AuthorName = request.AuthorName;
            
            dbLibr.ISBN = request.ISBN;
            await context.SaveChangesAsync();
            return Ok(await context.Librarys.ToListAsync());
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var dbLibr = await context.Librarys.FindAsync(id);
            if (dbLibr == null)
            {
                return BadRequest("Books Not Found");
            }
            context.Librarys.Remove(dbLibr);
            await context.SaveChangesAsync();
            return Ok(await context.Librarys.ToListAsync());
        }
    }
}

