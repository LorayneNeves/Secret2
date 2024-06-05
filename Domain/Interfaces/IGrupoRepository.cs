using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
	public interface IGrupoRepository
	{
		IEnumerable<Grupo> ObterTodos();
		Task<Grupo> BuscarPorId(int id);
		Task<int> BuscarId();
		Task Adicionar(Grupo grupo);
		Task Atualizar(Grupo grupo);
		Task Excluir(Grupo grupo);
	}
}
