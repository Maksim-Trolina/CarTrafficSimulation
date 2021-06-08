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
            //Если frontCar равно null, то впереди нет никаких машин
            if (frontCar == null)
            {
                speed += Acceleration;
            }
            else
            {
                int distance = frontCar.PositionX - PositionX - (Width + frontCar.Width);

                if (distance < speed + Acceleration)
                {
                    speed = 0;
                }
                else if (distance < speed + 3*Acceleration)
                {
                    speed -= Acceleration;
                }
                else
                {
                    speed += Acceleration;
                }
            }

            PositionX += speed;
        }
    }
}
