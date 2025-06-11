using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Producto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CodigoProducto { get; set; }

    public string Nombre { get; set; }

    [ForeignKey("Categoria")]
    public int CodigoCategoria { get; set; }

    public Categoria Categoria { get; set; }

    public List<Venta> Ventas { get; set; } = new();
}
