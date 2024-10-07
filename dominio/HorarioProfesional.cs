using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class HorarioProfesional
    {   
        public Profesional Profesional { get; set; }
        public Consultorio Consultorio { get; set; }
        public int DiaAtencion {  get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin {get; set; }
    }
}
