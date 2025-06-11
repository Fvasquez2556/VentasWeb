using VentasWeb.Models;
using System;
using System.Linq;

public static class DbInitializer
{
    public static void Initialize(AppDbContext context)
    {
        // Eliminar datos existentes en orden correcto
        context.Ventas.RemoveRange(context.Ventas);
        context.Productos.RemoveRange(context.Productos);
        context.Categorias.RemoveRange(context.Categorias);
        context.SaveChanges();

        // Insertar categorías
        context.Categorias.AddRange(
            new Categoria { Nombre = "Electrónica" },
            new Categoria { Nombre = "Ropa" },
            new Categoria { Nombre = "Hogar" }
        );
        context.SaveChanges();

        Console.WriteLine("Total categorías insertadas: " + context.Categorias.Count());

        // Obtener IDs reales desde base de datos con validación
        var categoriaElectronica = context.Categorias.FirstOrDefault(c => c.Nombre == "Electrónica");
        var categoriaRopa = context.Categorias.FirstOrDefault(c => c.Nombre == "Ropa");
        var categoriaHogar = context.Categorias.FirstOrDefault(c => c.Nombre == "Hogar");

        if (categoriaElectronica == null || categoriaRopa == null || categoriaHogar == null)
        {
            throw new Exception("Las categorías no fueron insertadas correctamente.");
        }

        // Insertar productos relacionados
        context.Productos.AddRange(
            new Producto { Nombre = "Laptop", CodigoCategoria = categoriaElectronica.CodigoCategoria },
            new Producto { Nombre = "Camisa", CodigoCategoria = categoriaRopa.CodigoCategoria },
            new Producto { Nombre = "Licuadora", CodigoCategoria = categoriaHogar.CodigoCategoria }
        );
        context.SaveChanges();

        var producto1 = context.Productos.FirstOrDefault(p => p.Nombre == "Laptop");
        var producto2 = context.Productos.FirstOrDefault(p => p.Nombre == "Camisa");
        var producto3 = context.Productos.FirstOrDefault(p => p.Nombre == "Licuadora");

        if (producto1 == null || producto2 == null || producto3 == null)
        {
            throw new Exception("Los productos no fueron insertados correctamente.");
        }

        // Insertar ventas
        context.Ventas.AddRange(
            new Venta { Fecha = new DateTime(2019, 2, 10), CodigoProducto = producto1.CodigoProducto },
            new Venta { Fecha = new DateTime(2019, 5, 21), CodigoProducto = producto2.CodigoProducto },
            new Venta { Fecha = new DateTime(2020, 1, 1), CodigoProducto = producto3.CodigoProducto },
            new Venta { Fecha = new DateTime(2021, 11, 1), CodigoProducto = producto1.CodigoProducto }
        );
        context.SaveChanges();
    }
}
