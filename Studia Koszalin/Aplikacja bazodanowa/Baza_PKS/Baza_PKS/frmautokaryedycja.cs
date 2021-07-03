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
    public partial class frmautokaryedycja : Form
    {
        Baza_PKSEntities db = new Baza_PKSEntities();
        private Autokar autokar;
        private bool toadd;

        public frmautokaryedycja(Autokar autokar)
        {
            InitializeComponent();
            this.autokar = autokar;
            if (autokar == null)
            {
                toadd = true;
                this.autokar = new Autokar();
            }
            else
            {
                toadd = false;
                tbnrrejst.Text = autokar.Nr_rejestr;
                tbmarka.Text = autokar.Marka;
                tbmodel.Text = autokar.Model;
                tbmiejsca.Text = autokar.Liczba_miejsc.ToString();
                tbidkursu.Text = autokar.Kurs.Oznaczenie;
            }
        }
        public Autokar Bus
        {
            get
            { return autokar; }

            set
            {
                autokar = value;
            }
        }

        private void btokeditautokar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbnrrejst.Text) || string.IsNullOrEmpty(tbmarka.Text) || string.IsNullOrEmpty(tbmodel.Text) || string.IsNullOrEmpty(tbmiejsca.Text) || string.IsNullOrEmpty(tbidkursu.Text))
            {
                MessageBox.Show("Wpisz dane w puste miejsca", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                autokar.Nr_rejestr = tbnrrejst.Text;
                autokar.Marka = tbmarka.Text;
                autokar.Model = tbmodel.Text;
                autokar.Liczba_miejsc = decimal.Parse(tbmiejsca.Text);
                autokar.Kurs.Oznaczenie = tbidkursu.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Hide(); 
            }
            catch (Exception ex)
            {
            }
        }

        private void btaneditautokar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
