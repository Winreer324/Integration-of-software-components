﻿using System;
using System.Collections.Generic;

namespace Pr5
{
    public class Door
    { 
        public double Price;
        public string ColorDoor;

        public static List<object> DoorArray;

        public Door(double Price, string ColorDoor)
	    {
            this.Price = Price; this.ColorDoor = ColorDoor;
        }

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
