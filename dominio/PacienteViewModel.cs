﻿using System;
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

        [DisplayName("Dirección")]
        public string DireccionCalle { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        [DisplayName("Cobertura")]
        public string NombreCobertura { get; set; }

        [DisplayName("Porcentaje")]
        public int PorcentajeCobertura { get; set; }
    }

}
