using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class RecuperarSenha
	{
		public RecuperarSenha(int idUsuario, DateTime dataSolicitacao)
		{
			UsuarioId = idUsuario;
			Data = dataSolicitacao;
		}
		private RecuperarSenha() { }
		public int RecuperarSenhaId { get; private set; }
		public int UsuarioId { get; private set; }
		public DateTime Data { get; private set; }
		public Usuario Usuario { get; private set; }
	}
}
