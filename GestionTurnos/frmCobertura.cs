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
using dominio;
namespace GestionTurnos
{
    public partial class frmCobertura : Form
    {
        private Cobertura cobertura;
        private List<Cobertura> listaCobertura;
        public frmCobertura()
        {
            InitializeComponent();
        }

        private void frmCobertura_Load(object sender, EventArgs e)
        {
            try
            {
                CoberturaNegocio negocio = new CoberturaNegocio();
                listaCobertura = negocio.listar();
                dgvCobertura.DataSource = listaCobertura;
                ocultarColumnas();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ocultarColumnas()
        {
            dgvCobertura.Columns["IdCobertura"].Visible = false;
        }

        private void btnSalirCobertura_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCobertura_Click(object sender, EventArgs e)
        {
            CoberturaNegocio negocio = new CoberturaNegocio();

            try
            {
                if (string.IsNullOrWhiteSpace(txtAgregarCobertura.Text)|| string.IsNullOrWhiteSpace(txtAgregarPorcentajeCobertura.Text))
                {
                    MessageBox.Show("El campo 'Cobertura' y 'Porcentaje Cobertura no pueden estar vacios", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cobertura = new Cobertura();
                cobertura.Descripcion = txtAgregarCobertura.Text;
                cobertura.PorcentajeCobertura = int.Parse(txtAgregarPorcentajeCobertura.Text);
                cobertura.Activo = true;
                DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea agregar la Cobertura?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    negocio.agregar(cobertura);

                    MessageBox.Show("Cobertura agregada exitosamente", "Cobertura", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                CoberturaNegocio negocio = new CoberturaNegocio();
                listaCobertura = negocio.listar();
                dgvCobertura.DataSource = listaCobertura;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminarCobertura_Click(object sender, EventArgs e)
        {
            CoberturaNegocio negocio = new CoberturaNegocio();
            Cobertura seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar la especialidad seleccionada de forma permanente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes && dgvCobertura.CurrentRow != null)
                {
                    seleccionado = (Cobertura)dgvCobertura.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.IdCobertura);
                    cargar();
                }

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Debe seleccionar al menos una Cobertura para eliminar.", "Cobertura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificarCobertura_Click(object sender, EventArgs e)
        {
            Cobertura seleccionado;
            if (dgvCobertura.CurrentRow != null)
            {
                seleccionado = (Cobertura)dgvCobertura.CurrentRow.DataBoundItem;
                frmModificarCobertura modificar = new frmModificarCobertura(seleccionado);
                modificar.ShowDialog();
                cargar();
            }
            else
            {
                MessageBox.Show("Seleccione una Cobertura haciendo clic en una fila de la tabla.", "Cobertura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
