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
    public partial class frmmiejscowosci : Form
    {

        Baza_PKSEntities db = new Baza_PKSEntities();

        public frmmiejscowosci()
        {
            InitializeComponent();
            bsmiejscowosci.DataSource = db.Miejscowości.ToList();
        }

        private void btcbmiejscowosci_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdyżurny dyz = new frmdyżurny();
            dyz.ShowDialog();
        }

        private void btdodajmiejscowosci_Click(object sender, EventArgs e)
        {
            frmmiejscowosciedycja add = new frmmiejscowosciedycja(null);
            if (add.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                db.Miejscowości.Add(add.city);
                db.SaveChanges();
                bsmiejscowosci.DataSource = db.Miejscowości.ToList();
            }
        }

        private void btedytujmiejscowosci_Click(object sender, EventArgs e)
        {
            frmmiejscowosciedycja edit = new frmmiejscowosciedycja(bsmiejscowosci.Current as Miejscowości);
            edit.ShowDialog();
            db.SaveChanges();
            bsmiejscowosci.DataSource = db.Miejscowości.ToList();
        }

        private void btusunmiejscowosci_Click(object sender, EventArgs e)
        {
            Miejscowości toremove = bsmiejscowosci.Current as Miejscowości;
            db.Miejscowości.Remove(toremove);
            db.SaveChanges();
            bsmiejscowosci.DataSource = db.Miejscowości.ToList();
        }
    }
}
