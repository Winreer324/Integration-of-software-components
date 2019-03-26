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
                "Nissan", "M-6", "AA 9392 F", 120132.4, 266.1,
                "Red", 1188.9, "V8",
                8500.0, 4, "Red",
                19, 1233.1, "Audi"
                ));
            auto.Add(new Auto
                (
                "Audi", "GT-21", "AF 2322 F", 320132.4, 321.8,
                "Red", 1932.3, "V8",
                12999.4, 4, "Red",
                21, 2576.4, "Audi"
                ));
            auto.Add(new Auto
                (
                "BMV", "X-9", "HF 1111 C", 290242.4, 261.1,
                "Black", 1432.3, "SG-2",
                11400.4, 2, "Black",
                19, 1926.4, "Nissan"
                ));
            
            //Console.WriteLine($"Wheel Diameter {auto[0].WheelObj.Diameter}");
            //Console.WriteLine($"Wheel Price {auto[0].WheelObj.Price}");
            //Console.WriteLine($"Wheel WheelManufactures {auto[0].WheelObj.WheelManufacturer}");
            //{ Firma = "Audi", Model = "GT-212", Number = "AF 2021 F", Price = 118050, Speed = 281.0 }
            //auto.Add(new Auto() { Firma = "BMV", Model = "A-8", Number = "AX 9341 F", Price = 154010, Speed = 334.0 });
            //auto.Add(new Auto() { Firma = "Kia", Model = "V-prm", Number = "FF 8431 F", Price = 152300, Speed = 320.0 });
            //auto.Add(new Auto() { Firma = "Tayota", Model = "GT-3", Number = "AA 5643 F", Price = 126500, Speed = 256.0 });
            //auto.Add(new Auto() { Firma = "Audi", Model = "I-7", Number = "WS 9412 F", Price = 345000, Speed = 275.0 });
            //auto.Add(new Auto() { Firma = "Lexus", Model = "Juke", Number = "AB 4801 E", Price = 205000, Speed = 304.0 });
            //auto.Add(new Auto() { Firma = "Scoda", Model = "AD", Number = "UY 0041 W", Price = 120000, Speed = 249.0 });
            //auto.Add(new Auto() { Firma = "Audi", Model = "Murato", Number = "EB 9412 Q", Price = 129000, Speed = 312.0 });
            //auto.Add(new Auto() { Firma = "Kia", Model = "X-2", Number = "LE 0211 F", Price = 121000, Speed = 254.0 });
            //auto.Add(new Auto() { Firma = "Audi", Model = "X-8", Number = "AF 8421 F", Price = 234000, Speed = 273.0 });

         

            //GFG sortAuto = new GFG();

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
