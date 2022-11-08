using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Person
    {

        private int age;
        private string firstName;
        private string lastName;
        private double height;
        private double weight;

        public int Age
        {
            get { return age; }
            set 
            {
                if (age > 0) { age = 0; }
                age = value; 
            }
        }
        public string FirstName
        {
            get { return firstName; }
            set { 
                if (firstName.Length < 2 || firstName.Length > 10) { throw new ArgumentException("Not a valid input","firstName"); }
                firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set {
                if (lastName.Length < 2 || lastName.Length > 10) { throw new ArgumentException("Not a valid input", "lastName"); }
                lastName = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }



    }
}
