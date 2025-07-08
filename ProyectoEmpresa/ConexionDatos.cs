using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        private readonly string cadenaConexion;

        public Conexion()
        {
            // Ajusta el nombre del servidor si es necesario
            cadenaConexion = "Server=.;Database=NominaDB;Trusted_Connection=True;";
        }

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}