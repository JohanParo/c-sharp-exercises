using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals
{
    public class Worm : Animal
    {
        public string weapon { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("HALLELUJAH!");
        }

        public Worm(string name, int age) : base(name, age)
        {
            Age = age;
            Name = name;
        }
        public override string Stats()
        {
            return base.Stats() + $", has a {weapon} equipped";
        }
    }
}
