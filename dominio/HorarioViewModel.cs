using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class HorarioViewModel
    {
        [DisplayName("Nombre")]
        public string NombreProfesional { get; set; }
        [DisplayName("Apellido")]
        public string ApellidoProfesional { get; set; }
        public string Especialidad { get; set; }

        [DisplayName("Día de Atención")]
        public string DiaAtencion { get; set; }

        [DisplayName("Hora de Inicio")]
        public TimeSpan HoraInicio { get; set; }

        [DisplayName("Hora de Fin")]
        public TimeSpan HoraFin { get; set; }
    }
}
