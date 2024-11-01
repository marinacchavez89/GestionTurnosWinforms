using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using System.IO;

namespace GestionTurnos
{
    public partial class frmPrincipal : Form
    {
        private List<Turno> listaTurno;
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
            LoginCobertura ventana = new LoginCobertura();
            ventana.ShowDialog();
            //frmCobertura ventana = new frmCobertura();
            //ventana.ShowDialog();
        }

        private void horariosProfesionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHorariosProfesionales ventana = new frmHorariosProfesionales();
            ventana.ShowDialog();
        }

        private void pacientesPorEdadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportesPacientes ventana = new frmReportesPacientes();
            ventana.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(Application.StartupPath, "Resources", "portada.png");
            pbxPortada.Load(imagePath);

            TurnoNegocio negocio = new TurnoNegocio();
            listaTurno = negocio.listar();

            List<TurnoViewModel> listaViewModel = new List<TurnoViewModel>();

            foreach (Turno turno in listaTurno)
            {
                if(turno.Profesional.DatosPersonales == null)
                {
                    turno.Profesional.DatosPersonales = new DatosPersonales();
                    {
                        turno.Profesional.DatosPersonales.Nombre = "No especificado";
                        turno.Profesional.DatosPersonales.Apellido = "No especificado";
                        turno.Profesional.Matricula = -1;                        
                    }
                }

                if (turno.Paciente.DatosPersonales == null)
                {
                    turno.Paciente.DatosPersonales = new DatosPersonales();
                    {
                        turno.Paciente.DatosPersonales.Nombre = "No especificado";
                        turno.Paciente.DatosPersonales.Apellido = "No especificado";
                    }
                }

                if(turno.FechaTurno == null)
                {
                    turno.FechaTurno = DateTime.MinValue;
                }

                TurnoViewModel viewModel = new TurnoViewModel()
                {
                    idTurno = turno.IdTurno,
                    Nombre_Paciente = turno.Paciente.DatosPersonales.Nombre,
                    Apellido_Paciente = turno.Paciente.DatosPersonales.Apellido,
                    DniPaciente = turno.Paciente.DatosPersonales.Dni,
                    Apellido_Profesional = turno.Profesional.DatosPersonales.Apellido,
                    Nombre_Profesional = turno.Profesional.DatosPersonales.Nombre,
                    Matricula = turno.Profesional.Matricula,
                    FechaTurno = turno.FechaTurno,
                    DescripcionEstadoTurno = turno.EstadoTurno.Descripcion,
                    //DescripcionEstadoTurno = turno.EstadoTurno.Descripcion,
                };

                listaViewModel.Add(viewModel);
            }
            dgvTurnos.DataSource = listaViewModel;
            dgvTurnos.Refresh();
            ocultarColumnas();
        }

        public void ocultarColumnas()
        {
            dgvTurnos.Columns["idTurno"].Visible = false;
        }

        private void recaudacionAnualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportesRecaudacionAnual ventana = new frmReportesRecaudacionAnual();
            ventana.ShowDialog();
        }
    }
}
