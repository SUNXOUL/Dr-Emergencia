using Microsoft.EntityFrameworkCore;
namespace DrEmergencias
{
    public class Contexto : DbContext
    {
        public DbSet<Emergencia> Emergencia {get;set;}
        public DbSet<EmergenciaA> EmergenciaA {get;set;}
        public DbSet<Paciente> Paciente {get;set;}
        public DbSet<Articulo> Articulos {get;set;}
        public DbSet<Suplidor> Suplidores {get;set;}
        public DbSet<OrdenInventario> Entradas { get; set; }
        public DbSet<OrdenInventario> Salidas { get; set; }
        public Contexto(DbContextOptions<Contexto> Options) : base(Options){}

    }
}