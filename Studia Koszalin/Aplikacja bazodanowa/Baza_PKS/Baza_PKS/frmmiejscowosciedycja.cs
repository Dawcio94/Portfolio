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
    public partial class frmmiejscowosciedycja : Form
    {

        private Miejscowości miejscowosc;
        private bool toadd;

        public frmmiejscowosciedycja(Miejscowości miejscowosc)
        {
            InitializeComponent();
            this.miejscowosc=miejscowosc;
            if (miejscowosc == null)
            {
                toadd = true;
                this.miejscowosc = new Miejscowości();
            }
            else
            {
                toadd = false;
                tbnazwamiejscowosci.Text = miejscowosc.Nazwa_miejscowosci;
            }
        }
        public Miejscowości city
        {
            get
            { return miejscowosc; }

            set
            {
                miejscowosc = value;
            }
        }

        private void btokeditmiejscowosci_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(tbnazwamiejscowosci.Text)){

                MessageBox.Show("Wpisz dane w puste miejsca", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try{
            miejscowosc.Nazwa_miejscowosci = tbnazwamiejscowosci.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Hide();
            }
            catch(Exception ex){}
        }

        private void btaneditmiejscowosci_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
