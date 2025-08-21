using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View(FakeData.Authors);
        }

        public IActionResult Details(int id)
        {
            var author = FakeData.Authors.FirstOrDefault(a => a.Id == id);
            if (author == null) return NotFound();
            return View(author);
        }
    }
}

