using Food_ordering_system_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Food_ordering_system_PROJECT.Controllers
{
    public class HomeController : Controller
    {
        private StoreEntities db = new StoreEntities();
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Product =db.Products.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Index(String searchCategory)
        {

            if (String.IsNullOrEmpty(searchCategory))
            {
                ViewBag.Product = db.Products.ToList();
            }
            else
            {

                var product = db.Products.Where(p => p.Category.name.Contains(searchCategory)).ToList();
                
                if (product.Count == 0 || product.Count.Equals(null))
                {
                    ViewBag.message = "No Result";
                }

                ViewBag.Product = product;

            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}