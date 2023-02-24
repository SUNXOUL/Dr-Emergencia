using Microsoft.EntityFrameworkCore;
namespace DrEmergencias
{
    public class Contexto : DbContext
    {
        public DbSet<Emergencia> Emergencias {get;set;}
        public DbSet<EmergenciaA> EmergenciaAs {get;set;}
        public DbSet<Paciente> Pacientes {get;set;}
        public DbSet<Articulo> Articulos {get;set;}
        public DbSet<Suplidor> Suplidores {get;set;}
        public DbSet<OrdenInventario> Entradas { get; set; }
        public DbSet<OrdenInventario> Salidas { get; set; }
        public Contexto(DbContextOptions<Contexto> Options) : base(Options){}

    }
}