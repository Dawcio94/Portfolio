namespace CarTiresService.Models
{
    public class RaportUslugPDF
    {
        //private CarTiresServiceEntities db = new CarTiresServiceEntities();
        public string NazwaUslugi { get; set; }
        public decimal? KosztZaSzt { get; set; }
        public int? Ilosc { get; set; }
        public decimal? Koszt { get; set; }

        //public RaportUslugPDF(int raportId)
        //{
        //    NazwaUslugi = db.RaportUslugi.Where(w => w.RaportId==raportId).Select(s => s.Uslugi.NazwaUslugi).ToString();
        //    KosztZaSzt=Convert.ToDecimal(db.RaportUslugi.Where(w => w.RaportId==raportId).Select(s => s.Uslugi.Koszt));
        //    Ilosc=Convert.ToInt32(db.RaportUslugi.Where(w => w.RaportId==raportId).Select(s => s.Ilosc));
        //    Koszt=KosztZaSzt*Ilosc;
        //}
    }
}