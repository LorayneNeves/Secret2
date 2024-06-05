using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
	public interface ILoginRepository
	{
		Task<Login> Autenticar(string email, string senha);
		Task<Login> BuscarPorId(int id);
		Task Inserir(Login login);
	}
}
