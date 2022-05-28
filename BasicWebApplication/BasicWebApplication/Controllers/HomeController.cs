using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;
using BasicWebApplication.Models;

namespace BasicWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["str1"] = "This is a string passed using ViewData";
            ViewData["num1"] = 100;

            ViewBag.str2 = "This is a string passed using ViewBag";
            ViewBag.num2 = 200;

            return View();
        }

        public ActionResult AddUser()
        {
            return View();
        }
        public ActionResult SaveUser(User u)
        {
            StreamWriter sw = new StreamWriter(Server.MapPath("~/App_Data/users.txt"),true);
            sw.WriteLine("User Details Added On" + DateTime.Now.ToString());
            sw.WriteLine("User Name" + u.UserName);
            sw.WriteLine("Password" + u.Password);
            sw.WriteLine("");
            sw.Close();
            return Content("User Details Have been Saved");
        }
        public ActionResult HtmlHelpers()
        {
            return View();
        }
    }
}