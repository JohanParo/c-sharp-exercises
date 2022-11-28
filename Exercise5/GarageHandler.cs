using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise5.Vehicles;

namespace Exercise5

{
    internal class GarageHandler : IGarageHandler
    {
        private Garage<Vehicle> garage;
        public GarageHandler(int size)
        {
            garage = new Garage<Vehicle>(size);
        }

        internal bool AddVehicle(Vehicle vehicle)
        {
            var added = garage.Add(vehicle);
            if (added) { return true; }
            return false;
        }

        public Vehicle RemoveVehicle(string regnr)
        {
            int position = garage.getPosition(regnr);
            if (position == -1)
            {
                return null;
            }
            return garage.Remove(position);        }

        internal void PrintAllVehicles()
        {
            foreach (Vehicle vehicle in garage)
            {
                if (vehicle != null)
                Console.WriteLine($"Vehicle with registry number: {vehicle.RegNr}");
            }
        }
    }
}
