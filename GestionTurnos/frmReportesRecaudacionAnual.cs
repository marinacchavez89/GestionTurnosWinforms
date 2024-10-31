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
    public partial class frmReportesRecaudacionAnual : Form
    {
        public frmReportesRecaudacionAnual()
        {
            InitializeComponent();
        }

        private void btnReporteRecaudacionSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void configurarColumnas()
        {
            dgvRecaudacionAnual.Columns.Clear();

            dgvRecaudacionAnual.Columns.Add("Año", "Año");
            dgvRecaudacionAnual.Columns.Add("Recaudacion", "Recaudacion");
        }

        private void btnReporteRecaudacionBuscar_Click(object sender, EventArgs e)
        {
            int anio;
            decimal recaudacionAnual;

            if (int.TryParse(txtAnio.Text, out anio))
            {
                TurnoNegocio negocio = new TurnoNegocio();
                recaudacionAnual = negocio.recaudacionAnual(anio);
                configurarColumnas();
                dgvRecaudacionAnual.Rows.Clear();

                if (txtAnio != null)
                {

                    dgvRecaudacionAnual.Rows.Add(anio, recaudacionAnual);
                }
                else
                {
                    MessageBox.Show("No hay datos para ese año.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un AÑO válido.");
            }
        }
    }
}
