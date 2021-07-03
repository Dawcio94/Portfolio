using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Strony_Autokary : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            decimal Id_autokaru = decimal.Parse(Request.QueryString["id"]);
            FillPage(Id_autokaru);
        }
    } 

    private void FillPage(decimal Id_autokaru)
    {
        Autokarmodel autokarmodel = new Autokarmodel();
        Autokar autokar = autokarmodel.GetAutokar(Id_autokaru);
        tbnrrejestr.Text = autokar.Nr_rejestr;
        tbmarka.Text = autokar.Marka;
        tbmodel.Text = autokar.Model;
        tbiloscmiejsc.Text = autokar.Liczba_miejsc.ToString();
        tbidkursu.Text = autokar.Id_kursu.ToString();
    }

    private Autokar Nowyautokar()
    {
        Autokar autokar = new Autokar();
        autokar.Nr_rejestr = tbnrrejestr.Text;
        autokar.Marka = tbmarka.Text;
        autokar.Model = tbmodel.Text;
        autokar.Liczba_miejsc = decimal.Parse(tbiloscmiejsc.Text);
        autokar.Id_kursu = decimal.Parse(tbidkursu.Text);
        return autokar;
    }

    protected void btok_Click(object sender, EventArgs e)
    {
        Autokarmodel autokarmodel = new Autokarmodel();
        Autokar autokar = Nowyautokar();
        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            decimal Id_autokaru = decimal.Parse(Request.QueryString["id"]);
            lbwynik.Text = autokarmodel.UpdateAutokary(Id_autokaru, autokar);
        }
        else
        {
            lbwynik.Text = autokarmodel.InsertAutokary(autokar);
        }

    }
}