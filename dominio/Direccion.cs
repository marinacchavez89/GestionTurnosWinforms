﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Direccion
    {
        public int IdDireccion {  get; set; }
        public string Calle {  get; set; }
        public Ciudad Ciudad { get; set; }
    }
}
