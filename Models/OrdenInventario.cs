using System.ComponentModel.DataAnnotations;
namespace DrEmergencias
{
public class OrdenInventario
{
    [Key]
    public int OrdenID { get; set; }
    public int ArticuloID { get; set; }
    public int? Cantidad { get; set; }
    public int? cantidad_anterior { get; set; }
    public int? cantidad_Resultante {get; set;}
    public string? Razon { get; set; }
    public DateTime? Fecha { get; set; }
    public bool Visible { get; set; }

    public OrdenInventario()
    {
        this.Cantidad =0;
        this.Visible = true;
        this.Fecha= DateTime.Now;
    }
}
    public class Entrada : OrdenInventario
    {
        
    }
        public class Salida: OrdenInventario
    {
        
    }
}