using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DrEmergencias
{
    public class Articulo
    {
        [Key]
        public int ArticuloID { get; set; }

        public string?  Descripcion { get; set; }
        public double? Costo { get;  set; }
        
        public double? Precio { get; set; }
        public int? Existencia { get; set; }

        public Articulo()
        {
            this.Existencia=0;
        }
    }
}