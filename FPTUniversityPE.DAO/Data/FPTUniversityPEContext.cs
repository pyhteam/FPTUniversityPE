using FPTUniversityPE.BusinessObject.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FPTUniversityPE.BusinessObject.Data
{
	public class FPTUniversityPEContext : DbContext
	{
		public FPTUniversityPEContext(DbContextOptions<FPTUniversityPEContext> options) : base(options)
		{

		}
		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			if (!options.IsConfigured)
			{
				options.UseSqlServer("Server=.;Database=FPTUniversityPE_DB;Trusted_Connection=True;TrustServerCertificate=True");
			}
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
			base.OnModelCreating(modelBuilder);
		}

		public DbSet<ArtWork>? artWorks { get; set; }
		public DbSet<Museums>? Museums { get; set; }
		public DbSet<User>? Users { get; set; }
		public DbSet<Role>? Roles { get; set; }
	}
}

