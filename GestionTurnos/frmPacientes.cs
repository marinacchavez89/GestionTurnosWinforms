using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
namespace GestionTurnos
{
    public partial class frmPacientes : Form
    {
        private List<Paciente> listaPaciente;
        private List<Cobertura> listaCobertura;
        private List<Provincia> listaProvincias;
        private List<Ciudad> listaCiudades;

        public frmPacientes()
        {
            InitializeComponent();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            CargarPacientes(); // Carga la lista de pacientes al iniciar el formulario

            CoberturaNegocio coberturaNegocio = new CoberturaNegocio();
            listaCobertura = coberturaNegocio.listar();
        }

        private void ocultarColumnas()
        {
            dgvPacientes.Columns["IdPaciente"].Visible = false;           
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            frmModificarPaciente ventana = new frmModificarPaciente(listaCobertura, listaProvincias, listaCiudades);
            ventana.ShowDialog();
            CargarPacientes();
        }

        private void btnModificarPaciente_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                Paciente pacienteSeleccionado = new Paciente
                {
                    IdPaciente = (int)dgvPacientes.SelectedRows[0].Cells["IdPaciente"].Value,
                    Dni = (int)dgvPacientes.SelectedRows[0].Cells["Dni"].Value,
                    DatosPersonales = new DatosPersonales
                    {
                        Nombre = dgvPacientes.SelectedRows[0].Cells["Nombre"].Value.ToString(),
                        Apellido = dgvPacientes.SelectedRows[0].Cells["Apellido"].Value.ToString(),
                        FechaNacimiento = (DateTime)dgvPacientes.SelectedRows[0].Cells["FechaNacimiento"].Value,
                        Email = dgvPacientes.SelectedRows[0].Cells["Email"].Value.ToString(),
                        Telefono = dgvPacientes.SelectedRows[0].Cells["Telefono"].Value.ToString(),
                        Direccion = new Direccion
                        {
                            Calle = dgvPacientes.SelectedRows[0].Cells["DireccionCalle"].Value.ToString(),
                            Ciudad = new Ciudad
                            {
                                Nombre = dgvPacientes.SelectedRows[0].Cells["DireccionCiudad"].Value.ToString(),
                                Provincia = new Provincia
                                {
                                    Nombre = dgvPacientes.SelectedRows[0].Cells["DireccionProvincia"].Value.ToString(),
                                    Pais = new Pais
                                    {
                                        Nombre = dgvPacientes.SelectedRows[0].Cells["DireccionPais"].Value.ToString()
                                    }
                                }
                            }
                        }
                    },
                    Cobertura = new Cobertura
                        {
                            Descripcion = dgvPacientes.SelectedRows[0].Cells["NombreCobertura"].Value.ToString(),
                        }
                };

                frmModificarPaciente ventana = new frmModificarPaciente(pacienteSeleccionado, listaCobertura, listaProvincias, listaCiudades);
                ventana.ShowDialog();
                //actualizar la lista de pacientes luego de que se modifique uno
            }
            else
            {
                MessageBox.Show("Debe seleccionar un paciente de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalirPaciente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarPacientes()
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

                PacienteViewModel viewModel = new PacienteViewModel
                {
                    IdPaciente = paciente.IdPaciente,
                    Dni = paciente.Dni,
                    Nombre = paciente.DatosPersonales.Nombre,
                    Apellido = paciente.DatosPersonales.Apellido,
                    FechaNacimiento = paciente.DatosPersonales.FechaNacimiento,
                    DireccionCalle = paciente.DatosPersonales.Direccion.Calle,
                    DireccionCiudad = paciente.DatosPersonales.Direccion.Ciudad.Nombre,
                    DireccionProvincia = paciente.DatosPersonales.Direccion.Ciudad.Provincia.Nombre,
                    DireccionPais = paciente.DatosPersonales.Direccion.Ciudad.Provincia.Pais.Nombre,
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
    }
}
