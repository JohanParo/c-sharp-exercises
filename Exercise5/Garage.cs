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

        public Garage(int size)
        {
            Storage = new Vehicle[size];
            StoredVehicles = 0;  
        }

        private void addVehicle(Vehicle vehicle)
        {
            Storage[StoredVehicles] = vehicle;
            StoredVehicles++;
        }

        private Vehicle RemoveVehicle(int spot)
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
