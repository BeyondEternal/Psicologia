using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Psicología.Shared.Model
{
    public enum Gender
    {
        Hombre,
        Mujer,
        NoEspecificado
    }

    public class Paciente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio"), MaxLength(100)]
        public string? Name { get; set; }
        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria"), DataType(DataType.Date)]
        public DateTime? Birthday { get; set; }
        [Required(ErrorMessage = "El género es obligatorio"), EnumDataType(typeof(Gender))]
        public Gender? Gender { get; set; }
        [Required(ErrorMessage = "El correo electrónico es obligatorio"), EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage = "El número de teléfono es obligatorio"), MaxLength(100), Phone]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "La descripción es obligatoria"), MaxLength(255), Description, DataType(DataType.MultilineText)]
        public string? Description { get; set; }
    }

}
