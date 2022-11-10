using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise3.Animals;

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

        public override string Stats()
        {
            return base.Stats() + $", has caught {numberOfFishesCaught} fishes";
        }
    }
}
