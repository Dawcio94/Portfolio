using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace Race
{
    public class CarWithInertia : Car
    {
        #region Fields

        protected bool stopping = false;

        public CarWithInertia(Rectangle carImage) : base(carImage)
        {
            MaxSpeed = 20;
        }

        #endregion

        #region Constructors

        #endregion

        #region Properties

        public int Acceleration { get; protected set; } = 2;
        public int Deceleration { get; protected set; } = -3;

        #endregion

        #region Methods

        protected override void SingleStep()
        {
            if (CurrentSpeed < MaxSpeed || CurrentSpeed > 0)
                CurrentSpeed += !stopping ? Acceleration : Deceleration;
            
            MoveCar();
        }

        public override void Run()
        {
            stopping = false;
            CurrentSpeed++;

            MovemenentLoop();
        }

        public override void Stop()
        {
            stopping = true;
        }

        #endregion
    }
}
