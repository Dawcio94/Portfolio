using CarTiresService.Models;
using CarTiresService.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Windows.Forms;

namespace CarTiresService.Controllers
{
    public class RezerwacjeController : Controller
    {
        private CarTiresServiceEntities db = new CarTiresServiceEntities();

        public ActionResult Index()
        {
            var rezerwacje = db.Rezerwacje.Include(r => r.Klienci).OrderBy(o => o.DataTime);
            return View(rezerwacje.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rezerwacje rezerwacje = db.Rezerwacje.Find(id);
            if (rezerwacje == null)
            {
                return HttpNotFound();
            }
            return View(rezerwacje);
        }

        public ActionResult Create()
        {
            var test = db.Klienci.Select(s => s).ToList();
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (var item in test)
            {
                list.Add(new SelectListItem()
                {
                    Text = $"{item.Imie} {item.Nazwisko}",
                    Value = item.KlientId.ToString()
                });
            }
            ViewBag.klientId = new SelectList(list,"Value","Text");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RezerwacjeId,KlientId,DataTime")] Rezerwacje rezerwacje, DateTime rezerwacjatime)
        {
            rezerwacje.DataTime = rezerwacjatime;
            bool istnieje = false;
            TimeSpan poczatekpracy = new TimeSpan(8, 0, 0);
            TimeSpan koniecPracy = new TimeSpan(16, 0, 0);

            if (rezerwacjatime.TimeOfDay<poczatekpracy || rezerwacjatime.TimeOfDay>=koniecPracy)
            {
                DialogResult result = MessageBox.Show("Nie można dodać rezerwacji na tą porę.\nUmów klienta na inny termin", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    return RedirectToAction("Create");
                }
            }

            foreach (var rezerwacja in db.Rezerwacje.ToList())
            {
                var czasRozpoczecia = (DateTime)rezerwacja.DataTime;
                var czasTrwania = (TimeSpan)db.RezerwacjaUsluga.Where(w => w.RezerwacjaId == rezerwacja.RezerwacjeId).Select(s => s.Uslugi.CzasTrwania).FirstOrDefault();
                var czasZakonczenia = czasRozpoczecia + czasTrwania;
                if (rezerwacja.KlientId == rezerwacje.KlientId && rezerwacjatime.Date == czasRozpoczecia.Date && (rezerwacjatime >= czasRozpoczecia && rezerwacjatime <= czasZakonczenia))
                {
                    DialogResult result = MessageBox.Show("Istnieje już rezerwacja na danego klienta o wybranej dacie.\nChcesz edytować?.", "Informacja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        return RedirectToAction("Edit", new { id = rezerwacja.RezerwacjeId });
                    }
                }
                else
                {
                    if (rezerwacjatime.Date == czasRozpoczecia.Date)
                    {
                        if (rezerwacjatime >= czasRozpoczecia && rezerwacjatime <= czasZakonczenia)
                        {
                            istnieje = true;
                            break;
                        }
                        else
                        {

                        }
                    }
                }
            }
                if (istnieje)
                {
                    DialogResult result1 = MessageBox.Show("Nie można dodać rezerwacji o tej godzinie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result1 == DialogResult.OK)
                    {
                        return RedirectToAction("Create");
                    }
                }
                else
                {
                    if (ModelState.IsValid)
                    {
                        db.Rezerwacje.Add(rezerwacje);
                        db.SaveChanges();
                        return RedirectToAction("Create", "RezerwacjaAuto", new { rezerwacjaId = rezerwacje.RezerwacjeId, klientId = rezerwacje.KlientId });
                    }
                    else
                    {
                        ViewBag.klientId = db.Klienci.Select(s => new SelectListItem { Value = s.KlientId.ToString(), Text = s.Imie + " " + s.Nazwisko });
                    }
                }
            
            return View(rezerwacje);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rezerwacje rezerwacje = db.Rezerwacje.Find(id);
            if (rezerwacje == null)
            {
                return HttpNotFound();
            }

            ViewBag.KlientId = new SelectList(db.Klienci.Select(s => new { KlientId = s.KlientId, ImieINazwisko = s.Imie+" "+s.Nazwisko }), "KlientId", "ImieINazwisko", rezerwacje.KlientId);
            ViewBag.StareKlientId=rezerwacje.KlientId;
            return View(rezerwacje);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RezerwacjeId,KlientId,DataTime")] Rezerwacje rezerwacje, DateTime rezerwacjatime, int stareKlientId)
        {
            rezerwacje.DataTime= rezerwacjatime;

            bool istnieje = false;
            TimeSpan poczatekpracy = new TimeSpan(8, 0, 0);
            TimeSpan koniecPracy = new TimeSpan(16, 0, 0);
            var listaRezerwacji = db.Rezerwacje.ToList();

            if (rezerwacjatime.TimeOfDay<poczatekpracy || rezerwacjatime.TimeOfDay>=koniecPracy)
            {
                DialogResult result = MessageBox.Show("Nie można dodać rezerwacji na tą porę.\nUmów klienta na inny termin", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    return RedirectToAction("Edit", new { id = rezerwacje.RezerwacjeId });
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
                            return RedirectToAction("Edit", new { id = rezerwacja.RezerwacjeId });
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
                    return RedirectToAction("Edit", new { id = rezerwacje.RezerwacjeId });
                }
            }
            else
            {
                if (ModelState.IsValid)
                {
                    Rezerwacje rezerwacje1 = db.Rezerwacje.Find(rezerwacje.RezerwacjeId);
                    rezerwacje1.DataTime=rezerwacjatime;
                    rezerwacje1.KlientId= rezerwacje.KlientId;
                    db.SaveChanges();
                    return RedirectToAction("Edit", "RezerwacjaAuto", new { id = rezerwacje.RezerwacjeId, stareKlientId = stareKlientId });
                }
            }
            return View(rezerwacje);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rezerwacje rezerwacje = db.Rezerwacje.Find(id);
            if (rezerwacje == null)
            {
                return HttpNotFound();
            }
            return View(rezerwacje);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Rezerwacje rezerwacje = db.Rezerwacje.Find(id);
                db.Rezerwacje.Remove(rezerwacje);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("Nie można usunąć rezerwacji.\nJuż został stworzony raport.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");

        }

        public ActionResult DeleteConfirmedCancel(int id)
        {
            Rezerwacje rezerwacje = db.Rezerwacje.Find(id);
            db.Rezerwacje.Remove(rezerwacje);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteConfirmedBack(int id)
        {
            Rezerwacje rezerwacje = db.Rezerwacje.Find(id);
            db.Rezerwacje.Remove(rezerwacje);
            db.SaveChanges();
            return RedirectToAction("Create");
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
