using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class AdminSeguridad
    {
        // Método para hashear la contraseña
        public byte[] HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public bool VerificarLogin(int legajo, string password)
        {
            // Hash de la contraseña proporcionada
            byte[] passwordHash = HashPassword(password);
            
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT COUNT(*) FROM UsuarioAdmin WHERE Legajo = @Legajo AND PasswordHash = @PasswordHash");
                datos.setearParametro("@Legajo", legajo);
                datos.setearParametro("@PasswordHash", passwordHash);
                
                int count = Convert.ToInt32(datos.ejecutarScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
