using System.Xml;
using System;
using System.ComponentModel.DataAnnotations;


namespace DrEmergencias
{
    public class Paciente
    {
        [Key]
        public int OrdenID{ get; set; }
        public string? PacienteID { get; set; }
        public string? PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string? PrimerApellido { get; set; }

        public string? SegundoApellido { get; set; }
        public Sexo? sexo { get; set; }

        public string? Cedula { get; set; }

        public string? Ocupacion { get; set; }

        public string? tutor {get; set;}

        public string? CedulaTutor { get; set; }
        
        public string? Alergia { get; set; }

        public string? Telefono { get; set; }
        public DateTime? FechadeNacimiento { get; set; }
        public int? Edad { get; set; }
        public string? Direccion { get; set; }
        public Provincia? Provincia { get; set; }
        public string? Municipio { get; set; }

         public bool? Visible {get; set;}
    }
}