using ClotheShop_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace ClotheShop_MVC.Controllers
{
    public class ShoppingCartsController : Controller
    {
        public ShoppingCarts cart;
        
        public ApplicationDbContext db = new ApplicationDbContext();
        // GET: ShoppingCart
        

        public ActionResult Show()
        {   
            return View(db.ShoppingCarts.Where(x=>User.Identity.Name==x.UserName).ToList());
        }

        public ActionResult Add(int id,int price,string name,string picture)
        {
            cart = new ShoppingCarts();
            
            cart.ProductID = id;
            cart.ClientID=picture;
            cart.DatePurchased = name;
            cart.Amount = price;
            cart.UserName =User.Identity.Name;;
            db.ShoppingCarts.Add(cart);
            db.SaveChanges();
           return RedirectToAction("Show","ShoppingCarts");
        }
        public ActionResult Delete(int id)
        {
           var toremove= db.ShoppingCarts.Find(id);
            db.ShoppingCarts.Remove(toremove);
            db.SaveChanges();
            return RedirectToAction("Show", "ShoppingCarts");
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}