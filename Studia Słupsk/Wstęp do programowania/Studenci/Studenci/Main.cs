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
   
    public partial class Main : Form
    {
        
        Students studenci = new Students();
        public List<Students.Student> list { get; set; }
        public Dictionary<string,double>diction { get; set; }
        int max;
        public Main()
        {
            list = studenci.Show();
            
            InitializeComponent();
            Students.Columns[5].Width = 0;
            operation.Text = "";
            label2.Text = "";
           
            Students.Items.Clear();
            foreach (var s in list)
            {
                List<double> degrees = new List<double>(s.Dictionary.Values);
                ListViewItem item = Students.Items.Add(new ListViewItem(new string[] { s.Id.ToString(), s.Name, s.Semester.ToString() }));
                foreach (var d in degrees) {
                    item.SubItems.Add(d.ToString());
                }
                max = s.Id;
            }
            Students.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
        }
      

        private void Search_Click(object sender, EventArgs e)
        { 
            Searching searching = new Searching(list);
            if (searching.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                if (searching.list1.Count == 0)
                {
                    MessageBox.Show("Nie znaleziono studenta", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Students.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.HeaderSize);
                    
                    Students.Items.Clear();
                    foreach (var s in searching.list1)
                    {
                        int i = 0;
                        double sum = 0;
                        List<double> degrees = new List<double>(s.Dictionary.Values);
                        ListViewItem item = Students.Items.Add(new ListViewItem(new string[] { s.Id.ToString(), s.Name, s.Semester.ToString() }));
                        foreach (var d in degrees)
                        {
                            
                            sum = sum + d;
                            i++;
                            item.SubItems.Add(d.ToString());
                        }
                        double aver = sum / i;
                        item.SubItems.Add(aver.ToString());
                    }
                    Students.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
                }  
            }  
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Adding adding = new Adding(max);
            if (adding.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                list.Add(adding.uczen);
                max = adding.uczen.Id;
                Students.Columns[5].Width = 0;
                Students.Items.Clear();
                foreach (var s in list)
                {
                    List<double> degrees = new List<double>(s.Dictionary.Values);
                    ListViewItem item = Students.Items.Add(new ListViewItem(new string[] { s.Id.ToString(), s.Name, s.Semester.ToString() }));
                    foreach (var d in degrees)
                    {
                        item.SubItems.Add(d.ToString());
                    }
                    max = s.Id;
                }
                Students.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Deleting deleting = new Deleting(list);
            if (deleting.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                list.Remove(deleting.uczen);
                Students.Columns[5].Width = 0;
                Students.Items.Clear();
                foreach (var s in list)
                {
                    List<double> degrees = new List<double>(s.Dictionary.Values);
                    ListViewItem item = Students.Items.Add(new ListViewItem(new string[] { s.Id.ToString(), s.Name, s.Semester.ToString() }));
                    foreach (var d in degrees)
                    {
                        item.SubItems.Add(d.ToString());
                    }
                    
                }
                Students.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Editing editing = new Editing(list);
            if (editing.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                list.Add(editing.uczenad);
                Students.Columns[5].Width = 0;
                Students.Items.Clear();
                foreach (var s in list)
                {
                    List<double> degrees = new List<double>(s.Dictionary.Values);
                    ListViewItem item = Students.Items.Add(new ListViewItem(new string[] { s.Id.ToString(), s.Name, s.Semester.ToString() }));
                    foreach (var d in degrees)
                    {
                        item.SubItems.Add(d.ToString());
                    }
                }
                Students.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }
        
        private void btaverage_Click(object sender, EventArgs e)
        {
            int i = 0;
            double average,sum=0;
            foreach(var s in list)
            {
                List<double> degrees = new List<double>(s.Dictionary.Values);
                foreach (var d in degrees)
                {
                    sum = sum + d;
                    i++;
                }
            }
            average = sum / i;
            operation.Text = "Srednia ocen równa się";
            label2.Text = average.ToString();
        }

        private void btmedian_Click(object sender, EventArgs e)
        {
            operation.Text = "Mediana ocen równa się";
            label2.Text = ""+studenci.SelectionSort(list).ToString();

        }

        private void btstandard_Click(object sender, EventArgs e)
        {
            operation.Text = "Odchylenie standardowe";
            label2.Text = "równa się "+ studenci.Standard(list).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students.Items.Clear();
            Students.Columns[5].Width = 0;

            foreach (var s in list)
            {
                List<double> degrees = new List<double>(s.Dictionary.Values);
                ListViewItem item = Students.Items.Add(new ListViewItem(new string[] { s.Id.ToString(), s.Name, s.Semester.ToString() }));
                foreach (var d in degrees)
                {
                    item.SubItems.Add(d.ToString());
                }
            }
            Students.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Zamknąć program ??", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
               // studenci.ToXML(list);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
