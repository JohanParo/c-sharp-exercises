using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise5.Vehicles;

namespace Exercise5

{
    internal class GarageHandler
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

        public Vehicle RemoveVehicle(int position)
        {
            return null;
        }

        public Vehicle RemoveVehicle(string regnr)
        {
            throw new NotImplementedException();
        }

        internal void CreateGarage(string? garageSize)
        {
            throw new NotImplementedException();
        }


    }
}
