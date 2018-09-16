using System;

namespace Car_Class_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car;
            
            

            car = new Car("Red", "Altima");
            Console.WriteLine(car.Describe());

            car = new Car("Green", "Elantra");
            Console.WriteLine(car.Describe());










            Console.ReadLine();

        }
    }
}
