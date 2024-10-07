using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Turno
    {
        public int IdTurno { get; set; }
        public Profesional Profesional { get; set; }
        public Paciente Paciente { get; set; }
        public DateTime FechaTurno { get; set; }
        public EstadoTurno EstadoTurno { get; set; }
        public float HonorarioConsulta { get; set; }

    }
}
