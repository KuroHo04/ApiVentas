namespace ApiVentas.Entities
{
    public class Venta
    {
        public int Id { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<Producto> Productos { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

    }
}