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
    public partial class Adding : Form
    {
        int max = 0;
        public Students.Student uczen { get; set; }
        Dictionary<string, double> dictionary = new Dictionary<string, double>();
        public Adding(int max)
        {
            this.max = max;
            
            InitializeComponent();
            lblid.Text = (max + 1).ToString();
        }

        private void btoksearching_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtdata.Text) || string.IsNullOrEmpty(txtsemester.Text))
            {
                MessageBox.Show("Wpisz dane w puste miejsca", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                
                int id = max + 1;
                string dane=txtdata.Text;
                int semester=int.Parse(txtsemester.Text);
                
                Students students  = new Students();
                uczen=students.Add(id, dane, semester,dictionary);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("Dodano studenta", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button1_Click(object sender, EventArgs e)
        {
            AddingDegrees addingDegrees = new AddingDegrees();
            if (addingDegrees.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dictionary = addingDegrees.diction;
            }
        }
    }
}

