using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using UserMAnagementApi.data;
using UserMAnagementApi.Dto;
using UserMAnagementApi.Helper;
using UserMAnagementApi.Model;

namespace UserMAnagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly JwtService _jwtService;

        public AuthController(IUserRepository repository,JwtService jwtService)
        {
            _userRepository = repository;
            _jwtService = jwtService;
        }
        [HttpPost("Register")]
        public IActionResult Register(RegisterDto dto)
        {
            var user = new User
            {
                Name = dto.Name,
                Email = dto.Email,
                Contact = dto.Contact,
                Address = dto.Address,
                Password =BCrypt.Net.BCrypt.HashPassword(dto.Password)
            };
            
            var  newUser = _userRepository.Create(user);
            return Created("Sucess",newUser);
        }
        [HttpPost("Login")]
        public IActionResult Login(LoginDto dto)
        {
            var user = _userRepository.GetByEmail(dto.Email);
            if (user == null)
            return BadRequest(new { message = "Invalid Credentials" });
            if(!BCrypt.Net.BCrypt.Verify(dto.Password,user.Password))
            {
                return BadRequest(new { message = "Invalid Credentials" });
            }
            var jwtstring = _jwtService.Generate(user.Id);
            Response.Cookies.Append("jwt", jwtstring, new CookieOptions
            {
                HttpOnly = true,
            });
            return Ok(new
            {
                message = "sucess"
            
            });
        }
        [HttpGet("User")]
        public IActionResult User()
        {
            try
            {
                var jwt = Request.Cookies["jwt"];
                var token = _jwtService.Verify(jwt);
                int userId = int.Parse(token.Issuer);
                var user = _userRepository.GetById(userId);
                return Ok(user);
            } catch (Exception ex)
            {
                return Unauthorized();
            }
   
        }
        [HttpGet("UserAll")]
        public IActionResult UserAll()
        {
            var user = _userRepository.GetAll();
            return new OkObjectResult(user);
        }
        [HttpPost("logout")]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("jwt");
            return Ok( new
            {
                message = "sucess"
            });
        }

    }
}
