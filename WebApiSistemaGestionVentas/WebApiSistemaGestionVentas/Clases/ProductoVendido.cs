namespace WebApiSistemaGestionVentas.Clases
{
    public class ProductoVendido
    {
        //Atributos y Propiedades
        public long Id { get; set; }
        public int IdProducto { get; set; }
        public int Stock { get; set; }
        public long IdVenta { get; set; }

        //Constructores
        public ProductoVendido()
        {
            this.Id = 0;
            this.IdProducto = 0;
            this.Stock = 0;
            this.IdVenta = 0;
        }
        public ProductoVendido(long id, int idProducto, int stock, long idVenta)
        {
            Id = id;
            IdProducto = idProducto;
            Stock = stock;
            IdVenta = idVenta;
        }
        public ProductoVendido(ProductoVendido pv)
        {
            this.Id = pv.Id;
            this.IdProducto = pv.IdProducto;
            this.Stock = pv.Stock;
            IdVenta = pv.IdVenta;
        }
    }
}
