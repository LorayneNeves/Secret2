using Domain.Entities;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
	public interface IUsuarioRepository
	{
       // IEnumerable<Usuario> ObterTodos();
        Task<Usuario> BuscarPorEmail(string email);
        Task Adicionar(Usuario usuario);
		Task Desativar(Usuario usuario);
		// Task<IDbContextTransaction> BeginTransactionAsync();
	}
}
