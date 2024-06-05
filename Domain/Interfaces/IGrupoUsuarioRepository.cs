using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
	public interface IGrupoUsuarioRepository
	{
		IEnumerable<GrupoUsuario> BuscarPorId(int id);
		Task Adicionar(GrupoUsuario grupoUsuario);
		Task Atualizar(GrupoUsuario grupoUsuario);
		Task Excluir(GrupoUsuario grupoUsuario);
	}
}
