using Data.EntityFramework;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
	public class RecuperarSenhaRepository : IRecuperarSenhaRepository
	{


		#region - Atributos e Construtores

		private readonly Context _contexto;

		public RecuperaSenhaRepository(Context contexto)
		{
			_contexto = contexto;
		}

		#endregion

		public Task Atualizar(RecuperarSenha recuperaSenha)
		{
			throw new NotImplementedException();
		}

		public Task<RecuperarSenha> BuscarPorId(int id)
		{
			throw new NotImplementedException();
		}

		public Task Adicionar(RecuperarSenha recuperaSenha)
		{
			throw new NotImplementedException();
		}
	}
}
