using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var productList = new List<Product>{
                            new Product() { ProductId = 1, ProductName = "Hansel & Gratel", ProductPrice = 180.0f } ,
                            new Product() { ProductId = 2, ProductName = "Marvel Comics 2018 Edition",  ProductPrice = 210.0f } ,
                            new Product() { ProductId = 3, ProductName = "Mission Impossible 3",  ProductPrice = 250.0f } ,
                            new Product() { ProductId = 4, ProductName = "Street Fighter 3" , ProductPrice = 20.0f } ,
                            new Product() { ProductId = 5, ProductName = "Xbox 360 Cheatsheet" , ProductPrice = 310.0f } ,
                            new Product() { ProductId = 6, ProductName = "Harry Potter and the Six Elves" , ProductPrice = 170.0f } ,
                            new Product() { ProductId = 7, ProductName = "Bob, The Builder" , ProductPrice = 190.0f }
                        };
            return View(productList);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "ProductId, ProductName")] Product product)
        {
            var name = product.ProductName;


            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            var query = Request.QueryString["search"];
            ViewBag.query = query;
            return View();
        }
    }
}