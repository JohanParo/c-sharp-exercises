using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals
{
    internal class Swan : Bird
    {
        public bool isAngry { get; set; }
        public Swan(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
        }
        public override string Stats()
        {
            return base.Stats() + $", is it angry: {isAngry}";
        }
    }
}
