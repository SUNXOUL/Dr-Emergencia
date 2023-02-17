using System.ComponentModel.DataAnnotations;

namespace DrEmergencias
{
    public class DetalleEmergencia
    {
        [Key]
        public int DetalleId {get;set;}

        public int PacienteID { get; set; }

        public  int OrdenID{get;set;}

        public string? PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        public string? PrimerApellido { get; set; }

        public string? SegundoApellido { get; set; }
        public Sexo? Sexo { get; set; }

        public string? Cedula { get; set; }
        public string? CedulaTutor { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Medico { get;set; }
        
        
        public bool? Visible {get; set;}


    }
}