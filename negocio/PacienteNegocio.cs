using dominio;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

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
                datos.setearConsulta(@"SELECT P.idPaciente, P.DNI, DP.Nombre AS NombrePaciente, DP.Apellido, DP.FechaNacimiento, DP.Email, DP.Telefono, 
                                              D.Calle, C.Nombre AS Cobertura, C.PorcentajeCobertura, 
                                              CI.Nombre AS Ciudad, PR.Nombre AS Provincia, PA.Nombre AS Pais
                                       FROM Paciente P
                                       INNER JOIN DatosPersonales DP ON P.DNI = DP.DNI
                                       INNER JOIN Direccion D ON DP.idDireccion = D.idDireccion
                                       INNER JOIN Ciudad CI ON D.idCiudad = CI.idCiudad
                                       INNER JOIN Provincia PR ON CI.idProvincia = PR.idProvincia
                                       INNER JOIN Pais PA ON PR.idPais = PA.idPais
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
                Console.WriteLine("Error al leer los datos: " + ex.Message);
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return lista;
        }
        public void agregar(Paciente paciente)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // validacion de datos obligatorios completos
                if (string.IsNullOrWhiteSpace(paciente.DatosPersonales.Nombre) ||
                    string.IsNullOrWhiteSpace(paciente.DatosPersonales.Apellido) ||
                    string.IsNullOrWhiteSpace(paciente.DatosPersonales.Email) ||
                    string.IsNullOrWhiteSpace(paciente.DatosPersonales.Telefono) ||
                    string.IsNullOrWhiteSpace(paciente.DatosPersonales.Direccion.Calle))
                {
                    throw new Exception("Los campos Nombre, Apellido, Email, Teléfono y Calle no pueden estar vacíos.");
                }
                // se inserta la direccion si no existe (podemos usar un metodo para obtenerla si ya existe(muy poco probable))
                datos.setearConsulta("INSERT INTO Direccion (Calle, idCiudad) OUTPUT INSERTED.idDireccion " +
                                     "VALUES (@calle, @idCiudad)");
                datos.setearParametro("@calle", paciente.DatosPersonales.Direccion.Calle);
                datos.setearParametro("@idCiudad", paciente.DatosPersonales.Direccion.Ciudad.IdCiudad);

                paciente.DatosPersonales.Direccion.IdDireccion = (int)datos.ejecutarScalar();

                // se insertan los datos personales
                datos.setearConsulta("INSERT INTO DatosPersonales (DNI, Nombre, Apellido, FechaNacimiento, Email, Telefono, idDireccion) " +
                                     "VALUES (@dni, @nombre, @apellido, @fechaNacimiento, @email, @telefono, @idDireccion)");
                datos.setearParametro("@dni", paciente.DatosPersonales.Dni);
                datos.setearParametro("@nombre", paciente.DatosPersonales.Nombre);
                datos.setearParametro("@apellido", paciente.DatosPersonales.Apellido);
                datos.setearParametro("@fechaNacimiento", paciente.DatosPersonales.FechaNacimiento);
                datos.setearParametro("@email", paciente.DatosPersonales.Email);
                datos.setearParametro("@telefono", paciente.DatosPersonales.Telefono);
                datos.setearParametro("@idDireccion", paciente.DatosPersonales.Direccion.IdDireccion);

                datos.ejecutarAccion();

                // se inserta al paciente
                datos.setearConsulta("INSERT INTO Paciente (DNI, idCobertura, Activo) VALUES (@dni, @idCobertura, 1)");
                datos.setearParametro("@dni", paciente.Dni);
                datos.setearParametro("@idCobertura", paciente.Cobertura.IdCobertura);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el paciente: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void modificar(Paciente paciente)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                  validarDatosPaciente(paciente);


                // actualiamos la direccion
                datos.setearConsulta("UPDATE Direccion SET" +
                    " Calle = @calle, idCiudad = @idCiudad WHERE idDireccion = @idDireccion");
                datos.setearParametro("@calle", paciente.DatosPersonales.Direccion.Calle);
                datos.setearParametro("@idCiudad", paciente.DatosPersonales.Direccion.Ciudad);
                datos.setearParametro("@idDireccion", paciente.DatosPersonales.Direccion.IdDireccion);

                datos.ejecutarAccion();

                datos.setearConsulta("UPDATE DatosPersonales SET" +
                    " Nombre = @nombre, Apellido = @apellido, FechaNacimiento = @fechaNacimiento, Email = @email, Telefono = @telefono" +
                    " WHERE DNI = @dni");
                datos.setearParametro("@nombre", paciente.DatosPersonales.Nombre);
                datos.setearParametro("@apellido", paciente.DatosPersonales.Apellido);
                datos.setearParametro("@fechaNacimiento", paciente.DatosPersonales.FechaNacimiento);
                datos.setearParametro("@email", paciente.DatosPersonales.Email);
                datos.setearParametro("@telefono", paciente.DatosPersonales.Telefono);
                datos.setearParametro("@dni", paciente.DatosPersonales.Dni);

                datos.ejecutarAccion();

                datos.setearConsulta("UPDATE Paciente SET" +
                    " idCobertura = @idCobertura WHERE DNI = @dni");
                datos.setearParametro("@idCobertura", paciente.Cobertura.IdCobertura);
                datos.setearParametro("@IdPaciente", paciente.IdPaciente);

                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        private void validarDatosPaciente(Paciente paciente)
        {
            if (string.IsNullOrWhiteSpace(paciente.DatosPersonales.Nombre) ||
                string.IsNullOrWhiteSpace(paciente.DatosPersonales.Apellido) ||
                string.IsNullOrWhiteSpace(paciente.DatosPersonales.Email) ||
                string.IsNullOrWhiteSpace(paciente.DatosPersonales.Telefono) ||
                string.IsNullOrWhiteSpace(paciente.DatosPersonales.Direccion.Calle))
            {
                throw new Exception("Los campos Nombre, Apellido, Email, Teléfono y Calle no pueden estar vacíos.");
            }
        }
       
    } }
