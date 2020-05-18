using Food_ordering_system_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
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
        // GET: Update
        public ActionResult Update(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST:Updates
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update([Bind(Include = "id,name,number_of_product")] Category category)
        {
            if (ModelState.IsValid)
            {
                db.Entry(category).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("List");
            }
            return View(category);
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,number_of_products")] Category category)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return RedirectToAction("List");
            }

            return View(category);
        }

    }
}