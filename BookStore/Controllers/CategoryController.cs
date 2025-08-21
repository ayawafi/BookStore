using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View(FakeData.Categories);
        }

        public IActionResult Details(int id)
        {
            var category = FakeData.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null) return NotFound();
            return View(category);
        }
}
}    
