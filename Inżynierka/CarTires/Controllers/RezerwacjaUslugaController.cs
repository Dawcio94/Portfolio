using CarTiresService.Models;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace CarTiresService.Controllers
{
    public class RezerwacjaUslugaController : Controller
    {
        private CarTiresServiceEntities db = new CarTiresServiceEntities();

        public ActionResult Index()
        {
            var rezerwacjaUsluga = db.RezerwacjaUsluga.Include(r => r.Rezerwacje).Include(r => r.Uslugi);

            return View(rezerwacjaUsluga.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RezerwacjaUsluga rezerwacjaUsluga = db.RezerwacjaUsluga.Find(id);
            if (rezerwacjaUsluga == null)
            {
                return HttpNotFound();
            }
            return View(rezerwacjaUsluga);
        }

        public ActionResult Create(int rezerwacjaId, int autoId)
        {
            var typAuta = db.Auta.Where(w => w.AutoId == autoId).Select(s => s.TypAuta).FirstOrDefault();
            var autoDoRezerwacji = db.Auta.Where(w => w.AutoId == autoId).Select(s => s.NazwaAuta + " " + s.ModelAuta + " " + s.NumerRejestracyjny).FirstOrDefault();
            var klientID = db.Rezerwacje.Where(w => w.RezerwacjeId == rezerwacjaId).Select(s => s.KlientId).FirstOrDefault();
            var daneKlienta = db.Klienci.Where(w => w.KlientId == klientID).Select(s => s.Imie + " " + s.Nazwisko + " " + s.NumerTelefonu).FirstOrDefault();
            ViewBag.TypAuta = typAuta;
            ViewBag.Auto = autoDoRezerwacji;
            ViewBag.Rezerwacja = rezerwacjaId.ToString() + "\nKlient:\n" + daneKlienta;
            ViewBag.ToDelete = rezerwacjaId;
            ViewBag.KlientId = klientID;
            ViewBag.AutoId = autoId;
            ViewBag.UslugaId = new SelectList(db.Uslugi.Where(w => w.TypAuta == typAuta).Select(s => new { UslugaID = s.UslugaId, DaneUslugi = s.NazwaUslugi + " Koszt:" + s.Koszt + " Czas:" + s.CzasTrwania.Value.Minutes + " minut Koła:" + s.TypFelgi }), "UslugaId", "DaneUslugi");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RezerwacjaUslugaId,RezerwacjaId,UslugaId")] RezerwacjaUsluga rezerwacjaUsluga, int rezerwacjaId)
        {
            if (ModelState.IsValid)
            {
                rezerwacjaUsluga.RezerwacjaId = rezerwacjaId;
                db.RezerwacjaUsluga.Add(rezerwacjaUsluga);
                db.SaveChanges();
                return RedirectToAction("Index", "Rezerwacje");
            }

            return View(rezerwacjaUsluga);
        }

        public ActionResult Edit(int? id, int stareKlientId, int stareAutoId)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RezerwacjaUsluga rezerwacjaUsluga = db.RezerwacjaUsluga.Where(w => w.RezerwacjaId == id).FirstOrDefault();
            if (rezerwacjaUsluga == null)
            {
                return HttpNotFound();
            }


            var typAuta = db.RezerwacjaAuto.Where(w => w.AutoId == w.Auta.AutoId).Select(s => s.Auta.TypAuta).FirstOrDefault();
            var klientID = db.Rezerwacje.Where(w => w.RezerwacjeId == id).Select(s => s.KlientId).FirstOrDefault();
            var daneKlienta = db.Klienci.Where(w => w.KlientId == klientID).Select(s => s.Imie + " " + s.Nazwisko + " " + s.NumerTelefonu).FirstOrDefault();
            var autoId = db.RezerwacjaAuto.Where(w => w.RezerwacjeId == id).Select(s => s.AutoId).FirstOrDefault();
            var autoDoRezerwacji = db.Auta.Where(w => w.AutoId == autoId).Select(s => s.NazwaAuta + " " + s.ModelAuta + " " + s.NumerRejestracyjny).FirstOrDefault();
            ViewBag.RezerwacjaId = "ID:" + id.ToString() + " Klient:" + daneKlienta;
            ViewBag.AutoId = autoDoRezerwacji;
            ViewBag.TypAuta = db.Auta.Where(w => w.AutoId == autoId).Select(s => s.TypAuta).FirstOrDefault();
            ViewBag.UslugaId = new SelectList(db.Uslugi.Where(w => w.TypAuta == typAuta).Select(s => new { UslugaID = s.UslugaId, DaneUslugi = s.NazwaUslugi + " Koszt:" + s.Koszt + " Czas:" + s.CzasTrwania.Value.Minutes + " minut Koła:" + s.TypFelgi }), "UslugaId", "DaneUslugi", rezerwacjaUsluga.UslugaId);
            ViewBag.StareKlientId=stareKlientId;
            ViewBag.StareAutoId=stareAutoId;
            return View(rezerwacjaUsluga);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RezerwacjaUslugaId,RezerwacjaId,UslugaId")] RezerwacjaUsluga rezerwacjaUsluga)
        {


            if (ModelState.IsValid)
            {
                rezerwacjaUsluga.RezerwacjaId = db.RezerwacjaUsluga.Where(w => w.RezerwacjaUslugaId == rezerwacjaUsluga.RezerwacjaUslugaId).Select(s => s.RezerwacjaId).FirstOrDefault();
                db.Entry(rezerwacjaUsluga).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Rezerwacje");
            }
            return View(rezerwacjaUsluga);
        }

        public ActionResult CancelEdit(int rezerwacjaId, int stareKlientId, int stareAutoId)
        {

            Rezerwacje rezerwacje = db.Rezerwacje.Find(rezerwacjaId);
            rezerwacje.KlientId=stareKlientId;
            RezerwacjaAuto rezerwacjaAuto = db.RezerwacjaAuto.Where(w => w.RezerwacjeId==rezerwacjaId).FirstOrDefault();
            rezerwacjaAuto.AutoId=stareAutoId;
            db.SaveChanges();
            return RedirectToAction("Index", "Rezerwacje");
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RezerwacjaUsluga rezerwacjaUsluga = db.RezerwacjaUsluga.Find(id);
            if (rezerwacjaUsluga == null)
            {
                return HttpNotFound();
            }
            return View(rezerwacjaUsluga);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RezerwacjaUsluga rezerwacjaUsluga = db.RezerwacjaUsluga.Find(id);
            db.RezerwacjaUsluga.Remove(rezerwacjaUsluga);
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
