namespace ApiVentas.Entities
{
    public class Producto
    {
        public int Id { get; set; }

        public int Codigo { get; set; }

        public string Descripcion { get; set; }

        public decimal PrecioUnitario { get; set; }
    }
}
