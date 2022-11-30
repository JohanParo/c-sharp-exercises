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
            var ui = new UI();
            Console.WriteLine("How big is your garage?");
            int garageSize = Int32.Parse(Console.ReadLine());
            handler = new GarageHandler(garageSize);


            do
            {
                ui.PrintMenu();
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ui.PrintString("What's your vehicles registry number?");
                        var regnr = Console.ReadLine();
                        bool added = handler.AddVehicle(CreateCar(regnr));
                        if (added) { ui.PrintString("Your vehicle has been parked"); }
                        else { ui.PrintString("Garage is full, you cannot park your vehicle here."); }
                        break;
                    case "2":
                        ui.PrintString("Please provide registry number for your vehicle");
                        var regnr2 = Console.ReadLine();
                        var vehicle = RemoveVehicle(regnr2);
                        if (vehicle != null) 
                        {
                            ui.PrintString($"your car with registry number {vehicle.RegNr} has been removed from the garage.");
                        }
                        else
                        {
                            ui.PrintString("Could not find a vehicle with that registry number.");
                        }
                        break;
                    case "3":
                        ui.PrintString("Showing all vehicles stored in the garage:");
                        handler.PrintAllVehicles();
                        break;
                    case "0":
                        return;
                    default:
                        break;
                }
            } while (keepRunning);
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

        

        public Car CreateCar(string regnr)
        {
            var car = new Car(regnr);
            return car;
        }
    }
}
