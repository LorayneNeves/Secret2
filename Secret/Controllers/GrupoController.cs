using Application.Interfaces;
using Application.Services;
using Application.ViewModels.Grupo;
using Microsoft.AspNetCore.Mvc;

namespace Secret.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GrupoController : ControllerBase
	{
		private readonly IGrupoService _grupoService;
		public GrupoController(IGrupoService grupoService)
		{
			_grupoService = grupoService;
		}

		#region - Metódos CRUD
		[HttpGet()]
		[ProducesResponseType(typeof(GrupoViewModel), StatusCodes.Status200OK)]
		public IActionResult Get()
		{
			return Ok(_grupoService.ObterTodos());
		}


		[HttpGet("/{id}")]
		[ProducesResponseType(typeof(GrupoViewModel), StatusCodes.Status200OK)]
		public IActionResult GetPorId(int id)
		{
			return Ok(_grupoService.BuscarPorId(id));
		}


		[HttpPost()]
		[ProducesResponseType(StatusCodes.Status201Created)]
		public async Task<IActionResult> Post([FromBody] NovoGrupoViewModel grupo, int idUsuario)
		{

			await _grupoService.Adicionar(grupo);

			return Ok("Usuário cadastrado com sucesso");
		}
		#endregion
	}
}
