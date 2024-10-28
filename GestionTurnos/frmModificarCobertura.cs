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
    public partial class frmModificarCobertura : Form
    {
        Cobertura seleccionado;

        public frmModificarCobertura(Cobertura seleccionado)
        {
            InitializeComponent();
            this.seleccionado = seleccionado;
        }

        private void frmModificarCobertura_Load(object sender, EventArgs e)
        {
            txtDescripcionCobertura.Text = seleccionado.Descripcion;
            txtPorcentajeCobertura.Text = seleccionado.PorcentajeCobertura.ToString();           
        }

        private void btnSalirCoberturaSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }   

        private void btnModificarCoberturaAceptar_Click(object sender, EventArgs e)
        {
            CoberturaNegocio negocio = new CoberturaNegocio();
            try
            {
                if (string.IsNullOrWhiteSpace(txtDescripcionCobertura.Text))
                {
                    MessageBox.Show("El campo 'Descripción' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(txtPorcentajeCobertura.Text, out int porcentaje) || porcentaje < 0 || porcentaje > 100)
                {
                    MessageBox.Show("El campo 'Porcentaje' debe ser un número entre 0 y 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                seleccionado.Descripcion = txtDescripcionCobertura.Text;
                seleccionado.PorcentajeCobertura = porcentaje;                
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea modificar la cobertura?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    negocio.modificar(seleccionado);
                    MessageBox.Show("Cobertura modificada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
