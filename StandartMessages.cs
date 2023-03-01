using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsiblePrincibleDemo
{
    public class StandartMessages
    {
        public static void WelcomeMessage() => Console.WriteLine("Welcome to my application");
        public static void EndApplication() => Console.ReadLine();
        public static void ValidationErrorMessage(string fieldName) => Console.WriteLine($"You did not give a valid {fieldName}");
    }
}
