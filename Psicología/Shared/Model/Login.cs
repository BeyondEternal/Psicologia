using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psicología.Shared.Model
{
    public class Login
    {
        [Required(ErrorMessage = "El usuario es obligatorio")]
        public string User { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string Password { get; set; }
    }
}
