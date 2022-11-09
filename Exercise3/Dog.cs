using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
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
            base.Age = age;
            base.Name = name;
        }
    }
}
