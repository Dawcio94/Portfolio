using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Zad2
{
    /// <summary>
    /// Logika interakcji dla klasy Open.xaml
    /// </summary>
    public partial class Open : Window
    {
        public Open()
        {
            InitializeComponent();
            DriveInfo dr=new DriveInfo.
            DirectoryInfo inf = new DirectoryInfo("*");
            foreach(FileInfo fi in inf.GetFiles() )
            {
                listBox.Items.Add(fi.ToString());
         
            }

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            
        }

      
    }
}
