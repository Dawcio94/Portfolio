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
    public partial class frmtrasyedycja : Form
    {
        Baza_PKSEntities db = new Baza_PKSEntities();
        private Trasa trasa;
        
        private bool toadd;

        public frmtrasyedycja(Trasa trasa)
        {
            InitializeComponent();
            bsmiastopocz.DataSource = db.Miejscowości.ToList();
            bsmiastokon.DataSource = db.Miejscowości.ToList();
            this.trasa = trasa;
            
            if (trasa == null )
            {
                toadd = true;
                this.trasa = new Trasa();
            }
            else
            {
                toadd = false;
                cbmiastopocz.Text = trasa.Miejscowości.Nazwa_miejscowosci;
                cbmiastokoniec.Text = trasa.Miejscowości1.Nazwa_miejscowosci;
                tboznacztrasy.Text = trasa.Oznaczenie_trasy;
            }
        }


        public Trasa route
        {
            get
            { return trasa; }

            set
            {
                trasa = value;
            }
        }

        private void btokedittrasy_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tboznacztrasy.Text)){

                MessageBox.Show("Wpisz dane w puste miejsca", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            try{
            trasa.Miejscowości.Nazwa_miejscowosci = cbmiastopocz.Text;
            trasa.Miejscowości1.Nazwa_miejscowosci=cbmiastokoniec.Text;
            trasa.Oznaczenie_trasy = tboznacztrasy.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Hide();
            }
            catch(Exception ex){}
        }

        private void btanedittrasy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
