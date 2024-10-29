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
    public partial class frmHorariosProfesionales : Form
    {
        private List<Profesional> listaProfesional;
        public frmHorariosProfesionales()
        {
            InitializeComponent();
        }       

        private void frmHorariosProfesionales_Load(object sender, EventArgs e)
        {
            ProfesionalNegocio negocio = new ProfesionalNegocio();
            listaProfesional = negocio.listarConHorarios();

            List<HorarioViewModel> listaViewModel = new List<HorarioViewModel>();

            // Crear una lista con los datos que se mostrarán en el DataGridView
            foreach (Profesional profesional in listaProfesional)
            {
                foreach (Horario horario in profesional.Horarios)
                {
                    HorarioViewModel viewModel = new HorarioViewModel
                    {
                        NombreProfesional = profesional.DatosPersonales.Nombre,
                        ApellidoProfesional = profesional.DatosPersonales.Apellido,
                        Especialidad = profesional.Especialidad?.Descripcion ?? "Sin Especialidad",
                        DiaAtencion = horario.NombreDia,
                        HoraInicio = horario.HoraInicio,
                        HoraFin = horario.HoraFin
                    };

                    listaViewModel.Add(viewModel);
                }
            }

            // Asignar la lista de ViewModel al DataGridView
            dgvHorariosProfesionales.DataSource = listaViewModel;
            dgvHorariosProfesionales.Refresh();
        }

        private void btnSalirHorariosProfes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
