using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Strony_Przebiegedycja : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            decimal Id_przebiegu = decimal.Parse(Request.QueryString["id"]);
            FillPage(Id_przebiegu);
        }
    }

    private void FillPage(decimal Id_przebiegu)
    {
        Przebiegmodel przebiegmodel = new Przebiegmodel();
        Przebieg przebieg = przebiegmodel.GetPrzebieg(Id_przebiegu);
        tbgodzina.Text = przebieg.Roznica_czasu.ToString();
        tbidmiej.Text = przebieg.Id_miejscowosci.ToString();
        tbidtrasy.Text = przebieg.Id_trasy.ToString();
        tbkolej.Text = przebieg.Kolejnosc.ToString();
    }

    private Przebieg Nowyprzebieg()
    {
        Przebieg przebieg = new Przebieg();
        przebieg.Roznica_czasu = TimeSpan.Parse(tbgodzina.Text);
        przebieg.Id_miejscowosci = decimal.Parse(tbidmiej.Text);
        przebieg.Id_trasy = decimal.Parse(tbidtrasy.Text);
        przebieg.Kolejnosc = decimal.Parse(tbkolej.Text);
        return przebieg;
    }

    protected void btok_Click1(object sender, EventArgs e)
    {
        Przebiegmodel przebiegmodel = new Przebiegmodel();
        Przebieg przebieg = Nowyprzebieg();
        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            decimal Id_przebiegu = decimal.Parse(Request.QueryString["id"]);
            lbwynik.Text = przebiegmodel.UpdatePrzebieg(Id_przebiegu, przebieg);
        }
        else
        {
            lbwynik.Text = przebiegmodel.InsertPrzebieg(przebieg);
        }
    }
}