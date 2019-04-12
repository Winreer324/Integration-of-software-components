using System.Data.Entity;

namespace Pr7
{
    class AutoContext : DbContext
    {

        public AutoContext()
            : base("auto")
        { }

        public DbSet<Auto> Autos { get; set; }
        public DbSet<Body> Bodys { get; set; }
        public DbSet<Door> Doors { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Wheel> Wheels { get; set; }
    }
}