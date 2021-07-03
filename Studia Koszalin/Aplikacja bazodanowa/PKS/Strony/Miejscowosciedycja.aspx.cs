using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Strony_Miejscowosciedycja : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            decimal Id_miejscowosci = Convert.ToDecimal(Request.QueryString["id"]);
            FillPage(Id_miejscowosci);
        }
    }

    private void FillPage(decimal Id_miejscowosci)
    {
        Miejscowoscmodel miejscowoscmodel = new Miejscowoscmodel();
        Miejscowości miejscowosc = miejscowoscmodel.GetMiejscowosc(Id_miejscowosci);
        tbmiejsce.Text = miejscowosc.Nazwa_miejscowosci;
    }

    private Miejscowości NowyMiejscowosc()
    {
        Miejscowości miejscowosc = new Miejscowości();
        miejscowosc.Nazwa_miejscowosci = tbmiejsce.Text;
        return miejscowosc;
    }

    protected void btok_Click1(object sender, EventArgs e)
    {
        Miejscowoscmodel miejscowoscmodel = new Miejscowoscmodel();
        Miejscowości miejscowosc = NowyMiejscowosc();
        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            decimal Id_miejscowosci = Convert.ToDecimal(Request.QueryString["id"]);
            lbwynik.Text = miejscowoscmodel.UpdateMiejscowosc(Id_miejscowosci, miejscowosc);
        }
        else
        {
            lbwynik.Text = miejscowoscmodel.InsertMiejscowosc(miejscowosc);
        }
    }
}