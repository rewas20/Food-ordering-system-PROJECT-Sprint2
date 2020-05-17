using Food_ordering_system_PROJECT .Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Food_ordering_system_PROJECT.Controllers
{
    public class ViewItemDetailsController : Controller
    {
        private StoreEntities db = new StoreEntities();
        public ActionResult ViewItemDetails(int id)
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



