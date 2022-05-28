using LibraryManagementServices.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LibraryManagementServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly LibraryDbContext context;
        public StudentController(LibraryDbContext db)
        {
            context = db;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await context.Students.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult> AddStudent(Student student)
        {
            context.Students.Add(student);
            await context.SaveChangesAsync();
            return Ok(await context.Students.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var stu = await context.Students.FindAsync(id);
            if (stu == null)
            {
                return BadRequest("Student Not Found");
            }
            return Ok(stu);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Student request)
        {
            var dbStu = await context.Students.FindAsync(request.Id);
            if (dbStu == null)
            {
                return BadRequest("Student Not Found");
            }
            dbStu.Id = request.Id;
            dbStu.Email = request.Email;
            dbStu.Password = request.Password;
            await context.SaveChangesAsync();
            return Ok(await context.Students.ToListAsync());
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var dbStu = await context.Students.FindAsync(id);
            if (dbStu == null)
            {
                return BadRequest("Student Not Found");
            }
            context.Students.Remove(dbStu);
            await context.SaveChangesAsync();
            return Ok(await context.Students.ToListAsync());
        }
    }
}


