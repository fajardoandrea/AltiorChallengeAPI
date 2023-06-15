using Microsoft.EntityFrameworkCore;

namespace AltiorChallenge.DALL
{
	public class SampleContext: DbContext
	{
        public SampleContext(DbContextOptions<SampleContext> options) 
            : base(options)
        {
                Database.EnsureCreated();
        }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			new DBInitializer(modelBuilder).Seed();

			modelBuilder.Entity<Persona>()
				.HasOne(a => a.Vendedor)
				.WithOne(a => a.Persona)
				.HasForeignKey<Vendedor>(a => a.IDPersona)
				.IsRequired(); 
		}
		public DbSet<Persona> Personas { get; set; }
		public DbSet<Vendedor> Vendedores { get; set; }
		public DbSet<Producto> Productos { get; set; }
		public DbSet<Venta> Ventas { get; set; }
	}
}
