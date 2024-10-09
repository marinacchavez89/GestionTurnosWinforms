using dominio;
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

namespace GestionTurnos
{
    public partial class frmPacientes : Form
    {
        private List<Paciente> listaPaciente;
        public frmPacientes()
        {
            InitializeComponent();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            PacienteNegocio negocio = new PacienteNegocio();
            listaPaciente = negocio.listar();
            dgvPacientes.DataSource = listaPaciente;
            ocultarColumnas();
        }

        private void ocultarColumnas()
        {
            dgvPacientes.Columns["Activo"].Visible = false;
        }
    }
}
