using System;
using System.Collections.Generic;  // add this when doing lists
namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {  //dot. notation way
            Car firstCar = new Car(); // Create a new instance of the Car class constructor{Car ()} method has new and (), type is Car = class name (not var)
            firstCar.Make = "Honda";
            firstCar.Model = "Element";
            firstCar.Year = 2008;

            // 2nd way object initializer way, new car
            var mazda = new Car()  // new object called Mazda, usec Car class as blueprint
            {
                Make = "Mazda",
                Model = "Who knows",
                Year = 2052  // because I can
            };

            //3rd way passing thru constructor way
            var jeep = new Car("Jeep", "Wrangler", 2174); //damn well better self drive

            // print out
            var carList = new List<Car>() { firstCar, mazda, jeep };  // List<type> remember type is name of class so = Car, List<car> constructor type Car

            foreach (var carInfo in carList)
            {
                Console.WriteLine($"{carInfo.Make} {carInfo.Model} {carInfo.Year}");
            }
            
        }


    }
}
