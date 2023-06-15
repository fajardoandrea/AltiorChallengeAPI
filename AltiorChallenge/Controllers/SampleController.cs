using AltiorChallenge.DALL;
using AltiorChallenge.Domain;
using AltiorChallenge.Services;
using AltiorChallenge.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AltiorChallenge.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class SampleController : ControllerBase
	{
        private readonly SampleContext _context;
		private readonly ISampleServices _services;
		public SampleController(SampleContext context, ISampleServices services)
		{
			_context = context;
			_services = services;
		}

		[HttpGet]
		[Route("GetListaPersonas")]
		public async Task<ActionResult> GetPersonas()
		{
			try
			{
				var listP = new List<PersonaDTO>();
				Task tarea1 = Task.Run(() => { listP = _services.GetAllPersonas(); });
				await Task.WhenAll(tarea1);
				return Ok(listP);
			}
			catch (Exception ex )
			{
				return BadRequest(ex.Message);
			}
		}
		[HttpGet]
		[Route("GetListaEmpleados")]
		public async Task<ActionResult> GetEmpleados()
		{
			try
			{
				var listV = new List<VendedorDTO>();
				Task tarea1 = Task.Run(() => { listV = _services.GetAllVendedores(); });
				await Task.WhenAll(tarea1);
				return Ok(listV);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}

		}
	}
}
