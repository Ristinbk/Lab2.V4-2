using System;

namespace Lab2.V4
{
    static partial class Create
    {
        public class CreateObject
        {

            public static void Show(Exam exam)
            {
                exam.Show();
            }

            public static void CreateDefaultStudents(ListOfStudents listOfStudents)
            {
                listOfStudents.AddPersone(1, "Илья", "Иванов", "Андреевич", "25 января 1989", Person.Gender.male, "ФЛ - 17011212", Exam.NameSubject.Literature, Exam.Assessment.Five);
                listOfStudents.AddPersone(2, "Иван", "Петров", "Олегович", "12 ноября 1990", Person.Gender.male, "АВ - 180322", Exam.NameSubject.Math, Exam.Assessment.Four);
                listOfStudents.AddPersone(3, "Петр", "Борисов", "Петрович", "25 августа 1989", Person.Gender.male, "АВ - 170105", Exam.NameSubject.Literature, Exam.Assessment.Two);
                listOfStudents.AddPersone(4, "Ольга", "Зинко", "Евгеньевна", "25 августа 1989", Person.Gender.male, "Ф-170116", Exam.NameSubject.Physics, Exam.Assessment.Tree);
                listOfStudents.AddPersone(5, "Олег", "Иванов", "Иванович", "25 августа 1989", Person.Gender.male, "МТ-170203", Exam.NameSubject.Physics, Exam.Assessment.Tree);
                listOfStudents.AddPersone(6, "Мария", "Иванова", "Олеговна", "25 августа 1989", Person.Gender.male, "С-1704108", Exam.NameSubject.Physics, Exam.Assessment.Tree);
                listOfStudents.AddPersone(7, "Ирина", "Савина", "Евгеньевна", "25 августа 1989", Person.Gender.male, "АВ-170115", Exam.NameSubject.Physics, Exam.Assessment.Tree);
            }

            public static void CreateDefaultTeacher(ListOfTeachers teachers)
            {
                teachers.AddPersone(1, "Борис", "Петров", "Дмитриевич", "25 января 196", Person.Gender.male, Teacher.Department.AVTF, Teacher.Title.Graduate, Exam.NameSubject.Literature);
                teachers.AddPersone(2, "Илья", "Смирнов", "Олегович", "12 ноября 1970", Person.Gender.male, Teacher.Department.FLA, Teacher.Title.Lecturer, Exam.NameSubject.Physics);
                teachers.AddPersone(3, "Борис", "Петров", "Дмитриевич", "25 августа 1969", Person.Gender.male, Teacher.Department.AVTF, Teacher.Title.Lecturer, Exam.NameSubject.Informatics);
                teachers.AddPersone(4, "Борис", "Иванов", "Дмитриевич", "25 августа 1977", Person.Gender.male, Teacher.Department.AVTF, Teacher.Title.Graduate, Exam.NameSubject.Literature);
                teachers.AddPersone(5, "Илья", "Иванов", "Андреевич", "25 августа 1968", Person.Gender.male, Teacher.Department.AVTF, Teacher.Title.Lecturer, Exam.NameSubject.Informatics);
                teachers.AddPersone(6, "Иван", "Петров", "Олегович", "12 ноября 1974", Person.Gender.male, Teacher.Department.FLA, Teacher.Title.Lecturer, Exam.NameSubject.Physics);
                teachers.AddPersone(7, "Петр", "Борисов", "Петрович", "12 ноября 1985", Person.Gender.male, Teacher.Department.FLA, Teacher.Title.Lecturer, Exam.NameSubject.Physics);
            }

            public static void CreateNewPerson(Exam exam, int q)
            {
                int number = 0;
                while (Convert.ToString(number) == "0")
                {
                    Console.Write("Введите идентификационный номер: ");
                    number = Int32.Parse(Console.ReadLine());
                    number = exam.СheckNumber(Convert.ToString(number));
                }

                Console.Write("Введите Имя: "); string firstName = firstName = Console.ReadLine();
                Console.Write("Введите Фамилию: "); string lastName = lastName = Console.ReadLine();
                Console.Write("Введите Отчество: "); string patronymic = patronymic = Console.ReadLine();
                Console.Write("Введите Дату рождения: "); string dateOfBirthday = dateOfBirthday = Console.ReadLine();

                Console.WriteLine("Пол: 1 - мужской, 2 - женский: ");
                Console.Write("Введите соответствуещее значение: ");
                int a = Int32.Parse(Console.ReadLine());
                Person.Gender gender;
                if (a == 1)
                    gender = Person.Gender.male;
                else
                    gender = Person.Gender.female;
                object[] list = { 1, 2, 3 };

                Console.WriteLine("Предмет: 1 - Инфомрматика, 2 - Литература ");
                Console.Write("Введите соответствуещее значение: ");
                Exam.NameSubject nameSubject = Exam.NameSubject.Informatics; 
                int c = Int32.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        nameSubject = Exam.NameSubject.Informatics;
                        break;
                    case 2:
                        nameSubject = Exam.NameSubject.Literature;
                        break;
                    case 3:
                        nameSubject = Exam.NameSubject.Math;
                        break;
                    case 4:
                        nameSubject = Exam.NameSubject.Physics;
                        break;
                    case 5:
                        nameSubject = Exam.NameSubject.Psychics;
                        break;
                }

                if (q == 4)
                {
                    Console.WriteLine("Оценка: 1 - Отлично, 2 - Хорошо ");
                    Console.Write("Введите соответствуещее значение: ");
                    Exam.Assessment assessment = Exam.Assessment.Five;
                    int d = Int32.Parse(Console.ReadLine());
                    switch (d)
                    {
                        case 1:
                            assessment = Exam.Assessment.Five;
                            break;
                        case 2:
                            assessment = Exam.Assessment.Four;
                            break;
                        case 3:
                            assessment = Exam.Assessment.Tree;
                            break;
                        case 4:
                            assessment = Exam.Assessment.Two;
                            break;
                    }

                    Console.Write("Введите номер группы: ");
                    string b = Convert.ToString(Console.ReadLine());

                    list[0] = b; list[1] = nameSubject; list[2] = assessment;
                }
                else
                {
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
                        case 4:
                            title = Teacher.Title.Professor;
                            break;
                    }

                    list[0] = department; list[1] = title; list[2] = nameSubject;
                }

                exam.AddPersone(number, firstName, lastName, patronymic, dateOfBirthday, gender, list);
            }
        }
    }

}
