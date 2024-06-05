using Data.EntityFramework;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
	public class UsuarioRepository : IUsuarioRepository
	{
		#region - Atributos e Construtores

		private readonly Context _contexto;

		public UsuarioRepository(Context contexto)
		{
			_contexto = contexto;
		}

		#endregion
		public async Task Adicionar(Usuario usuario)
		{
			try
			{
				await _contexto.Usuario.AddAsync(usuario);
				await _contexto.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw new Exception($"Erro ao inserir usuário: {ex.Message}");
			}
		}

		public async Task Atualizar(Usuario usuario)
		{
			throw new NotImplementedException();
			//try

			//{
			//	await _contexto.Usuario.Where(u => u.UsuarioId == usuario.UsuarioId).ExecuteUpdateAsync(u => u.SetProperty(u => u, usuario));
			//	await _contexto.SaveChangesAsync();
			//}
			//         catch (Exception ex)
			//         {
			//	throw new Exception($"Erro ao atualizar usuário: {ex.Message}");
			//}
		}

		public async Task<Usuario> BuscarPorEmail(string email)
		{
			try
			{
                return await _contexto.Usuario.FirstOrDefaultAsync(u => u.Email == email);
                
			}
			catch (Exception ex)
			{
				throw new Exception($"Erro ao buscar o usuário: {ex.Message}");
			}
		}

		public IEnumerable<Usuario> ObterTodos()
		{
			//throw new NotImplementedException();
			try
			{
                //var usuarios = _contexto.Usuario.Where(u => u.UsuarioId == usuario.UsuarioId).ToList();
                return _contexto.Usuario.ToList();

            }
            catch (Exception ex)
			{
				throw new Exception($"Erro ao buscar os usuários: {ex.Message}");
			}
		}
        //public async Task<IDbContextTransaction> BeginTransactionAsync()
        //{
        //    return await _contexto.Database.BeginTransactionAsync();
        //}
    }
}
