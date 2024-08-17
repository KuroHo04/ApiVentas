using Microsoft.AspNetCore.Mvc;
using ApiVentas.Entities;

namespace ApiVentas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VentasController : ControllerBase
    {
        public VentasController()
        {
        }

        [HttpGet]
        public ActionResult<List<Venta>> ObtenerVentas()
        {
            return Ok(Ventas.VentasRealizadas);
        }

        [HttpPost]
        public ActionResult CrearVenta([FromBody] Venta venta)
        {
            Ventas.VentasRealizadas.Add(venta);
            return Ok();
        }

        [HttpPut]
        public ActionResult Actualizar([FromBody] Venta venta)
        {
            var ventaEnLista = Ventas.VentasRealizadas
                .FirstOrDefault(v => v.Id == venta.Id);

            if (ventaEnLista == null)
            {
                return NotFound();
            }

            ventaEnLista.ClienteId = venta.ClienteId;
            ventaEnLista.ProductoId = venta.ProductoId;
            ventaEnLista.Fecha = venta.Fecha;
            ventaEnLista.Total = venta.Total;

            return Ok();
        }

        [HttpDelete("{id:int}")]
        public ActionResult Eliminar(int id)
        {
            var ventaEnLista = Ventas.VentasRealizadas
                .FirstOrDefault(v => v.Id == id);

            if (ventaEnLista == null)
            {
                return NotFound();
            }

            Ventas.VentasRealizadas.Remove(ventaEnLista);
            return Ok();
        }
    }
}