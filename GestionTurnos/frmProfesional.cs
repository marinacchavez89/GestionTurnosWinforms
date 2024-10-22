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
        public frmProfesional()
        {
            InitializeComponent();
        }

        private void frmProfesional_Load(object sender, EventArgs e)
        {
            ProfesionalNegocio negocio = new ProfesionalNegocio();
            listaProfesional = negocio.listar();

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
                    Especialidad = profesional.Especialidad.Descripcion,
                    Honorario = profesional.Honorario,
                    Dni = profesional.Dni,
                    Nombre = profesional.DatosPersonales.Nombre,
                    Apellido = profesional.DatosPersonales.Apellido,
                    FechaNacimiento = profesional.DatosPersonales.FechaNacimiento,
                    DireccionCalle = profesional.DatosPersonales.Direccion.Calle,
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
            frmModificarProfesional ventana = new frmModificarProfesional();
            ventana.ShowDialog();
        }

        private void btnSalirProfesional_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
