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
    public partial class frmEspecialidades : Form
    {
        private Especialidad especialidad;
        private List<Especialidad> listaEspecialidad;
        public frmEspecialidades()
        {
            InitializeComponent();
        }        

        private void frmEspecialidades_Load(object sender, EventArgs e)
        {
            try
            {
                EspecialidadNegocio negocio = new EspecialidadNegocio();
                listaEspecialidad = negocio.listar();
                dgvEspecialidades.DataSource = listaEspecialidad;
                ocultarColumnas();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvEspecialidades.Columns["IdEspecialidad"].Visible = false;
        }

        private void btnSalirEspecialidad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarEspecialidad_Click(object sender, EventArgs e)
        {
            EspecialidadNegocio negocio = new EspecialidadNegocio();

            try
            {
                if (string.IsNullOrWhiteSpace(txtAgregarEspecialidad.Text))
                {
                    MessageBox.Show("El campo 'Especialidad' no puede estar vacio", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                especialidad = new Especialidad();
                especialidad.Descripcion = txtAgregarEspecialidad.Text;
                DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea agregar la especialidad?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    negocio.agregar(especialidad);

                    MessageBox.Show("Especialidad agregada exitosamente", "Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargar()
        {
            try
            {
                EspecialidadNegocio negocio = new EspecialidadNegocio();
                listaEspecialidad = negocio.listar();
                dgvEspecialidades.DataSource = listaEspecialidad;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminarEspecialidad_Click(object sender, EventArgs e)
        {
            EspecialidadNegocio negocio = new EspecialidadNegocio();
            Especialidad seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar la especialidad seleccionada de forma permanente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes && dgvEspecialidades.CurrentRow != null)
                {
                    seleccionado = (Especialidad)dgvEspecialidades.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.IdEspecialidad);
                    cargar();
                }

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Debe seleccionar al menos una especialidad para eliminar.", "Especialidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
