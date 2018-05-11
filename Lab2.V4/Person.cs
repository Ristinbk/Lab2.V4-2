using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.V4
{
    public abstract class Person 
    {
        public string Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string DateOfBirthday { get; set; }
        public string StrGender { get; set; }

        public enum Gender
        {
            male, female
        }

        public Person(int number, string firstName, string lastName, string patronymic, string dateOfBirthday, Gender gender)
        {
            Number = Convert.ToString(number);
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            DateOfBirthday = dateOfBirthday;
            StrGender = Convert.ToString(gender);
            StrGender = Convert.ToString(gender);
        }
    }
}