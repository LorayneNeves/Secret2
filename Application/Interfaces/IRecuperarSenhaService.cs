using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
	public interface IRecuperarSenhaService
	{
		Task<RecuperarSenha> BuscarPorId(int id);
		Task Adicionar(RecuperarSenha recuperaSenha);
		Task Atualizar(RecuperarSenha recuperaSenha);
	}
}
