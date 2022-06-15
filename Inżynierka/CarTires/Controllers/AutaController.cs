using CarTiresService.Models;
using CarTiresService.Models;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace CarTiresService.Controllers
{
    public class AutaController : Controller
    {
        private CarTiresServiceEntities db = new CarTiresServiceEntities();

        public ActionResult Index()
        {
            var auta = db.Auta.Include(a => a.Klienci);
            return View(auta.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Auta auta = db.Auta.Find(id);
            if (auta == null)
            {
                return HttpNotFound();
            }
            return View(auta);
        }

        public ActionResult Create()
        {
            ViewBag.KlientId = new SelectList(db.Klienci.Select(s => new { KlientId = s.KlientId, DaneKlienta = s.Imie + " " + s.Nazwisko }), "KlientId", "DaneKlienta");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AutoId,NazwaAuta,ModelAuta,NumerRejestracyjny,VIN,TypAuta,KlientId")] Auta auta)
        {
            if (ModelState.IsValid)
            {
                db.Auta.Add(auta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(auta);
        }

        public ActionResult CreateSimple(int id, int rezerwacjaId)
        {
            ViewBag.RezerwacjaId = rezerwacjaId;
            ViewBag.KlientId = id;
            ViewBag.Klient = db.Klienci.Where(w => w.KlientId == id).Select(s => s.Imie + " " + s.Nazwisko + " " + s.NumerTelefonu).FirstOrDefault();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSimple([Bind(Include = "AutoId,NazwaAuta,ModelAuta,NumerRejestracyjny,VIN,TypAuta,KlientId")] Auta auta, int id, int rezerwacjaId)
        {
            if (ModelState.IsValid)
            {
                auta.KlientId = id;
                db.Auta.Add(auta);
                RezerwacjaAuto rezerwacjaAuto = new RezerwacjaAuto { AutoId=auta.AutoId, RezerwacjeId=rezerwacjaId };
                db.RezerwacjaAuto.Add(rezerwacjaAuto);
                db.SaveChanges();
                return RedirectToAction("Create", "RezerwacjaUsluga", new { rezerwacjaId = rezerwacjaId, autoId = auta.AutoId });
            }
            return View(auta);
        }

        public ActionResult CreateSimpleEdit(int id, int rezerwacjaId, int stareKlientId, int stareAutoId)
        {
            ViewBag.RezerwacjaId = rezerwacjaId;
            ViewBag.Id = id;
            ViewBag.Klient = db.Klienci.Where(w => w.KlientId == id).Select(s => s.Imie + " " + s.Nazwisko + " " + s.NumerTelefonu).FirstOrDefault();
            ViewBag.StareKlientId=stareKlientId;
            ViewBag.StareAutoId=stareAutoId;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSimpleEdit([Bind(Include = "AutoId,NazwaAuta,ModelAuta,NumerRejestracyjny,VIN,TypAuta,KlientId")] Auta auta, int id, int rezerwacjaId, int stareKlientId, int stareAutoId)
        {
            auta.KlientId = id;
            if (ModelState.IsValid)
            {
                db.Auta.Add(auta);
                db.SaveChanges();
                RezerwacjaAuto rezerwacjaAuto = db.RezerwacjaAuto.Where(w => w.RezerwacjeId==rezerwacjaId).FirstOrDefault();
                rezerwacjaAuto.AutoId=auta.AutoId;
                db.SaveChanges();
                return RedirectToAction("Edit", "RezerwacjaUsluga", new { id = rezerwacjaId, stareKlientId = stareKlientId, stareAutoId = stareAutoId });
            }
            return View(auta);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Auta auta = db.Auta.Find(id);
            if (auta == null)
            {
                return HttpNotFound();
            }
            ViewBag.KlientId = new SelectList(db.Klienci.Select(s => new { KlientId = s.KlientId, DaneKlienta = s.Imie + " " + s.Nazwisko }), "KlientId", "DaneKlienta", auta.KlientId);
            return View(auta);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AutoId,NazwaAuta,ModelAuta,NumerRejestracyjny,VIN,TypAuta,KlientId")] Auta auta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(auta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(auta);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Auta auta = db.Auta.Find(id);
            if (auta == null)
            {
                return HttpNotFound();
            }
            return View(auta);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Auta auta = db.Auta.Find(id);
            db.Auta.Remove(auta);
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
