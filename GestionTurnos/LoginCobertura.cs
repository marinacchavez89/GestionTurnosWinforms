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
    public partial class LoginCobertura : Form
    {
        public LoginCobertura()
        {
            InitializeComponent();
            txtLegajo.KeyPress += new KeyPressEventHandler(txtLegajo_KeyPress);
        }

        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int legajo;
            if (int.TryParse(txtLegajo.Text, out legajo)) // Validar si la conversión es exitosa
            {
                string password = txtPass.Text;

                AdminSeguridad adminSeguridad = new AdminSeguridad();
                bool loginExitoso = adminSeguridad.VerificarLogin(legajo, password);

                if (loginExitoso)
                {
                    frmCobertura ventana = new frmCobertura();
                    ventana.ShowDialog();
                    this.Close();
                }
                else
                {
                    lblErrorLogin.ForeColor = Color.Red;
                    lblErrorLogin.Text = "Legajo o contraseña incorrectos.";
                }
            }
            else
            {
                lblErrorLogin.ForeColor = Color.Red;
                lblErrorLogin.Text = "Ingrese un número de legajo válido.";
            }
        }
    }
}
