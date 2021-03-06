using ClotheShop_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClotheShop_MVC.Controllers
{
    public class WomanController : Controller
    {
        // GET: Woman
        public ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Tshirt()
        {
            return View(db.Clothes.Where(x => x.TypeID == 1 && x.Sex == "K").ToList());
        }
        public ActionResult Underwear()
        {
            return View(db.Clothes.Where(x => x.TypeID == 2 && x.Sex == "K").ToList());
        }
        public ActionResult Shirt()
        {
            return View(db.Clothes.Where(x => x.TypeID == 3 && x.Sex == "K").ToList());
        }
        public ActionResult Jacket()
        {
            return View(db.Clothes.Where(x => x.TypeID == 4 && x.Sex == "K").ToList());
        }
        public ActionResult Shoes()
        {
            return View(db.Clothes.Where(x => x.TypeID == 5 && x.Sex == "K").ToList());
        }
    }
}