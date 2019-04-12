

using GuitarsProject.DAL;
using Microsoft.EntityFrameworkCore;

namespace GuitarsProject
{
    public class AutoContext : DbContext
    {
        public AutoContext(DbContextOptions<AutoContext> options)
            : base(options)
        {
        }

        public DbSet<Auto> Autos { get; set; }
        public DbSet<Body> Bodies { get; set; }
        public DbSet<Door> Doors { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Wheel> Wheels { get; set; }
    }
}
