using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficJam
{
    class CarComparer : IComparer<Car>
    {
        public int Compare(Car car1, Car car2)
        {
            if (car1.PositionX == car2.PositionX)
                return 0;

            return car1.PositionX < car2.PositionX ? 1 : -1;
        }
    }
}
