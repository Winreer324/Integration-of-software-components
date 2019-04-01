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
            //List<Auto> auto = new List<Auto>();
            using (AutoContext db = new AutoContext())
            {
                Auto auto1 = new Auto
                { 
                    Firma = "Nissan",
                    Model = "M-6",
                    Number = "AA 939 F",
                    Price = 120132.4,
                    Speed = 266.1, 
                }; 
                Auto auto2 = new Auto
                { 
                    Firma = "Audi",
                    Model = "XR",
                    Number = "AA 939 F",
                    Price = 120132.4,
                    Speed = 266.1, 
                }; 
                Auto auto3 = new Auto
                { 
                    Firma = "Volga",
                    Model = "332",
                    Number = "AA 939 F",
                    Price = 120132.4,
                    Speed = 266.1, 
                };

                db.Autos.Add(auto1);
                db.Autos.Add(auto2);
                db.Autos.Add(auto3);
                //db.Autos.Add(new Auto
                //(
                //Firma: "Nissan",Model: "M-6", Number:"AA 939 F", Price: 120132.4, Speed: 266.1,
                //PriceDoor: 1188.9, ColorDoor: "RED",
                //DiameterWheel: 15, PriceWheel: 3500, WheelManufacturer: "Michlen",
                //PowerEngine: 350, VolumeEngine: 2.5,
                //BodyColor: "Red", BodyWeight: 950
                //));
                //db.Autos.Add(new Auto
                //(
                //Firma: "Nissan", Model: "M-2", Number: "AA 245 A", Price: 120132.4, Speed: 229.7,
                //PriceDoor: 1311.2, ColorDoor: "Blue",
                //DiameterWheel: 18, PriceWheel: 4150, WheelManufacturer: "Michlen",
                //PowerEngine: 277, VolumeEngine: 3.1,
                //BodyColor: "Blue", BodyWeight: 1050
                //));
                //db.Autos.Add(new Auto
                //(
                //Firma: "Audi", Model: "RX", Number: "FF 111 F", Price: 140222.3, Speed: 412.1,
                //PriceDoor: 2924.5, ColorDoor: "Black",
                //DiameterWheel: 20, PriceWheel: 3246, WheelManufacturer: "Michlen",
                //PowerEngine: 331, VolumeEngine: 2.7,
                //BodyColor: "Black", BodyWeight: 870
                //));


                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var autos = db.Autos;
                Console.WriteLine("Список объектов:");
                foreach (Auto u in autos)
                {
                    Console.WriteLine("Auto: {0}.{1} - {2} - {3} - {4} - {5}", u.Id, u.Firma, u.Model, u.Number, u.Price, u.Speed);
                    
                     
                }
            }

            using (BodyContext db = new BodyContext())
            {
                // создаем два объекта User
                Body body1 = new Body { BodyColor = "Red", BodyWeight = 950 };
                Body body2 = new Body { BodyColor = "Black", BodyWeight = 1125 };
                Body body3 = new Body { BodyColor = "Blue", BodyWeight = 1075 };

                // добавляем их в бд
                db.Bodys.Add(body1);
                db.Bodys.Add(body2);
                db.Bodys.Add(body3);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var bodys = db.Bodys;
                Console.WriteLine("Список объектов:");
                foreach (Body u in bodys)
                {
                    Console.WriteLine("Body: {0}.{1} - {2}", u.Id, u.BodyColor, u.BodyWeight);
                }
            }

            using (DoorContext db = new DoorContext())
            {
                // создаем два объекта User
                Door door1 = new Door { ColorDoor = "Red", Price = 950 }; 
                Door door2 = new Door { ColorDoor = "Blue", Price = 1450 }; 
                Door door3 = new Door { ColorDoor = "Black", Price = 1100 }; 
                Door door4 = new Door { ColorDoor = "White", Price = 790 }; 

                // добавляем их в бд
                db.Doors.Add(door1); 
                db.Doors.Add(door2); 
                db.Doors.Add(door3); 
                db.Doors.Add(door4); 

                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var doors = db.Doors;
                Console.WriteLine("Список объектов:");
                foreach (Door u in doors)
                {
                    Console.WriteLine("Door: {0}.{1} - {2}", u.Id, u.ColorDoor, u.Price);
                }
            }

            using (EngineContext db = new EngineContext())
            {
                // создаем два объекта User
                Engine engine1 = new Engine { Power = 320.8, Volume = 450 }; 
                Engine engine2 = new Engine { Power = 258.3, Volume = 3500 }; 
                Engine engine3 = new Engine { Power = 423.1, Volume = 510 }; 
                Engine engine4 = new Engine { Power = 542.4, Volume = 640 }; 
                Engine engine5 = new Engine { Power = 187.8, Volume = 240 }; 

                // добавляем их в бд
                db.Engines.Add(engine1); 
                db.Engines.Add(engine2); 
                db.Engines.Add(engine3); 
                db.Engines.Add(engine4); 
                db.Engines.Add(engine5); 

                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var engines = db.Engines;
                Console.WriteLine("Список объектов:");
                foreach (Engine u in engines)
                {
                    Console.WriteLine("Engine: {0}.{1} - {2}", u.Id, u.Power, u.Volume);
                }
            }

            using (WheelContext db = new WheelContext())
            {
                // создаем два объекта User
                Wheel wheel1 = new Wheel { Diameter = 17, Price = 1450.9 , WheelManufacturer = "Test1"}; 
                Wheel wheel2 = new Wheel { Diameter = 18, Price = 700 , WheelManufacturer = "Test2"}; 
                Wheel wheel3 = new Wheel { Diameter = 19, Price = 1000 , WheelManufacturer = "Test3"}; 
                Wheel wheel4 = new Wheel { Diameter = 16, Price = 1150.9 , WheelManufacturer = "Test4"}; 
                Wheel wheel5 = new Wheel { Diameter = 20, Price = 1750.9 , WheelManufacturer = "Test5"}; 
                Wheel wheel6 = new Wheel { Diameter = 22, Price = 2300 , WheelManufacturer = "Test6"}; 

                // добавляем их в бд
                db.Wheels.Add(wheel1); 
                db.Wheels.Add(wheel2); 
                db.Wheels.Add(wheel3); 
                db.Wheels.Add(wheel4); 
                db.Wheels.Add(wheel5); 
                db.Wheels.Add(wheel6); 

                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var wheels = db.Wheels;
                Console.WriteLine("Список объектов:");
                foreach (Wheel u in wheels)
                {
                    Console.WriteLine("Wheel: {0}.{1} - {2} - {3}", u.Id, u.Diameter, u.Price, u.WheelManufacturer);
                }
            } 

            Console.Read();
        }
    } 
}
