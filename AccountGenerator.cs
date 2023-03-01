using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsiblePrincibleDemo
{
    public class AccountGenerator
    {
        public static void Generator(Person person)
        {
            Console.WriteLine($"Your username is {person.FirstName.Substring(0, 1)}{person.LastName}");
        }
    }
}
