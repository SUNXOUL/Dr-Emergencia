using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace DrEmergencias
{
    public class EmergenciaA
    {
        [Key]
        public  int OrdenID{get;set;}
        public string? EmergenciaID{get;set;}
        public int PacienteID { get; set; }
        public string? ARS { get; set; }
        public string NSS { get; set; }
        public DateTime? Fecha { get; set; }
        public String? M_Consulta { get; set; }
        public String? Antecedentes { get; set; }
        public string? AtencionesPrevias { get; set; }
        public string? Donde { get; set; }
        public string? MedicoBase { get; set; }
        public int? Peso { get; set; }
        public int? TA { get; set; }
        public int? FC { get; set; }
        public int? FR { get; set; }
        public int? Temperatura { get; set; }
        public string? Cabeza { get; set; }
        public string? Cuello { get; set; }
        public string? Torax { get; set; }
        public string? Pulmones { get; set; }
        public string? Corazon { get; set; }
        public string? Abdomen { get; set; }
        public string? E_Inferiores { get; set; }
        public string? E_Superiores { get; set; }

        public string? Diagnostico { get; set; }
        public int? Hemogramas { get; set; }
        public int? Ex_Orina { get; set; }
        public int? Glisemia { get; set; }
        public int? Coprologico { get; set; }
        public int? Imagenes { get; set; }
        public string? Especifique { get; set; }
        public string? TyM { get; set; }

        public bool Visible {get; set;}

        public EmergenciaA()
        {
            this.Visible=true;
        }

    }
}