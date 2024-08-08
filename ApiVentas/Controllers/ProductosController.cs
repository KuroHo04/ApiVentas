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
            //_productos = new List<Producto>();

            //_productos.Add(new Producto()
            //{
            //    Id = 1,
            //    Codigo = 1,
            //    Descripcion = "Rockaccino",
            //    PrecioUnitario = 70.00m
            //});
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
    }
}
