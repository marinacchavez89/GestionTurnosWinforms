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
            dgvprofesional.DataSource = listaProfesional;
        }
    }
}
