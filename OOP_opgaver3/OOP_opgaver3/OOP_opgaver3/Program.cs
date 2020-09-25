using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace OOP_opgaver3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            List<Car> cars = new List<Car>()
            {
                new Car(){Make="Skoda", Model = "Fabia", Price = 60000},
                new Car(){Make="Fisker", Model = "Karma", Price = 2},
                new Car(){Make="ASkoda", Model = "Fabia", Price = 50000}
            };

              cars.Sort();

            foreach(var car in cars)
            {
                Console.WriteLine(car.Price);
            }

            cars.Sort(new CarComparer());

            foreach (var car in cars)
            {
                Console.WriteLine(car.Price);
            }

            cars.Sort(new CarComparer2());

            foreach (var car in cars)
            {
                Console.WriteLine(car.Price);
            }
        #endregion

            
        }

    }

    class Car : IComparable
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }

        public int CompareTo(object car)
        {
            return Price.CompareTo(((Car)car).Price);
        }
    }

    class CarComparer : IComparer<Car>
    {
        public int Compare([AllowNull] Car x, [AllowNull] Car y)
        {
            int MakeCompVal = x.Make.CompareTo(y.Make);
            if (MakeCompVal != 0)
                return MakeCompVal;

            int ModelCompVal = x.Model.CompareTo(y.Model);
            if (ModelCompVal != 0)
                return ModelCompVal;

            return (x.Price.CompareTo(y.Price));
        }
    }

    class CarComparer2 : IComparer<Car>
    {
        public int Compare([AllowNull] Car x, [AllowNull] Car y)
        {
            int ModelCompVal = x.Model.CompareTo(y.Model);
            if (ModelCompVal != 0)
                return ModelCompVal;

            return -1*(x.Price.CompareTo(y.Price));
        }
    }

}
