using CarService.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarService.Controllers
{
    public class HomeController : Controller
    {
        public CarRepairServiceEntities db = new CarRepairServiceEntities();
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Dashboard()
        {
            dynamic dash = new ExpandoObject();
           
            var cars = GetCars();
            var address = GetAdress();
            var orders = GetOrders();
            var services = GetService();
            dash.Cars = cars;
            dash.Addresses = address;
            dash.Orders = orders;
            dash.Serviceses = services;

            return View(dash);
        }
        private List<Order> GetOrders()
        {
            List<Order> ordersDetail = new List<Order>();
            ordersDetail = db.Orders.ToList();
            return ordersDetail;
        }
        private List<Services> GetService()
        {
            List<Services> serviceDetail = new List<Services>();
            serviceDetail = db.Serviceses.ToList();
            return serviceDetail;
        }
        private List<Car> GetCars()
        {
            List<Car> carsDetail = new List<Car>();
            carsDetail = db.Cars.ToList();
            return carsDetail;
        }
        private List<Address> GetAdress()
        {
            List<Address> adressDetail = new List<Address>();
            adressDetail = db.Addresses.ToList();
            return adressDetail;
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}