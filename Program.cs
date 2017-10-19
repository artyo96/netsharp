using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lectures> ListLectures = new List<Lectures>();
            List<Group> ListGroup = new List<Group>();
            List<Student> ListStudents = new List<Student>();
            Test(ref ListLectures, ref ListGroup, ref ListStudents);

            int menu;

            while (true)
            {
                Console.WriteLine("1. Показать всех студентов \n2. Выставить оценки за модуль\n3. Лучшие студенты по всем группам\n4. Лучшие студенты группы\n5. Лучшые студенты группы по конкретному предмету\n0. Exit");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        foreach (Student student in ListStudents)
                        {
                            student.ShowStudent();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Выберите группу");
                        int idGroup, idStudent, idLectures;
                        foreach (Group gr in ListGroup)
                        {
                            gr.ShowGroup();
                        }
                        idGroup = int.Parse(Console.ReadLine());
                        Console.WriteLine("Выберите студента:");
                        foreach (Student student in ListStudents)
                        {
                            student.ShowOneGroup(idGroup);
                        }
                        idStudent = int.Parse(Console.ReadLine());
                        Console.WriteLine("Выберите предмет для оценки за модуль:");
                        ListStudents[idStudent].ShowLecturesStudent();
                        idLectures = int.Parse(Console.ReadLine());

                        string nameModule;
                        int bod;
                        Console.WriteLine("Введите название модуля :");
                        nameModule = Console.ReadLine();
                        Console.WriteLine("Введите оценку :");
                        bod = int.Parse(Console.ReadLine());

                        ListStudents[idStudent].AddModule(idLectures, nameModule, bod);
                        break;
                    case 3:
                        List<Student> TempStudList = ListStudents;
                        Student.Sort(ref TempStudList);
                        for (int j = 0, i = 0; j < TempStudList.Count; j++)
                        {
                            if (TempStudList[j].GetSredBod() == 0)
                            {
                                continue;
                            }
                            if (i == 5)
                                break;
                            TempStudList[j].ShowStudent();
                        }
                        TempStudList.Clear();
                        break;
                    case 4:
                        TempStudList = new List<Student>();
                        Console.WriteLine("Выберите группу");
                        foreach (Group gr in ListGroup)
                        {
                            gr.ShowGroup();
                        }
                        idGroup = int.Parse(Console.ReadLine());
                        Student.ForSortGroup(ref TempStudList, ref ListStudents, idGroup);
                        Student.Sort(ref TempStudList);
                        for (int j = 0, i = 0; j < TempStudList.Count; j++)
                        {
                            if (TempStudList[j].GetSredBod() == 0)
                            {
                                continue;
                            }
                            if (i == 5)
                                break;
                            TempStudList[j].ShowStudent();
                        }
                        TempStudList.Clear();
                        break;
                    case 5:
                        TempStudList = new List<Student>();
                        Console.WriteLine("Выберите группу");
                        foreach (Group gr in ListGroup)
                        {
                            gr.ShowGroup();
                        }
                        idGroup = int.Parse(Console.ReadLine());
                        Student.ForSortGroup(ref TempStudList, ref ListStudents, idGroup);
                        for (int j = 0, i = 0; j < TempStudList.Count; j++)
                        {
                            if (TempStudList[j].GetSredBod() == 0)
                            {
                                continue;
                            }
                            if (i == 5)
                                break;
                            TempStudList[j].ShowStudent();
                        }
                        TempStudList.Clear();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }

        }


        static void Test(ref List<Lectures> ListLectures, ref List<Group> ListGroup, ref List<Student> ListStudents)
        {
            ListLectures.Add(new Lectures(0, "Биология"));
            ListLectures.Add(new Lectures(1, "Алгебра"));
            ListLectures.Add(new Lectures(2, "Геометрия"));
            ListLectures.Add(new Lectures(3, "Химия"));
            ListLectures.Add(new Lectures(4, "Физика"));
            ListLectures.Add(new Lectures(5, "География"));
            ListLectures.Add(new Lectures(6, "Философия"));
            ListLectures.Add(new Lectures(7, "Социология"));
            ListLectures.Add(new Lectures(8, "Экономика"));
            ListLectures.Add(new Lectures(9, "Информатика"));

            ListGroup.Add(new Group(0, "РПЗ-112"));
            ListGroup.Add(new Group(1, "ОПК-112"));
            ListGroup[0].SetListLectures = ListLectures[1];
            ListGroup[0].SetListLectures = ListLectures[2];
            ListGroup[0].SetListLectures = ListLectures[3];
            ListGroup[0].SetListLectures = ListLectures[4];
            ListGroup[0].SetListLectures = ListLectures[8];
            ListGroup[1].SetListLectures = ListLectures[0];
            ListGroup[1].SetListLectures = ListLectures[1];
            ListGroup[1].SetListLectures = ListLectures[2];
            ListGroup[1].SetListLectures = ListLectures[5];
            ListGroup[1].SetListLectures = ListLectures[6];
            ListGroup[1].SetListLectures = ListLectures[9];

            ListStudents.Add(new Student(0, "Иванов", "Иван", ListGroup[0]));
            ListStudents.Add(new Student(1, "Сидоров", "Олег", ListGroup[0]));
            ListStudents.Add(new Student(2, "Аров", "Артем", ListGroup[0]));
            ListStudents.Add(new Student(3, "Гузов", "Арсен", ListGroup[0]));
            ListStudents.Add(new Student(4, "Михов", "Марк", ListGroup[0]));
            ListStudents.Add(new Student(5, "Туров", "Сергей", ListGroup[0]));
            ListStudents.Add(new Student(6, "Миров", "Валерий", ListGroup[0]));
            ListStudents.Add(new Student(7, "Седов", "Денис", ListGroup[0]));

            ListStudents.Add(new Student(8, "Ников", "Аркадий", ListGroup[1]));
            ListStudents.Add(new Student(9, "Ротов", "Махомед", ListGroup[1]));
            ListStudents.Add(new Student(10, "Перов", "Андрей", ListGroup[1]));
            ListStudents.Add(new Student(11, "Воробьев", "Илья", ListGroup[1]));
            ListStudents.Add(new Student(12, "Дружов", "Данилл", ListGroup[1]));
            ListStudents.Add(new Student(13, "Жуков", "Аркадий", ListGroup[1]));
            ListStudents.Add(new Student(14, "Веров", "Виталий", ListGroup[1]));
        }
    }
}
