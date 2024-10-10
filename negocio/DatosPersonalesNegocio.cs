using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class DatosPersonalesNegocio
    {
        public List<DatosPersonales> listar()
        {
            List<DatosPersonales> lista = new List<DatosPersonales>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(@"SELECT DP.DNI, DP.Nombre, DP.Apellido, DP.FechaNacimiento, DP.Email, DP.Telefono, D.Calle
                               FROM DatosPersonales DP
                               INNER JOIN Direccion D ON DP.idDireccion = D.idDireccion");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    DatosPersonales aux = new DatosPersonales();
                    aux.Dni = (int)datos.Lector["DNI"];                   
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Apellido = (string)datos.Lector["Apellido"];
                    aux.FechaNacimiento = (DateTime)datos.Lector["FechaNacimiento"];
                    aux.Email =(string)datos.Lector["Email"];
                    aux.Telefono= (string)datos.Lector["Telefono"];
                    aux.Direccion = new Direccion();
                    aux.Direccion.Calle = (string)datos.Lector["Calle"];

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
