using System.Data.SqlClient;
using WebApiSistemaGestionVentas.Clases;

namespace WebApiSistemaGestionVentas.ADO.net
{
    public class UsuarioHandler
    {
        private SqlConnection conexion;
        private string CadenaConexion = "Server=sql.bsite.net\\MSSQL2016;" +
        "Database=ajomuch92_coderhouse_csharp_40930; " +
        "User Id= ajomuch92_coderhouse_csharp_40930;" +
        "Password=ElQuequit0Sexy2022;";

        public UsuarioHandler()
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

        public List<Usuario> GetUsuario()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            if (CadenaConexion == null)
            {
                throw new Exception("Conexión no realizada");
            }
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Usuario", conexion))
                {
                    conexion.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Usuario usuario = new Usuario();
                                usuario.Id = reader.GetInt32(0);
                                usuario.Nombre = reader.GetString(1);
                                usuario.Apellido = reader.GetString(2);
                                usuario.NombreUsuario = reader.GetString(3);
                                usuario.Contraseña = reader.GetString(4);
                                usuario.Mail = reader.GetString(5);
                                listaUsuarios.Add(usuario);
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
            return listaUsuarios;
        }
    }
}
