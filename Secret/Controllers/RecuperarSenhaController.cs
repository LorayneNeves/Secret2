using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Secret.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RecuperarSenhaController : Controller
	{
		private readonly IRecuperarSenhaService _recuperarSenhaService;
		public RecuperarSenhaController(IRecuperarSenhaService recuperarSenhaService)
		{
			_recuperarSenhaService = recuperarSenhaService;
		}

		#region - Metódos CRUD


		#endregion
	}
}
