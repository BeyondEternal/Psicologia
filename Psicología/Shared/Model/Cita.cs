using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Psicología.Shared.Model
{
    public class Cita
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "La fecha y hora de la cita son obligatorias"), DataType(DataType.DateTime)]
        public DateTime? Appointment { get; set; }
        [Required(ErrorMessage = "La duración de la cita es obligatoria")]
        public int? Duration { get; set; }
        [Required(ErrorMessage = "Las sesiones por mes son obligatorias")]
        public int? Frequency { get; set; }
        [ForeignKey("Paciente"), Required(ErrorMessage = "La identificación del paciente es obligatoria")]
        public int? IdPaciente { get; set; }
        public Paciente? Paciente { get; set; }
        [ForeignKey("Terapeuta"), Required(ErrorMessage = "La identificación del terapeuta es obligatoria")]
        public int? IdTherapist { get; set; }
        public Terapeuta? Terapeuta { get; set; }
    }


}
