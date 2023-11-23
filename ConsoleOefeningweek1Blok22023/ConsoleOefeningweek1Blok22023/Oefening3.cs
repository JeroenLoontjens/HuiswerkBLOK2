using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOefeningweek1Blok22023
{
    internal class Oefening3
    {

        public class Engine
        {

            public string name { get; set; }
            public string Model { get; set; }

            public void Start()
            {
                Console.WriteLine("PRUTTEL PRUTTEL");
            }
        }

        public class Car
        { 
            public string Make { get; set; } 
            public string Model { get; set; }
            public int Year { get; set; }   
            public Engine CarEngine { get; set; }

            public void Drive()
            {
                Console.WriteLine("WE ZIJN ER NOG LANG NIET");

            }

            public void Stop()
            {
                Console.WriteLine("THANKS FOR DRIVING CAR");
            }

            public void Honk()
            {
                Console.WriteLine("TUUT TUUT");
            }
        }

        public class Driver
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Car DriverCar { get; set; }

            public void StartCar()
            {
                DriverCar.CarEngine.Start();
                Console.WriteLine($"VROEM VROEM  VROOOOOOOOOOEM");
            }

            public void StopCar()
            {
                DriverCar.Stop();
                Console.WriteLine("Auto is gestopt");
            }


        }
    }
}
