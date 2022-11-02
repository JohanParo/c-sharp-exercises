using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_exercises
{
    internal class Employee
    {
        private string name { get; set; }
        private int pay { get; set; }

        public Employee(string name, int pay)
        {
            this.name = name;
            this.pay = pay;
        }
        public string Name 
        {
            get { return name; }
            set { name = value;  } 
        }
        public int Pay 
        {
            get { return pay; }
            set { pay = value; }
        }

    }
}
