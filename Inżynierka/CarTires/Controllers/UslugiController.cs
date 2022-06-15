using CarTiresService.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Windows.Forms;

namespace CarTiresService.Controllers
{
    public class UslugiController : Controller
    {
        private CarTiresServiceEntities db = new CarTiresServiceEntities();

        public ActionResult Index()
        {
            return View(db.Uslugi.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uslugi uslugi = db.Uslugi.Find(id);
            if (uslugi == null)
            {
                return HttpNotFound();
            }
            return View(uslugi);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UslugaId,NazwaUslugi,Koszt,CzasTrwania,TypAuta,TypFelgi")] Uslugi uslugi)
        {
            if (ModelState.IsValid)
            {
                db.Uslugi.Add(uslugi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(uslugi);
        }


        public ActionResult CreateSimple(string typAuta, int rezerwacjaId, int autoId)
        {
            ViewBag.RezerwacjaId = rezerwacjaId;
            ViewBag.AutoId = autoId;
            ViewBag.TypAuta = typAuta;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSimple([Bind(Include = "UslugaId,NazwaUslugi,Koszt,CzasTrwania,TypAuta,TypFelgi")] Uslugi uslugi, int rezerwacjaid, int autoId)
        {
            if (ModelState.IsValid)
            {
                db.Uslugi.Add(uslugi);
                RezerwacjaUsluga rezerwacjaUsluga = new RezerwacjaUsluga { RezerwacjaId=rezerwacjaid, UslugaId=uslugi.UslugaId };
                db.RezerwacjaUsluga.Add(rezerwacjaUsluga);
                db.SaveChanges();
                return RedirectToAction("Index", "Rezerwacje");
            }

            return View(uslugi);
        }

        public ActionResult CreateSimpleRaportUsluga(int? raportId, int? rezerwacjaId, decimal? kosztCalkowity, string[] listauslug = null, string[] listaczesc = null)
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

            return View();

        }


        public ActionResult CreateSimpleRaportUslugaEdit(int? raportId, int? rezerwacjaId, decimal? kosztCalkowity, string[] listauslug = null, string[] listaczesc = null)
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

            return View();

        }
        public ActionResult CreateSimpleRaportEdit(int? rezerwacjaId, int? raportId)
        {
            ViewBag.RezerwacjaId=rezerwacjaId;
            ViewBag.RaportId = raportId;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSimpleRaportEdit([Bind(Include = "UslugaId,NazwaUslugi,Koszt,CzasTrwania,TypAuta,TypFelgi")] Uslugi uslugi, int raportId, int rezerwacjaId)
        {
            if (ModelState.IsValid)
            {
                db.Uslugi.Add(uslugi);
                db.RaportUslugi.Add(new RaportUslugi { RaportId = raportId, UslugaId = uslugi.UslugaId, Ilosc=0 });
                db.SaveChanges();
                return RedirectToAction("Edit", "Raport", new { id = raportId, rezerwacjaid = rezerwacjaId });
            }

            return View(uslugi);
        }

        public ActionResult CreateSimpleRaport(int? rezerwacjaId, int? raportId)
        {
            ViewBag.RezerwacjaId=rezerwacjaId;
            ViewBag.RaportId = raportId;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSimpleRaport([Bind(Include = "UslugaId,NazwaUslugi,Koszt,CzasTrwania,TypAuta,TypFelgi")] Uslugi uslugi, int raportId, int rezerwacjaId)
        {
            if (ModelState.IsValid)
            {
                db.Uslugi.Add(uslugi);
                db.RaportUslugi.Add(new RaportUslugi { RaportId = raportId, UslugaId = uslugi.UslugaId, Ilosc=0 });
                db.SaveChanges();
                return RedirectToAction("CreateRaportDetail", "Raport", new { raportId = raportId, rezerwacjaid = rezerwacjaId });
            }

            return View(uslugi);
        }
        public ActionResult CreateSimpleEdit(string typAuta, int rezerwacjaId, int stareKlientId, int stareAutoId)
        {
            ViewBag.StareAutoId=stareAutoId;
            ViewBag.StareKlientId=stareKlientId;
            ViewBag.RezerwacjaId = rezerwacjaId;
            ViewBag.TypAuta = typAuta;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSimpleEdit([Bind(Include = "UslugaId,NazwaUslugi,Koszt,CzasTrwania,TypAuta,TypFelgi")] Uslugi uslugi, int rezerwacjaId)
        {
            if (ModelState.IsValid)
            {
                db.Uslugi.Add(uslugi);
                db.SaveChanges();
                RezerwacjaUsluga rezerwacjaUsluga = db.RezerwacjaUsluga.Where(w => w.RezerwacjaId == rezerwacjaId).FirstOrDefault();
                rezerwacjaUsluga.UslugaId=uslugi.UslugaId;
                db.SaveChanges();
                return RedirectToAction("Index", "Rezerwacje");
            }

            return View(uslugi);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uslugi uslugi = db.Uslugi.Find(id);
            if (uslugi == null)
            {
                return HttpNotFound();
            }
            return View(uslugi);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UslugaId,NazwaUslugi,Koszt,CzasTrwania,TypAuta,TypFelgi")] Uslugi uslugi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uslugi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(uslugi);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uslugi uslugi = db.Uslugi.Find(id);
            if (uslugi == null)
            {
                return HttpNotFound();
            }
            return View(uslugi);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Uslugi uslugi = db.Uslugi.Find(id);
            db.Uslugi.Remove(uslugi);
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
