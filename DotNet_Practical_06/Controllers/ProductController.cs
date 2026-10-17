
using System.Collections.Generic;
using System.Web.Mvc;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Category = "Electronics",
                    Price = 55000,
                    Image = "laptop.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "Smartphone",
                    Category = "Electronics",
                    Price = 25000,
                    Image = "smartphone.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "Headphones",
                    Category = "Accessories",
                    Price = 2000,
                    Image = "headphones.jpg"
                },
                new Product
                {
                    Id = 4,
                    Name = "Keyboard",
                    Category = "Accessories",
                    Price = 1500,
                    Image = "keyboard.jpg"
                }
            };

            return View(products);
        }
    }
}
