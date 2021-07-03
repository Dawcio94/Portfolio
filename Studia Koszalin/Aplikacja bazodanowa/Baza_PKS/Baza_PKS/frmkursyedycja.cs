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
    public partial class frmkursyedycja : Form
    {

        private Kurs kurs;
        private bool toadd;

        public frmkursyedycja(Kurs kurs)
        {
            InitializeComponent();
            this.kurs = kurs;
            if (kurs == null)
            {
                toadd = true;
                this.kurs = new Kurs();
            }
            else
            {
                toadd = false;
                tboznaczniekursu.Text = kurs.Oznaczenie;
                dtpkurs.Value = kurs.Data_kursu.Value;
                tbiloscpasazerow.Text = kurs.Ilość_pasażerów.ToString();
                tbgodzrozp.Text = kurs.Godzina_rozpoczecia.ToString();
                tbidtrasy.Text = kurs.Trasa.Oznaczenie_trasy;

            }
        }
        public Kurs position
        {
            get
            { return kurs; }

            set
            {
                kurs = value;
            }
        }

        private void btokeditkurs_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tboznaczniekursu.Text) || string.IsNullOrEmpty(tbiloscpasazerow.Text) || string.IsNullOrEmpty(tbgodzrozp.Text) || string.IsNullOrEmpty(tbidtrasy.Text))
            {

                MessageBox.Show("Wpisz dane w puste miejsca", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                kurs.Oznaczenie = tboznaczniekursu.Text;
                kurs.Data_kursu = dtpkurs.Value.Date;
                kurs.Ilość_pasażerów = decimal.Parse(tbiloscpasazerow.Text);
                kurs.Godzina_rozpoczecia = TimeSpan.Parse(tbgodzrozp.Text);
                kurs.Trasa.Oznaczenie_trasy = tbidtrasy.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Hide();
            }
            catch (Exception ex) { }
        }

        private void btaneditkurs_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
