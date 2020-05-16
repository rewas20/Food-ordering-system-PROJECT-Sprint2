using Food_ordering_system_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Food_ordering_system_PROJECT.Controllers
{
    public class CategorysController : Controller
    {
        private StoreEntities db = new StoreEntities();



        // GET: Categories
        public ActionResult List()
        {
            return View(db.Categories.ToList());
        }
    }
}