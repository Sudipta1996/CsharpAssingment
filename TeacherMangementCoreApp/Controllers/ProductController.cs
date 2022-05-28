using Microsoft.AspNetCore.Mvc;
using TeacherMangementCoreApp.Data;
using TeacherMangementCoreApp.Models;

namespace TeacherMangementCoreApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductDbContext _db;

        public ProductController(ProductDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
           IEnumerable<Product> products = _db.Products;
            return View(products);
        }
        //public IActionResult Create()
        //{
            
        //    return View();
        //}
        public IActionResult Create(Product p)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Add(p);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(p);
        }
        //[ActionName("Edit")]
        //public IActionResult Edit(int? id)
        //{
        //    if(id == null || id == 0)
        //    {
        //        return NotFound();
        //    }
        //    var products = _db.Products.Find(id);
        //    return View(products);
        //}
        //[ActionName("Edit With Parameter")]
        //public IActionResult Edit(Product p)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _db.Products.Update(p);
        //        _db.SaveChanges();
        //        return RedirectToAction("Index");

        //    }
        //    return View(p);
        //}
        public IActionResult Delete(int id)
        {
            Product product = _db.Products.FirstOrDefault(s => s.ProductId == id);
            if (product != null)
            {
                _db.Remove(product);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
