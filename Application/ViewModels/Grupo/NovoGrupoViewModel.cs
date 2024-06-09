using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.Grupo
{
	public class NovoGrupoViewModel
	{
		public string Nome { get; set; }
		public int Quantidade { get; set; }
		public decimal Valor { get; set; }
		public DateTime DataRevelacao { get; set; }
		public string Descricao { get; set; }
		public string? Foto { get; set; }

	}
	public class NovoGrupoRequest
	{
		public int GrupoId { get; set; }
		public NovoGrupoViewModel NovoGrupo { get; set; }
	}
}
