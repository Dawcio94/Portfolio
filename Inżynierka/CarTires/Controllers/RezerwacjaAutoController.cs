using CarTiresService.Models;
using CarTiresService.Models;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace CarTiresService.Controllers
{
    public class RezerwacjaAutoController : Controller
    {
        private CarTiresServiceEntities db = new CarTiresServiceEntities();

        public ActionResult Index()
        {
            var rezerwacjaAuto = db.RezerwacjaAuto.Include(r => r.Auta).Include(r => r.Rezerwacje);
            return View(rezerwacjaAuto.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RezerwacjaAuto rezerwacjaAuto = db.RezerwacjaAuto.Find(id);
            if (rezerwacjaAuto == null)
            {
                return HttpNotFound();
            }
            return View(rezerwacjaAuto);
        }

        public ActionResult Create(int rezerwacjaId, int klientId)
        {
            var daneKlienta = db.Klienci.Where(w => w.KlientId == klientId).Select(s => s.Imie + " " + s.Nazwisko + " " + s.NumerTelefonu).FirstOrDefault();
            ViewBag.AutoId = new SelectList(db.Auta.Where(w => w.KlientId == klientId).Select(s => new { AutoId = s.AutoId, DaneAuta = s.NazwaAuta + " " + s.ModelAuta + " " + s.NumerRejestracyjny }), "AutoId", "DaneAuta");
            ViewBag.RezerwacjeId = rezerwacjaId.ToString() + "\nKlient:\n" + daneKlienta;
            ViewBag.ToDelete = rezerwacjaId;
            ViewBag.KlientId = klientId;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RezerwacjaAutoId,RezerwacjeId,AutoId")] RezerwacjaAuto rezerwacjaAuto, int rezerwacjaId, int autoId)
        {
            if (ModelState.IsValid)
            {
                rezerwacjaAuto.RezerwacjeId = rezerwacjaId;
                db.RezerwacjaAuto.Add(rezerwacjaAuto);
                db.SaveChanges();
                return RedirectToAction("Create", "RezerwacjaUsluga", new { rezerwacjaId = rezerwacjaId, autoId = autoId });
            }

            return View(rezerwacjaAuto);
        }

        public ActionResult Edit(int? id, int stareKlientId)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RezerwacjaAuto rezerwacjaAuto = db.RezerwacjaAuto.Where(w => w.RezerwacjeId == id).FirstOrDefault();
            if (rezerwacjaAuto == null)
            {
                return HttpNotFound();
            }
            var klientID = db.Rezerwacje.Where(w => w.RezerwacjeId == id).Select(s => s.KlientId).FirstOrDefault();
            var daneKlienta = db.Klienci.Where(w => w.KlientId == klientID).Select(s => s.Imie + " " + s.Nazwisko + " " + s.NumerTelefonu).FirstOrDefault();
            ViewBag.AutoId = new SelectList(db.Auta.Where(w => w.KlientId == klientID).Select(s => new { AutoId = s.AutoId, DaneAuta = s.NazwaAuta + " " + s.ModelAuta + " " + s.NumerRejestracyjny }), "AutoId", "DaneAuta", rezerwacjaAuto.AutoId);
            ViewBag.RezerwacjeId = "ID:" + id.ToString() + " Klient:" + daneKlienta;
            ViewBag.KlientId = klientID;
            ViewBag.StareKlientId=stareKlientId;
            ViewBag.StareAutoId=rezerwacjaAuto.AutoId;
            return View(rezerwacjaAuto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RezerwacjaAutoId,RezerwacjeId,AutoId")] RezerwacjaAuto rezerwacjaAuto, int stareKlientId, int stareAutoId)
        {
            if (ModelState.IsValid)
            {
                rezerwacjaAuto.RezerwacjeId = db.RezerwacjaAuto.Where(w => w.RezerwacjaAutoId == rezerwacjaAuto.RezerwacjaAutoId).Select(s => s.RezerwacjeId).FirstOrDefault();
                db.Entry(rezerwacjaAuto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Edit", "RezerwacjaUsluga", new { id = rezerwacjaAuto.RezerwacjeId, stareKlientId = stareKlientId, stareAutoId = stareAutoId });
            }
            return View(rezerwacjaAuto);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RezerwacjaAuto rezerwacjaAuto = db.RezerwacjaAuto.Find(id);
            if (rezerwacjaAuto == null)
            {
                return HttpNotFound();
            }
            return View(rezerwacjaAuto);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RezerwacjaAuto rezerwacjaAuto = db.RezerwacjaAuto.Find(id);
            db.RezerwacjaAuto.Remove(rezerwacjaAuto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteConfirmedBack(int id, int klientId)
        {
            RezerwacjaAuto rezerwacjaAuto = db.RezerwacjaAuto.Where(w => w.RezerwacjeId == id).FirstOrDefault();
            db.RezerwacjaAuto.Remove(rezerwacjaAuto);
            db.SaveChanges();
            return RedirectToAction("Create", "RezerwacjaAuto", new { rezerwacjaId = id, klientId = klientId });
        }

        public ActionResult CancelEdit(int rezerwacjaId, int stareKlientId)
        {
            Rezerwacje rezerwacje = db.Rezerwacje.Find(rezerwacjaId);
            rezerwacje.KlientId= stareKlientId;
            db.SaveChanges();
            return RedirectToAction("Index", "Rezerwacje");
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
