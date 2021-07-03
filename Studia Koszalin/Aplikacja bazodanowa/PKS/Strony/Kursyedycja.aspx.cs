using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Strony_Kursyedycja : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            decimal Id_kursu = Convert.ToDecimal(Request.QueryString["id"]);
            FillPage(Id_kursu);
        }
    }

    private void FillPage(decimal Id_kursu)
    {
        Kursmodel kursmodel = new Kursmodel();
        Kurs kurs = kursmodel.GetKurs(Id_kursu);
        tboznkursu.Text = kurs.Oznaczenie;
        cdata.SelectedDate = kurs.Data_kursu.Value;
        tbiloscpas.Text = kurs.Ilość_pasażerów.ToString();
        tbgodz.Text = kurs.Godzina_rozpoczecia.ToString();
        tbidtrasy.Text = kurs.Id_trasy.ToString();
    }

    private Kurs NowyKurs()
    {
        Kurs kurs = new Kurs();

        kurs.Oznaczenie=tboznkursu.Text;
        kurs.Data_kursu=Convert.ToDateTime(cdata.SelectedDate.Date);
        kurs.Ilość_pasażerów = decimal.Parse(tbiloscpas.Text);
        kurs.Godzina_rozpoczecia= TimeSpan.Parse(tbgodz.Text);
        kurs.Id_trasy = decimal.Parse(tbidtrasy.Text);
        return kurs;
    }


    protected void btok_Click1(object sender, EventArgs e)
    {
        Kursmodel kursmodel = new Kursmodel();
        Kurs kurs = NowyKurs();
        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            decimal Id_kursu = Convert.ToDecimal(Request.QueryString["id"]);
            lbwynik.Text = kursmodel.UpdateKurs(Id_kursu, kurs);
        }
        else
        {
            lbwynik.Text = kursmodel.InsertKurs(kurs);
        }
    }
}