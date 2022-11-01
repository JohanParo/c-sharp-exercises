using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_exercises
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Pay { get; set; }

        public Employee(string name, int pay)
        {
            this.Name = name;
            this.Pay = pay;
        }

        public string GetName()
        {
            return this.Name;
        }

        public int GetPay()
        {
            return this.Pay;
        }
    }
}
