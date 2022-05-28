using Microsoft.AspNetCore.Identity;

namespace UserAuthenticationServices.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
