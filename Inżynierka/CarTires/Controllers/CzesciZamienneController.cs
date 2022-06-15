using CarTiresService.Models;
using CarTiresService.Models;
using System;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Windows.Forms;

namespace CarTiresService.Controllers
{
    public class CzesciZamienneController : Controller
    {
        private CarTiresServiceEntities db = new CarTiresServiceEntities();

        public ActionResult Index()
        {
            return View(db.CzesciZamienne.ToList());
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CzesciZamienne czesciZamienne = db.CzesciZamienne.Find(id);
            if (czesciZamienne == null)
            {
                return HttpNotFound();
            }
            return View(czesciZamienne);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CzescId,NazwaCzesci,Ilosc,KosztSztuka,TypAuta,TypFelgi")] CzesciZamienne czesciZamienne)
        {
            if (ModelState.IsValid)
            {
                db.CzesciZamienne.Add(czesciZamienne);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(czesciZamienne);
        }
        public ActionResult CreateSimpleRaportCzescEdit(int raportId, int rezerwacjaId, decimal kosztCalkowity, string[] listauslug, string[] listaczesc)
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

            ViewBag.RezerwacjaId=rezerwacjaId;
            ViewBag.RaportId = raportId;
            return View();
        }
        public ActionResult CreateSimpleRaportCzesc(int raportId, int rezerwacjaId, decimal kosztCalkowity, string[] listauslug, string[] listaczesc)
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

            ViewBag.RezerwacjaId=rezerwacjaId;
            ViewBag.RaportId = raportId;
            return View();
        }

        public ActionResult CreateSimpleRaport(int raportId, int rezerwacjaId)
        {
            ViewBag.RezerwacjaId=rezerwacjaId;
            ViewBag.RaportId = raportId;
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSimpleRaport([Bind(Include = "CzescId,NazwaCzesci,Ilosc,KosztSztuka,TypAuta,TypFelgi")] CzesciZamienne czesciZamienne, int raportId, int rezerwacjaId)
        {
            if (ModelState.IsValid)
            {
                db.CzesciZamienne.Add(czesciZamienne);
                db.RaportCzesc.Add(new RaportCzesc { RaportId = raportId, CzescId = czesciZamienne.CzescId, IloscUzytejCzesci=0 });
                db.SaveChanges();
                return RedirectToAction("CreateRaportDetail", "Raport", new { raportId = raportId, rezerwacjaid = rezerwacjaId });
            }

            return View(czesciZamienne);
        }
        public ActionResult CreateSimpleRaportEdit(int raportId, int rezerwacjaId)
        {
            ViewBag.RezerwacjaId=rezerwacjaId;
            ViewBag.RaportId = raportId;
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSimpleRaportEdit([Bind(Include = "CzescId,NazwaCzesci,Ilosc,KosztSztuka,TypAuta,TypFelgi")] CzesciZamienne czesciZamienne, int raportId, int rezerwacjaId)
        {
            if (ModelState.IsValid)
            {
                db.CzesciZamienne.Add(czesciZamienne);
                db.RaportCzesc.Add(new RaportCzesc { RaportId = raportId, CzescId = czesciZamienne.CzescId, IloscUzytejCzesci=0 });
                db.SaveChanges();
                return RedirectToAction("Edit", "Raport", new { id = raportId, rezerwacjaid = rezerwacjaId });
            }

            return View(czesciZamienne);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CzesciZamienne czesciZamienne = db.CzesciZamienne.Find(id);
            if (czesciZamienne == null)
            {
                return HttpNotFound();
            }
            czesciZamienne.KosztSztuka=Convert.ToDecimal(czesciZamienne.KosztSztuka, new CultureInfo("en-US"));
            db.SaveChanges();
            return View(czesciZamienne);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CzescId,NazwaCzesci,Ilosc,KosztSztuka,TypAuta,TypFelgi")] CzesciZamienne czesciZamienne)
        {
            if (ModelState.IsValid)
            {
                db.Entry(czesciZamienne).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(czesciZamienne);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CzesciZamienne czesciZamienne = db.CzesciZamienne.Find(id);
            if (czesciZamienne == null)
            {
                return HttpNotFound();
            }
            return View(czesciZamienne);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CzesciZamienne czesciZamienne = db.CzesciZamienne.Find(id);
            db.CzesciZamienne.Remove(czesciZamienne);
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
