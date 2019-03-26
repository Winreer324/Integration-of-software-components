using System;

namespace pr2
{
    public class Auto
    {
        public string Firma { get; set; }
        public string Model { get; set; }
        public string Number { get; set; }
        public double Price { get; set; }
        public double Speed { get; set; } 

        Details DetailsAuto;
        Door DoorAuto;
        Wheel WheelAuto;

        public Auto()
        {
            DetailsAuto = new Details();
            DoorAuto = new Door();
            WheelAuto = new Wheel();
        }

        public void InitDetails()
        {
            DetailsAuto = new Details();
        }

        public void InitDoors()
        {
            DoorAuto = new Door();
        }

        public void InitWheels()
        {
            WheelAuto = new Wheel();
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