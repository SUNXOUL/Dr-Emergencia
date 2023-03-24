using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DrEmergencias
{
    public class OrdenCompras
    {

        [Key]
        public int CompraId { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public int SuplidorId { get; set; }

        public double? Total { get; set; } = 0;

        public bool Visible { get; set; } = true;

        
        [ForeignKey("CompraId")]
        public List<ComprasDetalle> Detalle { get; set; } = new List<ComprasDetalle>();



    }

    public class ComprasDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int CompraId { get; set; }
        public int ArticuloId { get; set; }
        public int? cantidad { get; set; }
        public double? costo { get; set; }
        public bool Visible { get; set; }
        [NotMapped]
        public double? Importe
        {
            get { return cantidad * costo; }
        }

    }
}