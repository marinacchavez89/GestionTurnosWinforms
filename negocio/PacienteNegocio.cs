using dominio;
using System;
using System.Collections.Generic;

namespace negocio
{
    public class PacienteNegocio
    {
        public List<Paciente> listar()
        {
            List<Paciente> lista = new List<Paciente>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(@"SELECT P.idPaciente, P.DNI, DP.Nombre AS NombrePaciente, DP.Apellido, DP.FechaNacimiento, DP.Email, DP.Telefono, D.Calle, C.Nombre AS Cobertura, C.PorcentajeCobertura
                                       FROM Paciente P
                                       INNER JOIN DatosPersonales DP ON P.DNI = DP.DNI
                                       INNER JOIN Direccion D ON DP.idDireccion = D.idDireccion
                                       INNER JOIN Cobertura C ON P.idCobertura = C.idCobertura
                                       WHERE P.Activo = 1 AND C.Activo = 1");
                datos.ejecutarLectura();
                Console.WriteLine("Nombres de las columnas devueltas:");

                while (datos.Lector.Read())
                {
                    Paciente aux = new Paciente
                    {
                        IdPaciente = (int)datos.Lector["idPaciente"],
                        Dni = (int)datos.Lector["DNI"],

                        Cobertura = new Cobertura
                        {
                            Descripcion = (string)datos.Lector["Cobertura"],
                            PorcentajeCobertura = (int)datos.Lector["PorcentajeCobertura"]
                        },

                        DatosPersonales = new DatosPersonales
                        {
                            Dni = (int)datos.Lector["DNI"],
                            Nombre = (string)datos.Lector["NombrePaciente"],
                            Apellido = (string)datos.Lector["Apellido"],
                            FechaNacimiento = (DateTime)datos.Lector["FechaNacimiento"],
                            Email = (string)datos.Lector["Email"],
                            Telefono = (string)datos.Lector["Telefono"],
                            Direccion = new Direccion
                            {
                                Calle = (string)datos.Lector["Calle"]
                            }
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
