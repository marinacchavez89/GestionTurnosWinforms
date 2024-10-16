using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class PacienteViewModel
    {
        public int IdPaciente { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string DireccionCalle { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string NombreCobertura { get; set; }  // Cambiado de "Descripcion" a "NombreCobertura"
        public int PorcentajeCobertura { get; set; }
    }

}
