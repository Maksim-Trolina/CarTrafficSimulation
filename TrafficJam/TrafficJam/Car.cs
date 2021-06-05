using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficJam
{
    class Car
    {
        decimal speed;

        public decimal PositionX { get; set; }

        public Car(decimal speed, decimal positionX)
        {
            this.speed = speed;

            PositionX = positionX;
        }

        public void Move()
        {
            PositionX += speed;
        }
    }
}
