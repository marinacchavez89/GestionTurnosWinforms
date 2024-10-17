using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace negocio
{
    public class EspecialidadNegocio
    {
        public List<Especialidad> listar()
        {
            List<Especialidad> lista = new List<Especialidad>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(@"SELECT idEspecialidad, Nombre FROM Especialidad");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Especialidad aux = new Especialidad();
                    aux.IdEspecialidad = (int)datos.Lector["idEspecialidad"];
                    aux.Descripcion = (string)datos.Lector["Nombre"];

                    lista.Add(aux);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer los datos: " + ex.Message);
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return lista;
        }

        public void agregar(Especialidad especialidad)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT COUNT(*) FROM Especialidad WHERE Nombre = @nombre");
                datos.setearParametro("@nombre", especialidad.Descripcion);

                int cantidad = (int)datos.ejecutarScalar();

                if (cantidad > 0)
                {
                    throw new Exception($"Ya existe una especialidad con nombre '{especialidad.Descripcion}' en la base de datos.");
                }
                else
                {
                    datos.setearConsulta("INSERT INTO Especialidad (Nombre) VALUES(@nombre)");
                    datos.setearParametro("@nombre", especialidad.Descripcion);
                    datos.ejecutarAccion();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al agregar la especialidad: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
