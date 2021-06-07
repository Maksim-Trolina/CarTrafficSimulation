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

        //Максимальное число машин которое может быть на дороге
        uint maxCars = 10;

        int widthCar;

        int finishPos;

        //Кол-во машин, которые уже проехали всю дорогу
        public int CarsFinished { get; private set; }

        Random random;
        public SortedSet<Car> Cars { get; set; }

        public Road(double percentageCars, int maxSpeed, int startPositionX, int widthCar, int finishPos, uint maxCars)
        {
            this.maxSpeed = maxSpeed;

            this.startPositionX = startPositionX;

            this.percentageCars = percentageCars;

            this.widthCar = widthCar;

            this.finishPos = finishPos;

            this.maxCars = maxCars;

            random = new Random(DateTime.Now.Second);

            var comparer = new CarComparer();

            Cars = new SortedSet<Car>(comparer);
        }
        //Двигает все машины
        public void MoveCars()
        {
            RemoveCars();

            AddCar();

            Car carFront = null;

            foreach (var car in Cars)
            {
                car.Move(carFront);

                carFront = car;
            }
        }

        void AddCar()
        {
            if (Cars.Count < maxCars && (Cars.Count == 0 || Cars.Count < maxCars && Cars.Last().PositionX > 2 * widthCar + (maxSpeed+1)))
            {
                var car = CreateCar();

                Cars.Add(car);
            }
        }

        //Удаляет машины, которые проехали всю дорогу
        void RemoveCars()
        {
            CarsFinished += Cars.Where(x => x.PositionX > finishPos).Count();

            Cars.RemoveWhere(x => x.PositionX > finishPos);
        }

        //Рандом, определяющий какую машину надо создавать
        bool IsEvenlyMovingCar()
        {
            double num = random.NextDouble() * 100;

            return percentageCars > num;
        }

        Car CreateCar()
        {
            Car car;

            var startSpeed = random.Next(1, maxSpeed);

            if (IsEvenlyMovingCar())
            {
                car = new KeepDistanceCar(startSpeed, startPositionX, widthCar);
            }
            else
            {
                car = new UnKeepDistanceCar(startSpeed, startPositionX, widthCar);
            }

            return car;
        }
    }
}
