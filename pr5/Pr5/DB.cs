using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
//using MySql.Data.MySqlClient;

namespace Pr5
{
    public class DB
    {
        private const string MyConfigDB = "Database=auto;Data Source=localhost;User Id=root;Password=;";

        public DB()
        {
        }

        public void GetTable(string getQuery)
        {
            try
            { 
                MySqlConnection myConnection = new MySqlConnection(MyConfigDB);
                MySqlCommand query = myConnection.CreateCommand();

                myConnection.Open();

                query.CommandText = getQuery;
                MySqlDataReader readerDoor = query.ExecuteReader();

                while (readerDoor.Read())
                {
                    for (int i = 0; i < readerDoor.FieldCount; i++)
                    {
                        Console.Write($"{ readerDoor[i].ToString()}:");
                    }
                    Console.WriteLine();
                }

                myConnection.Close();
                //Console.WriteLine("\nПодключение прошло успешно!\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }

        public void ShowAll()
        {
            GetTable("SELECT * FROM auto;");
            //table("SELECT * FROM body;");
            //table("SELECT * FROM door;");
            //table("SELECT * FROM motor;");
            //table("SELECT * FROM wheel;");
        }

        public void UpdateRowTableAuto()
        {
            int Id;
            string Firma;
            string Model;
            string Number;
            double Price;
            double Speed;

            int[] arr = new int[4];

            Console.Write("Выберите id для обновления = ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите данные для фирмы = ");
            Firma = Convert.ToString(Console.ReadLine());

            Console.Write("Введите данные для модели = ");
            Model = Convert.ToString(Console.ReadLine());

            Console.Write("Введите данные для номера = ");
            Number = Convert.ToString(Console.ReadLine());

            Console.Write("Введите данные для цены = ");
            Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите данные для скоости = ");
            Speed = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите данные для id motor ");
            arr[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите данные для id body ");
            arr[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите данные для id wheel ");
            arr[2] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите данные для id door ");
            arr[3] = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"{Firma} {Model} {Number} {Price} {Speed} {arr[0]} {arr[1]} {arr[2]} {arr[3]}");

            try
            {  
                string Query = $"UPDATE `auto` SET `Auto_ID`='{Id}', `Firma`='{Firma}',`Model`='{Model}',`Number`='{Number}',`Price`={Price},`Speed`={Speed},`Motor_ID`={arr[0]},`Body_ID`={arr[1]},`Wheel_ID`={arr[2]},`Door_ID`={arr[3]} WHERE `Auto_ID`={Id}";

                MySqlConnection MyConn = new MySqlConnection(MyConfigDB);

                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();
                Console.WriteLine("Save Data");

                MyConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteTable()
        {
            try
            {
                int id = 0; 
                MySqlConnection myConnection = new MySqlConnection(MyConfigDB);
                MySqlCommand query = myConnection.CreateCommand();
                myConnection.Open();

                GetTable("SELECT * FROM auto;");

                Console.Write("Введите id для удаления :");
                id = Convert.ToInt32(Console.ReadLine());

                query.CommandText = $"DELETE FROM `auto` WHERE `Auto_ID`={id}";
                MySqlDataReader readerDoor = query.ExecuteReader();

                while (readerDoor.Read())
                {
                    for (int i = 0; i < readerDoor.FieldCount; i++)
                    {
                        Console.Write($"{ readerDoor[i].ToString()}:");
                    }
                    Console.WriteLine();
                }

                myConnection.Close();
                //Console.WriteLine("\nПодключение прошло успешно!\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }

        public void CreateNewRowTableAuto()
        {
            string Firma;
            string Model;
            string Number;
            double Price;
            double Speed;

            int[] arr = new int[4];

            try
            {
                Console.Write("Введите данные для фирмы = ");
                Firma = Convert.ToString(Console.ReadLine());

                Console.Write("Введите данные для модели = ");
                Model = Convert.ToString(Console.ReadLine());

                Console.Write("Введите данные для номера = ");
                Number = Convert.ToString(Console.ReadLine());

                Console.Write("Введите данные для цены = ");
                Price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите данные для скоости = ");
                Speed = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите данные для id motor ");
                arr[0] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите данные для id body ");
                arr[1] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите данные для id wheel ");
                arr[2] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите данные для id door ");
                arr[3] = Convert.ToInt32(Console.ReadLine());
                 
                string MyConnection = "Database=auto;Data Source=localhost;User Id=root;Password=;"; 
                string Query = $"INSERT INTO `auto` ( `Firma`, `Model`, `Number`, `Price`, `Speed`, `Motor_ID`, `Body_ID`, `Wheel_ID`, `Door_ID`) VALUES ('{Firma}','{Model}','{Number}',{Price},{Speed}, {arr[0]},{arr[1]},{arr[2]},{arr[3]});";
               
                MySqlConnection MyConn = new MySqlConnection(MyConnection); 
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader(); 
                Console.WriteLine("Save Data");
                while (MyReader.Read())
                {
                }
                MyConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CreateNewRowTableBody()
        {
            string BodyColor; double BodyWeight;
            Console.Write("Выберите вес автомобиля = ");
            BodyWeight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите цвет кузова = ");
            BodyColor = Convert.ToString(Console.ReadLine());

            try
            { 
                string MyConnection = "Database=auto;Data Source=localhost;User Id=root;Password=;"; 
                string Query = $"INSERT INTO `body`(`BodyColor`, `BodyWeight`) VALUES ('{BodyColor}','{BodyWeight}');";
                Console.WriteLine(Query);
                MySqlConnection MyConn = new MySqlConnection(MyConnection); 
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();  
                Console.WriteLine("Save Data");
                while (MyReader.Read())
                {
                }
                MyConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CreateNewRowTableDoor()
        {
            string ColorDoor; double Price;
            Console.Write("Выберите цену дверей = ");
            Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите цвет дверей = ");
            ColorDoor = Convert.ToString(Console.ReadLine());

            try
            {   
                string Query = $"INSERT INTO `door`(`Price`, `ColorDoor`) VALUES ('{ColorDoor}','{Price}');";
                Console.WriteLine(Query);
                MySqlConnection MyConn = new MySqlConnection(MyConfigDB); 
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();   
                Console.WriteLine("Save Data");
                while (MyReader.Read())
                {
                }
                MyConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CreateNewRowTableMotor()
        {
            double Power; double Volume;
            Console.Write("Выберите мощность мотора = ");
            Power = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите объем мотора = ");
            Volume = Convert.ToDouble(Console.ReadLine());

            try
            { 
                string Query = $"INSERT INTO `motor` (`Power`, `Volume`) VALUES ('{Power}','{Volume}');";
                Console.WriteLine(Query);
                MySqlConnection MyConn = new MySqlConnection(MyConfigDB);
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();
                Console.WriteLine("Save Data");
                while (MyReader.Read())
                {
                }
                MyConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CreateNewRowTableWheel()
        {
            int Price; int Diameter; string WheelManufacturer; 
            Console.Write("Выберите цену колёс = ");
            Price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите диаметер колёс = ");
            Diameter = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите производителя колёс = ");
            WheelManufacturer = Convert.ToString(Console.ReadLine());

            try
            { 
                string Query = $"INSERT INTO `wheel`( `Diameter`, `Price`, `WheelManufacturer``) VALUES ('{Diameter}','{Price}','{WheelManufacturer}');";
                Console.WriteLine(Query);
                MySqlConnection MyConn = new MySqlConnection(MyConfigDB);
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();
                Console.WriteLine("Save Data");
                while (MyReader.Read())
                {
                }
                MyConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } 
    }
}
