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
	public class GrupoService : IGrupoService
	{
		#region - Atributos e Construtores

		private readonly IGrupoRepository _grupoRepository;
		private readonly IGrupoUsuarioRepository _grupoUsuarioRepository;
		private IMapper _mapper;

		public GrupoService(IGrupoRepository grupoRepository, IGrupoUsuarioRepository grupoUsuarioRepository, IMapper mapper)
		{
			_grupoRepository = grupoRepository;
			_grupoUsuarioRepository = grupoUsuarioRepository;
			_mapper = mapper;
		}

		#endregion
		public async Task Adicionar(NovoGrupoViewModel grupo, int idUsuario)
		{
			try
			{
				var novoGrupo = _mapper.Map<Grupo>(grupo);
				await _grupoRepository.Adicionar(novoGrupo);

				int ultimoId = await _grupoRepository.BuscarId();
				var grupoUsuarioViewModel = new NovoGrupoUsuarioViewModel
				{
					GrupoId = ultimoId,
					UsuarioId = idUsuario,
				};

				var grupoUsuario = _mapper.Map<GrupoUsuario>(grupoUsuarioViewModel);

				await _grupoUsuarioRepository.Adicionar(grupoUsuario);
			}
			catch (Exception ex)
			{
				throw new Exception($"Erro ao inserir grupo (service): {ex.Message}");
			}
		}

		public async Task<GrupoViewModel> BuscarPorId(int id)
		{
			try
			{
				var grupo = await _grupoRepository.BuscarPorId(id);

				GrupoViewModel buscaGrupoId = _mapper.Map<GrupoViewModel>(grupo);

				return buscaGrupoId;
			}
			catch (Exception ex)
			{
				throw new Exception($"Erro ao buscar grupo (service): {ex.Message}");
			}
		}

		public IEnumerable<GrupoViewModel> ObterTodos()
		{
			try
			{
				var grupos = _grupoRepository.ObterTodos();

				return _mapper.Map<IEnumerable<GrupoViewModel>>(grupos);
			}
			catch (Exception ex)
			{
				throw new Exception($"Erro ao buscar todos os grupos (service): {ex.Message}");
			}
		}

		public Task Atualizar(GrupoViewModel grupo)
		{
			throw new NotImplementedException();
		}

		public Task Excluir(int id)
		{
			throw new NotImplementedException();
		}
		
	}
}
