using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studenci
{
    public partial class AddingDegrees : Form
    {
        public Dictionary<string, double> diction = new Dictionary<string, double>();
        
        public AddingDegrees()
        {
            InitializeComponent();
        }

        private void btoksearching_Click(object sender, EventArgs e)
        { 
            if (string.IsNullOrEmpty(txtsubject.Text) || string.IsNullOrEmpty(txtdegree.Text))
            {
                MessageBox.Show("Wpisz dane w puste miejsca", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
               
                diction.Add(txtsubject.Text, double.Parse(txtdegree.Text));
                txtsubject.Clear();
                txtdegree.Clear();
                MessageBox.Show("Dodano ocene", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Podaj poprawne dane", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btbacksearching_Click(object sender, EventArgs e)
        {
           
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Hide();
        }
    }
}
