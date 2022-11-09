using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Swan : Bird
    {
        public bool isAngry { get; set; }
        public Swan(string name, int age) : base(name, age)
        {
            base.Name = name;
            base.Age = age;
        }
    }
}
