using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.V4
{
    class ListOfStudents : Exam
    {
        List<Student> students = new List<Student>();

        public override void AddPersone(int number, string firstName, string lastName, string patronymic, string dateOfBirthday, Person.Gender gender, params object[] list)
        {
            Student student = new Student(number, firstName, lastName, patronymic, dateOfBirthday, gender, list);
            students.Add(student);
        }        

        public override void RemovePerson(string number)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Number == number)
                    students.Remove(students[i]);
            }
        }

        public override int СheckNumber(string number)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (number == students[i].Number)
                {
                    Console.WriteLine("Этот номер занят, попробуйте заново!");
                    number = "0";
                    break;
                }
            }
            return Int32.Parse(number);
        }

        public override void СhangePerson(string number)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Number == number)
                {
                    string firstName = students[i].FirstName;
                    Console.Write("Введите Имя: "); students[i].FirstName = Console.ReadLine();
                    Console.Write("Введите Фамилию: "); students[i].LastName = Console.ReadLine();
                    Console.Write("Введите Отчество: "); students[i].Patronymic = Console.ReadLine();
                    Console.Write("Введите Дату рождения: "); students[i].DateOfBirthday = Console.ReadLine();
                    Console.WriteLine("Пол: 1 - мужской, 2 - женский: ");
                    Console.Write("Введите соответствуещее значение: ");
                    int a = Int32.Parse(Console.ReadLine());
                    if (a == 1)
                        students[i].StrGender = Convert.ToString(Person.Gender.male);
                    else
                        students[i].StrGender = Convert.ToString(Person.Gender.female);

                    Console.WriteLine("Предмет: 1 - Инфомрматика, 2 - Литература ");
                    Console.Write("Введите соответствуещее значение: ");
                    NameSubject nameSubject = NameSubject.Informatics;
                    int c = Int32.Parse(Console.ReadLine());
                    switch (c)
                    {
                        case 1:
                            nameSubject = NameSubject.Informatics;
                            break;
                        case 2:
                            nameSubject = NameSubject.Literature;
                            break;
                        case 3:
                            nameSubject = NameSubject.Math;
                            break;
                        case 4:
                            nameSubject = NameSubject.Physics;
                            break;
                        case 5:
                            nameSubject = NameSubject.Psychics;
                            break;
                    }

                    Console.WriteLine("Оценка: 1 - Отлично, 2 - Хорошо ");
                    Console.Write("Введите соответствуещее значение: ");
                    Assessment assessment = Assessment.Five;
                    int d = Int32.Parse(Console.ReadLine());
                    switch (d)
                    {
                        case 1:
                            assessment = Assessment.Five;
                            break;
                        case 2:
                            assessment = Assessment.Four;
                            break;
                        case 3:
                            assessment = Assessment.Tree;
                            break;
                        case 4:
                            assessment = Assessment.Two;
                            break;
                    }

                    Console.Write("Введите номер группы: ");
                    string b = Convert.ToString(Console.ReadLine());

                    students[i].NumberGroop =  b;
                    students[i].Subject = Convert.ToString(nameSubject);
                    students[i].Assessment = Convert.ToString(assessment);
                }
            }
        }

        public override void Show()
        {
            Console.WriteLine("\nСтуденты:");
            Console.WriteLine("Номер\tФамилия Имя Отчество\tДата рождения\t\tПол\t\tГруппа\t");
            foreach (var t in students)
            {
                Console.WriteLine(t.Number + " \t" + t.LastName + " " +  t.FirstName + " " + t.Patronymic + "\t" + t.DateOfBirthday + "\t\t" + t.StrGender + "\t\t" + t.NumberGroop);

            }
        }

        public void ShowResultExam()
        {
            Console.Write("\n1 - Информатика, 2 - Литература, 3 - Математика, 4 - Физика, 5 - Психология, 6 - Вывести всё \n");
            Console.Write("Введите число, соответствующее предмету: ");
            string s = Console.ReadLine();
            string a ="0";
            switch (s)
            {
                case "1":
                    a = Convert.ToString(NameSubject.Informatics);
                    break;
                case "2":
                    a = Convert.ToString(NameSubject.Literature);
                    break;
                case "3":
                    a = Convert.ToString(NameSubject.Math);
                    break;
                case "4":
                    a = Convert.ToString(NameSubject.Physics);
                    break;
                case "5":
                    a = Convert.ToString(NameSubject.Psychics);
                    break;
                case "6":
                    Console.WriteLine("\nНомер\tФамилия Имя Отчество\t\tГруппа\tПредмет\t\tОценка");
                    foreach (var t in students)
                    {
                        Console.WriteLine(t.Number + " \t" + t.LastName + " " + t.FirstName + " " + t.Patronymic + "\t" + t.NumberGroop + "\t"+ t.Subject+ "\t\t" + t.Assessment);
                    }
                    break;                    
            }

            if (Int32.Parse(s) < 6)
            {
                Console.WriteLine("\nЭкзамен {0}: ", a);
                Console.WriteLine("Номер\tФамилия Имя Отчество\t\tГруппа\tОценка");                
                output(a);
            }

            void output(string s1)
            {
                foreach (var t in students)
                {
                    string s2 = Convert.ToString(t.Subject);
                    if (s1 == s2)
                        Console.WriteLine(t.Number + " \t" + t.FirstName + " " + t.LastName + " " + t.Patronymic + "\t" + t.NumberGroop + "\t" + t.Assessment);
                }
            }
        }
    }
}
