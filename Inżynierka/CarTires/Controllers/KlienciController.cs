using CarTiresService.Models;
using CarTiresService.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Windows.Forms;

namespace CarTiresService.Controllers
{
    public class KlienciController : Controller
    {
        private CarTiresServiceEntities db = new CarTiresServiceEntities();

        public ActionResult Index()
        {
            var klienci = db.Klienci.Include(k => k.Adresy);
            if (klienci.Select(s => s.Adresy) == null)
            {

            }
            return View(klienci.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Klienci klienci = db.Klienci.Find(id);
            if (klienci == null)
            {
                return HttpNotFound();
            }
            return View(klienci);
        }

        public ActionResult Create()
        {

            ViewBag.AdresId = new SelectList(db.Adresy.Select(s => new { AdresId = s.AdresId, DaneAdresu = s.Miasto + " " + s.Ulica + " " + "D: " + s.NumerDomu + " M:" + s.NumerMieszkania }), "AdresId", "DaneAdresu");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KlientId,Imie,Nazwisko,NumerTelefonu,AdresId")] Klienci klienci)
        {
            if (ModelState.IsValid)
            {
                db.Klienci.Add(klienci);
                db.SaveChanges();
                return RedirectToAction("CreateSimple", "Adresy", new { klientId = klienci.KlientId });
            }
            return View(klienci);
        }

        public ActionResult CreateSimple(DateTime rezerwacjatime)
        {
            ViewBag.Rezerwacja=rezerwacjatime;
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSimple([Bind(Include = "KlientId,Imie,Nazwisko,NumerTelefonu,AdresId")] Klienci klienci, DateTime rezerwacjatime, TimeSpan rezerwacjaTimeSpan)
        {
            if (ModelState.IsValid)
            {
                db.Klienci.Add(klienci);
                db.SaveChanges();
                bool istnieje = false;
                TimeSpan poczatekpracy = new TimeSpan(8, 0, 0);
                TimeSpan koniecPracy = new TimeSpan(16, 0, 0);
                rezerwacjatime+=rezerwacjaTimeSpan;
                if (rezerwacjatime.TimeOfDay<poczatekpracy || rezerwacjatime.TimeOfDay>=koniecPracy)
                {
                    DialogResult result = MessageBox.Show("Nie można dodać rezerwacji na tą porę.\nUmów klienta na inny termin", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        return RedirectToAction("Create", "Rezerwacje");
                    }
                }

                foreach (var rezerwacja in db.Rezerwacje.ToList())
                {
                    var czasRozpoczecia = (DateTime)rezerwacja.DataTime;
                    var czasTrwania = (TimeSpan)db.RezerwacjaUsluga.Where(w => w.RezerwacjaId==rezerwacja.RezerwacjeId).Select(s => s.Uslugi.CzasTrwania).FirstOrDefault();
                    var czasZakonczenia = czasRozpoczecia+czasTrwania;
                    if (rezerwacjatime.Date==czasRozpoczecia.Date)
                    {
                        if (rezerwacjatime>=czasRozpoczecia && rezerwacjatime<=czasZakonczenia)
                        {
                            istnieje = true;
                            break;
                        }
                        else
                        {

                        }
                    }
                }
                if (istnieje)
                {
                    DialogResult result = MessageBox.Show("Nie można dodać rezerwacji o tej godzinie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        return RedirectToAction("Create", "Rezerwacje");
                    }
                }
                else
                {
                    Rezerwacje rezerwacje = new Rezerwacje
                    {
                        DataTime = rezerwacjatime,
                        KlientId = klienci.KlientId
                    };

                    db.Rezerwacje.Add(rezerwacje);
                    db.SaveChanges();
                    return RedirectToAction("Create", "RezerwacjaAuto", new { rezerwacjaId = rezerwacje.RezerwacjeId, klientId = klienci.KlientId });
                }
            }
            return View(klienci);
        }

        public ActionResult CreateSimpleEdit(int id, int stareKlientId)
        {
            ViewBag.RezerwacjaId = id;
            ViewBag.StareKlientId=stareKlientId;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSimpleEdit([Bind(Include = "KlientId,Imie,Nazwisko,NumerTelefonu,AdresId")] Klienci klienci, int rezerwacjaId, int stareKlientId)
        {
            Rezerwacje rezerwacje = db.Rezerwacje.Find(rezerwacjaId);
            var rezerwacjatime = (DateTime)rezerwacje.DataTime;

            bool istnieje = false;
            TimeSpan poczatekpracy = new TimeSpan(8, 0, 0);
            TimeSpan koniecPracy = new TimeSpan(16, 0, 0);
            var listaRezerwacji = db.Rezerwacje.ToList();

            if (rezerwacjatime.TimeOfDay<poczatekpracy || rezerwacjatime.TimeOfDay>=koniecPracy)
            {
                DialogResult result = MessageBox.Show("Nie można dodać rezerwacji na tą porę.\nUmów klienta na inny termin", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    return RedirectToAction("Edit", "Rezerwacje", new { id = rezerwacje.RezerwacjeId });
                }
            }


            foreach (var rezerwacja in listaRezerwacji)
            {
                var czasRozpoczecia = (DateTime)rezerwacja.DataTime;
                var czasTrwania = (TimeSpan)db.RezerwacjaUsluga.Where(w => w.RezerwacjaId==rezerwacja.RezerwacjeId).Select(s => s.Uslugi.CzasTrwania).FirstOrDefault();
                var czasZakonczenia = czasRozpoczecia+czasTrwania;

                if (rezerwacja.RezerwacjeId==rezerwacje.RezerwacjeId)
                {
                    continue;
                }
                else
                {
                    if (rezerwacja.KlientId==rezerwacje.KlientId && rezerwacjatime.Date==czasRozpoczecia.Date && (rezerwacjatime>=czasRozpoczecia && rezerwacjatime<=czasZakonczenia))
                    {
                        DialogResult result = MessageBox.Show("Istnieje już rezerwacja na danego klienta o wybranej dacie.\nChcesz edytować?.", "Informacja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            return RedirectToAction("Edit", "Rezerwacje", new { id = rezerwacja.RezerwacjeId });
                        }
                    }
                    else
                    {
                        if (rezerwacjatime.Date==czasRozpoczecia.Date)
                        {
                            if (rezerwacjatime>=czasRozpoczecia && rezerwacjatime<=czasZakonczenia)
                            {
                                istnieje = true;
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                }
            }
            if (istnieje)
            {
                DialogResult result1 = MessageBox.Show("Nie można dodać rezerwacji o tej godzinie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result1 == DialogResult.OK)
                {
                    return RedirectToAction("Edit", "Rezerwacje", new { id = rezerwacje.RezerwacjeId });
                }
            }
            else
            {
                if (ModelState.IsValid)
                {
                    db.Klienci.Add(klienci);
                    rezerwacje.KlientId= klienci.KlientId;
                    db.SaveChanges();
                    return RedirectToAction("Edit", "RezerwacjaAuto", new { id = rezerwacjaId, stareKlientId = stareKlientId });
                }
            }
            return View(klienci);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Klienci klienci = db.Klienci.Find(id);
            if (klienci == null)
            {
                return HttpNotFound();
            }
            int? adresId = db.Klienci.Where(w => w.KlientId==id).Select(s => (int?)s.Adresy.AdresId).FirstOrDefault()??null;
            if (adresId!=null)
                ViewBag.AdresId=adresId;

            ViewBag.Miasto= db.Klienci.Where(w => w.KlientId==id).Select(s => s.Adresy.Miasto).FirstOrDefault();
            ViewBag.Adres = db.Klienci.Where(w => w.KlientId==id).Select(s => s.Adresy.Miasto + " ul." + s.Adresy.Ulica + " " + "D: " + s.Adresy.NumerDomu + " M:" + s.Adresy.NumerMieszkania).FirstOrDefault();

            return View(klienci);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KlientId,Imie,Nazwisko,NumerTelefonu,AdresId")] Klienci klienci, int? adresId)
        {

            if (ModelState.IsValid)
            {
                if (adresId!=0)
                    klienci.AdresId=adresId;
                db.Entry(klienci).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(klienci);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Klienci klienci = db.Klienci.Find(id);
            if (klienci == null)
            {
                return HttpNotFound();
            }
            return View(klienci);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Klienci klienci = db.Klienci.Find(id);
                Adresy adresy = db.Adresy.Find(klienci.AdresId);
                if (adresy!=null)
                    db.Adresy.Remove(adresy);

                db.Klienci.Remove(klienci);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show("Nie można usunąć klienta.\nIstnieją rezerwacje dla tego klienta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    return RedirectToAction("Index");
                }

            }
            return View();
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
