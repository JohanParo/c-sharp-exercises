using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise5.Vehicles;

namespace Exercise5
{
    internal class Manager
    {
        public void Run()
        {

            var keepRunning = true;
            Console.WriteLine("How big is your garage?");
            int garageSize = Int32.Parse(Console.ReadLine());
            var handler = new GarageHandler(garageSize);


            do
            {
                PrintMenu();
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("What's your vehicles registry number?");
                        var regnr = Console.ReadLine();
                        bool added = handler.AddVehicle(regnr);
                        if (added) { Console.WriteLine("Your vehicle has been parked"); }
                        else { Console.WriteLine("Garage is full, you cannot park your vehicle here."); }
                        break;
                    case "2":
                        Console.WriteLine("Please provide  registry number for your vehicle");
                        var regnr = Console.ReadLine();
                        break;
                    default:
                        break;
                }
            } while (keepRunning);
        }

        public void AddVehicle()
        {

        }
        public Vehicle RemoveVehicle()
        {
            return null;
        }

        public void PrintMenu()
        {
            Console.WriteLine("Menu with options goes here");
            Console.WriteLine("option 1 add vehicle");
            Console.WriteLine("option 2 remove vehicle");
            Console.WriteLine("option 3 list all vehicles");
        }

        public void CreateCar(string regnr, int wheels, string color)
        {
            var car = new Car(regnr);
            car.NumberOfWheels = wheels;
            car.Color = color;
        }
    }
}
