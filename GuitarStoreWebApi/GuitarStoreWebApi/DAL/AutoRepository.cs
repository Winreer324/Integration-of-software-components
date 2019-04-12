using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using System.Threading.Tasks;

namespace GuitarsProject.DAL
{
    public class AutoRepository : IRepository<Auto>
    {
        AutoContext db;

        #region PrivateMethods

        private static Auto GetYamahaPacifica012()
        {
            Auto yamahaPacifica12 = new Auto();
            yamahaPacifica12.Body = new Body
            {
                BodyColor = "агатис",
                BodyWeight = 212
            };
            yamahaPacifica12.Firma = "Yamaha";
            yamahaPacifica12.Number = "123";
            yamahaPacifica12.Model = "012";
            yamahaPacifica12.Price = 123;
            yamahaPacifica12.Speed = 123;

            yamahaPacifica12.Door = new Door()
            {
                Price = 22,
                ColorDoor = "клен"
            };

            yamahaPacifica12.Engine = new Engine()
            {
                Power = 123,
                Volume = 123,
            };

            yamahaPacifica12.Wheel = new Wheel()
            {
                Price = 123,
                Diameter = 12,
                WheelManufacturer = "1234qweqwe"
            };

            return yamahaPacifica12;
        }

        //private static Guitar GetGibsonLesPaul()
        //{
        //    Guitar gibsonLesPaul = new Guitar();
        //    gibsonLesPaul.Body = new Body
        //    {
        //        Wood = "Фигурный структурный клён",
        //        Cover = true
        //    };
        //    gibsonLesPaul.Brand = "Gibson";
        //    gibsonLesPaul.Color = Color.OrangeRed;
        //    gibsonLesPaul.Model = "True Historic 1959 Les Paul VCS Aged";
        //    gibsonLesPaul.Neck = new Neck()
        //    {
        //        Wood = "Махагони",
        //        FretsCount = 22
        //    };
        //    gibsonLesPaul.Pickups = new List<Pickup>()
        //    {
        //        new Pickup() {Color = Color.Silver, Type = Type.Humbucker},
        //        new Pickup() {Color = Color.Silver, Type = Type.Humbucker}
        //    };
        //    gibsonLesPaul.Strings = new List<GuitarString>()
        //    {
        //        new GuitarString() {Metal = "никель", Gauge = "Medium"},
        //        new GuitarString() {Metal = "никель", Gauge = "Medium"},
        //        new GuitarString() {Metal = "никель", Gauge = "Medium"},
        //        new GuitarString() {Metal = "никель", Gauge = "Medium"},
        //        new GuitarString() {Metal = "никель", Gauge = "Medium"},
        //        new GuitarString() {Metal = "никель", Gauge = "Medium"}
        //    };
        //    gibsonLesPaul.Type = GuitarType.LesPaul;

        //    return gibsonLesPaul;
        //}

        //private static Guitar GetFenderStratocaster()
        //{
        //    Guitar fenderStrat = new Guitar();
        //    fenderStrat.Body = new Body
        //    {
        //        Wood = "ольха",
        //        Cover = true
        //    };
        //    fenderStrat.Brand = "Fender";
        //    fenderStrat.Color = Color.Black;
        //    fenderStrat.Model = "Standard Stratocaster HSS";
        //    fenderStrat.Neck = new Neck()
        //    {
        //        Wood = "клён",
        //        FretsCount = 21
        //    };
        //    fenderStrat.Pickups = new List<Pickup>()
        //    {
        //        new Pickup() {Color = Color.Yellow, Type = Type.Humbucker},
        //        new Pickup() {Color = Color.Yellow, Type = Type.Single},
        //        new Pickup() {Color = Color.Yellow, Type = Type.Single}
        //    };
        //    fenderStrat.Strings = new List<GuitarString>()
        //    {
        //        new GuitarString() {Metal = "никель", Gauge = "Light"},
        //        new GuitarString() {Metal = "никель", Gauge = "Light"},
        //        new GuitarString() {Metal = "никель", Gauge = "Light"},
        //        new GuitarString() {Metal = "никель", Gauge = "Light"},
        //        new GuitarString() {Metal = "никель", Gauge = "Light"},
        //        new GuitarString() {Metal = "никель", Gauge = "Light"}
        //    };
        //    fenderStrat.Type = GuitarType.Stratocaster;

        //    return fenderStrat;
        //}

        #endregion

        public AutoRepository(AutoContext context)
        {
            db = context;
            if (db.Autos.Count() == 0)
            {
                db.Autos.Add(GetYamahaPacifica012());
                db.Autos.Add(GetYamahaPacifica012());
                db.Autos.Add(GetYamahaPacifica012());
                db.Autos.Add(GetYamahaPacifica012());
                db.Autos.Add(GetYamahaPacifica012());
                db.Autos.Add(GetYamahaPacifica012());
                db.SaveChangesAsync();
            }
        }

        public void Create(Auto auto)
        {
            db.Autos.Add(auto);
            db.SaveChanges();
        }

        public bool Delete(int id)
        {
            Auto deletingAuto = db.Autos
                .Where(g => g.Id == id)
                .FirstOrDefault();
            if (deletingAuto == null)
                return false;
            else
            {
                db.Autos.Remove(deletingAuto);
                db.SaveChanges();
                return true;
            }   
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public List<Auto> Get()
        {
            return db.Autos
                .Include(x => x.Engine)
                .Include(x => x.Door)
                .Include(x => x.Wheel)
                .Include(x => x.Body)
                .ToList();
        }

        public Auto Get(int id)
        {
            return db.Autos
                .Where(g => g.Id == id)
                .Include(x => x.Engine)
                .Include(x => x.Door)
                .Include(x => x.Body)
                .Include(x => x.Wheel)
                .FirstOrDefault();
        }

        public void Update(Auto auto)
        {
            db.Autos.Update(auto);
            db.SaveChanges();
        }

        public bool IsExists(int id)
        {
            return db.Autos.Any(e => e.Id == id);
        }
         
    }
}
