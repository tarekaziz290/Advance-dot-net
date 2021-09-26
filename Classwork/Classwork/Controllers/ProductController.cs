using Classwork.Models;
using Classwork.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Classwork.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            Database db = new Database();
            var products = db.Products.Get();
            return View(products);
        }
        [HttpGet]
        public ActionResult Create()
        {
           Product s = new Product();
            return View(s);
        }
        [HttpPost]
        public ActionResult Create(Product s)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Products.Create(s);
                return RedirectToAction("Index");
            }
            return View(s);
        }
        [HttpGet]
        public ActionResult Update(string name)
        {
            Database db = new Database();
            var s = db.Products.Get(name);
            return View(s);
        }
    }
}