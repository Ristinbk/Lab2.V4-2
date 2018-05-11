using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.V4
{
    class Teacher : Person
    {
        public string StrDepartment { get; set; }
        public string StrTitle { get; set; }
        public string StrNameSubject { get; set; }

        public enum Title
        {
            Docent,
            Professor,
            Lecturer,
            Graduate
        }

        public enum Department
        {
            AVTF,
            FGO,
            FLA
        }

        public Teacher(int number, string firstName, string lastName, string patronymic, string dateOfBirthday, Gender gender, params object[] list)
             : base(number, firstName, lastName, patronymic, dateOfBirthday, gender)
        {
            StrDepartment = Convert.ToString(list[0]);
            StrTitle = Convert.ToString(list[1]);
            StrNameSubject = Convert.ToString(list[2]);
        }
    }
}
