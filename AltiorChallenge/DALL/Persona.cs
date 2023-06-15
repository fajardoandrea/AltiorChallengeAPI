using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AltiorChallenge.DALL
{
	[Table("Personas")]
	public class Persona
	{
		
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Required]
		public string IDPersona { get; set; }
		[Required]
        public string documento { get; set; }
		public string Nombre { get; set; }
		[Required]
        public string Apellido { get; set; }
		public string EMail { get; set; }
        public virtual Vendedor Vendedor { get; set; }
    }
}
