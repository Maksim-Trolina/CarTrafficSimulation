using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficJam
{
    class KeepDistanceCar : Car
    {
        int speed;
        public KeepDistanceCar(int speed, int positionX)
        {
            this.speed = speed;

            PositionX = positionX;
        }

        public override void Move()
        {
            PositionX += speed;
        }
    }
}
