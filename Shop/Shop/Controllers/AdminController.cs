using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    public class AdminController : Controller
    {
        private readonly ShopContext _context;

        public AdminController(ShopContext shopContext)
        {
            _context = shopContext;
        }


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            await _context.Products.AddAsync(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
