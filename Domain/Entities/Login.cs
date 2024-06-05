using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class Login
	{
		public Login(string email, string senha)
		{
			Email = email;
			Senha = senha;
		}

		public int LoginId { get; private set; }
		public string Email { get; private set; }
		public string Senha { get; private set; }
	}
}
