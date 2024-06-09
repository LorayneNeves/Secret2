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
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public IActionResult Get()
		{
			return Ok(_grupoService.ObterTodos());
		}


		[HttpGet("BuscarPorId/{id}")]
		[ProducesResponseType(typeof(GrupoViewModel), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public IActionResult Get(int id)
		{
			return Ok(_grupoService.BuscarPorId(id));
		}


		[HttpPost()]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> Post([FromBody] NovoGrupoRequest novoGrupo)
		{
			await _grupoService.Adicionar(novoGrupo.NovoGrupo, novoGrupo.GrupoId);

			return Ok("Grupo cadastrado com sucesso");

		}
		#endregion
	}
}
