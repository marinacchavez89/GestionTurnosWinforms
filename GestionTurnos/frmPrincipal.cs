﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTurnos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void administrarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacientes ventana = new frmPacientes();
            ventana.ShowDialog();
        }
    }
}
