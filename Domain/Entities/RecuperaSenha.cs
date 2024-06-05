using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class RecuperaSenha
	{
		public RecuperaSenha(int idUsuario)
		{
			UsuarioId = idUsuario;
		}

		public int RecuperaSenhaId { get; private set; }
		public int UsuarioId { get; private set; }
		public DateTime DataSolicitacao { get; private set; }
		public Usuario Usuario { get; private set; }
	}
}
