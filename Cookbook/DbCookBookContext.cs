using Cookbook.Entities;
using Microsoft.EntityFrameworkCore;
namespace Cookbook
{
    public class DbCookBookContext : DbContext
    {
        public DbCookBookContext(DbContextOptions<DbCookBookContext> options): base(options) { }

        public DbSet<Dishes> Dishes { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<KindOfDiet> KindOfDiet { get; set; }
        public DbSet<KindOfdishes> KindOfdishes { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
