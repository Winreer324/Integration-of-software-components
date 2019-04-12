using System;
using System.Collections.Generic;

namespace Pr7
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Select the action:1 - create auto, 2 - show all auto, 3 - delete row in table auto, 4 - update \n 5 - exit");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "1": CreateAutos(); break;
                    case "2": ShowAutos(); break;
                    case "3": DeleteAutos(); break;
                    case "4": UpdateAutos(); break;
                    case "5": return;
                }
            }

        }

        private static void ShowAutos()
        {
            //строка подключения хранится в App.config -> connectionStrings
            AutoRepository autoRepo = new AutoRepository();
            IEnumerable<Auto> autos = autoRepo.Get();
            //Вывод всех гитар из базы данных
            foreach (Auto auto in autos)
            {
                Console.WriteLine($"{auto.Id} | {auto.Firma} | {auto.Number} | {auto.Model} | {auto.Speed} | {auto.Price}");
            }
        }

        private static void DeleteAutos()
        {
            //строка подключения хранится в App.config -> connectionStrings
            AutoRepository autoRepo = new AutoRepository();
            IEnumerable<Auto> autos = autoRepo.Get();
            //Вывод всех гитар из базы данных
            Console.WriteLine("Enter id for delete row: ");
            int id = Convert.ToInt32(Console.ReadLine());
            autoRepo.Delete(id);
        }

        private static void CreateAutos()
        {
            AutoRepository g = new AutoRepository();
            string firma, model, number;
            double price, speed;

            Console.WriteLine("Insert id of the auto");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert firma of the auto");
            firma = Console.ReadLine();

            Console.WriteLine("Insert model of the auto");
            model = Console.ReadLine();

            Console.WriteLine("Insert number of the auto");
            number = Console.ReadLine();

            Console.WriteLine("Insert speed of the auto");
            speed = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insert price of the auto");
            price = Convert.ToDouble(Console.ReadLine());
             
            g.Create(id, firma, model, number, speed, price);

            Console.WriteLine("Done");
        }

        private static void UpdateAutos()
        {
            AutoRepository g = new AutoRepository();
            string firma, model, number;
            double price, speed;

            Console.WriteLine("Enter id row: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert firma of the auto");
            firma = Console.ReadLine();

            Console.WriteLine("Insert model of the auto");
            model = Console.ReadLine();

            Console.WriteLine("Insert number of the auto");
            number = Console.ReadLine();

            Console.WriteLine("Insert speed of the auto");
            speed = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insert price of the auto");
            price = Convert.ToDouble(Console.ReadLine());

            g.Update(id, firma, model, number, speed, price);

            Console.WriteLine("Done");
        }



















        //private static void CreateTable(DB db)
        //{
        //    try
        //    {
        //        int tableSelection;
        //        Console.WriteLine("Выберите таблицу :\n- Auto - 0;\n- body - 1;\n- door - 2;\n- motor - 3;\n- wheel - 4; ");
        //        Console.Write("Выбор : ");
        //        tableSelection = Convert.ToInt32(Console.ReadLine());
        //        switch (tableSelection)
        //        {
        //            case 0: db.CreateNewRowTableAuto(); break;
        //            case 1: db.CreateNewRowTableBody(); break;
        //            case 2: db.CreateNewRowTableDoor(); break;
        //            case 3: db.CreateNewRowTableMotor(); break;
        //            case 4: db.CreateNewRowTableWheel(); break;
        //            default: Console.WriteLine("Wrong table selected"); break;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("Opps");
        //        throw;
        //    }
        //}

        //private static void DeleteTable(DB db)
        //{
        //    try
        //    {
        //        int tableSelection;
        //        Console.WriteLine("Выберите таблицу :\n- Auto - 0;\n- body - 1;\n- door - 2;\n- motor - 3;\n- wheel - 4; ");
        //        Console.Write("Выбор : ");
        //        tableSelection = Convert.ToInt32(Console.ReadLine());
        //        switch (tableSelection)
        //        {
        //            case 0: db.CreateNewRowTableAuto(); break;
        //            case 1: db.CreateNewRowTableBody(); break;
        //            case 2: db.CreateNewRowTableDoor(); break;
        //            case 3: db.CreateNewRowTableMotor(); break;
        //            case 4: db.CreateNewRowTableWheel(); break;
        //            default: Console.WriteLine("Wrong table selected"); break;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("Opps");
        //        throw;
        //    }
        //}

        //private static void ShowTable(DB db)
        //{
        //    try
        //    {
        //        int tableSelection;
        //        Console.WriteLine("Выберите таблицу :\n- Auto - 0;\n- body - 1;\n- door - 2;\n- motor - 3;\n- wheel - 4; ");
        //        Console.Write("Выбор : ");
        //        tableSelection = Convert.ToInt32(Console.ReadLine());
        //        switch (tableSelection)
        //        {
        //            case 0: db.GetTable("SELECT * FROM auto;"); break;
        //            case 1: db.GetTable("SELECT * FROM body;"); break;
        //            case 2: db.GetTable("SELECT * FROM door;"); break;
        //            case 3: db.GetTable("SELECT * FROM motor;"); break;
        //            case 4: db.GetTable("SELECT * FROM wheel;"); break;
        //            default: Console.WriteLine("Wrong table selected"); break;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("Opps");
        //        throw;
        //    }
    }
    }

