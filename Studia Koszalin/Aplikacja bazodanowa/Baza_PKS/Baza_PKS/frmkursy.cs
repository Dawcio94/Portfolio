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
    public partial class frmkursy : Form
    {

        Baza_PKSEntities db = new Baza_PKSEntities();

        public frmkursy()
        {
            InitializeComponent();
            bskursy.DataSource = db.Kurs.ToList();
            
        }

        private void btcbkursy_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdyżurny dyz = new frmdyżurny();
            dyz.ShowDialog();
        }

        private void btedytujkursy_Click(object sender, EventArgs e)
        {
            frmkursyedycja edit = new frmkursyedycja(bskursy.Current as Kurs);
            edit.ShowDialog();
            db.SaveChanges();
            bskursy.DataSource = db.Kurs.ToList();
        }

        private void btdodajkursy_Click(object sender, EventArgs e)
        {
            frmkursyedycja add = new frmkursyedycja(null);
            if (add.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                db.Kurs.Add(add.position);
                db.SaveChanges();
                bskursy.DataSource = db.Kurs.ToList();
            }
        }

        private void btusunkursy_Click(object sender, EventArgs e)
        {
            Kurs toremove = bskursy.Current as Kurs;
            db.Kurs.Remove(toremove);
            db.SaveChanges();
            bskursy.DataSource = db.Kurs.ToList();
        }

        private void btrtyg_Click(object sender, EventArgs e)
        {
            int suma = 0;
            bskursy.DataSource = db.Kurs.Where(p => p.Oznaczenie == tboznaczenie.Text).ToList();
            var all = db.Kurs.Where(p => p.Oznaczenie == tboznaczenie.Text).ToList();
            foreach (Kurs k in all)
            {
                if (DateTime.Today.Subtract(k.Data_kursu.Value).Days <= 7)
                {
                    suma += Convert.ToInt32(k.Ilość_pasażerów);
                }
                tbilosc.Text = suma.ToString();
            }
        }

        private void btsrednia_Click(object sender, EventArgs e)
        {
            bskursy.DataSource = db.Kurs.Where(p => p.Oznaczenie == tboznaczenie.Text).ToList();
            int suma =0;
            int srednia = 0;
            for(int i=0;i<=dgkursy.Rows.Count-1;i++){

                suma += Convert.ToInt32(dgkursy.Rows[i].Cells[2].Value);
                srednia = suma / dgkursy.Rows.Count;
            }
            tbilosc.Text = srednia.ToString();
        }
    }
}
