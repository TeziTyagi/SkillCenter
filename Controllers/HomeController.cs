using Microsoft.AspNetCore.Mvc;
using SkillCenter.DatabaseContext;
using SkillCenter.Models;
using System.Diagnostics;

namespace SkillCenter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProductDbContext _context;
        public HomeController(ILogger<HomeController> logger, ProductDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public ActionResult Product()
        {
            // Fetch products from the ProductDbContext
            var products = _context.Products.ToList();

            return View(products); // Pass the list of products to the view
        }

        //        public ActionResult Product()
        //        {
        //            var products = new List<MyModel>
        //{
        //    new MyModel { Id = 123, Description = "new description", Name = "name", Author = "Author" },
        //    new MyModel { Id = 1234, Description = "2.new description", Name = "3.name", Author = "4.Author" },
        //    new MyModel { Id = 1234, Description = "2.new description", Name = "3.name", Author = "4.Author" }
        //};

        //return View(products); // Return the collection of products
        //  }


        // return View(); }
        public IActionResult Index()
        {
            return View();
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
