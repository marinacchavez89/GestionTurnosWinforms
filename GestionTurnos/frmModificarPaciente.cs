﻿using dominio;
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

        public frmModificarPaciente()
        {
            InitializeComponent();
        }
        public frmModificarPaciente(Paciente paciente, List<Cobertura> cobertura)
        {
            InitializeComponent();
            this.cobertura = cobertura;
            cargarCoberturas();
            rellenarFormulario(paciente);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            paciente = new Paciente
            {
                IdPaciente = paciente.IdPaciente,
                Dni = paciente.Dni,
                DatosPersonales = new DatosPersonales
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Dni = int.Parse(txtDni.Text),
                    Email = txtEmail.Text,
                    Telefono = txtTelefono.Text,
                    Direccion = new Direccion
                    {
                        Calle = txtCalle.Text,
                        Ciudad = new Ciudad { Nombre = txtCiudad.Text }
                    }
                },
                Cobertura = new Cobertura
                {
                    IdCobertura = (int)cboCobertura.SelectedValue,
                    Descripcion = cboCobertura.SelectedValue.ToString(),
                }
            };
        }
        private void rellenarFormulario(Paciente paciente)
        {
            txtNombre.Text = paciente.DatosPersonales.Nombre;
            txtApellido.Text = paciente.DatosPersonales.Apellido;
            txtDni.Text = paciente.Dni.ToString();
            txtEmail.Text = paciente.DatosPersonales.Email;
            txtTelefono.Text = paciente.DatosPersonales.Telefono;
            txtCalle.Text = paciente.DatosPersonales.Direccion.Calle;
            txtCiudad.Text = paciente.DatosPersonales.Direccion.Ciudad.Nombre;
            txtProvincia.Text = paciente.DatosPersonales.Direccion.Ciudad.Provincia.Nombre;
            txtPais.Text = paciente.DatosPersonales.Direccion.Ciudad.Provincia.Pais.Nombre;
            dtpFechaNacimiento.Value = paciente.DatosPersonales.FechaNacimiento;
            cboCobertura.Text = paciente.Cobertura.Descripcion;
        }
        private void cargarCoberturas()
        {
            cboCobertura.DataSource = cobertura;
            cboCobertura.DisplayMember = "Descripcion";
            cboCobertura.ValueMember = "IdCobertura";
        }

    }
}
