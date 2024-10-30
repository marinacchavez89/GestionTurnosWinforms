using negocio;
using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace GestionTurnos
{
    public partial class frmReportesPacientes : Form
    {
        public frmReportesPacientes()
        {
            InitializeComponent();
        }

        private void ConfigurarColumnas()
        {
            dgvReportePacientes.Columns.Clear(); // Limpia todas las columnas para evitar duplicación.

            dgvReportePacientes.Columns.Add("Nombre", "Nombre");
            dgvReportePacientes.Columns.Add("Apellido", "Apellido");
            dgvReportePacientes.Columns.Add("Edad", "Edad");
            dgvReportePacientes.Columns.Add("TipoPaciente", "Tipo de Paciente");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int dni;

            if(int.TryParse(txtDNI.Text, out dni))
            {
                PacienteNegocio negocio = new PacienteNegocio();
                PacienteViewModel paciente = negocio.ObtenerPacientePorDni(dni);
                ConfigurarColumnas();
                dgvReportePacientes.Rows.Clear();

                if (paciente != null)
                {
                    
                    dgvReportePacientes.Rows.Add(paciente.Nombre, paciente.Apellido, paciente.Edad, paciente.TipoPaciente);
                }
                else
                {
                    MessageBox.Show("Paciente no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un DNI válido.");
            }
        }

        private void frmReportesPacientes_Load(object sender, EventArgs e)
        {
            ConfigurarColumnas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {

            try
            {
                PacienteNegocio negocio = new PacienteNegocio();                
                List<PacienteViewModel> listaPacientes = negocio.ObtenerPacientes();
              
                dgvReportePacientes.Rows.Clear();

                foreach (var paciente in listaPacientes)
                {
                    dgvReportePacientes.Rows.Add(paciente.Nombre, paciente.Apellido, paciente.Edad, paciente.TipoPaciente);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los pacientes: " + ex.Message);
            }

        }
    }
}
