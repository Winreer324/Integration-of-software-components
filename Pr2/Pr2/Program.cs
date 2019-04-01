using System;
using System.Collections.Generic;

namespace pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> auto = new List<Auto>(); 

            auto.Add(new Auto
                (
                "Nissan", "M-6", "AA 939 F", 120132.4, 266.1,
                1188.9, "RED",
                15, 3500, "Michlen",
                350, 2.5,
                "Red", 950
                ));
            auto.Add(new Auto
                (
                "Mercede", "AMG", "AA 777 A", 70000, 350,
                3500, "Black",
                19, 12500, "Pirelli",
                500, 3.7,
                "Black", 850
                ));
            auto.Add(new Auto
                (
                "Lada", "Priora", "XE 001 P", 4640, 200,
                150, "Violet",
                15, 75, "KAMA euro",
                89, 1.6,
                "Violet", 870
                )); 

            Console.WriteLine("\nДо сортировки\n");

            foreach (Auto a in auto)
            {
                a.ShowAuto();
            }

            Auto.SortAuto(auto);

            Console.WriteLine("\nПосле сортировки\n");

            foreach (Auto a in auto)
            {
                a.ShowAuto();
            }


            Console.ReadKey();     
        }
    }

    class GFG : IComparer<Auto>
    {
        public int Compare(Auto x, Auto y)
        {
            if (x.Price == 0 || y.Price == 0)
            {
                return 0;
            }
             
            return x.Price.CompareTo(y.Price);

        }
    }
}
