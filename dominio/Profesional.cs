﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Profesional
    {
        public int IdProfesional { get; set; }
        public int Matricula {  get; set; }
        public Especialidad Especialidad { get; set; }
        public float Honorario { get; set; }
        public int Dni { get; set; }
        public bool Activo { get; set; }

    }
}
