using LibraryMangementUi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementUi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public async Task<IActionResult> Index()
        {
            List<Library> libraryList = new List<Library>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:1056/api/Library"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    libraryList = JsonConvert.DeserializeObject<List<Library>>(apiResponse);
                }
            }
            return View(libraryList);
        }
        public ViewResult GetBook()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GetBook(int BookId)
        {
            Library library = new Library();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:1056/api/Library/" + BookId))
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        library = JsonConvert.DeserializeObject<Library>(apiResponse);
                    }
                    else
                        ViewBag.StatusCode = response.StatusCode;
                }
            }
            return View(library);
        }
        public ViewResult AddBook()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBook(Library library)
        {
            Library lbBook = new Library();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(library), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("http://localhost:1056/api/Library/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return View(lbBook);
        }
        //[HttpPut]
        //public Library Put([FromBody] Library res)
        //{
        //    return Library.Update(res);
        //}
         
        public async Task<IActionResult> UpdateBook(int id)
        {
            Library library = new Library();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:1056/api/Library/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    library = JsonConvert.DeserializeObject<Library>(apiResponse);
                }

            }
            return View(library);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBook(Library library)
        {
            Library library1 = new Library();
            using (var httpClient = new HttpClient())
            {
                var content = new MultipartFormDataContent();
                content.Add(new StringContent(library.BookId.ToString()), "BookId");
                content.Add(new StringContent(library.BookName), "BookName");
                content.Add(new StringContent(library.AuthorName), "AuthorName");
                content.Add(new StringContent(library.ISBN.ToString()), "ISBN");
                StringContent Content = new StringContent(JsonConvert.SerializeObject(library), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("http://localhost:1056/api/Library/id", Content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    library1 = JsonConvert.DeserializeObject<Library>(apiResponse);
                }
            }
            return RedirectToAction("Index");
        }

       [HttpPost]
        public async Task<IActionResult> DeleteBook(int Id)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("http://localhost:1056/api/Library/" + Id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
