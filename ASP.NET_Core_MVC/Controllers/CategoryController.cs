using Microsoft.AspNetCore.Mvc;
using ASP.NET_Core_MVC.Models;
using ASP.NET_Core_MVC.Data;
using System.Reflection.Metadata.Ecma335;

namespace ASP.NET_Core_MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryDbContext _db;
        public CategoryController(CategoryDbContext db)
        {
            _db = db;
        }

        //GET method to fetch all entries from db.
        public IActionResult Index()
        {
            IEnumerable<Category> categories = _db.Categories;
            return View(categories);
        }

        public IActionResult Create()
        {            
            return View();
        }

        //POST method to add new entry in db.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }            
            return View(obj);
        }

        public IActionResult Update(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.Categories.Find(id);
            if(categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        //POST method to add new entry in db.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
