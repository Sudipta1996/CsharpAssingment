using Microsoft.AspNetCore.Mvc;
using TeacherMangementCoreDBfirstApp.Models;
using TeacherMangementCoreDBfirstApp.Repository;

namespace TeacherMangementCoreDBfirstApp
{
    public class TeacherController : Controller
    {
        private ITeacherRepository _teacherRepository;

        public TeacherController()
        {
            _teacherRepository = new TeacherRepository(new TeacherContext());
        }
        public TeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public IActionResult Index()
        {
            var model = _teacherRepository.GetAll();
            return View(model);
        }
        public IActionResult AddTeacher()
        {
            return View();
        }
        public IActionResult AddTeacher(Teacher model)
        {
            if(ModelState.IsValid)
            {
                _teacherRepository.Insert(model);
                _teacherRepository.Save();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
