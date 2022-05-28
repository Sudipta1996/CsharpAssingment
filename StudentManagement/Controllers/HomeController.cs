using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        TeacherEntities1 context = new TeacherEntities1();
        public ActionResult Index()
        {
            return View(context.teachers);
        }
        public ActionResult CreateTeacher(teacher t)
        {
            if (ModelState.IsValid)
            {
                context.teachers.Add(t);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create");

        }
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(int? tid)
        {
            var account_to_edit = (from a in context.teachers
                                   where a.id == tid
                                   select a).SingleOrDefault();
            return View(account_to_edit);
        }
        public ActionResult EditAccount(teacher t)
        {
            context.Entry<teacher>(t).State = (EntityState)EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("Index");
        }




    }
}