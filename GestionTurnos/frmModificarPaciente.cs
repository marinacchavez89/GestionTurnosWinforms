using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTurnos
{
    public partial class frmModificarPaciente : Form
    {
        private Paciente paciente;
        private List<Cobertura> cobertura;

        public frmModificarPaciente(List<Cobertura> cobertura)
        {
            InitializeComponent();
            this.cobertura = cobertura;
            cargarCoberturas();
        }
        public frmModificarPaciente(Paciente paciente, List<Cobertura> cobertura)
        {
            InitializeComponent();
            this.paciente = paciente;
            this.cobertura = cobertura;
            cargarCoberturas();
            rellenarFormulario(paciente);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            try
            {
                // Validar los campos necesarios antes de proceder
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtDni.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Actualizar los datos del paciente con los valores del formulario
                paciente.DatosPersonales.Nombre = txtNombre.Text;
                paciente.DatosPersonales.Apellido = txtApellido.Text;
                paciente.DatosPersonales.Dni = int.Parse(txtDni.Text);
                paciente.DatosPersonales.Email = txtEmail.Text;
                paciente.DatosPersonales.Telefono = txtTelefono.Text;
                paciente.DatosPersonales.Direccion.Calle = txtCalle.Text;
                paciente.DatosPersonales.Direccion.Ciudad.Nombre = txtCiudad.Text;
                paciente.DatosPersonales.Direccion.Ciudad.Provincia.Nombre = txtProvincia.Text;
                paciente.DatosPersonales.Direccion.Ciudad.Provincia.Pais.Nombre = txtPais.Text;
                paciente.DatosPersonales.FechaNacimiento = dtpFechaNacimiento.Value;

                paciente.Cobertura.IdCobertura = (int)cboCobertura.SelectedValue;
                paciente.Cobertura.Descripcion = cboCobertura.Text;

                // Llamar al método de negocio para guardar o actualizar el paciente
                PacienteNegocio negocio = new PacienteNegocio();
                if (paciente.IdPaciente == 0)
                {
                    negocio.agregar(paciente);
                }
                MessageBox.Show("Paciente agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void rellenarFormulario(Paciente paciente)
        {
            txtNombre.Text = paciente.DatosPersonales.Nombre;
            txtApellido.Text = paciente.DatosPersonales.Apellido;
            txtDni.Text = paciente.Dni.ToString();
            txtEmail.Text = paciente.DatosPersonales.Email;
            txtTelefono.Text = paciente.DatosPersonales.Telefono;
            txtCalle.Text = paciente.DatosPersonales.Direccion.Calle;
            txtCiudad.Text = paciente.DatosPersonales.Direccion.Ciudad.Nombre;
            txtProvincia.Text = paciente.DatosPersonales.Direccion.Ciudad.Provincia.Nombre;
            txtPais.Text = paciente.DatosPersonales.Direccion.Ciudad.Provincia.Pais.Nombre;
            dtpFechaNacimiento.Value = paciente.DatosPersonales.FechaNacimiento;
            cboCobertura.Text = paciente.Cobertura.Descripcion;
        }
        private void cargarCoberturas()
        {
            cboCobertura.DataSource = cobertura;
            cboCobertura.DisplayMember = "Descripcion";
            cboCobertura.ValueMember = "IdCobertura";
        }

    }
}
