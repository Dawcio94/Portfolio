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
    public partial class frmlog : Form
    {

        public frmlog()
        {
            InitializeComponent();
        }

        private void btlog_Click(object sender, EventArgs e)
        {
            string login = tblogin1.Text.ToString();
            string haslo = tbhaslo1.Text.ToString();
            if (login == "admin" && haslo == "admin")
            {
                this.Hide();
                frmdyżurny dyz = new frmdyżurny();
                dyz.ShowDialog();
            }

        }

        private void btcblog_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPasazer frmP = new frmPasazer();
            frmP.ShowDialog();
        }
    }
}
