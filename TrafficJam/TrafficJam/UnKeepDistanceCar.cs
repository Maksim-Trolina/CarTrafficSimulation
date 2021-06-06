using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficJam
{
    class UnKeepDistanceCar : Car
    {
        int maxSpeed;

        Random random;
        public UnKeepDistanceCar(int maxSpeed, int positionX)
        {
            this.maxSpeed = maxSpeed;

            random = new Random(DateTime.Now.Second);

            PositionX = positionX;
        }
        public override void Move()
        {
            var speed = random.Next(1, maxSpeed);

            PositionX += speed;
        }
    }
}
