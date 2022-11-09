using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
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
            base.Age = age;
            base.Name = name;
        }
    }
}
