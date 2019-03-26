using System;
using System.Collections.Generic;

namespace pr2
{
    public class Details
    {
        public string BodyColor;
        public double Weight;
        public string Motor;

        //public List<var> DetailsArray;

        public Door DoorObj;
        public Wheel WheelObj;

        public Details(
            string BodyColor, double Weight, string Motor,
            double PriceDoor, int NumberOfDoors, string ColorDoor,
            int Diameter, double PriceWheel, string WheelManufactures
            )
        {
            this.BodyColor = BodyColor; this.Weight = Weight; this.Motor = Motor;
            DoorObj = new Door(PriceDoor, NumberOfDoors, ColorDoor);
            WheelObj = new Wheel(Diameter, PriceWheel, WheelManufactures);
            //DetailsArray = new Array { DoorObj, WheelObj };
        }

        public void AddDetails()
        {   
            Console.Write("Введите какой цвет машины?: ");
            BodyColor = Convert.ToString(Console.ReadLine());

            Console.Write("Введите сколько весит машина? : ");
            Weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите какая мощность у машины? : ");
            Motor = Convert.ToString(Console.ReadLine());

            
            //Doors.AddDoor();

            //Wheels.AddWheel();
        }

        public void ShowDetails() 
        {
            Console.WriteLine($"\nЦвет машины : {BodyColor}, Вес машины : {Weight}, Мощность машины : {Motor};");
        }
    }; 
}