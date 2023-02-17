using System.ComponentModel.DataAnnotations;

namespace DrEmergencias
{
    public class DetalleEmergenciaA
    {
        [Key]
        public int DetalleId {get;set;}

        public int PacienteID { get; set; }

        public  int OrdenID{get;set;}

        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }

        public string SegundoApellido { get; set; }
        public Sexo Sexo { get; set; }

        public string Cedula { get; set; }
        public DateTime? Fecha { get; set; }
        public string Medico { get;set; }
        public ARS Ars {get;set;}
        public int NSS {get;set;}
        
        
        public bool? Visible {get; set;}
    }
}