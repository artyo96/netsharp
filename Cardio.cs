using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportRent
{
    class Cardio
    {
        string Gabarity;
        int maxVesPolzovotelja;
        int VesTrenazhera;
        int Speed;
        int Price;
        public Cardio(string Gabarity, int maxVesPolzovotelja, int VesTrenazhera, int Speed, int Price)
        {
            this.Gabarity = Gabarity;
            this.maxVesPolzovotelja = maxVesPolzovotelja;
            this.VesTrenazhera = VesTrenazhera;
            this.Speed = Speed;
            this.Price = Price;
        }

        public override string ToString()
        {
            return String.Format("Габариты: {0}   Макс. вес пользователя: {1}   Вес тренажера: {2}", Gabarity, maxVesPolzovotelja, VesTrenazhera);
        }
    }

    class BegovajaDorozhka : Cardio
    {
        int PodemPolotna;
        string razmerPolotna;

        public BegovajaDorozhka(string Gabarity, int maxVesPolzovotelja, int VesTrenazhera, int Speed, int Price, int PodemPolotna, string razmerPolotna) :
            base(Gabarity, maxVesPolzovotelja, VesTrenazhera, Speed, Price)
        {
            this.PodemPolotna = PodemPolotna;
            this.razmerPolotna = razmerPolotna;
        }

        public override string ToString()
        {
            Console.WriteLine(base.ToString());
            Console.WriteLine("Подъем полотна(%): {0}   Размер полотна: {1}", PodemPolotna, razmerPolotna);
            return null;
        }
    }

    class VeloTren : Cardio
    {
        string Posadka;
        string Rezhimy;
        int diapazonUrovnjaNagruzki;
        public VeloTren(string Gabarity, int maxVesPolzovotelja, int VesTrenazhera, int Speed, int Price, string Posadka,
            string Rezhimy, int diapazonUrovnjaNagruzki) :
            base(Gabarity, maxVesPolzovotelja, VesTrenazhera, Speed, Price)
        {
            this.Posadka = Posadka;
            this.Rezhimy = Rezhimy;
            this.diapazonUrovnjaNagruzki = diapazonUrovnjaNagruzki;
        }

        public override string ToString()
        {
            Console.WriteLine(base.ToString());
            Console.WriteLine("Посадка: {0}   Режимы: {1}   Диапазон уровней нагрузки: {2}", Posadka, Rezhimy, diapazonUrovnjaNagruzki);
            return null;
        }
    }


}
