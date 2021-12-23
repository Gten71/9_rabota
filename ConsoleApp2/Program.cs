using System;
using System.Linq;
namespace ConsoleApp2
{
    class Program
    {
        struct Studia
        {
            public string nameK;
            public DateTime nach;
            public TimeSpan ach;
            public TimeSpan kon;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько проектов");
            int k = int.Parse(Console.ReadLine());
            Studia[] doms = new Studia[k];
            for (int i = 0; i < doms.Length; i++)
            {
                Console.Write("Введите название кaнала: ");
                doms[i].nameK = Console.ReadLine();
                Console.WriteLine("Введите дату проведения профилактики: ");
                Console.WriteLine("День");
                int d = int.Parse(Console.ReadLine());
                Console.WriteLine("Месяц");
                int m = int.Parse(Console.ReadLine());
                Console.WriteLine("Год");
                int g = int.Parse(Console.ReadLine());
                doms[i].nach = new DateTime(g, m, d);
                Console.WriteLine("Введите время начала проф работ : ");
                Console.WriteLine("Часы");
                int d1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Минуты");
                int m1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Секунды");
                int g1 = int.Parse(Console.ReadLine());
                doms[i].ach = new TimeSpan(d1, m1, g1);
                Console.WriteLine("Введите время конца проф работ : ");
                Console.WriteLine("Часы");
                int d2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Минуты");
                int m2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Секунды");
                int g2 = int.Parse(Console.ReadLine());
                doms[i].kon = new TimeSpan(d2, m2, g2);

                TimeSpan t = new TimeSpan(22, 00, 00);
                TimeSpan h = new TimeSpan(06, 00, 00);
                int q = 0;
                if (doms[i].ach > t && doms[i].ach < h)
                {
                    q = 1;
                }
                foreach (Studia item in doms)
                {
                    
                        Console.WriteLine(item.nameK +" "+ item.nach +""+ item.ach +""+ item.kon);
                    
            }
            }
            
        }
    }
}
