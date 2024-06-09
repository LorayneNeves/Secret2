using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
	public interface IRecuperarSenhaRepository
	{
		Task<RecuperarSenha> BuscarPorId(int id);
		Task Adicionar(RecuperarSenha recuperaSenha);
		Task Atualizar(RecuperarSenha recuperaSenha);
	}
}
