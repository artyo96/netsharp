using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Lectures
    {
        int idLectures;
        string MenoLectures;
        Dictionary<string, int> Moduly;

        public Lectures(int idLectures, string MenoLectures)
        {
            this.idLectures = idLectures;
            this.MenoLectures = MenoLectures;
            Moduly = new Dictionary<string, int>();
        }

        public Dictionary<string, int>.ValueCollection GetModuly
        {
            get
            {
                return Moduly.Values;
            }
        }

        public string GetInfo()
        {
            return String.Format("ID: {0} , Название предмета: {1}", idLectures, MenoLectures);
        }

        public int GetID()
        {
            return idLectures;
        }

        public void SetBodModul(string ModulKey, int ModulBod)
        {
            {
                Moduly.Add(ModulKey, ModulBod);
            }
        }
    }
}
