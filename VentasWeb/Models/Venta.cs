using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Venta
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CodigoVenta { get; set; }

    public DateTime Fecha { get; set; }

    [ForeignKey("Producto")]
    public int CodigoProducto { get; set; }

    public Producto Producto { get; set; }
}
