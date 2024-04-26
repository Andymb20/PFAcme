using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace DataAccess.ACME
{
    public class Conexion
    {
        private readonly string? _cadenaConexion;

        public Conexion()
        {
            string? cadenaConexion;
            // obtener cadena de conexion desde variable de entorno 
            cadenaConexion = Environment.GetEnvironmentVariable("SQLServerXE");
            
            _cadenaConexion = cadenaConexion;

        }
        
        public SqlConnection Conectar()
        {
            SqlConnection sqlConn;
            // Instanciar la conexion utilizando la cadena de conexion obtenida
            sqlConn = new SqlConnection(_cadenaConexion);

            return sqlConn;
        }

    }
    
}
