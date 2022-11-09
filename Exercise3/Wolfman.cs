using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, int age) : base(name, age)
        {
            base.Age = age;
            base.Name = name;
        }

        public void Talk()
        {
            Console.WriteLine("You gonna eat that?");
        }
    }
}
