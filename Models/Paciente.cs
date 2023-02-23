using System.Xml;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DrEmergencias
{
    public class Paciente
    {
        [Key]
        public int PacienteID { get; set; }
        public string? PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string? PrimerApellido { get; set; }

        public string? SegundoApellido { get; set; }
        public string? Sexo { get; set; }

        public string? Cedula { get; set; }

        public string? Ocupacion { get; set; }

        public string? Tutor {get; set;}

        public string? CedulaTutor { get; set; }
        
        public string? Alergia { get; set; }

        public string? Telefono { get; set; }
        public string? FechadeNacimiento { get; set; }
        public int? Edad { get; set; }
        public string? Direccion { get; set; }
        public string? Provincia { get; set; }
        public string? Municipio { get; set; }

        public bool? Visible {get; set;}

        [ForeignKey("PacienteID")]
        public List<EmergenciaADetalle> DetalleAseguradas { get; set; }

        [ForeignKey("PacienteID")]

        public List<EmergenciaDetalle> DetalleNoAseguradas {get; set;} 
        
    }

    public class EmergenciaADetalle
    {
        
        [Key]

        public int ADetalleId { get; set; }

        public int  PacienteID { get; set; }

        public int EmergenciaAId { get; set; }



    }

    public class EmergenciaDetalle
    {

        [Key]
        public int DetalleId { get; set; }

        public int PacienteID { get; set; }

        public int EmergenciaId { get; set; }



    }
}