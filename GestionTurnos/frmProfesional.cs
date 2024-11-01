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
using negocio;

namespace GestionTurnos
{
    public partial class frmProfesional : Form
    {
        private List<Profesional> listaProfesional;
        private List<Especialidad> listaEspecialidad;
        public frmProfesional()
        {
            InitializeComponent();
        }

        private void frmProfesional_Load(object sender, EventArgs e)
        {
            ProfesionalNegocio negocio = new ProfesionalNegocio();
            listaProfesional = negocio.listar();
            EspecialidadNegocio especialidadNegocio = new EspecialidadNegocio();
            listaEspecialidad = especialidadNegocio.listar();

            List<ProfesionalViewModel> listaViewModel = new List<ProfesionalViewModel>();

            foreach (Profesional profesional in listaProfesional)
            {
                if (profesional.DatosPersonales == null)
                {
                    profesional.DatosPersonales = new DatosPersonales
                    {
                        Nombre = "No especificado",
                        Apellido = "No especificado",
                        FechaNacimiento = DateTime.MinValue,
                        Direccion = new Direccion { Calle = "No especificado" },
                        Email = "No especificado",
                        Telefono = "No especificado"
                    };
                }
                if (profesional.Especialidad == null)
                {
                    profesional.Especialidad = new Especialidad
                    {
                        Descripcion = "Sin Especialidad"
                    };
                }

                ProfesionalViewModel viewModel = new ProfesionalViewModel
                {
                    IdProfesional = profesional.IdProfesional,
                    Matricula = profesional.Matricula,
                    Descripcion = profesional.Especialidad.Descripcion,
                    Honorario = profesional.Honorario,
                    Dni = profesional.Dni,
                    Nombre = profesional.DatosPersonales.Nombre,
                    Apellido = profesional.DatosPersonales.Apellido,
                    FechaNacimiento = profesional.DatosPersonales.FechaNacimiento,
                    DireccionCalle = profesional.DatosPersonales.Direccion.Calle,
                    DireccionCiudad = profesional.DatosPersonales.Direccion.Ciudad.Nombre,
                    DireccionProvincia = profesional.DatosPersonales.Direccion.Ciudad.Provincia.Nombre,
                    DireccionPais = profesional.DatosPersonales.Direccion.Ciudad.Provincia.Pais.Nombre,
                    Email = profesional.DatosPersonales.Email,
                    Telefono = profesional.DatosPersonales.Telefono
                };

                listaViewModel.Add(viewModel);

            }

            dgvProfesional.DataSource = listaViewModel;
            dgvProfesional.Refresh();

            ocultarColumnas();
        }

        private void ocultarColumnas()
        {
            dgvProfesional.Columns["IdProfesional"].Visible = false;
        }

        private void btnAgregarProfesional_Click(object sender, EventArgs e)
        {
            frmModificarProfesional ventana = new frmModificarProfesional(listaEspecialidad);
            ventana.ShowDialog();
        }

        private void btnSalirProfesional_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarProfesional ventana = new frmModificarProfesional(listaEspecialidad);
            ventana.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProfesional.SelectedRows.Count > 0)
            {
                var seleccionado = (ProfesionalViewModel)dgvProfesional.SelectedRows[0].DataBoundItem;
                int matricula = seleccionado.Matricula;

                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este profesional?", "Confirmación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    ProfesionalNegocio negocio = new ProfesionalNegocio();
                    try
                    {
                        negocio.eliminarProfesional(matricula);
                        MessageBox.Show("Profesional eliminado con éxito.");
                        
                        frmProfesional_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar profesional: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un profesional para eliminar.");
            }
        }
    }
}
