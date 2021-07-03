using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClotheShop_MVC.Models;
using Microsoft.Ajax.Utilities;

namespace ClotheShop_MVC.Controllers
{
    public class ProductTypesController : Controller
    {
        // GET: ProductTypes

        public ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult WomanClothes()
        {
            return View(db.ProductTypes.ToList());
        }
        public ActionResult ManClothes()
        {
            return View(db.ProductTypes.ToList());
        }
        public ActionResult KidsClothes()
        {
            return View(db.ProductTypes.ToList());
        }
    }
}