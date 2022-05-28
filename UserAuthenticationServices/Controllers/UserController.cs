using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using UserAuthenticationServices.Model;

namespace UserAuthenticationServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManger;
        private SignInManager<ApplicationUser> _signManager;

        public UserController(UserManager<ApplicationUser> usermanger, SignInManager<ApplicationUser>signinManger)
        {
            _userManger = usermanger;
            _signManager = signinManger;
        }
        [HttpPost]
        [Route("Register")]
        //POST : api/usercontroller/Register
        public async Task<Object> PostApplicationUser(ApplicationUser model)
        {
            var applicationUser = new ApplicationUser() 
            {         
                UserName = model.UserName,
                Email = model.Email,
                    FullName = model.FullName,
             };
            try
            {
                var result = await _userManger.CreateAsync(applicationUser, model.PasswordHash);
                return Ok(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
