﻿namespace c_sharp_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Uppgift 1:
                Klasser: Employee
             */
            /*
             Uppgift 2:
                Attribut:
                    Namn, Lön
                Metoder:
                    GetName, GetPay, PrintRegistery
             */

            //Uppgift 3:

            int end = 1;
            LinkedList<Employee> employees = new LinkedList<Employee>();

            employees.AddLast(new Employee("Johan Parö", 150));
            employees.AddLast(new Employee("Erik Parö", 140));


            while (end != 0)
            {
                Console.WriteLine("To add a employee type 1, o show the registery type 2, to exit type 0.");
                string input = Console.ReadLine();

                if (input == "1")
                {

                    Console.Write("Skriv in personens namn: ");
                    string name = Console.ReadLine();

                    Console.Write("Skriv in personens lön: ");
                    int pay = Int32.Parse(Console.ReadLine());

                    employees.AddLast(new Employee(name, pay));
                }
                else if (input == "2")
                {
                    PrintRegistry(employees);
                }
                else if (input == "0")
                {
                    end = 0;
                }
            }
        }

        private static void PrintRegistry(LinkedList<Employee> list)
        {
            Console.WriteLine("Register över anställda");
            foreach (Employee employee in list)
            {
                string msg = "Namn: " + employee.GetName() + ", Lön: " + employee.GetPay() + "kr.";
                Console.WriteLine(msg);
            }
            Console.WriteLine();
        }

    }
}