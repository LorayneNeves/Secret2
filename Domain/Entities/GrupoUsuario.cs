using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class GrupoUsuario
	{
		public GrupoUsuario(int idGrupo, int idUsuario)
		{
			GrupoId = idGrupo;
			UsuarioId = idUsuario;		
		}
		public GrupoUsuario()
		{
			
		}
		public int GrupoUsuarioId { get; private set; }
		public int GrupoId { get; private set; }
		public int UsuarioId { get; private set; }
		public Usuario Usuario { get; private set; }
		public Grupo Grupo { get; private set; }
	}
}
