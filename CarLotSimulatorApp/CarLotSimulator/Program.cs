using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
        
    {
        public static string make { get; private set; }
        public static string model { get; private set; }
        public static int year { get; private set; }
        public static string EngineNoise { get; private set; }
        public static string HonkNoise { get; private set; }
        public static bool IsDrivable { get; private set; }
        static void Main(string[] args, string make, CarLot carLot)

        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            
             Car Carlot = new Car();
            

            Car car1 = new Car();
            car1.model = "ModelX";
            car1.model = "ModelX";
            car1.year = 2020;
            car1.EngineNoise = "zoooooom";
            car1.HonkNoise = "beep";
            car1.IsDrivable = true;
            carLot.Garage.Add(car1);

            car1.MakeEngineNoise("zoooom");
            car1.MakeHonkNoise("beeep");

            
           

           

           var car2 = new Car();

            {
                make = ("Lexus");
                model = "RX300";
                year = 2001;
                EngineNoise = "shake shake vroom shake";
                HonkNoise = "beeep beeeep";
                IsDrivable = true;
                carLot.Garage.Add(car2);

            }
            car2.MakeEngineNoise("shake shake vroom shake");
            car2.MakeHonkNoise("beeep beeeep");
            

            

            Car car3 = new Car(2005, "Honda, Civic, Loud, Beep, True, vroom");
            carLot.Garage.Add(car3);

            car3.MakeHonkNoise("beep");
            car3.MakeEngineNoise("vroom");




            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            
            foreach (var car in carLot.Garage) 
            {
                Console.WriteLine($"model:{car.model}");
                Console.WriteLine($"make:{car.make}");
                Console.WriteLine($"year:{car.year}");
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        
        
            
        
    }
}
