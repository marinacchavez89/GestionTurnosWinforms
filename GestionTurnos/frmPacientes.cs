using dominio;
using negocio;
using System;
using System.Collections.Generic;
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

            List<PacienteViewModel> listaViewModel = new List<PacienteViewModel>();

            foreach (Paciente paciente in listaPaciente)
            {
                if (paciente.DatosPersonales == null)
                {
                    paciente.DatosPersonales = new DatosPersonales
                    {
                        Nombre = "No especificado",
                        Apellido = "No especificado",
                        FechaNacimiento = DateTime.MinValue,
                        Direccion = new Direccion { Calle = "No especificado" },
                        Email = "No especificado",
                        Telefono = "No especificado"
                    };
                }
                if (paciente.Cobertura == null)
                {
                    paciente.Cobertura = new Cobertura
                    {
                        Descripcion = "Sin Cobertura",
                        PorcentajeCobertura = 0
                    };
                }
                //
                PacienteViewModel viewModel = new PacienteViewModel
                {
                    IdPaciente = paciente.IdPaciente,
                    Dni = paciente.Dni,
                    Nombre = paciente.DatosPersonales.Nombre,
                    Apellido = paciente.DatosPersonales.Apellido,
                    FechaNacimiento = paciente.DatosPersonales.FechaNacimiento,
                    DireccionCalle = paciente.DatosPersonales.Direccion.Calle,
                    Email = paciente.DatosPersonales.Email,
                    Telefono = paciente.DatosPersonales.Telefono,
                    NombreCobertura = paciente.Cobertura.Descripcion,
                    PorcentajeCobertura = paciente.Cobertura.PorcentajeCobertura
                };

                listaViewModel.Add(viewModel);

            }

            dgvPacientes.DataSource = listaViewModel;
            dgvPacientes.Refresh();

            ocultarColumnas();
        }

        private void ocultarColumnas()
        {
            dgvPacientes.Columns["IdPaciente"].Visible = false;
           // dgvPacientes.Columns["Activo"].Visible = false

        }
    }
}
