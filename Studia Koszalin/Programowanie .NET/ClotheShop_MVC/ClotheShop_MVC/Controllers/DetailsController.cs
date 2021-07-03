using ClotheShop_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClotheShop_MVC.Controllers
{
    public class DetailsController : Controller
    {
        // GET: Details
        public ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Details(int? id)
        {
            
            return View(db.Clothes.Find(id));
        }
    }
}