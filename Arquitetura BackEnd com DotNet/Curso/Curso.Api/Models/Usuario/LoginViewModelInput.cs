using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Curso.Api.Models.Usuario
{
    public class LoginViewModelInput
    {
        [Required (ErrorMessage = "o login é obrogatorio" )]
        public string Login { get; set; }

        [Required(ErrorMessage = "a senha é obrogatoria")]
        public string Senha { get; set; }
    }
}
