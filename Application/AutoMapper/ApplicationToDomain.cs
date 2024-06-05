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
    public class ApplicationToDomain : Profile
	{
		public ApplicationToDomain()
		{

			CreateMap<UsuarioViewModel, Usuario>()
			.ConstructUsing(q => new Usuario(q.Nome, q.Email, q.Senha, q.Foto));

			CreateMap<NovoUsuarioViewModel, Usuario>()
			.ConstructUsing(q => new Usuario(q.Nome, q.Email, q.Senha, q.Foto));



			CreateMap<GrupoViewModel, Grupo>()
			   .ConstructUsing(p => new Grupo(p.GrupoId,p.Foto,p.Nome,p.Quantidade,p.Valor,p.DataRevelacao,p.Descricao));

			CreateMap<NovoGrupoViewModel, Grupo>()
			   .ConstructUsing(p => new Grupo(p.Foto, p.Nome, p.Quantidade, p.Valor, p.DataRevelacao, p.Descricao));



			CreateMap<GrupoUsuarioViewModel, GrupoUsuario>()
				   .ConstructUsing(c => new GrupoUsuario(c.GrupoId, c.UsuarioId));

			CreateMap<NovoGrupoUsuarioViewModel, GrupoUsuario>()
			   .ConstructUsing(c => new GrupoUsuario(c.GrupoId,c.UsuarioId));



			CreateMap<LoginViewModel, Login>()
			   .ConstructUsing(c => new Login(c.Email,c.Senha));

			CreateMap<NovoLoginViewModel, Login>()
			   .ConstructUsing(c => new Login(c.Email, c.Senha));
		}
	}
}
