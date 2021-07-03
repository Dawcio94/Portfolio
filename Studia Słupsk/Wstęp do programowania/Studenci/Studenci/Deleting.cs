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
    public partial class Deleting : Form
    {
        public Students.Student uczen { get; set; }
        public List<Students.Student> listm { get; set; }
        public Deleting(List<Students.Student> list)
        {
            listm = list;
            InitializeComponent();
        }

        private void btoksearching_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtdata.Text) && string.IsNullOrEmpty(txtid.Text))
            {
                MessageBox.Show("Wpisz dane w dowolne miejsce", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int id;
                if (txtid.Text == "")
                {
                    id = 0;
                }
                else
                {
                    id = int.Parse(txtid.Text);
                }
                string name = txtdata.Text;
                
                Students students = new Students();
                uczen=students.Delete(id, name, listm);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("Usunięto studenta", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Podaj poprawne dane", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btbacksearching_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }
    }
}
