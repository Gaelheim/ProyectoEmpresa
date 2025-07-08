using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class UsuarioDatos
    {
        private readonly Conexion conexion;

        public UsuarioDatos()
        {
            conexion = new Conexion();
        }

        public bool ValidarUsuario(string usuario, string clave, out string rol)
        {
            rol = string.Empty;
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = "SELECT Rol FROM Usuarios WHERE Usuario = @Usuario AND Clave = @Clave";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Clave", clave);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    rol = reader["Rol"].ToString();
                    return true;
                }

                return false;
            }
        }

        public bool CrearUsuario(string usuario, string clave, string rol)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = "INSERT INTO Usuarios (Usuario, Clave, Rol) VALUES (@Usuario, @Clave, @Rol)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Clave", clave);
                cmd.Parameters.AddWithValue("@Rol", rol);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}