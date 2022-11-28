using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise5.Vehicles;

namespace Exercise5
{
    internal interface IGarage
    {
        public bool Add();
        public Vehicle Remove();
        public int getPosition();
    }
}
