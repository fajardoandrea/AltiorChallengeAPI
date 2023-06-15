using AltiorChallenge.DALL;
using System.ComponentModel.DataAnnotations;

namespace AltiorChallenge.Domain
{
	public class PersonaDTO
	{
		public string IDPersona { get; set; }
		public string documento { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public string EMail { get; set; }
	}
}
