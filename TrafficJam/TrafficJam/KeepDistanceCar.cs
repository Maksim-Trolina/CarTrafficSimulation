using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficJam
{
    //Производный класс машины, представляет машину соблюдающую дистанцию
    class KeepDistanceCar : Car
    {
        public KeepDistanceCar(int speed, int positionX, int width)
        {
            this.speed = speed;

            Width = width;

            PositionX = positionX;
        }

        public override void Move(Car frontCar)
        {
            if (frontCar == null)
            {
                PositionX += speed;

                return;
            }

            int distance = frontCar.PositionX - PositionX - (Width + frontCar.Width);

            if (distance > speed + speed/2)
            {
                PositionX += speed;
            }
            else
            {
                PositionX += Math.Min(speed, distance);
            }
        }
    }
}
