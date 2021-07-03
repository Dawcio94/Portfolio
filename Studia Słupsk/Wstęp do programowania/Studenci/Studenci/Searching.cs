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
    public partial class Searching : Form
    {
        public List<Students.Student> list1 { get; set; }
        public List<Students.Student> listm { get; set; }
        public Searching(List<Students.Student>list)
        {
            listm = list;
            InitializeComponent();   
        }
        

        
        private void btbacksearching_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void  btoksearching_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtdata.Text) && string.IsNullOrEmpty(txtid.Text) && string.IsNullOrEmpty(txtsemester.Text))
            {
                MessageBox.Show("Wpisz dane w dowolne miejsce", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int id;
                int semester;
                string name = txtdata.Text;
                Students students = new Students();
                if (txtid.Text != "")
                {

                    id = int.Parse(txtid.Text);
                    semester = 0;
                    list1 = students.Search(id, name, semester, listm);

                }
                else if(txtsemester.Text!="")
                {
                    id = 0;
                    semester = int.Parse(txtsemester.Text);
                    list1 = students.Search(id, name, semester, listm);
                }
                else
                {
                    id = 0;
                    semester = 0;
                    list1 = students.Search(id, name, semester, listm);
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Podaj poprawne dane", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
