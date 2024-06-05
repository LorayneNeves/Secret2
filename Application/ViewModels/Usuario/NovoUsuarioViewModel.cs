using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.Usuario
{
    public class NovoUsuarioViewModel
    {
        [Required(ErrorMessage = "O nome e obrigatório.")]
        [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 3 caracteres.")]
        [MaxLength(255, ErrorMessage = "O nome deve ter no maximo 255 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Email é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O nome deve ter no maximo 500 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória.")]
        public string Senha { get; set; }
        public string? Foto { get; set; }

    }
}
