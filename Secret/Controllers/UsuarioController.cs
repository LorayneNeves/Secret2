using Application.Interfaces;
using Application.ViewModels.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace Secret.Controllers
{
    [Route("api/[controller]")]
	[ApiController]
	public class UsuarioController : ControllerBase
	{
		private readonly IUsuarioService _usuarioService;
		public UsuarioController(IUsuarioService usuarioService)
		{
			_usuarioService = usuarioService;
		}

		#region - Metódos CRUD

		[HttpPost("Adicionar")]

		public async Task<IActionResult> Post([FromBody] NovoUsuarioViewModel novoUsuario)
		{
			await _usuarioService.Adicionar(novoUsuario);

			return Ok("Usuário cadastrado com sucesso");
		}

		//[HttpGet("Desativar")]
		//public IActionResult Get()
		//{
		//	return;
		//}

		[HttpGet("BuscarPorEmail/{email}")]
		[ProducesResponseType(typeof(UsuarioViewModel), StatusCodes.Status200OK)]
		public IActionResult GetPorEmail(string email)
		{
			return Ok(_usuarioService.BuscarPorEmail(email));
		}		

		#endregion
	}
}
