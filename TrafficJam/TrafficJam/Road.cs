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
        int maxSpeed;

        double percentageCars;

        int startPositionX;

        const uint MaxCars = 10;

        uint countCars = 0;

        Random random;
        public SortedSet<Car> Cars { get; set; }

        public Road(uint countCars, double percentageCars, int maxSpeed, int startPositionX)
        {
            this.maxSpeed = maxSpeed;

            this.startPositionX = startPositionX;

            this.percentageCars = percentageCars;

            random = new Random(DateTime.Now.Second);

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

        bool IsEvenlyMovingCar()
        {
            double num = random.NextDouble();

            return !(percentageCars / 100 > num);
        }

        Car CreateCar()
        {
            Car car;

            if (IsEvenlyMovingCar())
            {
                var speed = random.Next(1, maxSpeed);

                car = new KeepDistanceCar(speed, startPositionX);
            }
            else
            {
                car = new UnKeepDistanceCar(maxSpeed, startPositionX);
            }

            return car;
        }
    }
}
