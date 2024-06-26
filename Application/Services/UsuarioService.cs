﻿using Application.Interfaces;
using Application.ViewModels.Usuario;
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
    public class UsuarioService: IUsuarioService
    {
        #region - Construtores

        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IGrupoUsuarioRepository _grupoUsuarioRepository;
        private readonly ILoginRepository _loginRepository;
        private IMapper _mapper;

        public UsuarioService(IUsuarioRepository usuarioRepository, IGrupoUsuarioRepository grupoUsuarioRepository, ILoginRepository loginRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
           _grupoUsuarioRepository = grupoUsuarioRepository;
            _loginRepository = loginRepository;
            _mapper = mapper;
        }
        #endregion

        public async Task Adicionar(NovoUsuarioViewModel usuario)
        {
            //using var transaction = await _usuarioRepository.BeginTransactionAsync();
            try
            {
                var usuarioExistente = await _usuarioRepository.BuscarPorEmail(usuario.Email);
                if (usuarioExistente != null)
                {
                    throw new Exception("Um usuário com este e-mail já existe.");
                }

                var novoUsuario = _mapper.Map<Usuario>(usuario);

                var login = new NovoUsuarioViewModel
                {
                    Email = novoUsuario.Email,
                    Senha = novoUsuario.Senha,
                };

                var novoLogin = _mapper.Map<Login>(login);

                await _usuarioRepository.Adicionar(novoUsuario);
                await _loginRepository.Inserir(novoLogin);

                //await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                //await transaction.RollbackAsync();
                throw new Exception($"Erro ao inserir usuário (service): {ex.Message}", ex);
            }
        }

        public Task Atualizar(Guid id, UsuarioViewModel usuario)
		{
			throw new NotImplementedException();
		}

		public async Task<UsuarioViewModel> BuscarPorEmail(string email)
		{
			try
			{
				var usuario = await _usuarioRepository.BuscarPorEmail(email);

				UsuarioViewModel buscaUsuarioId = _mapper.Map<UsuarioViewModel>(usuario);

				return buscaUsuarioId;
			}
			catch (Exception ex)
			{
				throw new Exception($"Erro ao buscar usuário (service): {ex.Message}");
			}
		}


		public Task Desativar(UsuarioViewModel usuario)
		{
			throw new NotImplementedException();
		}

	}
}
