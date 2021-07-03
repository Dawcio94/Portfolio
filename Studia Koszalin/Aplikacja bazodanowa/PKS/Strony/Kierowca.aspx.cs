using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Strony_Kierowca : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void gvkierowcy_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridViewRow row = gvkierowcy.Rows[e.NewEditIndex];
        decimal rowId = Convert.ToDecimal(row.Cells[1].Text);
        Response.Redirect("~/Strony/Kierowcaedycja.aspx?id=" + rowId);
    }


    protected void bddodajkierowca_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Strony/Kierowcaedycja.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        TimeSpan today = DateTime.Now.TimeOfDay;
        TimeSpan ts = new TimeSpan(5, 30, 0);
        TimeSpan gr = new TimeSpan(8, 0, 0);
        TimeSpan all = gr.Add(ts);
        if (today <= all)
        {
            sdskierowcawtrasie.SelectCommand = "Select * From Kierowca as k Inner Join Kurs as ku on k.Id_kursu=ku.Id_kursu where ku.Godzina_rozpoczecia<='" + today + "'";
        }
        GridView1.DataSource = sdskierowcawtrasie;
        GridView1.DataBind();
    }
}