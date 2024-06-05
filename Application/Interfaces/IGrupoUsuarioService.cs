using Application.ViewModels.Grupo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
	public interface IGrupoUsuarioService
	{
		Task<List<GrupoViewModel>> BuscarPorId(int id);
		Task Inserir(NovoGrupoUsuarioViewModel grupoUsuario);
		Task Atualizar(GrupoUsuarioViewModel grupoUsuario);
		Task Excluir(int id);
	}
}
