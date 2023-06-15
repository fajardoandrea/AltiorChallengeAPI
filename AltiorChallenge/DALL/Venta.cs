using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AltiorChallenge.DALL
{
	[Table("Ventas")]
	public class Venta
	{
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IdVenta { get; set; }
		[ForeignKey("IDendedor")]
		public string IDVendedor { get; set; }
		[ForeignKey("IDProducto")]
		public string IdProducto { get; set; }
		public int Cantidad { get; set; }
		public int Monto { get; set; }
		public virtual Vendedor Vendedor { get; set; }
		public virtual List<Producto> Productos { get; set; }
	}
}
