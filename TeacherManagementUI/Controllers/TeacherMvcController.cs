using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TeacherManagementUI.Models;
using TeacherManagementUI.Repository;

namespace TeacherManagementUI.Controllers
{
    public class TeacherMvcController : Controller
    {
        // GET: TeacherMvc
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public async Task<ActionResult> Index()
        {
            List<TeacherViewModel> teacher = new List<TeacherViewModel>();
            var service = new ServiceRepository();
            {
                using (var response = service.GetResponse("teachers"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    teacher = JsonConvert.DeserializeObject
                    <List<TeacherViewModel>>(apiResponse);
                }
            }
            return View(teacher);
        }
        public ViewResult Create()
        {
            return View();
        }
        //post teacher/create//
        public async Task<ActionResult> Create(TeacherViewModel teacher)
        {
            if(ModelState.IsValid)
            {
                TeacherViewModel newteacher = new TeacherViewModel();
                var service = new ServiceRepository();
                {
                    using(var response = service.PostResponse("teachers",teacher))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        newteacher = JsonConvert.DeserializeObject<TeacherViewModel>(apiResponse);
                    }
                }
               return RedirectToAction("Index");
            }
            return View(teacher);
        }
    }
}