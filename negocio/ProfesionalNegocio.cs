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
                datos.setearConsulta(@"SELECT P.idProfesional, P.Matricula, P.Honorario, E.Nombre AS Especialidad, DP.DNI, DP.Nombre, DP .Apellido, DP.FechaNacimiento, DP.Email, DP.Telefono, D.Calle, CI.Nombre AS Ciudad, PR.Nombre AS Provincia , PA.Nombre AS Pais
                                       FROM Profesional AS P 
                                       INNER JOIN DatosPersonales AS DP ON P.DNI = DP.DNI 
                                       INNER JOIN Especialidad AS E ON P.idEspecialidad = E.idEspecialidad
                                       INNER JOIN Direccion AS D ON DP.idDireccion = D.idDireccion
                                       INNER JOIN Ciudad  CI ON D.idCiudad = CI.idCiudad
                                       INNER JOIN Provincia  PR ON CI.idProvincia = PR.idProvincia
                                       INNER JOIN Pais  PA ON PR.idPais = PA.idPais
                                       WHERE P.Activo = 1");
                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {
                    Profesional aux = new Profesional
                    {
                        IdProfesional = (int)datos.Lector["idProfesional"],
                        Matricula = (int)datos.Lector["Matricula"],
                        Honorario = (decimal)datos.Lector["Honorario"],

                        Especialidad = new Especialidad
                        {
                            Descripcion = (string)datos.Lector["Especialidad"]
                        },

                        Dni = (int)datos.Lector["DNI"],

                        DatosPersonales = new DatosPersonales
                        {
                            Dni = (int)datos.Lector["DNI"],
                            Nombre = (string)datos.Lector["Nombre"],
                            Apellido = (string)datos.Lector["Apellido"],
                            FechaNacimiento = (DateTime)datos.Lector["FechaNacimiento"],
                            Email = (string)datos.Lector["Email"],
                            Telefono = (string)datos.Lector["Telefono"],
                            Direccion = new Direccion
                            {
                                Calle = (string)datos.Lector["Calle"],
                                Ciudad = new Ciudad
                                {
                                    Nombre = (string)datos.Lector["Ciudad"],
                                    Provincia = new Provincia
                                    {
                                        Nombre = (string)datos.Lector["Provincia"],
                                        Pais = new Pais
                                        {
                                            Nombre = (string)datos.Lector["Pais"]
                                        }
                                    }

                                }
                            }
                        }
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

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta(@"DELETE FROM Profesional WHERE idProfesional = @id");
                datos.setearParametro("id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Profesional> listarConHorarios()
        {
            List<Profesional> lista = new List<Profesional>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("ListarHorariosProfesionalesConDatos");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    int matricula = (int)datos.Lector["Matricula"];
                    string nombre = (string)datos.Lector["Nombre"];
                    string apellido = (string)datos.Lector["Apellido"];
                    string especialidadDescripcion = (string)datos.Lector["Especialidad"];
                    byte diaAtencion = (byte)datos.Lector["DiaAtencion"];
                    TimeSpan horaInicio = (TimeSpan)datos.Lector["HoraInicio"];
                    TimeSpan horaFin = (TimeSpan)datos.Lector["HoraFin"];

                    // Buscar si el profesional ya existe en la lista
                    Profesional profesional = lista.FirstOrDefault(p => p.Matricula == matricula);

                    if (profesional == null)
                    {
                        // Si no existe, crear uno nuevo
                        profesional = new Profesional
                        {
                            Matricula = matricula,
                            DatosPersonales = new DatosPersonales
                            {
                                Nombre = nombre,
                                Apellido = apellido,
                            },
                            Especialidad = new Especialidad
                            {
                                Descripcion = especialidadDescripcion,
                            },
                            Horarios = new List<Horario>()
                        };

                        lista.Add(profesional);
                    }

                    // Agregar el horario
                    Horario horario = new Horario
                    {
                        DiaAtencion = diaAtencion,
                        HoraInicio = horaInicio,
                        HoraFin = horaFin
                    };

                    profesional.Horarios.Add(horario);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en listarConHorarios: " + ex.Message);
                //throw;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return lista;
        }
    }
}
