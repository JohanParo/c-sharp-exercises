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
        GarageHandler handler;
        public void Run()
        {

            var keepRunning = true;
            Console.WriteLine("How big is your garage?");
            int garageSize = Int32.Parse(Console.ReadLine());
            handler = new GarageHandler(garageSize);


            do
            {
                PrintMenu();
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("What's your vehicles registry number?");
                        var regnr = Console.ReadLine();
                        bool added = handler.AddVehicle(CreateCar(regnr));
                        if (added) { Console.WriteLine("Your vehicle has been parked"); }
                        else { Console.WriteLine("Garage is full, you cannot park your vehicle here."); }
                        break;
                    case "2":
                        Console.WriteLine("Please provide registry number for your vehicle");
                        var regnr2 = Console.ReadLine();
                        var vehicle = RemoveVehicle(regnr2);
                        if (vehicle != null) 
                        {
                            Console.WriteLine($"your car with registry number {vehicle.RegNr} has been removed from the garage.");
                        }
                        else
                        {
                            Console.WriteLine("Could not find a vehicle with that registry number.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Showing all vehicles stored in the garage:");
                        handler.PrintAllVehicles();
                        break;
                    case "0":
                        return;
                    default:
                        break;
                }
            } while (keepRunning);
        }

        public void AddVehicle()
        {

        }

        public Vehicle RemoveVehicle(string regnr)
        {
            Vehicle vehicle = handler.RemoveVehicle(regnr);
            if (vehicle == null)
            {
                return null;
            }
            return vehicle;
        }

        public void PrintMenu()
        {
            Console.WriteLine("Menu with options goes here");
            Console.WriteLine("option 1 add vehicle");
            Console.WriteLine("option 2 remove vehicle");
            Console.WriteLine("option 3 list all vehicles");
            Console.WriteLine("enter 0 to exit the program");
        }

        public Car CreateCar(string regnr)
        {
            var car = new Car(regnr);
            return car;
        }
    }
}
