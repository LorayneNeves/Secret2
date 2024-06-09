using Application.ViewModels.Grupo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
	public interface IGrupoService
	{
		IEnumerable<GrupoViewModel> ObterTodos();
		Task<GrupoViewModel> BuscarPorId(int id);
		Task Adicionar(NovoGrupoViewModel grupo, int idUsuario);
		Task Atualizar(GrupoViewModel grupo);
		Task Excluir(int id);
		
	}
}
