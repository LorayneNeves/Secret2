using Application.Interfaces;
using Application.ViewModels.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace Secret.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LoginController : ControllerBase
	{
		private readonly ILoginService _loginService;
		public LoginController(ILoginService loginService)
		{
			_loginService = loginService;
		}
		#region - Metódos CRUD

		[HttpPost()]
		[ProducesResponseType(typeof(UsuarioViewModel), StatusCodes.Status200OK)]
		[ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> Post(NovoLoginViewModel login)
		{
			var usuario = await _loginService.Autenticar(login);

			if (usuario == null)
			{
				return BadRequest("Login inválido ou usuário inexistente!");
			}

			return Ok(usuario);
		}

		#endregion
	}
}
