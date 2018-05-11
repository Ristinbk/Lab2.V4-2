using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.V4
{
    abstract class Exam
    {
        public enum NameSubject
        {
            Informatics,
            Literature,
            Math,
            Physics,
            Psychics
        }

        public enum Assessment
        {
            Two,
            Tree,
            Four,
            Five,
            Credited,
            NoCredited
        }

        public abstract void Show();
        public abstract void RemovePerson(string number);
        public abstract int СheckNumber(string number);
        public abstract void AddPersone(int number, string firstName, string lastName, string patronymic, string dateOfBirthday, Person.Gender gender, params object[] list);
        public abstract void СhangePerson(string number);
    //    public abstract void Change(string firstName, string lastName, string patronymic, string dateOfBirthday, Person.Gender gender, params object[] list);
     //   public abstract void Change(string firstName, string lastName, string patronymic, string dateOfBirthday, string gender, params object[] list);
    }
}
