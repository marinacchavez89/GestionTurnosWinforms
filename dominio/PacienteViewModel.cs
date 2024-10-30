using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [DisplayName("Fecha Nac.")]
        public DateTime FechaNacimiento { get; set; }

        //se agregó edad y tipo para usar en la función de reportes

        public int Edad { get; set; }

        public string TipoPaciente { get; set; }

        [DisplayName("Dirección")]
        public string DireccionCalle { get; set; }
        [DisplayName("Ciudad")]
        public string DireccionCiudad { get; set; }
        [DisplayName("Provincia")]
        public string DireccionProvincia { get; set; }
        [DisplayName("País")]
        public string DireccionPais { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        [DisplayName("Cobertura")]
        public string NombreCobertura { get; set; }

        [DisplayName("Porcentaje")]
        public int PorcentajeCobertura { get; set; }
    }

}
