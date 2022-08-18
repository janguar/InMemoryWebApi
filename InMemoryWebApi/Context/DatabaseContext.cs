using InMemoryWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace InMemoryWebApi.Context
{
	public class DatabaseContext : DbContext
	{
		public DbSet<Address> Address { get; set; }

		public DbSet<Album> Albums { get; set; }
		public DbSet<BookEntity> BookEntities { get; set; }

		public DbSet<Comment> Comments { get; set; }

		public DbSet<Company> Companies { get; set; }
		public DbSet<Geo> Geo { get; set; }
		public DbSet<Photo> Photos { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<Todo> Todos { get; set; }
		public DbSet<User> Users { get; set; }

		public DatabaseContext(DbContextOptions<DatabaseContext> options)
		: base(options)
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlite(@"DataSource=mydatabase.db;");
			//optionsBuilder.UseSqlServer(@"");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}