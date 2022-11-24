using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise5.Vehicles;

namespace Exercise5
{
    internal class Garage<T> : IEnumerable<Vehicle>
    {
        public Vehicle[] Storage { get; set; }
        private int StoredVehicles { get; set; }
        private int capacity;

        public Garage(int size)
        {
            Storage = new Vehicle[size];
            StoredVehicles = 0;
            capacity = size;
        }

        public bool Add(Vehicle vehicle)
        {
            if (StoredVehicles == capacity)
            {
                return false;
            }
            else
            {
                Storage[StoredVehicles] = vehicle;
                StoredVehicles++;
                return true;
            }
        }

        private Vehicle Remove(int spot)
        {
            var tmp = Storage[spot];
            return tmp;
        }

        public IEnumerator<Vehicle> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public Vehicle showVehicle(int pos)
        {
            return Storage[pos];
        }
    }
}
