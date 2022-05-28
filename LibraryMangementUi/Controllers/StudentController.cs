using LibraryMangementUi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementUi.Controllers
{
    public class StudentController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Student> studentList = new List<Student>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:1056/api/student"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    studentList = JsonConvert.DeserializeObject<List<Student>>(apiResponse);
                }
            }
            return View(studentList);
        }
        public ViewResult GetBook()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GetStudent(int StudentId)
        {
            Student student = new Student();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:1056/api/student/" + StudentId))
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        student = JsonConvert.DeserializeObject<Student>(apiResponse);
                    }
                    else
                        ViewBag.StatusCode = response.StatusCode;
                }
            }
            return View(student);
        }
        public ViewResult AddStudent()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddStudent(Student student)
        {
            Student lbStudent = new Student();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(student), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("http://localhost:1056/api/student/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return View(lbStudent);
        }
        //[HttpPut]
        //public Library Put([FromBody] Library res)
        //{
        //    return Library.Update(res);
        //}

        public async Task<IActionResult> UpdateStudent(int id)
        {
            Student student = new Student();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:1056/api/student" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    student = JsonConvert.DeserializeObject<Student>(apiResponse);
                }

            }
            return View(student);
        }
        //[HttpPost]
        //public async Task<IActionResult> UpdateBook(Library library)
        //{
        //    Library library1 = new Library();
        //    using (var httpClient = new HttpClient())
        //    {
        //        var content = new MultipartFormDataContent();
        //        content.Add(new StringContent(library.BookId.ToString()), "BookId");
        //        content.Add(new StringContent(library.BookName), "BookName");
        //        content.Add(new StringContent(library.AuthorName), "AuthorName");
        //        content.Add(new StringContent(library.ISBN.ToString()), "ISBN");
        //        StringContent Content = new StringContent(JsonConvert.SerializeObject(library), Encoding.UTF8, "application/json");
        //        using (var response = await httpClient.PutAsync("http://localhost:1056/api/Library/id", Content))
        //        {
        //            string apiResponse = await response.Content.ReadAsStringAsync();
        //            library1 = JsonConvert.DeserializeObject<Library>(apiResponse);
        //        }
        //    }
        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public async Task<IActionResult> DeleteStudent(int Id)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("http://localhost:1056/api/student/" + Id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("Index");
        }
    }
}
