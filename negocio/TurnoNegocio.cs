using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class TurnoNegocio
    {
        public List<Turno> listar()
        {
            List<Turno> lista = new List<Turno>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(@"SELECT 
                                       DP_Paciente.Nombre AS Nombre_Paciente, 
                                       DP_Paciente.Apellido AS Paciente_Apellido,
	                                   P.DNI,
                                       T.FechaTurno,
                                       T.Matricula,
	                                   T.idTurno,
                                       DP_Profesional.Apellido AS Apellido_Profesional, 
                                       DP_Profesional.Nombre AS Nombre_Profesional,
	                                   ET.Descripcion
                                       FROM Turno T
                                       INNER JOIN Profesional P ON T.Matricula = P.Matricula
                                       INNER JOIN DatosPersonales DP_Profesional ON P.DNI = DP_Profesional.DNI
                                       INNER JOIN Especialidad E ON E.idEspecialidad = P.idEspecialidad
                                       INNER JOIN Paciente Pac ON Pac.idPaciente = T.idPaciente
                                       INNER JOIN DatosPersonales DP_Paciente ON Pac.DNI = DP_Paciente.DNI
                                       INNER JOIN EstadoTurno ET ON ET.idEstadoTurno = T.idEstadoTurno;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Turno aux = new Turno
                    {
                        FechaTurno = (DateTime)datos.Lector["FechaTurno"],
                        IdTurno = (int)datos.Lector["idTurno"],

                        Profesional = new Profesional
                        {
                            Matricula = (int)datos.Lector["Matricula"],
                            DatosPersonales = new DatosPersonales
                            {
                                Nombre = (string)datos.Lector["Nombre_Profesional"],
                                Apellido = (string)datos.Lector["Apellido_Profesional"],
                            }
                        },

                        Paciente = new Paciente
                        {
                            DatosPersonales = new DatosPersonales
                            {
                                Nombre = (string)datos.Lector["Nombre_Paciente"],
                                Apellido = (string)datos.Lector["Paciente_Apellido"],
                                Dni = (int)datos.Lector["DNI"],
                            }
                        },

                        EstadoTurno = new EstadoTurno
                        {
                            Descripcion = (string)datos.Lector["Descripcion"],
                        }
                    };

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
    }
}
