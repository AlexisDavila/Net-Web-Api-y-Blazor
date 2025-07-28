
using NetFirebase.Api.Models.Domain;

namespace NetFirebase.Api.Services.Productos;


public interface IProductoService
{
   Task<IEnumerable<Producto>> GetAllProductos();
   Task<Producto> GetProductoById(int id);
   Task<Producto> CreateProducto(Producto producto);
   Task<Producto> UpdateProducto(Producto producto);
   Task<bool> DeleteProducto(int id);
   Task<bool> SaveChanges();
}