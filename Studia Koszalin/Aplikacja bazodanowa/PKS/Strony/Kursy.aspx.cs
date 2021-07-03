using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Strony_Kursy : System.Web.UI.Page
{
    Baza_PKSEntities db = new Baza_PKSEntities();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void gvkurs_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridViewRow row = gvkurs.Rows[e.NewEditIndex];
        decimal rowId = Convert.ToDecimal(row.Cells[1].Text);
        Response.Redirect("~/Strony/Kursyedycja.aspx?id=" + rowId);
    }

    protected void btdodajkurs_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Strony/Kursyedycja.aspx");
    }

    protected void bttyg_Click(object sender, EventArgs e)
    {
        int suma = 0;
        var all = db.Kurs.Where(p => p.Oznaczenie == tboznkursu.Text).ToList();
        foreach (Kurs k in all)
        {
            if (DateTime.Today.Subtract(k.Data_kursu.Value).Days <= 7)
            {
                suma += Convert.ToInt32(k.Ilość_pasażerów);
            }
            tbpasazer.Text = suma.ToString();
        }
    }

    protected void btsrednia_Click(object sender, EventArgs e)
    {
        int suma = 0;
        int srednia = 0;
        var all = db.Kurs.Where(p => p.Oznaczenie == tboznkursu.Text).ToList();
        foreach (Kurs k in all)
        {
            for (int i = 0; i <= gvkurs.Rows.Count - 1; i++)
            {

                suma += Convert.ToInt32(k.Ilość_pasażerów);
                srednia = suma / gvkurs.Rows.Count;
            }
            tbpasazer.Text = srednia.ToString();
        }
    }

    protected void gvkurs_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}