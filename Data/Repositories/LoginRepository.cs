using AutoMapper;
using Data.EntityFramework;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
	public class LoginRepository : ILoginRepository
	{

		#region - Atributos e Construtores

		private readonly Context _contexto;
		private readonly IMapper _mapper;

		public LoginRepository(Context contexto, IMapper mapper)
		{
			_contexto = contexto;
			_mapper = mapper;
		}
		#endregion
		public async Task<Login> Autenticar(string email, string senha)
		{
			return await _contexto.Login.FirstOrDefaultAsync(u => u.Email == email && u.Senha == senha);
		}

		public async Task<Login> BuscarPorId(int id)
		{
			try
			{
				var login = await _contexto.Login.Where(c => c.LoginId == id).FirstOrDefaultAsync();

				return login;
			}
			catch (Exception ex)
			{
				throw new Exception($"Erro ao buscar o login: {ex.Message}");
			}
		}
		public async Task Inserir(Login login)
		{
			try
			{
				await _contexto.Login.AddAsync(login);
				await _contexto.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw new Exception($"Erro ao inserir o login: {ex.Message}");
			}
		}



	}
}
