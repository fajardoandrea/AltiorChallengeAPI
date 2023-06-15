using AltiorChallenge.DALL;
using AltiorChallenge.Domain;
using AltiorChallenge.Services.Contracts;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AltiorChallenge.Services
{
	public class SampleServices : ISampleServices
	{
		private readonly SampleContext _context;
		private readonly IMapper _mapper;
        public SampleServices(SampleContext context, IMapper mapper)
        {
			_context = context;
			_mapper = mapper;
        }
        public List<VendedorDTO> GetAllVendedores()
		{
			var entityList = _context.Vendedores.ToList();
			var listaV = new List<VendedorDTO>();
			foreach (var vendedor in entityList)
			{
				var vendedores= _mapper.Map<VendedorDTO>(vendedor);
				listaV.Add(vendedores);
			}
			return listaV;
		}

		public List<PersonaDTO> GetAllPersonas()
		{
			var entitylist = _context.Personas.ToList();
			var listaP = new List<PersonaDTO>();
			foreach (var persona in entitylist)
			{
				var personas = _mapper.Map<PersonaDTO>(persona);
				listaP.Add(personas);
			}
			return listaP;
		}

	}
}
