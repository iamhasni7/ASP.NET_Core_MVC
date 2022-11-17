using Microsoft.AspNetCore.Mvc;
using ASP.NET_Core_MVC.Models;
using ASP.NET_Core_MVC.Data;

namespace ASP.NET_Core_MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryDbContext _db;
        public CategoryController(CategoryDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> categories = _db.Categories;
            return View(categories);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            
            return View();
        }
    }
}
