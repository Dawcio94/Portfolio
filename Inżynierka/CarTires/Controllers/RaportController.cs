using CarTiresService.Models;
using CarTiresService.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CarTiresService.Controllers
{
    public class RaportController : Controller
    {
        private CarTiresServiceEntities db = new CarTiresServiceEntities();

        public ActionResult Index()
        {
            var raport = db.Raport.Include(r => r.Rezerwacje);
            return View(raport.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Raport raport = db.Raport.Find(id);
            if (raport == null)
            {
                return HttpNotFound();
            }
            var rezerwacjaId = db.Raport.Where(w => w.RaportId == id).Select(s => s.RezerwacjaId).FirstOrDefault();
            var auto = db.RezerwacjaAuto.Where(w => w.RezerwacjeId==rezerwacjaId).Select(s => s.Auta.NazwaAuta+" "+s.Auta.ModelAuta +" "+s.Auta.NumerRejestracyjny).FirstOrDefault();
            var uslugi = db.RaportUslugi.Where(w => w.RaportId == id).Select(s => s.Uslugi).ToList();
            var czesci = db.RaportCzesc.Where(w => w.RaportId == id).Select(s => s.CzesciZamienne).ToList();

            ViewBag.Auto=auto;
            ViewBag.Uslugi=uslugi;
            ViewBag.Czesci=czesci;
            return View(raport);
        }

        public ActionResult Create()
        {
            var termin = DateTime.Now.Date.AddDays(-14);
            ViewBag.RezerwacjaId = new SelectList(db.Rezerwacje.Where(w => w.DataTime.Value>=termin).Select(s => new { RezerwacjeId = s.RezerwacjeId, DaneRezerwacji = s.RezerwacjeId + " " + s.Klienci.Imie + " " + s.Klienci.Nazwisko + " " + (s.RezerwacjaAuto.Select(x => x.Auta.NazwaAuta + " " + x.Auta.ModelAuta + " " + x.Auta.NumerRejestracyjny).FirstOrDefault().ToString()) }), "RezerwacjeId", "DaneRezerwacji");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RaportId,RezerwacjaId,KosztCalkowity")] Raport raport)
        {
            foreach (var raportElem in db.Raport.ToList())
            {
                if (raport.RezerwacjaId==raportElem.RezerwacjaId)
                {
                    DialogResult result = MessageBox.Show("Istnieje już raport na daną rezerwacje.\nChcesz edytować?.", "Informacja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        return RedirectToAction("Edit", new { id = raportElem.RaportId, rezerwacjaId = raportElem.RezerwacjaId });
                    }
                    break;
                }
            }
            if (ModelState.IsValid)
            {
                db.Raport.Add(raport);
                db.SaveChanges();
                var klientId = db.Rezerwacje.Where(w => w.RezerwacjeId==raport.RezerwacjaId).Select(s => s.KlientId).FirstOrDefault();
                if (db.Klienci.Where(w => w.KlientId==klientId).Select(s => s.AdresId).FirstOrDefault()==null)
                    return RedirectToAction("AddAdres", "Adresy", new { raportId = raport.RaportId, klientId = klientId, rezerwacjaId = raport.RezerwacjaId });
                else
                    return RedirectToAction("CreateRaportDetail", new { raportId = raport.RaportId, rezerwacjaId = raport.RezerwacjaId });
            }

            return View(raport);
        }

        public ActionResult UpdateDetailRaport(int raportId, int rezerwacjaId, string elementId, decimal kosztCalkowity, string[] listauslug, string[] listaczesc)
        {

            if (raportId == 0)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Raport raport = db.Raport.Find(raportId);

            if (raport == null)
                return HttpNotFound();
            if (listauslug!=null)
            {
                foreach (var item in listauslug)
                {
                    var usluga = item.Split(':');
                    var uslugaId = Int32.Parse(usluga[0]);
                    if (uslugaId==0)
                        break;

                    RaportUslugi raportUslugi = db.RaportUslugi.Where(w => w.RaportId == raportId&& w.UslugaId==uslugaId).FirstOrDefault();
                    if (usluga[1]=="0")
                    {
                        db.RaportUslugi.Remove(raportUslugi);
                    }
                    else
                    {
                        raportUslugi.Ilosc=Int32.Parse(usluga[1]);
                    }
                }
            }

            if (listaczesc!=null)
            {

                foreach (var item in listaczesc)
                {
                    var czesc = item.Split(':');
                    var czescId = Int32.Parse(czesc[0]);
                    var iloscAktualnieZuzyta = Int32.Parse(czesc[1]);
                    if (czescId==0)
                        break;

                    RaportCzesc raportCzesc = db.RaportCzesc.Where(w => w.RaportId == raportId&& w.CzescId==czescId).FirstOrDefault();
                    var staraIloscUzyta = raportCzesc.IloscUzytejCzesci;
                    CzesciZamienne czesciZamienne = db.CzesciZamienne.Where(w => w.CzescId==czescId).FirstOrDefault();

                    if (staraIloscUzyta!=iloscAktualnieZuzyta)
                    {
                        if (staraIloscUzyta>iloscAktualnieZuzyta)
                        {
                            var roznica = staraIloscUzyta-iloscAktualnieZuzyta;
                            czesciZamienne.Ilosc+=roznica;
                        }
                        else //staraIloscUzyta<iloscAktualnieZuzyta
                        {
                            var roznica = iloscAktualnieZuzyta-staraIloscUzyta;
                            czesciZamienne.Ilosc-=roznica;
                            if (czesciZamienne.Ilosc<0)
                            {
                                DialogResult result = MessageBox.Show($"Nie można edytować raportu.\nStan części {czesciZamienne.NazwaCzesci} poniżej '0'", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                if (result == DialogResult.OK)
                                {
                                    return RedirectToAction("Edit", new { id = raportId, rezerwacjaId = raport.RezerwacjaId });
                                }
                            }
                        }
                    }

                    if (czesc[1]=="0")
                    {
                        db.RaportCzesc.Remove(raportCzesc);
                    }
                    else
                    {
                        raportCzesc.IloscUzytejCzesci=iloscAktualnieZuzyta;
                    }
                }
            }
            raport.KosztCalkowity = kosztCalkowity;
            db.Entry(raport).State = EntityState.Modified;


            if (elementId.Contains("Część"))
            {
                var length = elementId.Length;
                var ids = elementId.Remove(length-5, 5);
                var id = Convert.ToInt32(ids);
                db.RaportCzesc.Add(new RaportCzesc { CzescId=id, RaportId=raportId, IloscUzytejCzesci=0 });
                db.SaveChanges();
            }
            else
            {
                var length = elementId.Length;
                var ids = elementId.Remove(length-6, 6);
                var id = Convert.ToInt32(ids);
                db.RaportUslugi.Add(new RaportUslugi { UslugaId=id, RaportId=raportId, Ilosc=1 });
                db.SaveChanges();
            }
            return RedirectToAction("CreateRaportDetail", "Raport", new { raportId = raportId, rezerwacjaid = rezerwacjaId });
        }

        public ActionResult UpdateDetailRaportEdit(int raportId, int rezerwacjaId, string elementId, decimal kosztCalkowity, string[] listauslug, string[] listaczesc)
        {

            if (raportId == 0)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Raport raport = db.Raport.Find(raportId);

            if (raport == null)
                return HttpNotFound();
            if (listauslug!=null)
            {
                foreach (var item in listauslug)
                {
                    var usluga = item.Split(':');
                    var uslugaId = Int32.Parse(usluga[0]);
                    if (uslugaId==0)
                        break;

                    RaportUslugi raportUslugi = db.RaportUslugi.Where(w => w.RaportId == raportId&& w.UslugaId==uslugaId).FirstOrDefault();
                    if (usluga[1]=="0")
                    {
                        db.RaportUslugi.Remove(raportUslugi);
                    }
                    else
                    {
                        raportUslugi.Ilosc=Int32.Parse(usluga[1]);
                    }
                }
            }

            if (listaczesc!=null)
            {

                foreach (var item in listaczesc)
                {
                    var czesc = item.Split(':');
                    var czescId = Int32.Parse(czesc[0]);
                    var iloscAktualnieZuzyta = Int32.Parse(czesc[1]);
                    if (czescId==0)
                        break;

                    RaportCzesc raportCzesc = db.RaportCzesc.Where(w => w.RaportId == raportId&& w.CzescId==czescId).FirstOrDefault();
                    var staraIloscUzyta = raportCzesc.IloscUzytejCzesci;
                    CzesciZamienne czesciZamienne = db.CzesciZamienne.Where(w => w.CzescId==czescId).FirstOrDefault();

                    if (staraIloscUzyta!=iloscAktualnieZuzyta)
                    {
                        if (staraIloscUzyta>iloscAktualnieZuzyta)
                        {
                            var roznica = staraIloscUzyta-iloscAktualnieZuzyta;
                            czesciZamienne.Ilosc+=roznica;
                        }
                        else //staraIloscUzyta<iloscAktualnieZuzyta
                        {
                            var roznica = iloscAktualnieZuzyta-staraIloscUzyta;
                            czesciZamienne.Ilosc-=roznica;
                            if (czesciZamienne.Ilosc<0)
                            {
                                DialogResult result = MessageBox.Show($"Nie można edytować raportu.\nStan części {czesciZamienne.NazwaCzesci} poniżej '0'", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                if (result == DialogResult.OK)
                                {
                                    return RedirectToAction("Edit", new { id = raportId, rezerwacjaId = raport.RezerwacjaId });
                                }
                            }
                        }
                    }

                    if (czesc[1]=="0")
                    {
                        db.RaportCzesc.Remove(raportCzesc);
                    }
                    else
                    {
                        raportCzesc.IloscUzytejCzesci=iloscAktualnieZuzyta;
                    }
                }
            }
            raport.KosztCalkowity = kosztCalkowity;
            db.Entry(raport).State = EntityState.Modified;


            if (elementId.Contains("Część"))
            {
                var length = elementId.Length;
                var ids = elementId.Remove(length-5, 5);
                var id = Convert.ToInt32(ids);
                db.RaportCzesc.Add(new RaportCzesc { CzescId=id, RaportId=raportId, IloscUzytejCzesci=0 });
                db.SaveChanges();
            }
            else
            {
                var length = elementId.Length;
                var ids = elementId.Remove(length-6, 6);
                var id = Convert.ToInt32(ids);
                db.RaportUslugi.Add(new RaportUslugi { UslugaId=id, RaportId=raportId, Ilosc=1 });
                db.SaveChanges();
            }
            return RedirectToAction("Edit", "Raport", new { id = raportId, rezerwacjaid = rezerwacjaId });
        }

        public ActionResult CreateRaportDetail(int raportId, int rezerwacjaId)
        {
            ViewBag.RaportId = raportId;
            ViewBag.RezerwacjaId = rezerwacjaId;
            var uslugaZRezerwacji = db.RezerwacjaUsluga.Where(w => w.RezerwacjaId == rezerwacjaId).Select(s => s.UslugaId).FirstOrDefault();
            var ilosc = db.RezerwacjaUsluga.Where(w => w.RezerwacjaId == rezerwacjaId).Count();
            var rodzajAuta = db.RezerwacjaAuto.Where(w => w.RezerwacjeId == rezerwacjaId).Select(s => s.Auta.TypAuta).FirstOrDefault();
            ViewBag.Klient = db.Rezerwacje.Where(w => w.RezerwacjeId == rezerwacjaId).Select(s => s.Klienci.Imie + " " + s.Klienci.Nazwisko + " " + s.Klienci.NumerTelefonu).FirstOrDefault();
            ViewBag.Auto = db.RezerwacjaAuto.Where(w => w.RezerwacjeId == rezerwacjaId).Select(s => s.Auta.NazwaAuta + " " + s.Auta.ModelAuta + " " + s.Auta.NumerRejestracyjny).FirstOrDefault();
            if (db.RaportUslugi.Where(w => w.UslugaId == uslugaZRezerwacji && w.RaportId==raportId).Select(s => s).FirstOrDefault()==null)
            {
                db.RaportUslugi.Add(new RaportUslugi { RaportId=raportId, UslugaId=uslugaZRezerwacji, Ilosc=1 });
                db.SaveChanges();
            }
            ViewBag.RaportCzesci = db.RaportCzesc.Where(w => w.RaportId == raportId).Select(s => s.CzesciZamienne).ToList();
            ViewBag.RaportUslugi = db.RaportUslugi.Where(w => w.RaportId == raportId).Select(s => s.Uslugi).ToList();
            ViewBag.Czesci=db.CzesciZamienne.Select(s => s).ToList();
            ViewBag.Uslugi=db.Uslugi.Select(s => s).ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateRaportDetail([Bind(Include = "RaportId,RezerwacjaId,KosztCalkowity")] Raport raport)
        {
            if (ModelState.IsValid)
            {
                db.Raport.Add(raport);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(raport);
        }

        public ActionResult UpdateRaport(int raportId, decimal kosztCalkowity, string[] listauslug, string[] listaczesc)
        {
            if (raportId == 0)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Raport raport = db.Raport.Find(raportId);

            if (raport == null)
                return HttpNotFound();
            if (listauslug!=null)
            {
                foreach (var item in listauslug)
                {
                    var usluga = item.Split(':');
                    var uslugaId = Int32.Parse(usluga[0]);
                    if (uslugaId==0)
                        break;

                    RaportUslugi raportUslugi = db.RaportUslugi.Where(w => w.RaportId == raportId&& w.UslugaId==uslugaId).FirstOrDefault();
                    if (usluga[1]=="0")
                    {
                        db.RaportUslugi.Remove(raportUslugi);
                    }
                    else
                    {
                        raportUslugi.Ilosc=Int32.Parse(usluga[1]);
                    }
                }
            }

            if (listaczesc!=null)
            {

                foreach (var item in listaczesc)
                {
                    var czesc = item.Split(':');
                    var czescId = Int32.Parse(czesc[0]);
                    var iloscAktualnieZuzyta = Int32.Parse(czesc[1]);
                    if (czescId==0)
                        break;

                    RaportCzesc raportCzesc = db.RaportCzesc.Where(w => w.RaportId == raportId&& w.CzescId==czescId).FirstOrDefault();
                    var staraIloscUzyta = raportCzesc.IloscUzytejCzesci;
                    CzesciZamienne czesciZamienne = db.CzesciZamienne.Where(w => w.CzescId==czescId).FirstOrDefault();

                    if (staraIloscUzyta!=iloscAktualnieZuzyta)
                    {
                        if (staraIloscUzyta>iloscAktualnieZuzyta)
                        {
                            var roznica = staraIloscUzyta-iloscAktualnieZuzyta;
                            czesciZamienne.Ilosc+=roznica;
                        }
                        else //staraIloscUzyta<iloscAktualnieZuzyta
                        {
                            var roznica = iloscAktualnieZuzyta-staraIloscUzyta;
                            czesciZamienne.Ilosc-=roznica;
                            if (czesciZamienne.Ilosc<0)
                            {
                                DialogResult result = MessageBox.Show($"Nie można edytować raportu.\nStan części {czesciZamienne.NazwaCzesci} poniżej '0'", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                if (result == DialogResult.OK)
                                {
                                    return RedirectToAction("Edit", new { id = raportId, rezerwacjaId = raport.RezerwacjaId });
                                }
                            }
                        }
                    }

                    if (czesc[1]=="0")
                    {
                        db.RaportCzesc.Remove(raportCzesc);
                    }
                    else
                    {
                        raportCzesc.IloscUzytejCzesci=iloscAktualnieZuzyta;
                    }
                }
            }
            raport.KosztCalkowity = kosztCalkowity;
            db.Entry(raport).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id, int rezerwacjaId)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Raport raport = db.Raport.Find(id);
            if (raport == null)
            {
                return HttpNotFound();
            }
            ViewBag.RaportId = id;
            ViewBag.RezerwacjaId = rezerwacjaId;
            var uslugaZRezerwacji = db.RezerwacjaUsluga.Where(w => w.RezerwacjaId == rezerwacjaId).Select(s => s.UslugaId).FirstOrDefault();
            var ilosc = db.RezerwacjaUsluga.Where(w => w.RezerwacjaId == rezerwacjaId).Count();
            var rodzajAuta = db.RezerwacjaAuto.Where(w => w.RezerwacjeId == rezerwacjaId).Select(s => s.Auta.TypAuta).FirstOrDefault();
            ViewBag.Klient = db.Rezerwacje.Where(w => w.RezerwacjeId == rezerwacjaId).Select(s => s.Klienci.Imie + " " + s.Klienci.Nazwisko + " " + s.Klienci.NumerTelefonu).FirstOrDefault();
            ViewBag.Auto = db.RezerwacjaAuto.Where(w => w.RezerwacjeId == rezerwacjaId).Select(s => s.Auta.NazwaAuta + " " + s.Auta.ModelAuta + " " + s.Auta.NumerRejestracyjny).FirstOrDefault();
            ViewBag.RaportCzesci = db.RaportCzesc.Where(w => w.RaportId == id).Select(s => s.CzesciZamienne).ToList();
            ViewBag.RaportUslugi = db.RaportUslugi.Where(w => w.RaportId == id).Select(s => s.Uslugi).ToList();
            ViewBag.Czesci=db.CzesciZamienne.Select(s => s).ToList();
            ViewBag.Uslugi=db.Uslugi.Select(s => s).ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RaportId,RezerwacjaId,KosztCalkowity")] Raport raport)
        {
            if (ModelState.IsValid)
            {
                db.Entry(raport).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(raport);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Raport raport = db.Raport.Find(id);
            if (raport == null)
            {
                return HttpNotFound();
            }

            var rezerwacjaId = db.Raport.Where(w => w.RaportId == id).Select(s => s.RezerwacjaId).FirstOrDefault();
            var auto = db.RezerwacjaAuto.Where(w => w.RezerwacjeId==rezerwacjaId).Select(s => s.Auta.NazwaAuta+" "+s.Auta.ModelAuta +" "+s.Auta.NumerRejestracyjny).FirstOrDefault();
            var uslugi = db.RaportUslugi.Where(w => w.RaportId == id).Select(s => s.Uslugi).ToList();
            var czesci = db.RaportCzesc.Where(w => w.RaportId == id).Select(s => s.CzesciZamienne).ToList();

            ViewBag.Auto=auto;
            ViewBag.Uslugi=uslugi;
            ViewBag.Czesci=czesci;
            return View(raport);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Raport raport = db.Raport.Find(id);
            db.Raport.Remove(raport);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCancelBack(int id)
        {
            Raport raport = db.Raport.Where(w => w.RaportId == id).FirstOrDefault();
            db.Raport.Remove(raport);
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
