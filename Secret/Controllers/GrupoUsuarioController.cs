using Application.Interfaces;
using Application.ViewModels.Grupo;
using Microsoft.AspNetCore.Mvc;

namespace Secret.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GrupoUsuarioController : ControllerBase
	{
		private readonly IGrupoUsuarioService _grupoUsuarioService;
		public GrupoUsuarioController(IGrupoUsuarioService grupoUsuarioService)
		{
			_grupoUsuarioService = grupoUsuarioService;
		}
		#region - Metódos CRUD
		[HttpGet("BuscarPorId/{id}")]
		public async Task<IActionResult> GetPorId(int id)
		{
			return Ok(await _grupoUsuarioService.BuscarPorId(id));
		}
		[HttpPost("Adicionar")]
		public async Task<IActionResult> Post([FromBody] NovoGrupoUsuarioViewModel novoGrupoUsuario)
		{
			await _grupoUsuarioService.Adicionar(novoGrupoUsuario);

			return Ok("Grupo cadastrado com sucesso para o usuário");
		}
		[HttpDelete("Excluir/{id}")]
		public async Task<IActionResult> Excluir(int id)
		{
			await _grupoUsuarioService.Excluir(id);

			return Ok("Grupo excluído com sucesso");
		}

		#endregion
	}
}
