using Microsoft.EntityFrameworkCore;

namespace InMemoryWebApi
{
	public class DatabaseContext : DbContext
	{
		public DbSet<Book> Books { get; set; }

		public DatabaseContext(DbContextOptions<DatabaseContext> options)
			: base(options)
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);



		}
	}
}
