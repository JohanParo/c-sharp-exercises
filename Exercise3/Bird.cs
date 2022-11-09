using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Bird : Animal
    {
        public bool canFly { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Caaw!");
        }

        public Bird(string name, int age) : base(name, age)
        {
            base.Age = age;
            base.Name = name;
        }
    }
}
