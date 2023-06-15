using AltiorChallenge.DALL;
using AltiorChallenge.Domain;
using AutoMapper;

namespace AltiorChallenge.Services.MapperProfile
{
	public class VendedorProfile : Profile
	{
        public VendedorProfile()
        {
            CreateMap<Vendedor, VendedorDTO>();
			CreateMap<VendedorDTO, Vendedor>();
		}
    }
}
