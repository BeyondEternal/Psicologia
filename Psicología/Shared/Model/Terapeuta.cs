using System.ComponentModel.DataAnnotations;

namespace Psicología.Shared.Model
{
    public class Terapeuta
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio"), MaxLength(100)]
        public string? Name { get; set; }
        [Required(ErrorMessage = "El género es obligatorio"), EnumDataType(typeof(Gender))]
        public Gender? Gender { get; set; }
        [Required(ErrorMessage = "La especialidad es obligatoria"), MaxLength(100)]
        public string? Speciallity { get; set; }
        [Required(ErrorMessage = "El correo electrónico es obligatorio"), EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage = "El número de teléfono es obligatorio"), MaxLength(100), Phone]
        public string? Phone { get; set; }
    }

}
