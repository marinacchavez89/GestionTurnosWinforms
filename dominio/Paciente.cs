﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Paciente
    {
        public int IdPaciente { get; set; }        
        public Cobertura Cobertura { get; set;}
        public int Dni { get; set; }
        public bool Activo { get; set; }
        public DatosPersonales DatosPersonales { get; set; }
    }
}
