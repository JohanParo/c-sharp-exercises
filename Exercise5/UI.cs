using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class UI : IUI 
    {
        public void PrintMenu()
        {
            Console.WriteLine("Menu with options goes here");
            Console.WriteLine("option 1 add vehicle");
            Console.WriteLine("option 2 remove vehicle");
            Console.WriteLine("option 3 list all vehicles");
            Console.WriteLine("enter 0 to exit the program");
        }

        public void PrintString(string output)
        {
            Console.WriteLine(output);
        }
    }
}
