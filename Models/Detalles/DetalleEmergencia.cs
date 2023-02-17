using System.ComponentModel.DataAnnotations;

namespace DrEmergencias
{
    class DetalleEmergencia
    {
        [Key]
        public int DetalleId {get;set;}

        public int PacienteID { get; set; }

        public  int OrdenID{get;set;}
    }
}