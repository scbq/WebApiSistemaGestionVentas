namespace WebApiSistemaGestionVentas.Clases
{
    public class Producto
    {
        //Atributos y Propiedades
        public long Id { get; set; }
        public string Descripciones { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public long IdUsusario { get; set; }

        //Constructores
        public Producto()
        {
            this.Id = 0;
            this.Descripciones = "";
            this.Costo = 0;
            this.PrecioVenta = 0;
            this.Stock = 0;
            this.IdUsusario = 0;
        }
        public Producto(long id, string descripciones, decimal costo, decimal precioVenta, int stock, long idUsusario)
        {
            this.Id = id;
            this.Descripciones = descripciones;
            this.Costo = costo;
            this.PrecioVenta = precioVenta;
            this.Stock = stock;
            this.IdUsusario = idUsusario;
        }
        public Producto(Producto p)
        {
            this.Id = p.Id;
            this.Descripciones = p.Descripciones;
            this.Costo = p.Costo;
            this.PrecioVenta = p.PrecioVenta;
            this.Stock = p.Stock;
            this.IdUsusario = p.IdUsusario;
        }
    }
}
