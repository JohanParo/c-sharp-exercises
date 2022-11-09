using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Flamingo : Bird
    {
        public int numberOfFeathers { get; set; }
        public Flamingo(string name, int age) : base(name, age)
        {
            base.Age = age;
            base.Name = name;
        }
        public override string Stats()
        {
            return base.Stats() + $", has {numberOfFeathers} feathers";
        }
    }
}
