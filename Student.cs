using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Student
    {
        int ID;
        string LastName;
        string FirstName;
        Group GroupStudent;
        float StredBodov;
        List<Lectures> ListLecturesStudent;

        public Student(int ID, string LastName, string FirstName, Group GroupStudent)
        {
            this.ID = ID;
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.GroupStudent = GroupStudent;
            ListLecturesStudent = GroupStudent.GetListLectures;
        }

        void SrednjaOcenka()
        {
            List<float> ocenki = new List<float>();
            int ocenkiZaOdnin = 0;
            foreach (Lectures x in ListLecturesStudent)
            {
                if (x.GetModuly.Count == 0)
                {
                    continue;
                }
                foreach (int tmp in x.GetModuly)
                {
                    ocenkiZaOdnin += tmp;
                }
                ocenki.Add(((float)ocenkiZaOdnin / (float)x.GetModuly.Count));
                ocenkiZaOdnin = 0;
            }
            int vseZaModul = 0;
            foreach (int getSred in ocenki)
            {
                vseZaModul += getSred;
            }
            StredBodov = (float)vseZaModul / (float)ocenki.Count;
        }

        public void ShowStudent()
        {
            Console.WriteLine("ID: {0} Фамилия {1} Имя {2} Группа {3} Средняя оценка {4}", ID, LastName, FirstName, GroupStudent.GetNameGroup, StredBodov);
        }

        public void ShowOneGroup(int idGroup)
        {
            if (idGroup == GroupStudent.GetID)
            {
                ShowStudent();
            }
        }

        public void ShowLecturesStudent()
        {
            foreach (Lectures Lectures in ListLecturesStudent)
            {
                Console.WriteLine(Lectures.GetInfo());
            }
        }

        public void AddModule(int idLectures, string nameModule, int bod)
        {
            foreach (Lectures Lectures in ListLecturesStudent)
            {
                if (idLectures == Lectures.GetID())
                {
                    Lectures.SetBodModul(nameModule, bod);
                    break;
                }
            }
            SrednjaOcenka();
        }

        public float GetSredBod()
        {
            return StredBodov;
        }

        public static void Sort(ref List<Student> ListForSort)
        {
            for (int i = 0; i < ListForSort.Count; i++)
            {
                for (int j = 0; j < ListForSort.Count - i - 1; j++)
                {
                    if (ListForSort[j].StredBodov < ListForSort[j + 1].StredBodov)
                    {
                        Student temp = ListForSort[j];
                        ListForSort[j] = ListForSort[j + 1];
                        ListForSort[j + 1] = temp;
                    }
                }
            }
        }

        public static void ForSortGroup(ref List<Student> ListForSort, ref List<Student> StudList, int idGroup)
        {
            foreach (Student stud in StudList)
            {
                if (stud.GroupStudent.GetID == idGroup)
                {
                    ListForSort.Add(stud);
                }
            }
        }

        public static void SortForModule(ref List<Student> ListForSort, ref Group ListGroup)
        {
            Dictionary<Student, float> DictListModule = new Dictionary<Student, float>();
            foreach (Lectures x in ListGroup.GetListLectures)
            {
                Console.WriteLine(x.GetInfo());
            }
            Console.WriteLine("Выберите предмет:");
            int idLectures = int.Parse(Console.ReadLine());

            foreach (Student stud in ListForSort)
            {
                DictListModule.Add(stud, stud.SredModule(idLectures));
            }
            DictListModule.OrderBy(x => x.Value);
            ListForSort.Clear();
            ListForSort = new List<Student>();
            foreach (Student stud in DictListModule.Keys)
            {
                ListForSort.Add(stud);
            }
        }

        float SredModule(int idModule)
        {
            List<float> ocenki = new List<float>();
            int ocenkiZaOdnin = 0;

            foreach (int x in ListLecturesStudent[idModule].GetModuly)
            {
                ocenkiZaOdnin += x;
            }
            return ((float)ocenkiZaOdnin / (float)ListLecturesStudent[idModule].GetModuly.Count);
        }
    }
}
