
using Microsoft.EntityFrameworkCore;
using NetFirebase.Api.Data;
using NetFirebase.Api.Models.Domain;

namespace NetFirebase.Api.Services.Productos;

public class ProductoService : IProductoService
{
    private readonly DatabaseContext _context;

    public ProductoService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Producto>> GetAllProductos()
    {
      return await _context.Database.SqlQuery<Producto>(@$"
         SELECT * FROM ""Productos""
      ").ToListAsync();
    }

   public async Task<Producto> GetProductoById(int id)
   {
      Console.WriteLine($"Obteniendo producto con ID: {id}");
      var resultado = await _context.Database.SqlQuery<Producto>(@$"
         SELECT * FROM ""Productos"" WHERE Id = {id}
      ").FirstOrDefaultAsync();

      return resultado is null ? null! : resultado!;
   }

   public async Task<Producto> CreateProducto(Producto producto)
   {
      var resultado = await _context.Database.ExecuteSqlAsync(@$"
         INSERT INTO ""Productos"" (Nombre, Descripcion, Precio)
         VALUES (
            {producto.Nombre},
            {producto.Descripcion},
            {producto.Precio}
         )
      ");
      if (resultado <= 0)
      {
         throw new Exception("Errores en la inserción del producto");
      }
      return producto;
   }

    public async Task<Producto> UpdateProducto(Producto producto)
    {
        _context.Productos.Update(producto);
        await SaveChanges();
        return producto;
    }

    public Task DeleteProducto(int id)
    {
      throw new NotImplementedException();
    }

    public Task<bool> SaveChanges()
    {
        throw new NotImplementedException();
    }
}