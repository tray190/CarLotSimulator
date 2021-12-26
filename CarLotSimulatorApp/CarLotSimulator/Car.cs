using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car


    {
       

        public Car(int v1, string v2)
        {
        }
        public Car()

        {
           
        }
            public Car( string name, string model, int year, string engineNoise, string HonkNoise, bool isDriveable, string make = "default param value")
        {
            Name = name;
        }

        public int year { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string EngineNoise { get; set; } = "vroom";
        public string HonkNoise { get; set; } = "beep";
        public bool IsDrivable { get; set; } = true;
        public string Name { get; }

        public void MakeEngineNoise(string engineNoise)

        {
            Console.WriteLine($"{EngineNoise}");
        }
        public void MakeHonkNoise(string honkNoise)

        {
            Console.WriteLine($"{HonkNoise}");


            { }

            {

            }
            make = make;
            model = model;
            year = year;
            EngineNoise = EngineNoise;
            HonkNoise = HonkNoise;
            IsDrivable = IsDrivable;

        }
        

    }

    
    
    }

