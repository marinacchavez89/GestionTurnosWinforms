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
    public partial class frmModificarEspecialidad : Form
    {
        Especialidad seleccionado;
        public frmModificarEspecialidad(Especialidad seleccionado)
        {
            InitializeComponent();
            this.seleccionado = seleccionado;
        }

        private void frmModificarEspecialidad_Load(object sender, EventArgs e)
        {
            txtDescripcionEspecialidad.Text = seleccionado.Descripcion;
        }

        private void btnModificarEspecialidadSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificarEspecialidadAceptar_Click(object sender, EventArgs e)
        {
            EspecialidadNegocio negocio = new EspecialidadNegocio();

            try
            {
                if (string.IsNullOrWhiteSpace(txtDescripcionEspecialidad.Text))
                {
                    MessageBox.Show("El campo 'Descripción' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                seleccionado.Descripcion = txtDescripcionEspecialidad.Text;

                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea modificar la especialidad?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    negocio.modificar(seleccionado);
                    MessageBox.Show("Especialidad modificada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
