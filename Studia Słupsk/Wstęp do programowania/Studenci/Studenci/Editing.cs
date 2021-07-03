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
    public partial class Editing : Form
    {
        public Students.Student uczen { get; set; }
        public Students.Student uczenad { get; set; }
        public List<Students.Student> listm { get; set; }
        public Editing(List<Students.Student> list)
        {
            listm = list;
            InitializeComponent();
        }

        private void btoksearching_Click(object sender, EventArgs e)
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
            uczen = students.Choose(id, name, listm);
            Detailsediting detailsediting = new Detailsediting(uczen,listm);
            if (detailsediting.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                uczenad = detailsediting.uczena;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void btbacksearching_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
