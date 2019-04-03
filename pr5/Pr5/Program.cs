using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr5
{ 
    class Program
    {  
        static void Main(string[] args)
        {
            DB db = new DB(); 

            while (true)
            {
                int choice;
                Console.WriteLine("Выберите операцию :\n- Вывод - 0;\n- Создание - 1;\n- Обновление - 2;\n- Удаление - 3;\n- Выход - 4;");
                Console.Write("Выбор : ");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    { 
                        case 0: ShowTable(db); break;
                        case 1: CreateTable(db); break;
                        case 2: db.UpdateRowTableAuto(); break;
                        case 3: db.DeleteTable(); break;
                        case 4: System.Environment.Exit(1); break;
                        default:
                            Console.WriteLine("Invalid key");
                            break;
                    }
                }
                catch (Exception)
                {
                    System.Environment.Exit(1);
                    throw;
                }
            } 
        }
        
        private static void CreateTable(DB db)
        {
            try
            {
                int tableSelection;
                Console.WriteLine("Выберите таблицу :\n- Auto - 0;\n- body - 1;\n- door - 2;\n- motor - 3;\n- wheel - 4; ");
                Console.Write("Выбор : ");
                tableSelection = Convert.ToInt32(Console.ReadLine());
                switch (tableSelection)
                {
                    case 0: db.CreateNewRowTableAuto(); break;
                    case 1: db.CreateNewRowTableBody(); break;
                    case 2: db.CreateNewRowTableDoor(); break;
                    case 3: db.CreateNewRowTableMotor(); break;
                    case 4: db.CreateNewRowTableWheel(); break;
                    default: Console.WriteLine("Wrong table selected"); break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Opps"); 
                throw;
            }
        }

        private static void ShowTable(DB db)
        {
            try
            {
                int tableSelection;
                Console.WriteLine("Выберите таблицу :\n- Auto - 0;\n- body - 1;\n- door - 2;\n- motor - 3;\n- wheel - 4; ");
                Console.Write("Выбор : ");
                tableSelection = Convert.ToInt32(Console.ReadLine());
                switch (tableSelection)
                {
                    case 0: db.GetTable("SELECT * FROM auto;"); break;
                    case 1: db.GetTable("SELECT * FROM body;"); break;
                    case 2: db.GetTable("SELECT * FROM door;"); break;
                    case 3: db.GetTable("SELECT * FROM motor;"); break;
                    case 4: db.GetTable("SELECT * FROM wheel;"); break;
                    default: Console.WriteLine("Wrong table selected"); break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Opps");
                throw;
            }
        }

    }
}
