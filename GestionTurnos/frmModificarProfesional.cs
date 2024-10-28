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
    public partial class frmModificarProfesional : Form
    {
        private Profesional profesional;
        private List<Especialidad> especialidad;

        public frmModificarProfesional(List<Especialidad> especialidad)
        {
            InitializeComponent();
            this.especialidad = especialidad;
            cargarEspecialidad();            
        }

        public frmModificarProfesional(Profesional profesional, List<Especialidad> especialidad)
        {
            InitializeComponent();
            this.profesional = profesional;
            this.especialidad = especialidad;
            cargarEspecialidad();
            rellenarFormulario(profesional);            

        }

        private void cargarEspecialidad()
        {
            cboEspecialidad.DataSource = especialidad;
            cboEspecialidad.DisplayMember = "Descripcion";
            cboEspecialidad.ValueMember = "IdEspecialidad";
        }

        private void rellenarFormulario(Profesional profesional)
        {
            txtNombre.Text = profesional.DatosPersonales.Nombre;
            txtApellido.Text = profesional.DatosPersonales.Apellido;
            txtDocumento.Text = profesional.Dni.ToString();
            txtEmail.Text = profesional.DatosPersonales.Email;
            txtTelefono.Text = profesional.DatosPersonales.Telefono;
            txtCalle.Text = profesional.DatosPersonales.Direccion.Calle;
            txtCiudad.Text = profesional.DatosPersonales.Direccion.Ciudad.Nombre;
            txtProvincia.Text = profesional.DatosPersonales.Direccion.Ciudad.Provincia.Nombre;
            txtPais.Text = profesional.DatosPersonales.Direccion.Ciudad.Provincia.Pais.Nombre;
            dtpFechaNacimiento.Value = profesional.DatosPersonales.FechaNacimiento;
            cboEspecialidad.Text = profesional.Especialidad.Descripcion;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            ProfesionalNegocio negocioProf = new ProfesionalNegocio();

            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
