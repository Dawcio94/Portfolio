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
    public partial class frmautokary : Form
    {
        Baza_PKSEntities db = new Baza_PKSEntities();

        public frmautokary()
        {
            InitializeComponent();
            bsautokar.DataSource = db.Autokar.ToList();
        }

        private void btcbautokary_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdyżurny dyz = new frmdyżurny();
            dyz.ShowDialog();
        }

        private void btdodajautokary_Click(object sender, EventArgs e)
        {
            frmautokaryedycja add = new frmautokaryedycja(null);
            if (add.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                db.Autokar.Add(add.Bus);
                db.SaveChanges();
                bsautokar.DataSource = db.Autokar.ToList();
            }
        }

        private void btedytujautokary_Click(object sender, EventArgs e)
        {
            frmautokaryedycja edit = new frmautokaryedycja(bsautokar.Current as Autokar);
            edit.ShowDialog();
            db.SaveChanges();
            bsautokar.DataSource = db.Autokar.ToList();
        }

        private void btusunautokary_Click(object sender, EventArgs e)
        {
            Autokar toremove = bsautokar.Current as Autokar;
            db.Autokar.Remove(toremove);
            db.SaveChanges();
            bsautokar.DataSource = db.Autokar.ToList();
        }

       

        private void btszukajautokary_Click(object sender, EventArgs e)
        {
            Autokar autoclick = bsautokar.Current as Autokar;
            bskierowca.DataSource = db.Kierowca.Where(p => p.Id_kursu == autoclick.Id_kursu).ToList();
        }
    }
}
