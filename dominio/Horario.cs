using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Horario
    {
        public byte DiaAtencion { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }

        public string NombreDia
        {
            get
            {
                switch (DiaAtencion)
                {
                    case 1: return "Lunes";
                    case 2: return "Martes";
                    case 3: return "Miércoles";
                    case 4: return "Jueves";
                    case 5: return "Viernes";
                    case 6: return "Sábado";
                    case 7: return "Domingo";
                    default: return "Día no válido";
                }
            }
        }
    }
}
