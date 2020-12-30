using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenStore.Model;
using Microsoft.EntityFrameworkCore;

namespace OpenStore.Controllers
{
    public class HomeController : Controller
    {
        ProductContext db;
        public HomeController(ProductContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }

        public IActionResult Authorization()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult Сabinet()
        {
            return View(db.Products.ToList());
        }


        [HttpGet]
        public IActionResult ViewProduct(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.ProductId = id;
            return View(db.Products.ToList());
        }


        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.ProductId = id;           
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return "Спасибо, " + order.User + ", за покупку!";
        }

     
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Product product = await db.Products.FirstOrDefaultAsync(p => p.Id == id);
                if (product != null)
                {
                    foreach(var item in db.Products)
                    {
                        if(id==item.Id)
                        {
                            ViewBag.ProductId = id;
                            ViewBag.ProductName =item.Name;
                            ViewBag.ProductImageSrc = item.ImageSrc;
                            ViewBag.ProductPrice = item.Price;
                            ViewBag.ProductQuantity = item.Quantity;
                            ViewBag.ProductShortDescribe = item.ShortDescribe;
                            ViewBag.ProductDescribe = item.Describe;
                            ViewBag.ProductBrand = item.Brand;
                            ViewBag.ProductCharacteristics = item.Characteristics;

                        }
                    }
             
                    return View(product);
                }
                
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Product product)
        {
            db.Products.Update(product);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }



    }
}
