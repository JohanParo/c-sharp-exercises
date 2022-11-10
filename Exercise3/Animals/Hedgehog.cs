using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals
{
    public class Hedgehod : Animal
    {
        public int numberOfSpikes { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("???!");
        }

        public Hedgehod(string name, int age) : base(name, age)
        {
            Age = age;
            Name = name;
        }
        public override string Stats()
        {
            return base.Stats() + $", has {numberOfSpikes} number of spikes";
        }
    }
}
