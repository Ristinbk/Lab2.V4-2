using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.V4
{
    static partial class Create
    {
        public static Exam ListOfStudents { get; private set; }
        public static Exam Teachers { get; private set; }

        public static void CreateObjects()
        {
            ListOfStudents students = new ListOfStudents();
            ListOfTeachers teachers = new ListOfTeachers();
            Console.Write("1 - Cписок студентов\n2 - Список преподавателей\n3 - Информация о сессии\n4 - Добавить запись о студенте\n5 - Добавить запись о преподавателе\n6 - Удалить запись о студенте\n7 - Удалить запись о преподавателе\n8 - Изменить запись о студенте\n9 - Изменить запись о преподавателе");
            CreateDefaultPersone();
            int a;
            do
            {
                Console.Write("\nВведите соответствуещее значение: ");
                a = Int32.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        CreateObject.Show(students);
                        break;
                    case 2:
                        CreateObject.Show(teachers);
                        break;
                    case 3:
                        students.ShowResultExam();                        
                        break;
                    case 4:
                        CreateObject.CreateNewPerson(students, a);
                        break;
                    case 5:
                        CreateObject.CreateNewPerson(teachers, a);
                        break;
                    case 6:
                        Console.Write("Введите идентификационный номер: ");
                        string number = Console.ReadLine();
                        students.RemovePerson(number);
                        break;
                    case 7:
                        Console.Write("Введите идентификационный номер: ");
                        number = Console.ReadLine();
                        teachers.RemovePerson(number);
                        break;
                    case 8:
                        Console.Write("Введите идентификационный номер: ");
                        number = Console.ReadLine();
                        students.СhangePerson(number);
                        break;
                    case 9:
                        Console.Write("Введите идентификационный номер: ");
                        number = Console.ReadLine();
                        teachers.СhangePerson(number);
                        break;
                }
            } while (a != 0);

            void CreateDefaultPersone()
            {
                CreateObject.CreateDefaultStudents(students);
                CreateObject.CreateDefaultTeacher(teachers);
            }
        }
    }
}
