using Data.EntityFramework;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
	public class GrupoRepository : IGrupoRepository
	{


		#region - Atributos e Construtores

		private readonly Context _contexto;

		public GrupoRepository(Context contexto)
		{
			_contexto = contexto;
		}
		#endregion
		public async Task Adicionar(Grupo grupo)
		{
			try
			{
				await _contexto.Grupo.AddAsync(grupo);
				await _contexto.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw new Exception($"Erro ao inserir grupo: {ex.Message}");
			}
		}

		public async Task Atualizar(Grupo grupo)
		{
			try
			{
				//await _contexto.Grupo.Where(g => g.GrupoId == grupo.GrupoId).ExecuteUpdateAsync(g => g.SetProperty(g => g, grupo));
				await _contexto.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw new Exception($"Erro ao atualizar grupo: {ex.Message}");
			}
		}

		public async Task<int> BuscarId()
		{
			var ultimoId = await _contexto.Grupo.MaxAsync(g => g.GrupoId);
			return ultimoId;
		}

		public async Task<Grupo> BuscarPorId(int id)
		{

			return await _contexto.Grupo.FindAsync(id);

		}

		public async Task Excluir(Grupo grupo)
		{
			try
			{
				_contexto.Grupo.Remove(grupo);
				await _contexto.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw new Exception($"Erro ao excluir grupo: {ex.Message}");
			}
		}

		public IEnumerable<Grupo> ObterTodos()
		{
			try
			{
				var grupos = _contexto.Grupo.Where(c => c.GrupoId != 9).ToList();

				return grupos;
			}
			catch (Exception ex)
			{
				throw new Exception($"Erro ao buscar os grupos: {ex.Message}");
			}
		}


	}
}