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
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }
    }
    public ActionResult Addtocart(int id)
    {
        var search = db.Carts.Find(id);
        if (search == null)
        {
            Cart cart = new Cart();
            cart.product_id = id;
            cart.added_at = DateTime.Now;
            db.Carts.Add(cart);
            db.SaveChanges();
        }


        return RedirectToAction("Index");
    }
}