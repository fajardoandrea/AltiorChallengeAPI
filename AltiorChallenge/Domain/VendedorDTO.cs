using AltiorChallenge.DALL;
using System.ComponentModel.DataAnnotations.Schema;

namespace AltiorChallenge.Domain
{
	public class VendedorDTO
	{
		public string IDVendedor { get; set; }
		public string Alias { get; set; }
		public string Sucursal { get; set; }
		public string IDPersona { get; set; }

	}
}
