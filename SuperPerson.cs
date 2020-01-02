using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleWebScraper
{
    class SuperPerson : Person
    {
        public SuperPerson(string FirstName, string LastName) : base(FirstName, LastName)
        {

        }

        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}
