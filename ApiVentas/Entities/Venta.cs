namespace ApiVentas.Entities
{
    public class Venta
    {
        public Cliente Cliente { get; set; }
        public List<Producto> Productos { get; set; } 

        // TODO: agregar mas campos.
    }
}
