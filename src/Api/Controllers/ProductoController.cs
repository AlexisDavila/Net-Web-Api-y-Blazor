
using Microsoft.AspNetCore.Mvc;
using NetFirebase.Api.Models.Domain;
using NetFirebase.Api.Services.Productos;

namespace NetFirebase.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductoController : ControllerBase
{
   private readonly IProductoService _productoService;
   public ProductoController(IProductoService productoService)
   {
      _productoService = productoService;
   }

   [HttpPost]
   public async Task<ActionResult> CreateProducto(
      [FromBody] Producto producto
   )
   {
      await _productoService.CreateProducto(producto);
      return Ok();
   }
   [HttpGet]
   public async Task<ActionResult> GetAllProductos()
   {
      var results = await _productoService.GetAllProductos();
      return Ok(results);
   }
   [HttpGet("{id}")]
   public async Task<ActionResult> GetProductoById(int id)
   {
      var result = await _productoService.GetProductoById(id);
      return Ok(result);
   }
   [HttpGet("nombre/{nombre}")]
   public async Task<ActionResult> GetProductoByNombre(string nombre)
   {
      var results = await _productoService.GetProductoByNombre(nombre);
      return Ok(results);
   }
   [HttpPut]
   public async Task<ActionResult> UpdateProducto(
      [FromBody] Producto producto
   )
   {
      await _productoService.UpdateProducto(producto);
      return Ok();
   }

   [HttpDelete("{id}")]
   public async Task<ActionResult> DeleteProducto(int id)
   {
      await _productoService.DeleteProducto(id);
      return Ok();
   }
}