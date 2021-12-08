﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class PersonHandler
    {
        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }
        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            try
            {
                Person person = new Person(fName, lName);
            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1.Message);
            }

            person.Height = height;
            SetAge(person, age);
            return person;
        }
    }
}