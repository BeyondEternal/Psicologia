using Microsoft.EntityFrameworkCore;
using Psicología.Shared.Model;


namespace Psicología.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Terapeuta> Terapeutas { get; set; }
    }
}
