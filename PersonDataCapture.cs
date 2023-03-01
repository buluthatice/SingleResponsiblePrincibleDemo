using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SingleResponsiblePrincibleDemo
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            Person person = new Person();

            Console.WriteLine("What is your firstname?");
            person.FirstName = Console.ReadLine();

            Console.WriteLine("What is your lastname?");
            person.LastName = Console.ReadLine();
            return person;
        }
    }
}
