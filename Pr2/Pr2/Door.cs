using System;

namespace pr2
{
    public class Door
    { 
        public double Price;
        public int NumberOfDoors;
        public string ColorDoor;
         
        public Door()
	    {
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

        public void showDoor()
        {
            Console.WriteLine($"\nЦена дверей : {Price}, Колицество дверей : {NumberOfDoors}, Цвет дверей : {ColorDoor};");
        }
    }
}
