using System;
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
            this.WindowState = FormWindowState.Maximized;
        }

        private void administrarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacientes ventana = new frmPacientes();
            ventana.ShowDialog();
        }

        private void administrarProfesionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfesional ventana = new frmProfesional();
            ventana.ShowDialog();
        }

        private void administrarEspecialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEspecialidades ventana = new frmEspecialidades();
            ventana.ShowDialog();
        }

        private void coberturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCobertura ventana = new frmCobertura();
            ventana.ShowDialog();
        }

        private void horariosProfesionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHorariosProfesionales ventana = new frmHorariosProfesionales();
            ventana.ShowDialog();
        }
    }
}
