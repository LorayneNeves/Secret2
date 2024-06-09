using Application.ViewModels.Usuario;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUsuarioService
	{
		Task<UsuarioViewModel> BuscarPorEmail(string email);
		Task Adicionar(NovoUsuarioViewModel usuario);
		Task Atualizar(Guid id, UsuarioViewModel usuario);
		Task Desativar(UsuarioViewModel usuario);
	}
}
