using System.ComponentModel.DataAnnotations;

namespace DrEmergencias
{
    public class Suplidor
    {
        [Key]
        public int SuplidorID { get; set; }

        public string Nombre  { get; set; }
        
        public string  Contacto{get;set;}
        public bool Visible { get; set; }

        public Suplidor()
        {
            this.Visible=true;
        }
    }
}