using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals
{
    public class Horse : Animal
    {
        public int hooves { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Neigh!");
        }

        public Horse(string name, int age) : base(name, age)
        {
            Age = age;
            Name = name;
        }
        public override string Stats()
        {
            return base.Stats() + $", has {hooves} hooves";
        }
    }
}
