﻿namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonHandler personHandler = new PersonHandler();

            Person person1 = personHandler.CreatePerson(28, "Johan", "Paro", 194, 130);


            Console.WriteLine(person1.ToString());

        }
    }
}