using System;
using System.Collections.Generic;

namespace Pr6
{
    public class Wheel
    {
        public int Id { get; set; }
        public int Diameter { get; set; }
        public double Price { get; set; }
        public string WheelManufacturer { get; set; }
          
        public void AddWheel()
        {
            Console.Write("Введите диаметр колес : ");
            Diameter = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите цену колёс за 4 шт. :");
            Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите производителя колес : ");
            WheelManufacturer = Convert.ToString(Console.ReadLine()); 
        }

        public void ShowWheel()
        {
            Console.WriteLine($"\nДиаметр колес : {Diameter}, Цена колёс за 4 шт. : {Price}, Производитель колес : {WheelManufacturer};");
        }
    }
}