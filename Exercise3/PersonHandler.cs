﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }

        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person(fname, lname);
            SetAge(person, age);
            SetHeight(person, height);
            SetWeight(person, weight);
            return person;

        }
    }
}
