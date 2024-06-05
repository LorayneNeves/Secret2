using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Usuario
    {
        public Usuario(string? foto, string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Foto = foto;
        }
        public Usuario(int idUsuario, string? foto, string nome, string email, string senha)
        {
            UsuarioId = idUsuario;
            Nome = nome;
            Email = email;
            Senha = senha;
            Foto = foto;
        }

        public int UsuarioId { get; private set; }
        public string? Foto { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public ICollection<GrupoUsuario> GrupoUsuarios { get; set; }
    }

}
