using System;
using System.Collections.Generic;

namespace pr2
{
    public class Wheel
    {
        public int Diameter;
        public double Price; 
        public string WheelManufacturer;

        public static Wheel Wheels;

        public Wheel(int Diameter, double Price, string WheelManufacturer)
        {
            //Wheels = new Wheel(this.Diameter, this.Price, this.WheelManufacturer);
            this.Diameter = Diameter; this.Price = Price; this.WheelManufacturer = WheelManufacturer;
        }

        public void AddWheel()
        {
            Console.Write("Введите диаметр колес : ");
            Diameter = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите цену колёс за 4 шт. :");
            Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите производителя колес : ");
            WheelManufacturer = Convert.ToString(Console.ReadLine()); 
        }

        public void showWheel()
        {
            Console.WriteLine($"\nДиаметр колес : {Diameter}, Цена колёс за 4 шт. : {Price}, Производитель колес : {WheelManufacturer};");
        }
    }
}