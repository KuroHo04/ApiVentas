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
        public ActionResult<List<Producto>> ObtenerProductos()
        {
            return Ok(Productos.ProductosAgregados);
        }

        [HttpPost]

        public ActionResult CrearProducto([FromBody] Producto producto)
        {
            Productos.ProductosAgregados.Add(producto);
            return Ok();
        }

        [HttpPut]
        public ActionResult Actualizar([FromBody] Producto producto)
        {
            //LinQ
            var productoEnLista = Productos.ProductosAgregados
                .FirstOrDefault(p => p.Id == producto.Id);


            //Producto? productoEnLista = null;
            //foreach (Producto productoAgregado in Productos.ProductosAgregados)
            //{
            //    if (productoAgregado.Id == producto.Id)
            //    {
            //        productoEnLista = productoAgregado;
            //        break;
            //    }
            //}

            if (productoEnLista == null)
            {
                return NotFound();
            }

            productoEnLista.Codigo = producto.Codigo;
            productoEnLista.Descripcion = producto.Descripcion;
            productoEnLista.PrecioUnitario = producto.PrecioUnitario;

            return Ok();
        }
    }
}
