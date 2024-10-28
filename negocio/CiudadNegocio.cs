using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class CiudadNegocio
    {
        public List<Ciudad> listarCiudadPorProvincia(int idProvincia)
        {
            List<Ciudad> lista = new List<Ciudad>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                // Consulta para obtener las ciudades de una provincia específica
                datos.setearConsulta("SELECT IdCiudad, Nombre, IdProvincia FROM Ciudad WHERE IdProvincia = @IdProvincia");
                datos.setearParametro("@IdProvincia", idProvincia);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    // Crear una nueva instancia de Ciudad
                    Ciudad aux = new Ciudad
                    {
                        IdCiudad = (int)datos.Lector["IdCiudad"],
                        Nombre = (string)datos.Lector["Nombre"],
                        Provincia = new Provincia { IdProvincia = idProvincia }
                    };

                    lista.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return lista;
        }
    }
}
