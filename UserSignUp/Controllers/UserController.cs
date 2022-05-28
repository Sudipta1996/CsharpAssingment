using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using UserSignUp.DAL;
using UserSignUp.Model;

namespace UserSignUp.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserDal _userDal;
        public UserController(IUserDal userDal)
        {
            _userDal = userDal; 
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUp request)
        {
            SignUpResponse response = new SignUpResponse();
            try
            {

            }catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return Ok(request);
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(SignIn request)
        {
            SignInResponse response = new SignInResponse();
            try
            {

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return Ok(request);
        }
    }
}
