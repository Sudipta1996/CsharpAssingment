using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pharmacyManagementWebApiservice.Dto;
using pharmacyManagementWebApiservice.Helper;
using pharmacyManagementWebApiservice.Models;
using pharmacyManagementWebApiservice.Repository;
using System;

namespace pharmacyManagementWebApiservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly JwtService _jwtService;

        public AuthController(IUserRepository repository, JwtService jwtService)//inject jwt service and Iuserrepository//
        {
            _userRepository = repository;
            _jwtService = jwtService;
        }
        
        [HttpPost("Register")]
        public IActionResult Register(RegisterDto dto)
        {
            var user = new UserDetail
            {
                UserName = dto.UserName,
                Email = dto.Email,
                Contact = dto.Contact,
                UserAddress = dto.UserAddress,
                UserPassword = BCrypt.Net.BCrypt.HashPassword(dto.UserPassword)//password encryption tool bcrypt//
            };

            var newUser = _userRepository.Create(user);
            return Created("Sucess", newUser);
        }
        [HttpPost("Login")]
        public IActionResult Login(LoginDto dto)
        {
            var user = _userRepository.GetByEmail(dto.Email);
            if (user == null)
                return BadRequest(new { message = "Invalid Credentials" });
            if (!BCrypt.Net.BCrypt.Verify(dto.UserPassword, user.UserPassword))
            {
                return BadRequest(new { message = "Invalid Credentials" });
            }
            var jwtstring = _jwtService.Generate(user.UserId);//encode jwt//
            //frontend have get it this cookies and send it  not doing any modification//
            Response.Cookies.Append("jwt", jwtstring, new CookieOptions
            {
                HttpOnly = true,
            });
            //if login is correct then message sucess//
            return Ok(new
            {                
                message = "sucess"
            });
        }
        #region user
        [HttpGet("User")]
        public IActionResult User()
        {
            try
            {
                var jwt = Request.Cookies["jwt"];//got jwt//
                var token = _jwtService.Verify(jwt);//verify//
                int userId = int.Parse(token.Issuer);//issuer is string so we have to parse it//
                var user = _userRepository.GetById(userId);//find userId who is login//
                return Ok(user);//status code sucess//
            }
            catch (Exception ex)
            {
                return Unauthorized();
            }

        }
        #endregion user
        [HttpGet("UserAll")]
        public IActionResult UserAll()
        {
            var user = _userRepository.GetAll();
            return new OkObjectResult(user);
        }
        [HttpPost("logout")]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("jwt");//remove the cookies//
            return Ok(new
            {
                message = "sucess"
            });
        }
    }
}
