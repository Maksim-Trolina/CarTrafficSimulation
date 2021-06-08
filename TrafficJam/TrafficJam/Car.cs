using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficJam
{
    //Базовый класс для разных видов машин
    abstract class  Car
    {
        protected int speed;

        protected const int Acceleration = 1;
        public int Width { get; protected set; }
        public int PositionX { get; protected set; }

        public abstract void Move(Car frontCar);
    }
}
