using System.ComponentModel.DataAnnotations;

public class OrdenInventario
{
    [Key]
    public int OrdenID { get; set; }
    public int ArticuloID { get; set; }
    public int? Cantidad { get; set; }
    public string? Razon { get; set; }
    public DateTime? Fecha { get; set; }
    public bool Visible { get; set; }

    public OrdenInventario()
    {
        this.Cantidad =0;
        this.Visible = true;
    }
}