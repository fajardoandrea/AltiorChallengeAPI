using AltiorChallenge.DALL;
using AltiorChallenge.Domain;

namespace AltiorChallenge.Services.Contracts
{
	public interface ISampleServices
	{
		public List<VendedorDTO> GetAllVendedores();
		public List<PersonaDTO> GetAllPersonas();
	}
}
