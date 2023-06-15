using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AltiorChallenge.DALL
{
	[Table("Productos")]	
	public class Producto
	{
		[Required]
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public string IdProducto { get; set; }
		public string Nombre { get; set;}
		public string Categoria { get; set;}
		public string Descripcion { get; set; }
		public virtual List<Venta> Ventas { get; set; }

	}
}
