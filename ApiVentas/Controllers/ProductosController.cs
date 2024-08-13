using ApiVentas.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiVentas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {

        public ProductosController()
        {
            
        }

        [HttpGet]
        public  ActionResult<List<Producto>> ObtenerProductos()
        {
            return Ok(Productos.ProductosAgregados);
        }

        [HttpPost]

        public ActionResult CrearProducto([FromBody]Producto producto)
        {
            Productos.ProductosAgregados.Add(producto);
            return Ok();
        }

        [HttpPut]
        public ActionResult Actualizar([FromBody]Producto producto)
        {
            var productoEnLista = Productos.ProductosAgregados.FirstOrDefault(p => p.Id == producto.Id);
        }
    }
}
