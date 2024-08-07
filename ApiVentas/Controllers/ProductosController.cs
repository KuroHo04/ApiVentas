using ApiVentas.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiVentas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        List<Producto> _productos;

        public ProductosController()
        {
            _productos = new List<Producto>();

            _productos.Add(new Producto()
            {
                Id = 1,
                Codigo = 1,
                Descripcion = "Rockaccino",
                PrecioUnitario = 70.00m
            });
        }

        [HttpGet]
        public  ActionResult<List<Producto>> ObtenerProductos()
        {
            return Ok(_productos);
        }
    }
}
