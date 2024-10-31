using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class TurnoViewModel
    {
        public int idTurno { get; set; }
        [DisplayName("Nombre Paciente")]
        public string Nombre_Paciente { get; set; }
        [DisplayName("Apellido Paciente")]
        public string Apellido_Paciente { get; set; }
        [DisplayName("DNI Paciente")]
        public int DniPaciente { get; set; }
        [DisplayName("Nombre Profesional")]
        public string Nombre_Profesional { get; set; }
        [DisplayName("Apellido Profesional")]
        public string Apellido_Profesional { get; set; }
        public int Matricula { get; set; }
        [DisplayName("Fecha Turno")]
        public DateTime FechaTurno { get; set; }
        [DisplayName("Estado Turno")]
        public string DescripcionEstadoTurno { get; set; }
    }
}
