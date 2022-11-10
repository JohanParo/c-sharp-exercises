using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Animals
{
    public class Dog : Animal
    {
        public bool isShedding { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Woof!");
        }

        public Dog(string name, int age) : base(name, age)
        {
            Age = age;
            Name = name;
        }

        public override string Stats()
        {
            return base.Stats() + $", is it shedding: {isShedding}";
        }

        public string isAGoodBoy()
        {
            return $"Yes {Name} is a good boy!";
        }
    }
}
