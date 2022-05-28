using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstCoreWebApp.Pages
{
    public class ContactModel : PageModel
    {
        public bool hasData=false;
        public string name = "";
        public string email = "";
        public string message = "";
        public void OnGet()
        {
        }
        public void OnPost()
        {
            hasData = true;
            name = Request.Form["name"];
            email = Request.Form["email"];
            message = Request.Form["message"];
        }
    }
}
