using System;
using System.Collections.Generic;
using System.Linq;

namespace Pr7
{
    internal class AutoRepository : IRepository<Auto>
    {
        AutoContext db;
        public AutoRepository()
        {
            db = new AutoContext();
        }
        public void Create(int id, string firma, string model, string number, double speed, double price)
        {
            Auto creatingAuto = new Auto
            {
                Id = id,
                Firma = firma,
                Number = number,
                Model = model,
                Speed = speed,
                Price = price
            };
            db.Autos.Add(creatingAuto);
            db.SaveChanges();
        } 
        public void Delete(int id)
        {
            Auto deletingAuto = db.Autos.Where(g => g.Id == id).FirstOrDefault();
            db.Autos.Remove(deletingAuto);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public IEnumerable<Auto> Get()
        {
            return db.Autos;
        }  

        public void Update(int id, string firma, string model, string number, double speed, double price)
        {
            Auto updatingAuto = db.Autos.Where(g => g.Id == id).FirstOrDefault();
            updatingAuto.Firma = firma;
            updatingAuto.Model = model;
            updatingAuto.Number = number;
            updatingAuto.Price = price;
            updatingAuto.Speed = speed;
            db.SaveChanges();
        }
 
    }
}