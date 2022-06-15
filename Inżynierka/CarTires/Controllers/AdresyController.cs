using CarTiresService.Models;
using CarTiresService.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace CarTiresService.Controllers
{
    public class AdresyController : Controller
    {
        private CarTiresServiceEntities db = new CarTiresServiceEntities();

        public ActionResult Index()
        {
            return View(db.Adresy.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adresy adresy = db.Adresy.Find(id);
            if (adresy == null)
            {
                return HttpNotFound();
            }
            return View(adresy);
        }
        public ActionResult CreateSimple(int klientId)
        {
            ViewBag.KlientId=klientId;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSimple([Bind(Include = "AdresId,Miasto,Ulica,NumerDomu,NumerMieszkania,KodPocztowy")] Adresy adresy, int klientId)
        {
            if (ModelState.IsValid)
            {
                db.Adresy.Add(adresy);
                Klienci klienci = db.Klienci.Where(w => w.KlientId == klientId).FirstOrDefault();
                klienci.AdresId=adresy.AdresId;
                db.SaveChanges();
                return RedirectToAction("Index", "Klienci");
            }

            return View(adresy);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AdresId,Miasto,Ulica,NumerDomu,NumerMieszkania,KodPocztowy")] Adresy adresy)
        {
            if (ModelState.IsValid)
            {
                db.Adresy.Add(adresy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adresy);
        }

        public ActionResult AddAdres(int raportId, int klientId, int rezerwacjaId)
        {
            ViewBag.RaportId=raportId;
            ViewBag.KlientId=klientId;
            ViewBag.RezerwacjaId=rezerwacjaId;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddAdres([Bind(Include = "AdresId,Miasto,Ulica,NumerDomu,NumerMieszkania,KodPocztowy")] Adresy adresy, int raportId, int klientId, int rezerwacjaId)
        {
            if (ModelState.IsValid)
            {
                db.Adresy.Add(adresy);
                Klienci klient = db.Klienci.Find(klientId);
                klient.AdresId=adresy.AdresId;
                db.SaveChanges();
                return RedirectToAction("CreateRaportDetail", "Raport", new { raportId = raportId, rezerwacjaId = rezerwacjaId });
            }

            return View(adresy);
        }
        public ActionResult EditSimple(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adresy adresy = db.Adresy.Find(id);
            var klientId = db.Klienci.Where(w => w.AdresId==id).Select(s => s.KlientId).FirstOrDefault();
            if (adresy == null)
            {
                return HttpNotFound();
            }
            ViewBag.KlientId=klientId;
            return View(adresy);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditSimple([Bind(Include = "AdresId,Miasto,Ulica,NumerDomu,NumerMieszkania,KodPocztowy")] Adresy adresy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adresy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Klienci");
            }
            return View(adresy);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adresy adresy = db.Adresy.Find(id);
            if (adresy == null)
            {
                return HttpNotFound();
            }
            return View(adresy);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AdresId,Miasto,Ulica,NumerDomu,NumerMieszkania,KodPocztowy")] Adresy adresy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adresy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adresy);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adresy adresy = db.Adresy.Find(id);
            if (adresy == null)
            {
                return HttpNotFound();
            }
            return View(adresy);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Adresy adresy = db.Adresy.Find(id);
            db.Adresy.Remove(adresy);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
