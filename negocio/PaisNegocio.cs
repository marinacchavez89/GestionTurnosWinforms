using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class PaisNegocio
    {
        public List<Pais> listarPaisPorProvincia(int idProvincia)
        {

            List<Pais> lista = new List<Pais>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                // Consulta para obtener los países según una provincia específica
                datos.setearConsulta("SELECT DISTINCT P.IdPais, P.Nombre FROM Pais P JOIN Provincia Prov ON P.IdPais = Prov.IdPais WHERE Prov.IdProvincia = @IdProvincia");
                datos.setearParametro("@IdProvincia", idProvincia);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    // Crear una nueva instancia de Pais
                    Pais aux = new Pais
                    {
                        IdPais = (int)datos.Lector["IdPais"],
                        Nombre = (string)datos.Lector["Nombre"],
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
