using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWebScraper
{
    class Person
    {
        private string _firstName;
        private string _lastName;

        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public static void Sleep()
        {
            Console.WriteLine("I'm sleeping");
        }

        public void Eat()
        {
            Console.WriteLine("I'm eating");
        }

        public void Walk()
        {
            Console.WriteLine("I'm walking");
        }
    }
}
