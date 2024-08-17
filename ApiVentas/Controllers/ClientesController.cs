using ApiVentas.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiVentas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        public ClientesController()
        {
        }
        [HttpGet]
        public ActionResult<List<Cliente>> ObtenerClientes()
        {
            return Ok(Clientes.ClientesAgregados);
        }

        [HttpPost]
        public ActionResult CrearClientes([FromBody] Cliente cliente)
        {
            Clientes.ClientesAgregados.Add(cliente);
            return Ok();
        }
        [HttpPut]
        public ActionResult Actualizar([FromBody] Cliente cliente)
        {
            //LinQ
            var clienteEnLista = Clientes.ClientesAgregados
                .FirstOrDefault(c => c.Id == cliente.Id);

            //Producto? productoEnLista = null;
            //foreach (Producto productoAgregado in Productos.ProductosAgregados)
            //{
            //    if (productoAgregado.Id == producto.Id)
            //    {
            //        productoEnLista = productoAgregado;
            //        break;
            //    }
            //}

            if (clienteEnLista == null)
            {
                return NotFound();
            }
            clienteEnLista.Nombre = cliente.Nombre;
            clienteEnLista.Telefono = cliente.Telefono;
            clienteEnLista.Direccion = cliente.Direccion;

            return Ok();
        }
        [HttpDelete("{id:int}")]
        public ActionResult Eliminar(int id)
        {
            var clienteEnLista = Clientes.ClientesAgregados
                .FirstOrDefault(p => p.Id == id);

            if (clienteEnLista == null)
            {
                return NotFound();
            }
            Clientes.ClientesAgregados.Remove(clienteEnLista);

            return Ok();
        }
    }
}