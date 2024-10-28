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
        private List<Provincia> provincias;
        private List<Ciudad> ciudades;
        private List<Pais> paises;

        // Constructor para dar de alta paciente.
        public frmModificarPaciente(List<Cobertura> cobertura, List<Provincia> provincias, List<Ciudad> ciudades)
        {
            InitializeComponent();
            this.cobertura = cobertura;
            this.provincias = provincias;
            this.ciudades = ciudades;
            cargarCoberturas();            
            cargarProvincias();
            
        }

        // Constructor para "modificar" paciente.
        public frmModificarPaciente(Paciente paciente, List<Cobertura> cobertura, List<Provincia> provincias, List<Ciudad> ciudades)
        {
            InitializeComponent();
            this.paciente = paciente;
            this.cobertura = cobertura;
            this.provincias = provincias;
            this.ciudades = ciudades;

            cargarCoberturas();
            cargarProvincias();
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
                if (paciente == null)
                {
                    paciente = new Paciente();
                }

                // Validar los campos necesarios antes de proceder
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtDni.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Asegúrate de que el objeto `DatosPersonales` esté inicializado antes de asignar valores
                if (paciente.DatosPersonales == null)
                {
                    paciente.DatosPersonales = new DatosPersonales();
                }

                // Actualizar los datos del paciente con los valores del formulario
                paciente.DatosPersonales.Nombre = txtNombre.Text;
                paciente.DatosPersonales.Apellido = txtApellido.Text;
                paciente.DatosPersonales.Dni = int.Parse(txtDni.Text);
                paciente.DatosPersonales.Email = txtEmail.Text;
                paciente.DatosPersonales.Telefono = txtTelefono.Text;
                paciente.DatosPersonales.Direccion = new Direccion
                {
                    Calle = txtCalle.Text,
                    Ciudad = new Ciudad
                    {
                        IdCiudad = (int)cboCiudad.SelectedValue,
                        Nombre = cboCiudad.Text,
                        Provincia = new Provincia
                        {
                            IdProvincia = (int)cboProvincia.SelectedValue,
                            Nombre = cboProvincia.Text
                        }
                    }
                };
                paciente.DatosPersonales.FechaNacimiento = dtpFechaNacimiento.Value;

                if (paciente.Cobertura == null)
                {
                    paciente.Cobertura = new Cobertura();
                }

                paciente.Cobertura.IdCobertura = (int)cboCobertura.SelectedValue;
                paciente.Cobertura.Descripcion = cboCobertura.Text;

                // Llamar al método de negocio para guardar o actualizar el paciente
                PacienteNegocio negocio = new PacienteNegocio();
                if (paciente.IdPaciente == 0)
                {
                    negocio.agregar(paciente);                    
                    MessageBox.Show("Paciente agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    negocio.modificar(paciente);                    
                    MessageBox.Show("Paciente modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }                           
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
            // Esto se tiene que editar porque ahora es un desplegable.
            //txtCiudad.Text = paciente.DatosPersonales.Direccion.Ciudad.Nombre;
            //txtProvincia.Text = paciente.DatosPersonales.Direccion.Ciudad.Provincia.Nombre;
            //txtPais.Text = paciente.DatosPersonales.Direccion.Ciudad.Provincia.Pais.Nombre;
            dtpFechaNacimiento.Value = paciente.DatosPersonales.FechaNacimiento;
            cboCobertura.Text = paciente.Cobertura.Descripcion;
        }
        private void cargarCoberturas()
        {
            cboCobertura.DataSource = cobertura;
            cboCobertura.DisplayMember = "Descripcion";
            cboCobertura.ValueMember = "IdCobertura";
        }
        private void cargarProvincias()
        {
            ProvinciaNegocio negocio = new ProvinciaNegocio();
            provincias = negocio.listar(); // Cargar todas las provincias

            // Cargar las provincias en el ComboBox
            cboProvincia.DataSource = provincias;
            cboProvincia.DisplayMember = "Nombre";
            cboProvincia.ValueMember = "IdProvincia";

            // Si es un formulario de modificación, selecciona la provincia del paciente
            if (paciente != null && paciente.DatosPersonales?.Direccion?.Ciudad?.Provincia != null)
            {
                cboProvincia.SelectedValue = paciente.DatosPersonales.Direccion.Ciudad.Provincia.IdProvincia;

                // Cargar las ciudades de la provincia seleccionada
                cargarCiudades((int)cboProvincia.SelectedValue);
            }
            else
            {
                // Si es una nueva alta, selecciona la primera provincia por defecto
                if (cboProvincia.Items.Count > 0)
                {
                    cboProvincia.SelectedIndex = 0;
                }
            }
        }

        private void cargarCiudades(int idProvincia)
        {
            CiudadNegocio ciudadNegocio = new CiudadNegocio();
            var ciudadesFiltradas = ciudadNegocio.listarCiudadPorProvincia(idProvincia);

            if (ciudadesFiltradas != null && ciudadesFiltradas.Count > 0)
            {
                cboCiudad.DataSource = ciudadesFiltradas;
                cboCiudad.DisplayMember = "Nombre";
                cboCiudad.ValueMember = "IdCiudad";
            }
            else
            {
                cboCiudad.DataSource = null;
            }
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvincia.SelectedItem is Provincia provinciaSeleccionada)
            {
                cargarCiudades(provinciaSeleccionada.IdProvincia);
                cargarPaises(provinciaSeleccionada.IdProvincia);
            }
        }

        private void cargarPaises(int idProvincia)
        {
            PaisNegocio paisNegocio = new PaisNegocio();
            var paisesFiltrados = paisNegocio.listarPaisPorProvincia(idProvincia);

            if (paisesFiltrados != null && paisesFiltrados.Count > 0)
            {
                cboPais.DataSource = paisesFiltrados;
                cboPais.DisplayMember = "Nombre";
                cboPais.ValueMember = "IdPais";
            }
            else
            {
                cboPais.DataSource = null;
            }
        }
    }
}
