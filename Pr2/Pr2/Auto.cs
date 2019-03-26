using System;
using System.Collections.Generic;

namespace pr2
{
    public class Auto : Details,  IComparable<Auto>
    {
        public string Firma { get; set; }
        public string Model { get; set; }
        public string Number { get; set; }
        public double Price { get; set; }
        public double Speed { get; set; }

        //List<object> DetailsAutoArray = new List<object> { DoorAuto, Wheel };

        //Details DetailsAuto;
        //Door DoorAuto; 
        //Wheel WheelAuto;

        public Auto
            (
            string Firma, string Model, string Number, double Price, double Speed,
            string BodyColor, double Weight, string Motor,
            double PriceDoor, int NumberOfDoors, string ColorDoor,
            int Diameter, double PriceWheel, string WheelManufactures
            ) : base
            (
             BodyColor,  Weight,  Motor,
             PriceDoor,  NumberOfDoors,  ColorDoor,
             Diameter, PriceWheel,  WheelManufactures
            )
        {
            this.Firma = Firma;
            this.Model = Model;
            this.Number = Number;
            this.Price = Price;
            this.Speed = Speed;
        }

        public int CompareTo(Auto o)
        {
            Auto p = o as Auto;
            if (p != null)
                return this.Speed.CompareTo(p.Speed);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }

        public void AddAuto()
        {
            Console.Write("Введите фирму автомобиля : ");
            Firma = Convert.ToString(Console.ReadLine());

            Console.Write("Введите модель автомобиля :");
            Model = Convert.ToString(Console.ReadLine());

            Console.Write("Введите номер автомобиля : ");
            Number = Convert.ToString(Console.ReadLine());

            Console.Write("Введите цену автомобиля : ");
            Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите скорость автомобиля : ");
            Speed = Convert.ToDouble(Console.ReadLine());
        }

        public void ShowAuto()
        {
            Console.WriteLine($"\nПроизводитель : {Firma}, Модель : {Model}, Номер : {Number}, Цена : {Price}, Скороть : {Speed};"); 
        }

       
    }
}