using System.Data.SqlClient;
using WebApiSistemaGestionVentas.Clases;

namespace WebApiSistemaGestionVentas.ADO.net
{
    public class ProductoHandler
    {
        private SqlConnection conexion;
        private string CadenaConexion = "Server=sql.bsite.net\\MSSQL2016;" +
        "Database=ajomuch92_coderhouse_csharp_40930; " +
        "User Id= ajomuch92_coderhouse_csharp_40930;" +
        "Password=ElQuequit0Sexy2022;";

        public ProductoHandler()
        {
            try
            {
                conexion = new SqlConnection(CadenaConexion);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Producto> GetProductos()
        {
            List<Producto> listaProductos = new List<Producto>();
            if (CadenaConexion == null)
            {
                throw new Exception("Conexión no realizada");
            }
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Producto", conexion))
                {
                    conexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Producto producto = new Producto();
                                producto.Id = reader.GetInt64(0);
                                producto.Descripciones = reader.GetString(1);
                                producto.Costo = reader.GetDecimal(2);
                                producto.PrecioVenta = reader.GetDecimal(3);
                                producto.Stock = reader.GetInt32(4);
                                producto.IdUsusario = reader.GetInt64(5);
                                listaProductos.Add(producto);
                            }
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return listaProductos;
        }
    }
}
