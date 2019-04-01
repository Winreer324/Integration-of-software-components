using Pr6;
using System;
using System.Collections.Generic;

namespace Pr6
{
    //public class Auto : IComparable<Auto>
    public class Auto 
    {
        public int Id { get; set; }
        public string Firma { get; set; }
        public string Model { get; set; }
        public string Number { get; set; }
        public double Price { get; set; }
        public double Speed { get; set; }

        //public Door DoorAutoId { get; set; }
        //public Wheel WheelAutoId { get; set; }
        //public Engine EngineAutoId { get; set; }
        //public Body BodyAutoId { get; set; }

        //public Auto
        //    (
        //    string Firma, string Model, string Number, double Price, double Speed,
        //    double PriceDoor, string ColorDoor,
        //    int DiameterWheel, double PriceWheel, string WheelManufacturer,
        //    double PowerEngine, double VolumeEngine,
        //    string BodyColor, double BodyWeight
        //    )
        //{
        //    this.Firma = Firma;
        //    this.Model = Model;
        //    this.Number = Number;
        //    this.Price = Price;
        //    this.Speed = Speed;

        //    DoorAuto = new Door(PriceDoor, ColorDoor);
        //    WheelAuto = new Wheel(DiameterWheel, PriceWheel, WheelManufacturer);
        //    EngineAuto = new Engine(PowerEngine, VolumeEngine);
        //    BodyAuto = new Body(BodyColor, BodyWeight);
        //}

        //public int CompareTo(Auto o)
        //{
        //    Auto p = o as Auto;
        //    if (p != null)
        //        return this.Speed.CompareTo(p.Speed);
        //    else
        //        throw new Exception("Невозможно сравнить два объекта");
        //}

        //public void AddAuto()
        //{
        //    Console.Write("Введите фирму автомобиля : ");
        //    Firma = Convert.ToString(Console.ReadLine());

        //    Console.Write("Введите модель автомобиля :");
        //    Model = Convert.ToString(Console.ReadLine());

        //    Console.Write("Введите номер автомобиля : ");
        //    Number = Convert.ToString(Console.ReadLine());

        //    Console.Write("Введите цену автомобиля : ");
        //    Price = Convert.ToDouble(Console.ReadLine());

        //    Console.Write("Введите скорость автомобиля : ");
        //    Speed = Convert.ToDouble(Console.ReadLine());
        //}

        //public void ShowAuto()
        //{
        //    Console.WriteLine($"\nПроизводитель : {Firma}, Модель : {Model}, Номер : {Number}, Цена : {Price}, Скороть : {Speed};");
        //}

        //public static List<Auto> SortAuto(List<Auto> auto)
        //{
        //    Console.WriteLine("\nЧто сортировать? (1 - фирма, 2 - модель, 3 - номер, 4 - цена, 5 - скорость)");
        //    int sortColumn = Convert.ToInt32(Console.ReadLine());

        //    if (sortColumn == 1)
        //    {
        //        Console.WriteLine("Сортировать по возрастанию - 1, убыванию - 2");
        //        int question = Convert.ToInt32(Console.ReadLine());
        //        switch (question)
        //        {
        //            case 1:
        //                auto.Sort(delegate (Auto us1, Auto us2)
        //                { return us1.Firma.CompareTo(us2.Firma); });
        //                break;
        //            case 2:
        //                auto.Sort(delegate (Auto us1, Auto us2)
        //                { return us2.Firma.CompareTo(us1.Firma); });
        //                break;
        //            default:
        //                Console.WriteLine("Вы ввели не то...");
        //                break;
        //        }
        //    }
        //    else if (sortColumn == 2)
        //    {
        //        Console.WriteLine("Сортировать по возрастанию - 1, убыванию - 2");
        //        int question = Convert.ToInt32(Console.ReadLine());
        //        switch (question)
        //        {
        //            case 1:
        //                auto.Sort(delegate (Auto us1, Auto us2)
        //                { return us1.Model.CompareTo(us2.Model); });
        //                break;
        //            case 2:
        //                auto.Sort(delegate (Auto us1, Auto us2)
        //                { return us2.Model.CompareTo(us1.Model); });
        //                break;
        //            default:
        //                Console.WriteLine("Вы ввели не то...");
        //                break;
        //        }
        //    }
        //    else if (sortColumn == 3)
        //    {
        //        Console.WriteLine("Сортировать по возрастанию - 1, убыванию - 2");
        //        int question = Convert.ToInt32(Console.ReadLine());
        //        switch (question)
        //        {
        //            case 1:
        //                auto.Sort(delegate (Auto us1, Auto us2)
        //                { return us1.Number.CompareTo(us2.Number); });
        //                break;
        //            case 2:
        //                auto.Sort(delegate (Auto us1, Auto us2)
        //                { return us2.Number.CompareTo(us1.Number); });
        //                break;
        //            default:
        //                Console.WriteLine("Вы ввели не то...");
        //                break;
        //        }
        //    }
        //    else if (sortColumn == 4)
        //    {
        //        Console.WriteLine("Сортировать по возрастанию - 1, убыванию - 2");
        //        int question = Convert.ToInt32(Console.ReadLine());
        //        switch (question)
        //        {
        //            case 1:
        //                auto.Sort(delegate (Auto us1, Auto us2)
        //                { return us1.Price.CompareTo(us2.Price); });
        //                break;
        //            case 2:
        //                auto.Sort(delegate (Auto us1, Auto us2)
        //                { return us2.Price.CompareTo(us1.Price); });
        //                break;
        //            default:
        //                Console.WriteLine("Вы ввели не то...");
        //                break;
        //        }
        //    }
        //    else if (sortColumn == 5)
        //    {
        //        Console.WriteLine("Сортировать по возрастанию - 1, убыванию - 2");
        //        int question = Convert.ToInt32(Console.ReadLine());
        //        switch (question)
        //        {
        //            case 1:
        //                auto.Sort(delegate (Auto us1, Auto us2)
        //                { return us1.Speed.CompareTo(us2.Speed); });
        //                break;
        //            case 2:
        //                auto.Sort(delegate (Auto us1, Auto us2)
        //                { return us2.Speed.CompareTo(us1.Speed); });
        //                break;
        //            default:
        //                Console.WriteLine("Вы ввели не то...");
        //                break;
        //        }
        //    }

        //    return auto;
        //}
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