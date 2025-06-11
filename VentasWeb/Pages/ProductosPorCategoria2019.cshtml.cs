using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VentasWeb.Models;

public class ProductosPorCategoria2019Model : PageModel
{
    private readonly AppDbContext _context;

    public ProductosPorCategoria2019Model(AppDbContext context)
    {
        _context = context;
    }

    [BindProperty(SupportsGet = true)]
    public int? CategoriaSeleccionadaId { get; set; }

    public List<SelectListItem> CategoriasConVentas { get; set; } = new();
    public List<Producto> ProductosFiltrados { get; set; } = new();

    public async Task OnGetAsync()
    {
        // Cargar categorías con ventas en 2019
        var categorias = await _context.Ventas
            .Where(v => v.Fecha.Year == 2019)
            .Include(v => v.Producto)
                .ThenInclude(p => p.Categoria)
            .Select(v => v.Producto.Categoria)
            .Distinct()
            .ToListAsync();

        CategoriasConVentas = categorias
            .Select(c => new SelectListItem
            {
                Value = c.CodigoCategoria.ToString(),
                Text = c.Nombre
            })
            .ToList();

        // Si ya se seleccionó una categoría, filtrar productos vendidos en 2019
        if (CategoriaSeleccionadaId.HasValue)
        {
            ProductosFiltrados = await _context.Ventas
                .Where(v => v.Fecha.Year == 2019 && v.Producto.CodigoCategoria == CategoriaSeleccionadaId)
                .Include(v => v.Producto)
                .Select(v => v.Producto)
                .Distinct()
                .ToListAsync();
        }
    }
}