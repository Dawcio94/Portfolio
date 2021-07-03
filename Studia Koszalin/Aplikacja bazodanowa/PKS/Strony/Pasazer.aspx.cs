using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Strony_Pasazer : System.Web.UI.Page
{
    Baza_PKSEntities db = new Baza_PKSEntities();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btzaloguj_Click(object sender, EventArgs e)
    {
        sdskurs.SelectCommand = "SELECT * from Kurs where Godzina_rozpoczecia>='" + TimeSpan.Parse(tbgodz.Text) + "';";
        GridView1.DataSource = sdskurs;
        GridView1.DataBind();
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Select")
        {
            Int16 index = Convert.ToInt16(e.CommandArgument);
            sdsprzebieg.SelectCommand = "Select * from Przebieg as p Inner Join Trasa as t on p.Id_trasy=t.Id_trasy Inner join Kurs as k on k.Id_trasy=t.Id_trasy where k.Id_kursu='" + decimal.Parse(GridView1.Rows[index].Cells[1].Text) + "' and (p.Id_miejscowosci>='" + decimal.Parse(dplmiastopocz.SelectedValue) + "' and p.Id_miejscowosci<='" + decimal.Parse(dplmiastokon.SelectedValue) + "')";
            GridView2.DataSource = sdsprzebieg;
            GridView2.DataBind();
                sdsmiasto.SelectCommand = "Select * from Miejscowości as m Inner Join Przebieg as p on m.Id_miejscowosci=p.Id_miejscowosci Inner Join Trasa as t on p.Id_trasy=t.Id_trasy Inner join Kurs as k on k.Id_trasy=t.Id_trasy where k.Id_kursu='" + decimal.Parse(GridView1.Rows[index].Cells[1].Text) + "' and (p.Id_miejscowosci>='" + decimal.Parse(dplmiastopocz.SelectedValue) + "' and p.Id_miejscowosci<='" + decimal.Parse(dplmiastokon.SelectedValue) + "')";
            GridView3.DataSource = sdsmiasto;
                GridView3.DataBind();
        }
    }
}