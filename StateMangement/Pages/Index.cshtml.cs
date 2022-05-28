using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StateMangement.Pages
{
    public class IndexModel : PageModel
    {
        private readonly string SESS_KEY;

        // holds user-id after reading 
        // a session variable 
        public String UserName { get; set; }

        // when the index page is requested 
        public void OnGet()
        {

            // will be null if no session variable 
            UserName = HttpContext.Session.GetString(SESS_KEY);

        }

        // when the link to login is clicked 
        // click event handlers are prefixed 
        // OnGet or OnPost depending on the 
        // type of request they handle 
        public IActionResult OnGetDoLogin()
        {

            // let us say some dummy login process 
            // takes place and gives us the user 
            // name as XYZ 

            // save in a session 
            HttpContext.Session.SetString();

            return RedirectToPage();

        }

        // when the link to log off is clicked 
        public IActionResult OnGetLogOff()
        {

            // remove session key 
            HttpContext.Session.Remove(SESS_KEY);

            return RedirectToPage();
        }
    }
}