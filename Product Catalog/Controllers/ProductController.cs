using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Product_Catalog.Models;

namespace Product_Catalog.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        // Product List View
        public ActionResult Index()
        {

            var products = GetProducts(); return View(products);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var product = GetProducts().FirstOrDefault(p => p.ProductId == id); if (product == null)
                return HttpNotFound(); return View(product);

        }

        private List<Product> GetProducts()
        {
            return new List<Product>
{
new Product
{
ProductId = 1, ProductName = "Laptop", Description = "dell laptop", Price = 55000,
Category = "Electronics"
},
new Product
{
ProductId = 2, ProductName = "Mobile", Description = "Vivo", Price = 30000,
Category = "Electronics"
},
new Product
{
ProductId = 3, ProductName = "Watch", Description = "casio", Price = 45400,
Category = "Accessories"
}
};
        }
    }
}
