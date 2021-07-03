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
    public partial class Detailsediting : Form
    {
        public Students.Student uczenr { get; set; }
        public Students.Student uczena { get; set; }
        public List<Students.Student> listm { get; set; }
        public Dictionary<string, double> dictionary { get; set; }
        public Detailsediting(Students.Student student, List<Students.Student> list)
        {
            listm = list;
            uczenr = student;
            InitializeComponent();
            label6.Text = uczenr.Id.ToString();
            txtdata.Text = uczenr.Name;
            txtsemester.Text = uczenr.Semester.ToString();
           
        }

        private void btbacksearching_Click(object sender, EventArgs e)
        {
            this.Hide();
            
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
                int id = uczenr.Id;
                string name = uczenr.Name;
                Students students = new Students();
                uczenr = students.Delete(id, name, listm);
                listm.Remove(uczenr);
                string namea = txtdata.Text;
                int semestera = int.Parse(txtsemester.Text);
                uczena = students.Add(id, namea, semestera,dictionary);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("Zedytowano dane studenta", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Podaj poprawne dane", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
           
        }

        private void btdegrees_Click(object sender, EventArgs e)
        {
            Editdegrees editdegrees = new Editdegrees(uczenr.Dictionary);
            if (editdegrees.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dictionary = editdegrees.diction;
            }
        }
    }
}
