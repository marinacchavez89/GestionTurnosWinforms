using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ProvinciaNegocio
    {
        public List<Provincia> listar()
        {
            List<Provincia> lista = new List<Provincia>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                // Consulta para obtener las provincias
                datos.setearConsulta("SELECT idProvincia, Nombre, idPais FROM Provincia");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    // Crear una nueva instancia de Provincia
                    Provincia aux = new Provincia();
                    aux.IdProvincia = (int)datos.Lector["idProvincia"];
                    aux.Nombre = (string)datos.Lector["Nombre"];                   

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
