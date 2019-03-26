using System;
using System.Collections.Generic;

namespace pr2
{
    public class Door
    { 
        public double Price;
        public int NumberOfDoors;
        public string ColorDoor;

        public static List<object> DoorArray;

        public Door(double Price, int NumberOfDoors, string ColorDoor)
	    {
            //DoorArray = new List<object> { this.Price, this.NumberOfDoors, this.ColorDoor };
            this.Price = Price; this.NumberOfDoors = NumberOfDoors; this.ColorDoor = ColorDoor;
        }

        public void AddDoor()
        { 
            Console.Write("Введите количество дверей :");
            NumberOfDoors = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Введите цену за {NumberOfDoors} двери : ");
            Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите цвет дверей : ");
            ColorDoor = Convert.ToString(Console.ReadLine());
        }
         
        public void ShowDoor()
        {
            Console.WriteLine($"\nЦена дверей : {Price}, Колицество дверей : {NumberOfDoors}, Цвет дверей : {ColorDoor};");
        }
    }
}
