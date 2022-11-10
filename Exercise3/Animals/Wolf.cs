using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals
{
    public class Wolf : Animal
    {
        public bool isHungry { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Howl!");
        }

        public Wolf(string name, int age) : base(name, age)
        {
            Age = age;
            Name = name;
        }

        public override string Stats()
        {
            return base.Stats() + $", is it hungry: {isHungry}";
        }
    }
}
