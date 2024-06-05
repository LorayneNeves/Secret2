using Application.Interfaces;
using Application.ViewModels.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace Secret.Controllers
{
    [Route("api/[controller]")]
	[ApiController]
	public class UsuarioController : Controller
	{
		private readonly IUsuarioService _usuarioService;
		public UsuarioController(IUsuarioService usuarioService)
		{
			_usuarioService = usuarioService;
		}

		#region - Metódos CRUD

		[HttpGet("ObterTodos")]
		public IActionResult Get()
		{
			return Ok(_usuarioService.ObterTodos());
		}

		[HttpGet("buscarporemail/{email}")]
		public IActionResult GetPorEmail(string email)
		{
			return Ok(_usuarioService.BuscarPorEmail(email));
		}

		[HttpPost("Adicionar")]
		public async Task<IActionResult> Post([FromBody] NovoUsuarioViewModel novoUsuario)
		{
			await _usuarioService.Adicionar(novoUsuario);

			return Ok("Usuário cadastrado com sucesso");
		}

		#endregion
	}
}
