using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using dominio;
using static System.Net.Mime.MediaTypeNames;

namespace negocio
{
    public class PacienteNegocio
    {
        public List<Paciente> listar()
        {
            List<Paciente> lista = new List<Paciente>();
            AccesoDatos datos = new AccesoDatos();
            AccesoDatos datosImagenes = new AccesoDatos();

            try
            {
                datos.setearConsulta(@"SELECT P.idPaciente, DP.Nombre, DP.Apellido, DP.DNI, DP.FechaNacimiento, D.Calle, C.idCobertura
                                       FROM Paciente P
                                       INNER JOIN DatosPersonales DP
                                       ON P.DNI = DP.DNI
                                       INNER JOIN Direccion D
                                       ON DP.idDireccion = D.idDireccion
                                       INNER JOIN Cobertura C
                                       ON C.idCobertura = P.idCobertura
                                       WHERE P.Activo = 1");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Paciente aux = new Paciente();
                    aux.IdPaciente = (int)datos.Lector["idPaciente"];
                    aux.Dni = (int)datos.Lector["DNI"];
                    aux.Cobertura = new Cobertura();
                    aux.Cobertura.IdCobertura = (int)datos.Lector["idCobertura"];
                    

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
