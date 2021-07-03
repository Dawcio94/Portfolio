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

namespace Race
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Car firstCar = null;
        private CarWithInertia secondCar = null;
        private CarWithInertia1 thirdCar = null;

        public MainWindow()
        {
            InitializeComponent();
            firstCar = new Car(FirstCarImage);
            secondCar = new CarWithInertia(SecondCarImage);
            thirdCar = new CarWithInertia1(ThirdCarImage);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.Key)
            {
                case Key.Space:
                    firstCar.Run();
                    secondCar.Run();
                    thirdCar.Run();
                    break;
                case Key.Escape:
                    firstCar.Stop();
                    secondCar.Stop();
                    thirdCar.Stop();
                    break;
            }
        }
    }
}
