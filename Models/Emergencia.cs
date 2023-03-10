using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace DrEmergencias
{
    public class Emergencia
    {
        [Key]
        public  int OrdenID{get;set;}
        public string? EmergenciaID{get;set;}
        public int PacienteID { get; set; }
        public DateTime? Fecha { get; set; }
        public string? M_Consulta { get; set; }
        public string? Antecedentes { get; set; }
        public string? AtencionesPrevias { get; set; }
        public string? Donde { get; set; }
        public string? MedicoBase { get; set; }
        public int? Peso { get; set; }
        public int? TA { get; set; }
        public int? FC { get; set; }
        public int? FR { get; set; }
        public int? Temperatura {get;set;}
        public string? Diagnostico { get; set; }
        public int? Hemogramas { get; set; }
        public int? Ex_Orina { get; set; }
        public int? Glisemia { get; set; }
        public int? Coprologico { get; set; }
        public int? Imagenes { get; set; }
        public string? Especifique { get; set; }
        public string? TyM { get; set; }
        public bool Visible {get; set;}

        public Emergencia()
        {
            this.Visible=true;
        }
    }
}