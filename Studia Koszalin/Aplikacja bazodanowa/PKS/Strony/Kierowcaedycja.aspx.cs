using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Strony_Kierowcaedycja : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            decimal Id_kierowcy = Convert.ToDecimal(Request.QueryString["id"]);
            FillPage(Id_kierowcy);
        }
    }

    private void FillPage(decimal Id_kierowcy)
    {
        Kierowcamodel kierowcamodel = new Kierowcamodel();
        Kierowca kierowca = kierowcamodel.GetKierowca(Id_kierowcy);
        tbdanekier.Text = kierowca.Imie_Nazwisko;
        tbidkursu.Text = kierowca.Id_kursu.ToString();
    }

    private Kierowca NowyKierowca()
    {
        Kierowca kierowca = new Kierowca();
        kierowca.Imie_Nazwisko = tbdanekier.Text;
        kierowca.Id_kursu = decimal.Parse(tbidkursu.Text);
        return kierowca;
    }


    protected void btok_Click(object sender, EventArgs e)
    {
        Kierowcamodel kierowcamodel = new Kierowcamodel();
        Kierowca kierowca = NowyKierowca();
        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            decimal Id_kierowcy = Convert.ToDecimal(Request.QueryString["id"]);
            lbwynik.Text = kierowcamodel.UpdateKierowca(Id_kierowcy, kierowca);
        }
        else
        {
            lbwynik.Text = kierowcamodel.InsertKierowca(kierowca);
        }
    }
}