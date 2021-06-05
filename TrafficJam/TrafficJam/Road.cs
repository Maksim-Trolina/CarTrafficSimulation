using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficJam
{
    class Road
    {
        decimal maxSpeed;

        decimal percentageCars;

        decimal startPositionX;

        const uint MaxCars = 10;

        uint countCars = 0;
        public SortedSet<Car> Cars { get; set; }

        public Road(uint countCars, decimal percentageCars, decimal maxSpeed, decimal startPositionX)
        {
            this.maxSpeed = maxSpeed;

            this.startPositionX = startPositionX;

            this.percentageCars = percentageCars;

            var comparer = new CarComparer();

            Cars = new SortedSet<Car>(comparer);
        }

        public void MoveCars()
        {
            AddCar();

            foreach (var car in Cars)
            {
                car.Move();
            }
        }

        void AddCar()
        {
            if (countCars == 0 || countCars < MaxCars && Cars.First().PositionX > 100)
            {
                var car = CreateCar();

                Cars.Add(car);

                countCars++;
            }
        }

        Car CreateCar()
        {
            var random = new Random(DateTime.Now.Second);

            var speed = /*(decimal)random.Next(0, (int) maxSpeed);*/10;

            var car = new Car(speed, 0);

            return car;
        }
    }
}
