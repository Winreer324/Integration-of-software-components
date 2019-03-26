using System;
using System.IO;


namespace Pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double result = 0;

            Console.Write("Введите x: "); 
            if (double.TryParse(Console.ReadLine(), out x))
            {
                result = (double)(Math.Pow(x + (7 / 6.0), 4 / 3.0)) + Math.Sin(Math.Pow(Math.E, x)) + Math.Asin(((double)Math.Cos(Math.PI * x)));
                Console.WriteLine("result: " + result);
            }
            else
                Console.WriteLine("Не верное число... ");

            Console.WriteLine("Press to key for exit...");
            Console.ReadKey();
        }
    }
}
