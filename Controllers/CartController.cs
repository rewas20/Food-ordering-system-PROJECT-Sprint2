using Food_ordering_system_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace Food_ordering_system_PROJECT.Controllers
{
    public class CartController : Controller
    {
        private StoreEntities db = new StoreEntities();
        // GET: Cart
        public ActionResult Index()
        {
            return RedirectToAction("Index","Home");
        }
        public ActionResult Addtocart(int id)
        {
            var search = db.Carts.SingleOrDefault(c => c.product_id == id);
            if (search == null)
            {
                
                Cart cart = new Cart();
                cart.product_id = id;
                cart.added_at = DateTime.Now;
                db.Carts.Add(cart);
                db.SaveChanges();
            }
            else
            {
                search.countProduct++;
                db.Entry(search).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }


            return RedirectToAction("Index");
        }
        public ActionResult DeleteProduct(int? id)
        {
            var product = db.Carts.SingleOrDefault(c => c.product_id == id); ;

            if (product == null || id == null)
            {
                return RedirectToAction("Index", "Cart");
            }

            db.Carts.Remove(product);
            db.SaveChanges();

            return RedirectToAction("DeleteProduct");
        }
    }
   

}