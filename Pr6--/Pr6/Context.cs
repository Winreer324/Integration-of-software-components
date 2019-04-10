using System.Data.Entity;

namespace Pr6
{
    class AutoContext : DbContext
    {
        public AutoContext()
            : base("DbConnection")
        { }

        public DbSet<Auto> Autos { get; set; }
    }

    class BodyContext : DbContext
    {
        public BodyContext()
            : base("DbConnection")
        { }

        public DbSet<Body> Bodys { get; set; }
    }

    class DoorContext : DbContext
    {
        public DoorContext()
            : base("DbConnection")
        { }

        public DbSet<Door> Doors { get; set; }
    }

    class EngineContext : DbContext
    {
        public EngineContext()
            : base("DbConnection")
        { }

        public DbSet<Engine> Engines { get; set; }
    }

    class WheelContext : DbContext
    {
        public WheelContext()
            : base("DbConnection")
        { }

        public DbSet<Wheel> Wheels { get; set; }
    }
}