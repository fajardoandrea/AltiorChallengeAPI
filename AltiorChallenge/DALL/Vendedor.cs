using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AltiorChallenge.DALL
{
	[Table("Vendedores")]
	public class Vendedor
	{
		[Required]	
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public string IDVendedor { get; set; }
        public string Alias { get; set; }
        public string Sucursal { get; set; }
		[ForeignKey("IDPersona")]
		public string IDPersona { get; set; }
		public virtual Persona Persona { get; set; }
		public virtual Producto Producto { get; set; }
	}
}
