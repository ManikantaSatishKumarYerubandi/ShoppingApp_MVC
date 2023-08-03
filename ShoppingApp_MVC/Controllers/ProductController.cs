using Microsoft.AspNetCore.Mvc;
using ShoppingApp_MVC.Models;

namespace ShoppingApp_MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DisplayProducts()
        {
            ProductDetails pobj=new ProductDetails();
            return View(pobj.GetProductAll());
        }
    }
}
