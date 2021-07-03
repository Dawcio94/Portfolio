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
    public partial class frmprzebiegedycja : Form
    {
        private Przebieg przebieg;
        private Trasa trasa;
        private bool toadd;

        Baza_PKSEntities db = new Baza_PKSEntities();

        public frmprzebiegedycja(Przebieg przebieg,Trasa trasa)
        {
            InitializeComponent();
            bsmiasto.DataSource = db.Miejscowości.ToList();
            this.przebieg = przebieg;
            this.trasa = trasa;
            if (przebieg == null && trasa==null)
            {
                toadd = true;
                this.przebieg = new Przebieg();
            }
            else
            {
                toadd = false;
                cbmiasto.Text = przebieg.Miejscowości.Nazwa_miejscowosci;
                tbidtrasy.Text = trasa.Oznaczenie_trasy;
                tbroznicaczasu.Text = przebieg.Roznica_czasu.ToString();
                tbkolejnosc.Text = przebieg.Kolejnosc.ToString();
            }
        }

        public Przebieg kolejka
        {
            get
            { return przebieg; }

            set
            {
                przebieg = value;
            }
        }

        private void btokeditprzebieg_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(tbidtrasy.Text) || string.IsNullOrEmpty(tbroznicaczasu.Text) || string.IsNullOrEmpty(tbkolejnosc.Text)){

                MessageBox.Show("Wpisz dane w puste miejsca", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            try{
            przebieg.Miejscowości.Nazwa_miejscowosci = cbmiasto.Text;
            trasa.Oznaczenie_trasy = tbidtrasy.Text;
            przebieg.Roznica_czasu = TimeSpan.Parse(tbroznicaczasu.Text);
            przebieg.Kolejnosc = decimal.Parse(tbkolejnosc.Text);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Hide();
            }
            catch(Exception ex){}
        }

        private void btaneditprzebieg_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        
    }
}
