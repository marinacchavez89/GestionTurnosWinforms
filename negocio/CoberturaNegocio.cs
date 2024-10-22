using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class CoberturaNegocio
    {
        public List<Cobertura> listar()
        {
            List<Cobertura> lista = new List<Cobertura>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(@"SELECT idCobertura, Nombre, PorcentajeCobertura, Activo FROM Cobertura");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Cobertura aux = new Cobertura();
                    aux.IdCobertura = (int)datos.Lector["idCobertura"];
                    aux.Descripcion = (string)datos.Lector["Nombre"];
                    aux.PorcentajeCobertura = (int)datos.Lector["PorcentajeCobertura"];
                    aux.Activo = (bool)datos.Lector["Activo"];

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

        public void agregar(Cobertura cobertura)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT COUNT(*) FROM Cobertura WHERE Nombre = @nombre");
                datos.setearParametro("@nombre", cobertura.Descripcion);

                int cantidad = (int)datos.ejecutarScalar();

                if (cantidad > 0)
                {
                    throw new Exception($"Ya existe una cobertura con nombre '{cobertura.Descripcion}' en la base de datos.");
                }
                else
                {

                    datos.setearConsulta("INSERT INTO Cobertura (Nombre, PorcentajeCobertura, Activo) VALUES (@nombre, @porcentaje, @activo)");
                    datos.setearParametro("@nombre", cobertura.Descripcion);
                    datos.setearParametro("@porcentaje", cobertura.PorcentajeCobertura);
                    datos.setearParametro("@activo", cobertura.Activo);
                    datos.ejecutarAccion();

                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al agregar la cobertura: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("DELETE FROM Cobertura WHERE idCobertura = @id");
                datos.setearParametro("id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificar(Cobertura cobertura)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT COUNT(*) FROM Cobertura WHERE Nombre = @nombre AND idCobertura <> @id");
                datos.setearParametro("@nombre", cobertura.Descripcion);
                datos.setearParametro("@id", cobertura.IdCobertura);
                int cantidad = (int)datos.ejecutarScalar();
                if (cantidad > 0)
                {
                    throw new Exception($"Ya existe una cobertura con la descripción '{cobertura.Descripcion}' en la base de datos.");
                }
                else
                {
                    datos.setearConsulta("UPDATE Cobertura SET Nombre = @nombre, PorcentajeCobertura = @porcentaje, Activo = @activo WHERE idCobertura = @id");
                    datos.setearParametro("@nombre", cobertura.Descripcion);
                    datos.setearParametro("@porcentaje", cobertura.PorcentajeCobertura);
                    datos.setearParametro("@activo", cobertura.Activo);
                    datos.setearParametro("@id", cobertura.IdCobertura);
                    datos.ejecutarAccion();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar la cobertura: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
