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
    public partial class frmdyżurny : Form
    {
        public frmdyżurny()
        {
            InitializeComponent();
        }

        private void btautokary_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmautokary auto = new frmautokary();
            auto.ShowDialog();
        }

        private void btkierowcy_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmkierowcy driver = new frmkierowcy();
            driver.ShowDialog();
        }

        private void bttrasy_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmtrasy route = new frmtrasy();
            route.ShowDialog();
        }

        private void btkurs_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmkursy kurs = new frmkursy();
            kurs.ShowDialog();
        }

        private void btmiejscowosci_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmiejscowosci city = new frmmiejscowosci();
            city.ShowDialog();
        }

        private void btprzebieg_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprzebieg process = new frmprzebieg();
            process.ShowDialog();
        }

        private void btwyloguj_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPasazer frmP = new frmPasazer();
            frmP.ShowDialog();
        }
    }
}
