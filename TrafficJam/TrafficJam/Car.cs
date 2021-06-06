using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficJam
{
    abstract class  Car
    {
        public int PositionX { get; protected set; }

        public abstract void Move();
    }
}
