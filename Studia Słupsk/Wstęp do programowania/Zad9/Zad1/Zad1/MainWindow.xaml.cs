using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zad1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
            textBlock.Text="";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            i++;
            textBlock.Text = i.ToString();            
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            i = 0;
            textBlock.Text = "";
        }
    }
}
