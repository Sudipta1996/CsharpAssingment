using LibraryMangementUi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementUi.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(Login login)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Student student = new Student();
                    using (var httpClient = new HttpClient())
                    {
                        StringContent content = new StringContent(JsonConvert.SerializeObject(student), Encoding.UTF8, "application/json");

                        using (var response = await httpClient.PostAsync("http://localhost:1056/api/student/", content))
                        {
                            string apiResponse = await response.Content.ReadAsStringAsync();
                        }
                    }
                    if (student != null)
                    {
                        FormsAuthentication.SetAuthCookie(login.Email, false);
                        return RedirectToAction("Index", "User");
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "The Email or Password provided is incorrect";
                    }
                }
            }
            catch
            {

            }
            return View();

        }

        public ActionResult LogOff()
        {

            //Session.Remove("UserID");

            FormsAuthentication.SignOut();
            return RedirectToAction("Login");

        }
    }
}
