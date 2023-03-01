using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsiblePrincibleDemo
{
    public class PersonValidator
    {
        public static bool Validator(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandartMessages.ValidationErrorMessage("first name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandartMessages.ValidationErrorMessage("last name");
                return false;
            }
            return true;
        }
    }
}
