using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5.Vehicles
{
    internal abstract class Vehicle
    {
        private string regNr;

        public string RegNr
        {
            get { return regNr; }
        }
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }

        public Vehicle(string regNr)
        {
            this.regNr = regNr;
        }


    }
}
