using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VentasWeb.Models;

public class Categoria
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CodigoCategoria { get; set; }

    public string Nombre { get; set; }
    public List<Producto> Productos { get; set; } = new();
}
