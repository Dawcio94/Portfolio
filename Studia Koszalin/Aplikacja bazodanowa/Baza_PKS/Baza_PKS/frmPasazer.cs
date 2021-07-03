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
    public partial class frmPasazer : Form
    {

        Baza_PKSEntities db = new Baza_PKSEntities();
        
        public frmPasazer()
        {
            InitializeComponent();
            bspoczatek.DataSource = db.Miejscowości.ToList();
            bskoniec.DataSource = db.Miejscowości.ToList();

        }

        private void btlog_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmlog log = new frmlog();
            log.ShowDialog();
        }

        private void btwyszukaj_Click(object sender, EventArgs e)
        {
            TimeSpan godz = TimeSpan.Parse(tbgodzina.Text);
            bskurs.DataSource = db.Kurs.Where(p => p.Data_kursu == dtpdatapasazer.Value.Date && p.Godzina_rozpoczecia>=godz).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Kurs kurslick = bskurs.Current as Kurs;
            string pocz = cbprzystanekpocz.SelectedValue.ToString();
            string kon = cbprzystanekkon.SelectedValue.ToString();
            decimal poczid = decimal.Parse(pocz);
            decimal konid = decimal.Parse(kon);
            bsprzebieg.DataSource = db.Przebieg.Where(p => p.Id_trasy == kurslick.Id_trasy && (p.Miejscowości.Id_miejscowosci>= poczid && p.Miejscowości.Id_miejscowosci<=konid)).ToList();
           
           

        }

        private void frmPasazer_Load(object sender, EventArgs e)
        {

        }
    }
}
