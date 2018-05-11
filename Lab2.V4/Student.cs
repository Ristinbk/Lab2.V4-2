using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.V4
{
    class Student : Person
    {

        public string NumberGroop { get; set; }
        public string Subject { get; set; }
        public string Assessment { get; set; }

        public Student(int number, string firstName, string lastName, string patronymic, string dateOfBirthday, Gender gender, params object[] list)
            : base(number, firstName, lastName, patronymic, dateOfBirthday, gender)
        {
            NumberGroop = Convert.ToString(list[0]);           
            Subject = Convert.ToString(list[1]);
            Assessment = Convert.ToString(list[2]);
        }
    }
}
