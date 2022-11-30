using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise5.Vehicles;

namespace Exercise5
{
    internal interface IGarageHandler
    {
        public bool AddVehicle(Vehicle vehicle);
        public Vehicle RemoveVehicle(string regnr);
        public void PrintAllVehicles();
    }
}
