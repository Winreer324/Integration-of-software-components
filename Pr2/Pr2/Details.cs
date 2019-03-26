using System;

namespace pr2
{
    public class Details : IDoorAndWhhel
    {
        Door Doors;
        Wheel Wheels;
        string BodyColor;
        string Weight;
        string Motor;

        public Details()
        {
            Doors = new Door();
            Wheels = new Wheel();
        }

        public void AddDetails()
        {   
            Console.Write("Введите какой цвет машины?: ");
            BodyColor = Convert.ToString(Console.ReadLine());

            Console.Write("Введите сколько весит машина? : ");
            Weight = Convert.ToString(Console.ReadLine());

            Console.Write("Введите какая мощность у машины? : ");
            Motor = Convert.ToString(Console.ReadLine());

            
            Doors.AddDoor();

            Wheels.AddWheel();
        }

        public void ShowDetails() 
        {
            Console.WriteLine($"\nЦвет машины : {BodyColor}, Вес машины : {Weight}, Мощность машины : {Motor};");
        }
    }; 
}