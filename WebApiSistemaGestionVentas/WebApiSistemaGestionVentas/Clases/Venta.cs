namespace WebApiSistemaGestionVentas.Clases
{
    public class Venta
    {
        //Atributos y propiedades
        public long Id { get; set; }
        public string Comentarios { get; set; }
        public int IdUsuario { get; set; }

        //Constructores
        public Venta()
        {
            this.Id = 0;
            this.Comentarios = "";
            this.IdUsuario = 0;
        }
        public Venta(long id, string comentarios, int idUsuario)
        {
            this.Id = id;
            this.Comentarios = comentarios;
            this.IdUsuario = idUsuario;
        }
        public Venta(Venta v)
        {
            this.Id = v.Id;
            this.Comentarios = v.Comentarios;
            this.IdUsuario = v.IdUsuario;
        }
    }
}
