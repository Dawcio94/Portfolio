using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Strony_Trasyedycja : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            decimal Id_trasy = decimal.Parse(Request.QueryString["id"]);
            FillPage(Id_trasy);
        }
    }

    private void FillPage(decimal Id_trasy)
    {
        Trasamodel trasamodel = new Trasamodel();
        Trasa trasa = trasamodel.GetTrasa(Id_trasy);
        tbidmiastpocz.Text = trasa.Id_miejscowosci_poczatek.ToString();
        tbidmiastkon.Text = trasa.Id_miejscowosci_koniec.ToString();
        tboznacztrasy.Text = trasa.Oznaczenie_trasy;
    }

    private Trasa NowyTrasa()
    {
        Trasa trasa = new Trasa();
        trasa.Id_miejscowosci_poczatek = decimal.Parse(tbidmiastpocz.Text);
        trasa.Id_miejscowosci_koniec = decimal.Parse(tbidmiastkon.Text);
        trasa.Oznaczenie_trasy = tboznacztrasy.Text;
        return trasa;
    }


    protected void btok_Click(object sender, EventArgs e)
    {
        Trasamodel trasamodel = new Trasamodel();
        Trasa trasa = NowyTrasa();
        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            decimal Id_trasy = decimal.Parse(Request.QueryString["id"]);
            lbwynik.Text = trasamodel.UpdateTrasa(Id_trasy, trasa);
        }
        else
        {
            lbwynik.Text = trasamodel.InsertTrasa(trasa);
        }
    }
}
