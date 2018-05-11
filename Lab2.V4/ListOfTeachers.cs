using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.V4
{
    class ListOfTeachers : Exam
    {
        List<Teacher> teachers = new List<Teacher>();

        public override void AddPersone(int number, string firstName, string lastName, string patronymic, string dateOfBirthday, Person.Gender gender, params object[] list)
        {
            Teacher teacher = new Teacher(number, firstName, lastName, patronymic, dateOfBirthday, gender, list);
            teachers.Add(teacher);
        }

        public override void Show()
        {
            Console.WriteLine("\nПреподаватели:");
            Console.WriteLine("Номер\tФамилия Имя Отчество\tДата рождения\tПол\tКафедра\tДолжность\t\tПредмет");
            foreach (var t in teachers)
            {
                Console.WriteLine(t.Number + " \t" + t.FirstName + " " + t.LastName + " " + t.Patronymic + "\t" + t.DateOfBirthday + "\t" + t.StrGender + "\t" + t.StrDepartment + "\t" + t.StrTitle + "\t\t" + t.StrNameSubject);
            }
        }

        public override void RemovePerson(string number)
        {
            for (int i = 0; i < teachers.Count; i++)
            {
                if (teachers[i].Number == number)
                    teachers.Remove(teachers[i]);
            }
        }

        public override int СheckNumber(string number)
        {
            for (int i = 0; i < teachers.Count; i++)
            {
                if (number == teachers[i].Number)
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
            for (int i = 0; i < teachers.Count; i++)
            {
                if (teachers[i].Number == number)
                {
                    string firstName = teachers[i].FirstName;
                    Console.Write("Введите Имя: "); teachers[i].FirstName = Console.ReadLine();
                    Console.Write("Введите Фамилию: "); teachers[i].LastName = Console.ReadLine();
                    Console.Write("Введите Отчество: "); teachers[i].Patronymic = Console.ReadLine();
                    Console.Write("Введите Дату рождения: "); teachers[i].DateOfBirthday = Console.ReadLine();
                    Console.WriteLine("Пол: 1 - мужской, 2 - женский: ");
                    Console.Write("Введите соответствуещее значение: ");
                    int a = Int32.Parse(Console.ReadLine());
                    if (a == 1)
                        teachers[i].StrGender = Convert.ToString(Person.Gender.male);
                    else
                        teachers[i].StrGender = Convert.ToString(Person.Gender.female);

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

                    Console.WriteLine("Группа: 1 - AVTF, 2 - FGO, 3 - FLA, 4 - 223 ");
                    Console.Write("Введите соответствуещее значение: ");
                    Teacher.Department department = Teacher.Department.AVTF;
                    int b = Int32.Parse(Console.ReadLine());
                    switch (b)
                    {
                        case 1:
                            department = Teacher.Department.AVTF;
                            break;
                        case 2:
                            department = Teacher.Department.FGO;
                            break;
                        case 3:
                            department = Teacher.Department.FLA;
                            break;
                    }

                    Console.WriteLine("Группа: 1 - Docent, 2 - Graduate, 3 - Lecturer, 4 - Professor ");
                    Console.Write("Введите соответствуещее значение: ");
                    Teacher.Title title = Teacher.Title.Docent;
                    int e = Int32.Parse(Console.ReadLine());
                    switch (e)
                    {
                        case 1:
                            title = Teacher.Title.Docent;
                            break;
                        case 2:
                            title = Teacher.Title.Graduate;
                            break;
                        case 3:
                            title = Teacher.Title.Lecturer;
                            break;
                        case 5:
                            title = Teacher.Title.Professor;
                            break;
                    }

                    teachers[i].StrDepartment = Convert.ToString(department);
                    teachers[i].StrNameSubject = Convert.ToString(nameSubject);
                    teachers[i].StrTitle = Convert.ToString(title);
                }
            }
        }
    }
}
