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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Paciente>().HasData(
                new Paciente
                {
                    PacienteID = 1,
                    PrimerNombre = "Cesar",
                    SegundoNombre = "Jose",
                    PrimerApellido ="Reynoso",
                    Sexo = "Hombre",
                    Cedula = "809-7877890-1",
                    Ocupacion = "DBA",
                    Telefono ="829-567-9072",
                    FechadeNacimiento="3/8/2003",
                    Edad = 19,
                    Direccion ="Nagua,RD",
                    Provincia ="MTS",
                    Municipio ="Nagua",
                    Visible = true,




                },

                new Paciente
                {
                    PacienteID = 2,
                    PrimerNombre = "Em",
                    SegundoNombre = "Ramon",
                    PrimerApellido ="Sanchez",
                    Sexo = "Hombre",
                    Cedula = "222-3377890-3",
                    Ocupacion = "Agricultor",
                    Telefono ="849-343-0000",
                    FechadeNacimiento="3/8/2005",
                    Edad = 17,
                    Direccion ="Pinia 3",
                    Provincia ="Duarte",
                    Municipio ="SFM",
                    Visible = true,




                },

                new Paciente
                {
                    PacienteID = 3,
                    PrimerNombre = "Camila",
                    SegundoNombre = "",
                    PrimerApellido ="Almonte",
                    SegundoApellido = "Castellanos",
                    Sexo = "Mujer",
                    Cedula = "332-4447822-2",
                    Ocupacion = "Estilista",
                    Telefono ="787-567-9072",
                    FechadeNacimiento="3/8/2000",
                    Edad = 23,
                    Direccion ="SALCEDO, LAS cuevas",
                    Provincia ="Duarte",
                    Municipio ="Salcedo",
                    Visible = true,




                },

                new Paciente
                {
                    PacienteID = 4,
                    PrimerNombre = "Kinsgton",
                    SegundoNombre = "Elsmon",
                    PrimerApellido ="Rodriguez",
                    Sexo = "Hombre",
                    Cedula = "402-7877890-1",
                    Ocupacion = "Civil Engenieer",
                    Telefono ="829-337-9712",
                    FechadeNacimiento="3/8/1990",
                    Edad = 33,
                    Direccion ="Cabrera, La entrada",
                    Provincia ="MTS",
                    Municipio ="Cabrera",
                    Visible = true,




                },

                new Paciente
                {
                    PacienteID = 5,
                    PrimerNombre = "Jeison",
                    SegundoNombre = "Lo",
                    PrimerApellido ="Lopez",
                    SegundoApellido= "Javier",
                    Sexo = "Hombre",
                    Cedula = "888-7899890-1",
                    Ocupacion = "Analista de sistemas",
                    Telefono ="829-567-7777",
                    FechadeNacimiento="3/8/1997",
                    Edad = 26,
                    Direccion ="Spain, MALLORCA",
                    Provincia ="N",
                    Municipio ="N",
                    Visible = true,




                },


                new Paciente
                {
                    PacienteID = 6,
                    PrimerNombre = "Yoland",
                    SegundoNombre = "Ves",
                    PrimerApellido ="JULIENS",
                    Sexo = "Mujer",
                    Cedula = "867-1877111-1",
                    Ocupacion = "Enterprise ADMIN",
                    Telefono ="829-567-8890",
                    FechadeNacimiento="3/8/2002",
                    Edad = 20,
                    Direccion ="USA, CANADA",
                    Provincia ="N",
                    Municipio ="N",
                    Visible = true,




                },

                new Paciente
                {
                    PacienteID = 7,
                    PrimerNombre = "Holland",
                    SegundoNombre = "Gab",
                    PrimerApellido ="Estrella",
                    Sexo = "Hombre",
                    Cedula = "222-1111111-1",
                    Ocupacion = "Senior Dev",
                    Telefono ="878-567-9072",
                    FechadeNacimiento="3/8/2004",
                    Edad = 18,
                    Direccion ="France, Paris",
                    Provincia ="N",
                    Municipio ="N",
                    Visible = true,




                },

                new Paciente
                {
                    PacienteID = 8,
                    PrimerNombre = "Nou",
                    SegundoNombre = "ester",
                    PrimerApellido ="Martinez",
                    Sexo = "Mujer",
                    Cedula = "666-7877890-1",
                    Ocupacion = "Alquimista",
                    Telefono ="829-567-333",
                    FechadeNacimiento="3/8/2003",
                    Edad = 19,
                    Direccion ="Nagua,RD",
                    Provincia ="MTS",
                    Municipio ="Nagua",
                    Visible = true,




                },

                new Paciente
                {
                    PacienteID = 9,
                    PrimerNombre = "C",
                    SegundoNombre = "James",
                    PrimerApellido ="Ilstens",
                    Sexo = "Hombre",
                    Cedula = "123-7877890-1",
                    Ocupacion = "Dto",
                    Telefono ="119-227-3372",
                    FechadeNacimiento="3/8/2003",
                    Edad = 19,
                    Direccion ="Nagua,RD",
                    Provincia ="MTS",
                    Municipio ="Nagua",
                    Visible = true,




                },


                new Paciente
                {
                    PacienteID = 10,
                    PrimerNombre = "Amanda",
                    SegundoNombre = "",
                    PrimerApellido ="Fernandez",
                    Sexo = "Mujer",
                    Cedula = "804-4877890-4",
                    Ocupacion = "DBA",
                    Telefono ="829-567-4444",
                    FechadeNacimiento="3/8/2003",
                    Edad = 19,
                    Direccion ="Nagua,RD",
                    Provincia ="MTS",
                    Municipio ="Nagua",
                    Visible = true,




                }

                
            );

            modelBuilder.Entity<Suplidor>().HasData(

                    new Suplidor{
                        SuplidorID =1,
                        Nombre = "GBC Enterprise",
                        Contacto ="829-787-5366"
                    },
                    new Suplidor{
                        SuplidorID = 2,
                        Nombre ="FarmaSalud",
                        Contacto = "809-123-9933"
                    
                    },
                    new Suplidor{
                        SuplidorID =3,
                        Nombre ="Minoxidil",
                        Contacto ="829-863-5107"
                    }

            );
        }

    }

    
}