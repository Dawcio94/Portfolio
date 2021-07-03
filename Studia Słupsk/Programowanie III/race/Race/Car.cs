using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace Race
{
    public class Car
    {
        #region Fields

        protected Rectangle carImage = null;

        #endregion

        #region Constructors

        public Car(Rectangle carImage)
        {
            this.carImage = carImage;
        }

        #endregion

        #region Properties

        public int CurrentSpeed { get; protected set; } = 0;
        public int MaxSpeed { get; protected set; } = 5;

        #endregion

        #region Methods

        protected void MoveCar()
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                Canvas.SetLeft(carImage, Canvas.GetLeft(carImage) + CurrentSpeed);
                
            });
            Thread.Sleep(50);
        }

        protected virtual void SingleStep()
        {
            MoveCar();
        }

        protected void MovemenentLoop()
        {
            Task.Run(() =>
            {
                while (CurrentSpeed > 0)
                {
                    SingleStep();
                }
            });
        }

        public virtual void Run()
        {
            CurrentSpeed = MaxSpeed;
            MovemenentLoop();
        }

        public virtual void Stop()
        {
            CurrentSpeed = 0;
        }

        #endregion
    }
}
