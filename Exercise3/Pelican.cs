using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Pelican : Bird
    {
        public int numberOfFishesCaught { get; set; }
        public Pelican(string name, int age) : base(name, age)
        {
            base.Name = name;
            base.Age = age;
        }
    }
}
