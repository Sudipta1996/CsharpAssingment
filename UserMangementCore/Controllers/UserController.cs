using Microsoft.AspNetCore.Mvc;
using UserMangementCore.Data;
using UserMangementCore.Models;

namespace UserMangementCore.Controllers
{
    public class UserController : Controller
    {
        private readonly UserDbContext userDbcontext;

        public UserController(UserDbContext db)
        {
            userDbcontext = db;
        }
        public IActionResult Index()
        {
            IEnumerable<User> user = userDbcontext.user;
            return View(user);
        }
    }
}
