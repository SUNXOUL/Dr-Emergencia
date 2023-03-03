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
        public DbSet<Entrada> Entradas { get; set; }
        public DbSet<Salida> Salidas { get; set; }
        public DbSet<OrdenCompras> OrdenCompras {get; set;}
        public Contexto(DbContextOptions<Contexto> Options) : base(Options){}

    }

    
}