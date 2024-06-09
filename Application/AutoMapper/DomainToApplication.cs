using Application.ViewModels.Grupo;
using Application.ViewModels.Usuario;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AutoMapper
{
    public class DomainToApplication : Profile
	{
		public DomainToApplication()
		{
			CreateMap<Usuario, UsuarioViewModel>();
			CreateMap<Grupo, GrupoViewModel>();
			CreateMap<GrupoUsuario, GrupoUsuarioViewModel>();
			CreateMap<Login, LoginViewModel>();
			CreateMap<NovoUsuarioViewModel, Login>();
			CreateMap<RecuperarSenha, RecuperarSenhaViewModel>();
		}
	}
}
