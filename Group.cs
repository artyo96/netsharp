using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Group
    {
        int id;
        string NameGroup;
        List<Lectures> ListLectures;

        public Group(int id, string NameGroup)
        {
            this.id = id;
            this.NameGroup = NameGroup;
            ListLectures = new List<Lectures>();
        }

        public void ShowGroup()
        {
            Console.WriteLine("ID: {0}, Группа: {1}", id, NameGroup);
        }

        public Lectures SetListLectures
        {
            set
            {
                ListLectures.Add(value);
            }
        }
        public List<Lectures> GetListLectures
        {
            get
            {
                return ListLectures;
            }
        }

        public string GetNameGroup
        {
            get
            {
                return NameGroup;
            }
        }
        public int GetID
        {
            get
            {
                return id;
            }
        }
    }
}
