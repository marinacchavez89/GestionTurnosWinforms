using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Cobertura
    {
        public int IdCobertura { get; set; }
        public string Descripcion {  get; set; }
        public int PorcentajeCobertura { get; set; }
        public bool Activo { get; set; }
    }
}
