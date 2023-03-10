using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DrEmergencias
{
    public class Articulo
    {
        [Key]
        public int ArticuloID { get; set; }

        public int SuplidorId {get; set;}

        public string?  Descripcion { get; set; }
        public double? Costo { get;  set; }
        
        public double? Precio { get; set; }
        public int? Existencia { get; set; }

        public ESTADOS Estado {get; set;}
        public int Num_Reorden {get; set;}
        public bool Visible { get; set; }

        
        public Articulo()
        {
            this.Existencia=0;
            this.Visible = true;
            this.Estado = ESTADOS.DESABILITADO;
        }
    }

    public enum ESTADOS
    {
        ACTIVO,

        DESABILITADO,

        REORDEN
    }

}