using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise5.Vehicles;

namespace Exercise5
{
    internal class Garage<T> : IEnumerable<Vehicle>, IGarage
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

        public Vehicle Remove(int spot)
        {
            var tmp = Storage[spot];
            Storage[spot] = null;
            return tmp;
        }

        public int getPosition(string regnr)
        {
            for (int i = 0; i < capacity; i++)
            {
                if (Storage[i].RegNr == regnr)
                    return i;
            }
            return -1;
        }

        public IEnumerator<Vehicle> GetEnumerator()
        {
            foreach (Vehicle v in Storage)
            {
                yield return v;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Vehicle showVehicle(int pos)
        {
            return Storage[pos];
        }
    }
}
