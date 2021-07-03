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
    public partial class frmprzebieg : Form
    {

        Baza_PKSEntities db = new Baza_PKSEntities();
        
        TimeSpan max = new TimeSpan(0, 0, 0);
        
        public frmprzebieg()
        {
            
            InitializeComponent();
            
            bstrasy.DataSource = db.Trasa.ToList();
            Trasa trasaclick = bstrasy.Current as Trasa;
            bsprzebieg.DataSource = db.Przebieg.Where(p => p.Id_trasy == trasaclick.Id_trasy).ToList();


            foreach (Przebieg p in bsprzebieg)
            {
                if (p.Roznica_czasu.Value > max)
                {
                    max = p.Roznica_czasu.Value;
                }
            }
        }
        public TimeSpan getMax(){
            return max;
        }
        
        private void btcbprzebieg_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdyżurny dyz = new frmdyżurny();
            dyz.ShowDialog();
        }

        private void btdodajprzebieg_Click(object sender, EventArgs e)
        {
            frmprzebiegedycja add = new frmprzebiegedycja(null,null);
            if (add.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Trasa trasaclick = bstrasy.Current as Trasa;
                db.Przebieg.Add(add.kolejka);
                db.SaveChanges();
                bsprzebieg.DataSource = db.Przebieg.Where(p => p.Id_trasy == trasaclick.Id_trasy).ToList();
            }
        }

        private void btedytujprzebieg_Click(object sender, EventArgs e)
        {
            Trasa trasaclick = bstrasy.Current as Trasa;
            frmprzebiegedycja edit = new frmprzebiegedycja(bsprzebieg.Current as Przebieg,bstrasy.Current as Trasa);
            edit.ShowDialog();
            db.SaveChanges();
            bsprzebieg.DataSource = db.Przebieg.Where(p => p.Id_trasy == trasaclick.Id_trasy).ToList();
        }

        private void btusunprzebieg_Click(object sender, EventArgs e)
        {
            Trasa trasaclick = bstrasy.Current as Trasa;
            Przebieg toremove = bsprzebieg.Current as Przebieg;
            db.Przebieg.Remove(toremove);
            db.SaveChanges();
            bsprzebieg.DataSource = db.Przebieg.Where(p => p.Id_trasy == trasaclick.Id_trasy).ToList();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Trasa trasaclick = bstrasy.Current as Trasa;
            bsprzebieg.DataSource = db.Przebieg.Where(p => p.Id_trasy== trasaclick.Id_trasy).ToList();
        }
    }
}
