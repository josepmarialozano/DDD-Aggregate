using System;

namespace DDDAggregate {
    class Program {
        static void Main(string[] args) {
            Domain domain = new Domain();
            Car car = domain.GetCar();
            Console.WriteLine(car.ToString());
            domain.flatTyre(1);
            Console.WriteLine(car.ToString());
        }
    }
}
