using System;
using System.Collections.Generic;

namespace Pr6
{
    public class Door
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string ColorDoor { get; set; } 
         

        public void AddDoor()
        { 
            Console.Write($"Введите цену за {Price} дверей : ");
            Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите цвет дверей : ");
            ColorDoor = Convert.ToString(Console.ReadLine());
        }
         
        public void ShowDoor()
        {
            Console.WriteLine($"\nЦена дверей : {Price}, Цвет дверей : {ColorDoor};");
        }
    }
}
