using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Pr6
{ 
    class Program
    {
        static void Main(string[] args)
        {
            
            //List<Auto> auto = new List<
            AutoRepository autoRepository = new AutoRepository();
            //autoRepository.Create(50,"qwe123", "rweq123","qwer123",123,123);
            ShowGuitars();
            Console.Read();
        }
        private static void ShowGuitars()
        {
            //строка подключения хранится в App.config -> connectionStrings
            AutoRepository autoRepo = new AutoRepository();
            IEnumerable<Auto> autos = autoRepo.Get();
            //Вывод всех гитар из базы данных
            foreach (Auto auto in autos)
            {
                Console.WriteLine($"{auto.Id} | {auto.Firma} | {auto.Model} | {auto.Number} | {auto.Price} | {auto.Speed}");
            }
        }
    } 
}
