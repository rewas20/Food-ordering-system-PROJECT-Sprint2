using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Food_ordering_system_PROJECT.Models;

namespace Food_ordering_system_PROJECT.Controllers
{
    public class DetailsController : Controller
    {
        private StoreEntities db = new StoreEntities();
        // GET: Details
        public ActionResult Details(int id)
        {
            var product = db.Products.Find(id);
            if (product != null)
            {
                ViewBag.Product = product;
                return View();
            }
            else
            {
                return HttpNotFound();
            }
        }
    }
}
