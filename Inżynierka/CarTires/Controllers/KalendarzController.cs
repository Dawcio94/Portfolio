using CarTiresService.Models;
using CarTiresService.Models;
using DHTMLX.Scheduler;
using DHTMLX.Scheduler.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CarTiresService.Controllers
{
    public class KalendarzController : Controller
    {
        private readonly CarTiresServiceEntities db = new CarTiresServiceEntities();

        public ActionResult Index()
        {
            var scheduler = new DHXScheduler(this)
            {
                Skin = DHXScheduler.Skins.Flat
            };

            scheduler.Config.first_hour = 8;
            scheduler.Config.last_hour = 17;

            scheduler.EnableDynamicLoading(SchedulerDataLoader.DynamicalLoadingMode.Month);

            scheduler.LoadData = true;
            scheduler.Config.isReadonly = true;

            scheduler.Config.Tooltip_delta_x = 15;
            scheduler.Config.Tooltip_delta_y = -20;
            scheduler.Config.Tooltip_timeout_to_display = 50;

            return View(scheduler);
        }

        public ActionResult Data()
        {
            List<Appointment> listaKalendarz = new List<Appointment>();

            foreach (var rezerwacja in db.Rezerwacje.ToList())
            {
                var czasStartu = (DateTime)rezerwacja.DataTime;
                var czasTrwania = (TimeSpan)db.RezerwacjaUsluga.Where(w => w.RezerwacjaId==rezerwacja.RezerwacjeId).Select(s => s.Uslugi.CzasTrwania).FirstOrDefault();
                var auto = db.RezerwacjaAuto.Where(w => w.RezerwacjeId==rezerwacja.RezerwacjeId).Select(s => s.Auta.NazwaAuta+" "+s.Auta.ModelAuta+" "+s.Auta.NumerRejestracyjny).FirstOrDefault();
                var opis = $"{rezerwacja.Klienci.Imie} {rezerwacja.Klienci.Nazwisko} {rezerwacja.Klienci.NumerTelefonu} {auto}";
                var czasKonca = czasStartu.Add(czasTrwania);
                listaKalendarz.Add(new Appointment { id=rezerwacja.RezerwacjeId, text=opis, start_date=czasStartu.ToString("yyyy-MM-dd HH:mm"), end_date=czasKonca.ToString("yyyy-MM-dd HH:mm") });
            }
            return new SchedulerAjaxData(listaKalendarz);
        }

    }
}