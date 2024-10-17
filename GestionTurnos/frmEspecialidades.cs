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
    }
}
