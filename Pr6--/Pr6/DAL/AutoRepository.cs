using System;
using System.Collections.Generic;
using System.Linq;

namespace Pr6
{
    internal class AutoRepository : IRepository<Auto>
    {
        AutoContext db;
        public AutoRepository()
        {
            db = new AutoContext();
        }
        public void Create(Auto auto)
        {
            db.Autos.Add(auto);
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

        public List<Auto> Get()
        {
            return db.Autos
                .Include(x => x.Firma)
                .Include(x => x.Model)
                .Include(x => x.Number)
                .Include(x => x.Speed)
                .Include(x => x.Price)
                .ToList();
        }

        public Auto Get(int id)
        {
            return db.Autos
                .Where(g => g.Id == id)
                .Include(x => x.Firma)
                .Include(x => x.Model)
                .Include(x => x.Number)
                .Include(x => x.Speed)
                .Include(x => x.Price)
                .FirstOrDefault();
        }

        public void Update(Auto auto)
        {
            Auto updatingAuto = db.Autos
                .Where(g => g.Id == auto.Id)
                .FirstOrDefault();
            updatingAuto = auto;
            db.SaveChanges();
        }

        IEnumerable<Auto> IRepository<Auto>.Get()
        {
            throw new NotImplementedException();
        }
    }
}