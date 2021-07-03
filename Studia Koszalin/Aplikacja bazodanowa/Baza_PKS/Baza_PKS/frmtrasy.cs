using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baza_PKS
{
    public partial class frmtrasy : Form
    {

        Baza_PKSEntities db = new Baza_PKSEntities();

        public frmtrasy()
        {
            InitializeComponent();
            bstrasy.DataSource = db.Trasa.ToList();
        }

        private void btcbtrasy_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdyżurny dyz = new frmdyżurny();
            dyz.ShowDialog();
        }

        private void btusuntrasy_Click(object sender, EventArgs e)
        {
            Trasa toremove = bstrasy.Current as Trasa;
            db.Trasa.Remove(toremove);
            db.SaveChanges();
            bstrasy.DataSource = db.Trasa.ToList();
        }

        private void btdodajtrasy_Click(object sender, EventArgs e)
        {
            frmtrasyedycja add = new frmtrasyedycja(null);
            if (add.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                db.Trasa.Add(add.route);
                db.SaveChanges();
                bstrasy.DataSource = db.Trasa.ToList();
            }
        }

        private void btedytujtrasy_Click(object sender, EventArgs e)
        {
            frmtrasyedycja edit = new frmtrasyedycja(bstrasy.Current as Trasa);
            edit.ShowDialog();
            db.SaveChanges();
            bstrasy.DataSource = db.Trasa.ToList();
        }
    }
}
