using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Net;

namespace Cookbook.Entities
{
	public class CookBookDbContext : DbContext
	{
		private string _connectionString = "Server=DAREKDESKTOP\\MSSQLSERVER01;Database=CookBookDb;Trusted_connection=True;TrustServerCertificate=true;";

		public DbSet<Dishes> Dishes { get; set; }
		public DbSet<Ingredients> Ingredients { get; set; }
		public DbSet<KindOfDiet> KindOfDiets { get; set; }
		public DbSet<KindOfDishes> KindOfDishes { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(_connectionString);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Ingredients>(i =>
			{
				i.HasOne(c => c.Dishes)
				.WithMany(a => a.Ingredients)
				.HasForeignKey(c => c.DishesId);


			});

			//modelBuilder.Entity<User>()
			//	.HasOne(u => u.Address)
			//	.WithOne(a => a.User)
			//	.HasForeignKey<Address>(a => a.UserId);
		}
	}
}
