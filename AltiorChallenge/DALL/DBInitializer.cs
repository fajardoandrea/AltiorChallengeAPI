using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace AltiorChallenge.DALL
{
	public class DBInitializer
	{
		private readonly ModelBuilder _modelBuilder;

		public DBInitializer(ModelBuilder modelBuilder)
		{
			_modelBuilder = modelBuilder;
		}

		public void Seed()
		{
			_modelBuilder.Entity<Persona>().HasData(
				new Persona() { IDPersona = "1",
					Nombre = "Prueba",
					Apellido="ap", 
					documento="12345678",
					EMail ="Prueba@prueba.com"
				});
			_modelBuilder.Entity<Persona>().HasData(
			new Persona()
			{
				IDPersona = "2",
				Nombre = "Prueba2",
				Apellido = "Perez",
				documento = "11112222",
				EMail = "otromail@prueba.com"

			});

			_modelBuilder.Entity<Vendedor>().HasData(
				new Vendedor() {
					IDVendedor = "1",
					Alias = "vendedor1",
					Sucursal = "central",
					IDPersona = "1"
				});
			_modelBuilder.Entity<Vendedor>().HasData(
				new Vendedor()
				{
					IDVendedor = "2",
					Alias = "vendedor2",
					Sucursal = "Sur",
					IDPersona = "2"
				});
		}
	}
}
