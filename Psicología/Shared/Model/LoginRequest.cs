using System.ComponentModel.DataAnnotations;

namespace Psicología.Shared.Model
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "El usuario debe ser válido")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "La contraseña debe ser válida")]
        public string? Password { get; set; }
    }
}
