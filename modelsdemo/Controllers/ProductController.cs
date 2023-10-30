using Microsoft.AspNetCore.Mvc;
using modelsdemo.Models;
namespace modelsdemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            List<Product> Products = new List<Product>()
            {
                new Product{Id=1,Name="mobile",Price=7788},
                new Product{Id=2,Name="lap",Price=7678},
                new Product{Id=3,Name="laptop",Price=9888},
                new Product{Id=4,Name="tap",Price=9888},
            };
            ViewBag.List = Products;
            return View();
        }
    }
}
