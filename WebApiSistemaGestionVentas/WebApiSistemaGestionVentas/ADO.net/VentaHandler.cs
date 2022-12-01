using System.Data.SqlClient;
using WebApiSistemaGestionVentas.Clases;

namespace WebApiSistemaGestionVentas.ADO.net
{
    public class VentaHandler
    {
        private SqlConnection conexion;
        private string CadenaConexion = "Server=sql.bsite.net\\MSSQL2016;" +
        "Database=ajomuch92_coderhouse_csharp_40930; " +
        "User Id= ajomuch92_coderhouse_csharp_40930;" +
        "Password=ElQuequit0Sexy2022;";

        public VentaHandler()
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

        public List<Venta> GetVenta()
        {
            List<Venta> listaVentas = new List<Venta>();
            if (CadenaConexion == null)
            {
                throw new Exception("Conexión no realizada");
            }
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Venta", conexion))
                {
                    conexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Venta ventas = new Venta();
                                ventas.Id = reader.GetInt64(0);
                                ventas.Comentarios = reader.GetString(1);
                                ventas.IdUsuario = reader.GetInt32(2);
                                listaVentas.Add(ventas);
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
            return listaVentas;
        }
    }
}
