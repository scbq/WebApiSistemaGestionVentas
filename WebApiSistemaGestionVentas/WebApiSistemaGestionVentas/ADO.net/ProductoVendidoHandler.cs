using System.Data.SqlClient;
using WebApiSistemaGestionVentas.Clases;

namespace WebApiSistemaGestionVentas.ADO.net
{
    public class ProductoVendidoHandler
    {
        private SqlConnection conexion;
        private string CadenaConexion = "Server=sql.bsite.net\\MSSQL2016;" +
        "Database=ajomuch92_coderhouse_csharp_40930; " +
        "User Id= ajomuch92_coderhouse_csharp_40930;" +
        "Password=ElQuequit0Sexy2022;";

        public ProductoVendidoHandler()
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

        public List<ProductoVendido> GetProductosVendidos()
        {
            List<ProductoVendido> listaProductosVendidos = new List<ProductoVendido>();
            if (CadenaConexion == null)
            {
                throw new Exception("Conexión no realizada");
            }
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM ProductoVendido", conexion))
                {
                    conexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ProductoVendido produVendido = new ProductoVendido();
                                produVendido.Id = reader.GetInt64(0);
                                produVendido.Stock = reader.GetInt32(1);
                                produVendido.IdProducto = reader.GetInt32(2);
                                produVendido.IdVenta = reader.GetInt64(3);
                                listaProductosVendidos.Add(produVendido);
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
            return listaProductosVendidos;
        }
    }
}
