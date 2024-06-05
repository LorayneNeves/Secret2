using Application.Interfaces;
using Application.ViewModels.Grupo;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
	public class GrupoUsuarioService : IGrupoUsuarioService
	{
		#region - Atributos e Construtores

		private readonly IGrupoUsuarioRepository _grupoUsuarioRepository;
		private readonly IGrupoRepository _grupoRepository;
		private IMapper _mapper;

		public GrupoUsuarioService(IGrupoUsuarioRepository grupoUsuarioRepository, IGrupoRepository grupoRepository, IMapper mapper)
		{
			_grupoUsuarioRepository = grupoUsuarioRepository;
			_grupoRepository = grupoRepository;
			_mapper = mapper;
		}
		#endregion
		public Task Atualizar(GrupoUsuarioViewModel grupoUsuario)
		{
			throw new NotImplementedException();
		}

		public async Task<List<GrupoViewModel>> BuscarPorId(int id)
		{

			try
			{
				var gruposUsuario = _grupoUsuarioRepository.BuscarPorId(id);

				if (gruposUsuario != null)
				{
					List<GrupoViewModel> grupos = new List<GrupoViewModel>();

					foreach (GrupoUsuario itens in gruposUsuario)
					{
						grupos.Add(_mapper.Map<GrupoViewModel>(await _grupoRepository.BuscarPorId(itens.GrupoId)));
					}

					return grupos;
				}
				else
				{
					throw new Exception("Não foi encontrado nenhum grupo para esse usuário");
				}
			}
			catch (Exception ex)
			{
				throw new Exception($"Erro ao buscar todos os grupos do usuário (service): {ex.Message}");
			}
		}

		public Task Excluir(int id)
		{
			throw new NotImplementedException();
		}

		public async Task Inserir(NovoGrupoUsuarioViewModel grupoUsuario)
		{
			try
			{
				var novoGrupoUsuario = _mapper.Map<GrupoUsuario>(grupoUsuario);
				await _grupoUsuarioRepository.Adicionar(novoGrupoUsuario);
			}
			catch (Exception ex)
			{
				throw new Exception($"Erro ao inserir grupo ao usuário (service): {ex.Message}");
			}
		}



	}
}
