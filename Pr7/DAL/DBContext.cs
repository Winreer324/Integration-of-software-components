using Microsoft.EntityFrameworkCore;

namespace Pr7
{
    class AutoContext : DbContext
    {

        //public AutoContext()
        //    : base("auto_migration")
        //{ }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=auto_migrarion;Uid=root;Pwd=;CharSet=utf8");
        }

        public DbSet<Auto> Autos { get; set; }
        public DbSet<Body> Bodys { get; set; }
        public DbSet<Door> Doors { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Wheel> Wheels { get; set; }
    }
}