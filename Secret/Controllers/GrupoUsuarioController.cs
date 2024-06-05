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
		[HttpGet("buscarporid/{id}")]
		public async Task<IActionResult> GetPorId(int id)
		{
			return Ok(await _grupoUsuarioService.BuscarPorId(id));
		}
		[HttpPost("adicionar")]
		public async Task<IActionResult> Post([FromBody] NovoGrupoUsuarioViewModel novoGrupoUsuario)
		{
			await _grupoUsuarioService.Inserir(novoGrupoUsuario);

			return Ok("Grupo cadastrado com sucesso para o usuário");
		}
		[HttpDelete("excluir/{id}")]
		public async Task<IActionResult> Excluir(int id)
		{
			await _grupoUsuarioService.Excluir(id);

			return Ok("Grupo excluído com sucesso para o usuário");
		}

		#endregion
	}
}
