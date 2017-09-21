using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportRent
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Skates> ListSkates = new List<Skates>();
            List<Boots> ListBoots = new List<Boots>();
            List<VeloTren> ListVelo = new List<VeloTren>();
            List<BegovajaDorozhka> ListBegDor = new List<BegovajaDorozhka>();
            int menu = -1;
            do
            {
                try
                {
                    int menuInC;
                    Console.WriteLine("1. Добавить часть инвентарь \n2. Показать инвентарь \n3. Выход");
                    menu = int.Parse(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("1. Добавить скейт \n2. Добавить бутсы \n3. Добавить велотренажер \n4. Добавить беговую дорожку");
                            menuInC = int.Parse(Console.ReadLine());
                            switch (menuInC)
                            {
                                case 1:
                                    Console.WriteLine("Введите тип скейта:");
                                    string TypeSkates = Console.ReadLine();
                                    Console.WriteLine("Класс скейта:");
                                    string ClassSkates = Console.ReadLine();
                                    Console.WriteLine("Размер скейта:");
                                    int SizeShoeSkates = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Цвет скейта:");
                                    string ColorShoeSkates = Console.ReadLine();
                                    Console.WriteLine("Цену скейта:");
                                    int PriceSkates = int.Parse(Console.ReadLine());
                                    ListSkates.Add(new Skates(TypeSkates, ClassSkates, SizeShoeSkates, ClassSkates, PriceSkates));
                                    Console.WriteLine("Часть инвентаря добавлена!");
                                    break;
                                   
                                case 2:
                                    Console.WriteLine("Введите назначение бутсов:");
                                    string FunctionUse = Console.ReadLine();
                                    Console.WriteLine("Размер шипов:");
                                    int SizeThorns = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Форму шипов:");
                                    string FormThorns = Console.ReadLine();
                                    Console.WriteLine("Размер бутсов:");
                                    int SizeShoe = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Цвет бутсов:");
                                    string ColorShoe = Console.ReadLine();
                                    Console.WriteLine("Цену бутсов:");
                                    int Price = int.Parse(Console.ReadLine());
                                    ListBoots.Add(new Boots(FunctionUse, SizeThorns, FormThorns, SizeShoe, ColorShoe, Price));
                                    Console.WriteLine("Часть инвентаря добавлена!");
                                    break;
                                case 3:
                                    Console.WriteLine("Введите габариты:");
                                    string Gabarity = Console.ReadLine();
                                    Console.WriteLine("Максимальный вес пользователя:");
                                    int maxVesPolzovotelja = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Вес тренажера ");
                                    int VesTrenazhera = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Скорость тренажера: ");
                                    int Speed = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Цену тренажера:");
                                    int PriceVelo = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Посадку велотренажера:");
                                    string Posadka = Console.ReadLine();
                                    Console.WriteLine("Режимы велотренажера:");
                                    string Rezhimy = Console.ReadLine();
                                    Console.WriteLine("Уровни нагрузки:");
                                    int diapazonUrovnjaNagruzki = int.Parse(Console.ReadLine());
                                    ListVelo.Add(new VeloTren(Gabarity, maxVesPolzovotelja, VesTrenazhera, Speed, PriceVelo, Posadka, Rezhimy, diapazonUrovnjaNagruzki));
                                    Console.WriteLine("Часть инвентаря добавлена!");
                                    break;
                                case 4:
                                    Console.WriteLine("Введите габариты :");
                                    string GabarityBegDor = Console.ReadLine();
                                    Console.WriteLine("Максимальный вес пользователя:");
                                    int maxVesPolzovoteljaBegDor = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Вес тренажера: ");
                                    int VesTrenazheraBegDor = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Скорость тренажера: ");
                                    int SpeedBegDor = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Цену тренажера:");
                                    int PriceBegDor = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Подъем полотна (в градусах):");
                                    int PodemPolotna = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Размер полотна беговой дорожки:");
                                    string razmerPolotna = Console.ReadLine();
                                    ListBegDor.Add(new BegovajaDorozhka(GabarityBegDor, maxVesPolzovoteljaBegDor, VesTrenazheraBegDor,
                                        SpeedBegDor, PriceBegDor, PodemPolotna, razmerPolotna));
                                    Console.WriteLine("Часть инвентаря добавлена!");
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("1. Посмотреть Скейты \n2. Бутсы \n3. Велотренажеры \n4. Беговые дорожки");
                            menuInC = int.Parse(Console.ReadLine());
                            switch (menuInC)
                            {
                                case 1:
                                    foreach (Skates skate in ListSkates)
                                    {
                                        skate.ToString();
                                    }
                                    break;
                                case 2:
                                    foreach (Boots boot in ListBoots)
                                    {
                                        boot.ToString();
                                    }
                                    break;
                                case 3:
                                    foreach (VeloTren velo in ListVelo)
                                    {
                                        velo.ToString();
                                    }
                                    break;
                                case 4:
                                    foreach (BegovajaDorozhka begDor in ListBegDor)
                                    {
                                        begDor.ToString();
                                    }
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (menu != 3);
        }
    }
}
