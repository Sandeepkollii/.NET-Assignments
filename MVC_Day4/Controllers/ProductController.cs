using Microsoft.AspNetCore.Mvc;
using MVC_Day4.Models;

namespace MVC_Day4.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult PasswithBag()
        {
            var Product = new Product
            {

                PCode = 1001,
                Name = "Laptop",
                QtyInStock = 30,
                Details = "Intel i7 6th GEN",
                Price = 49000
            };
            ViewBag.Product = Product;
            return View();
        }
        public IActionResult PassMultiple()
        {
            var product1 = new List<Product>()
            {
                new Product() { PCode = 1002, Name = "Hard disk", QtyInStock = 20, Details = "10 TB SSD", Price = 21000 },
                new Product() { PCode = 1003, Name = "Mobile", QtyInStock = 40, Details = "Iphone 16 pro 128 GB", Price = 124000 },
                new Product() { PCode = 1004, Name = "CPU", QtyInStock = 10, Details = "Intel", Price = 9000 },
                new Product() { PCode = 1005, Name = "Desktop", QtyInStock = 30, Details = "Samsung", Price = 12000 },
                new Product() { PCode = 1006, Name = "Drive", QtyInStock = 50, Details = "SONY 64 GB", Price = 1000 }

            };
            ViewBag.product1 = product1;
            return View();
        }
        public IActionResult ObjectToView()
        {
            var product = new Product
            {
                PCode = 201,
                Name = "Headphones",
                QtyInStock = 30,
                Details = "Wireless Headphones",
                Price = 150.99m
            };
            return View(product);
        }
        static List<Product> product2=null;
        public ProductController()
        {
            if (product2 == null)
            {
                product2 = new List<Product>
            {
                new Product() { PCode = 2001, Name = "Laptop", QtyInStock = 15, Details = "Gaming Laptop", Price = 120099 },
                new Product() { PCode = 2002, Name = "Phone", QtyInStock = 25, Details = "Smartphone", Price = 69999 },
                new Product() { PCode = 2003, Name = "Tablet", QtyInStock = 10, Details = "Android Tablet", Price = 35000 },
                new Product() { PCode = 2004, Name = "Monitor", QtyInStock = 8, Details = "4K Monitor", Price = 4500 },
                new Product() { PCode = 2005, Name = "Keyboard", QtyInStock = 50, Details = "Mechanical Keyboard", Price = 1200 }
            };
            }
        }
        public IActionResult ListView()
        {
            return View(product2);
        }
        public IActionResult Index()
        {
            return View(product2.ToList());
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            
            var p = product2.Where(x => x.PCode == id).FirstOrDefault();
            if (p == null)
            {
                return NotFound("The Pcode is not found");
            }
            return View(p);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product newProduct)
        {
            product2.Add(newProduct);
            return RedirectToAction("Index");

        }
        public IActionResult Edit(int id)
        {
            var p = product2.Where(x => x.PCode == id).FirstOrDefault();
            return View(p);
        }
        [HttpPost]
        public IActionResult Edit(int PCode, Product obj)
        {
            foreach (Product p in product2)
            {
                if (p.PCode == PCode)
                {
                    p.QtyInStock = obj.QtyInStock;
                    p.Details = obj.Details;
                    p.Price = obj.Price;
                }
                break;
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var p = product2.Where(x => x.PCode == id).FirstOrDefault();
            return View(p);
        }
        [HttpPost]
        public IActionResult Delete(int PCode, Product obj)
        {
            foreach (Product p in product2)
            {
                if (p.PCode == PCode)
                {
                    product2.Remove(p);
                }
                break;
            }
            return RedirectToAction("Index");
        }
    }
}