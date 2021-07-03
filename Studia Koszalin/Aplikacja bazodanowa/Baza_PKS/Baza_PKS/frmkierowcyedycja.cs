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
    public partial class frmkierowcyedycja : Form
    {
        private Kierowca kierowca;
        private Kurs kurs;
        private bool toadd;

        public frmkierowcyedycja(Kierowca kierowca,Kurs kurs)
        {
            InitializeComponent();
            this.kierowca = kierowca;
            this.kurs = kurs;
            if (kierowca == null && kurs==null)
            {
                toadd = true;
                this.kierowca = new Kierowca();
            }
            else
            {
                toadd = false;
                tbimienazwisko.Text = kierowca.Imie_Nazwisko;
                tbidkursu.Text = kurs.Oznaczenie;
            }
        }


        public Kierowca Driver
        {
            get
            { return kierowca; }

            set
            {
                kierowca = value;
            }
        }

        private void btokeditkierowcy_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbimienazwisko.Text) || string.IsNullOrEmpty(tbidkursu.Text)){

                MessageBox.Show("Wpisz dane w puste miejsca", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try{
            kierowca.Imie_Nazwisko = tbimienazwisko.Text;
            kurs.Oznaczenie = tbidkursu.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Hide();
            }
            catch(Exception ex)
            {}
        }

        private void btaneditkierowcy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
