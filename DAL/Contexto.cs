using Microsoft.EntityFrameworkCore;
namespace DrEmergencias
{
    public class Contexto : DbContext
    {
        public DbSet<Emergencia> Emergencia {get;set;}
        public DbSet<EmergenciaA> EmergenciaA {get;set;}
        public DbSet<Paciente> Paciente {get;set;}
        public DbSet<DetalleEmergencia> DetallesEmergencias {get;set;}
        public DbSet<DetalleEmergenciaA> DetallesEmergenciasA {get;set;}
        public Contexto(DbContextOptions<Contexto> Options) : base(Options){}
    }
}