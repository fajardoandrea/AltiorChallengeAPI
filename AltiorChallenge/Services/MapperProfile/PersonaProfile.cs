using AltiorChallenge.DALL;
using AltiorChallenge.Domain;
using AutoMapper;
namespace AltiorChallenge.Services.MapperProfile
{
	public class PersonaProfile : Profile
	{
        public PersonaProfile() 
        {
            CreateMap<Persona, PersonaDTO>();
            CreateMap<PersonaDTO, Persona>();
        }
    }
}
