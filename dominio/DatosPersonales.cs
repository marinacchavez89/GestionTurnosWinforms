using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class DatosPersonales
    {
        public int Dni {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Direccion Direccion { get; set; } = new Direccion();
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
