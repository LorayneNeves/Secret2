using Application.Interfaces;
using Application.ViewModels.Usuario;
using AutoMapper;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
	public class LoginService : ILoginService
	{
		#region - Atributos e Construtores

		private readonly ILoginRepository _loginRepository;
		private readonly IUsuarioRepository _usuarioRepository;
		private IMapper _mapper;

		public LoginService(ILoginRepository loginRepository, IUsuarioRepository usuarioRepository, IMapper mapper)
		{
			_loginRepository = loginRepository;
			_usuarioRepository = usuarioRepository;
			_mapper = mapper;
		}
		#endregion
		public async Task<UsuarioViewModel?> Autenticar(NovoLoginViewModel login)
		{
			var usuarioAutenticado = await _loginRepository
			  .Autenticar(login.Email, login.Senha);

			if (usuarioAutenticado != null)
			{
				var usuario = await _usuarioRepository.BuscarPorEmail(login.Email);
				UsuarioViewModel buscaUsuarioPoEmail = _mapper.Map<UsuarioViewModel>(usuario);

				return buscaUsuarioPoEmail;
			}
			else
			{
				return null;
			}
		}

		
	}
}
