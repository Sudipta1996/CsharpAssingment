using System.ComponentModel.DataAnnotations;

namespace UserSignUp.Model
{
    public class SignIn
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }


    }
    public class SignInResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
