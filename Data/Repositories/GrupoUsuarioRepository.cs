using Data.EntityFramework;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
	public class GrupoUsuarioRepository : IGrupoUsuarioRepository
	{


		#region - Atributos e Construtores

		private readonly Context _contexto;

		public GrupoUsuarioRepository(Context contexto)
		{
			_contexto = contexto;
		}

		#endregion
		public async Task Adicionar(GrupoUsuario grupoUsuario)
		{
			try
			{
				await _contexto.GrupoUsuario.AddAsync(grupoUsuario);
				await _contexto.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw new Exception($"Erro ao inserir usuário no grupo: {ex.Message}");
			}
		}

		public async Task Atualizar(GrupoUsuario grupoUsuario)
		{

			try
			{
				
				await _contexto.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw new Exception($"Erro ao atualizar grupo: {ex.Message}");
			}
		}

		public IEnumerable<GrupoUsuario> BuscarPorId(int id)
		{
			try
			{
				var grupoUsuario = _contexto.GrupoUsuario.Where(c => c.UsuarioId == id).ToList();

				return grupoUsuario;
			}
			catch (Exception ex)
			{
				throw new Exception($"Erro ao buscar grupos do usuário: {ex.Message}");
			}
		}

		public async Task Excluir(GrupoUsuario grupoUsuario)
		{
			try
			{
				_contexto.GrupoUsuario.Remove(grupoUsuario);
				await _contexto.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw new Exception($"Erro ao excluir usuário no grupo: {ex.Message}");
			}
		}


	}
}
