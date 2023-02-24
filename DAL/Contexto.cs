using Microsoft.EntityFrameworkCore;
namespace DrEmergencias
{
    public class Contexto : DbContext
    {
        public DbSet<Emergencia> Emergencias {get;set;}
        public DbSet<EmergenciaA> EmergenciaAs {get;set;}
        public DbSet<Paciente> Pacientes {get;set;}
        public Contexto(DbContextOptions<Contexto> Options) : base(Options){}
    }
}