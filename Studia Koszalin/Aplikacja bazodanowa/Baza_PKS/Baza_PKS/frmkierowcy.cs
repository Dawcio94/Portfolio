using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baza_PKS
{
    public partial class frmkierowcy : Form
    {
        Baza_PKSEntities db = new Baza_PKSEntities();
       TimeSpan ts = new TimeSpan(3, 15, 0);
       TimeSpan gr = new TimeSpan(8, 0, 0);
       public frmkierowcy()
        {
            InitializeComponent();
            bskierowcy.DataSource = db.Kierowca.ToList();
            bskurs.DataSource = db.Kurs.ToList();
        }        

        private void btcbkierowcy_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdyżurny dyz = new frmdyżurny();
            dyz.ShowDialog();
        }

        private void btedytujkierowcy_Click(object sender, EventArgs e)
        {
            frmkierowcyedycja edit = new frmkierowcyedycja(bskierowcy.Current as Kierowca,bskurs.Current as Kurs);
            edit.ShowDialog();
            db.SaveChanges();
            bskierowcy.DataSource = db.Kierowca.ToList();
        }

        private void btdodajkierowcy_Click(object sender, EventArgs e)
        {
            frmkierowcyedycja add = new frmkierowcyedycja(null,null);
            if (add.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                db.Kierowca.Add(add.Driver);
                db.SaveChanges();
                bskierowcy.DataSource = db.Kierowca.ToList();
            }
        }

        private void btusunkierowcy_Click(object sender, EventArgs e)
        {
            Kierowca toremove = bskierowcy.Current as Kierowca;
            db.Kierowca.Remove(toremove);
            db.SaveChanges();
            bskierowcy.DataSource = db.Kierowca.ToList();
        }

        private void btszukajkierowcy_Click(object sender, EventArgs e)
        {
            TimeSpan today = DateTime.Now.TimeOfDay;
            TimeSpan all = gr.Add(ts);
            bskierowcywtr.DataSource = db.Kierowca.Where(p => p.Kurs.Data_kursu == DateTime.Today &&( p.Kurs.Godzina_rozpoczecia <= today && all>=today)).ToList();
        }
    }
}
