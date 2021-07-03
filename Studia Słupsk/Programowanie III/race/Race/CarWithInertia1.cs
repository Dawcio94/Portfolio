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
    class CarWithInertia1 : CarWithInertia
    {

        public CarWithInertia1(Rectangle carImage) : base(carImage)
        {
            MaxSpeed = 20;
        }

        public new int Acceleration { get; protected set; } = 1;
        public new int Deceleration { get; protected set; } = -5;

        async public override void Run()
        {
            await Task.Run(()=>
            {
                Thread.Sleep(200);
                stopping = false;
                CurrentSpeed++;

                MovemenentLoop();
            });
        }

    }
}
