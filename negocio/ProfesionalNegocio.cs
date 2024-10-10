using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ProfesionalNegocio
    {
        public List<Profesional> listar()
        {
            List<Profesional> lista = new List<Profesional>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(@"SELECT P.idProfesional, P.Matricula, E.Nombre, P.DNI, DP.Nombre, DP.Apellido, DP.Email, P.Honorario, D.Calle
                                       FROM Profesional AS P 
                                       INNER JOIN DatosPersonales AS DP ON P.DNI = DP.DNI 
                                       INNER JOIN Direccion AS D ON DP.idDireccion = D.idDireccion
                                       INNER JOIN Especialidad AS E ON P.idEspecialidad = E.idEspecialidad
                                       WHERE P.Activo = 1");
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    Profesional aux = new Profesional();
                    aux.IdProfesional = (int)datos.Lector["idProfesional"];
                    aux.Matricula = (int)datos.Lector["Matricula"];
                    aux.Dni = (int)datos.Lector["DNI"];
                    aux.Honorario = (decimal)datos.Lector["Honorario"];

                    aux.Especialidad = new Especialidad();
                    aux.Especialidad.Descripcion = (string)datos.Lector["Nombre"];


                    lista.Add(aux);
                }

            }
            catch ( Exception ex)
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
