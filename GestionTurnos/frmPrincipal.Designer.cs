﻿namespace GestionTurnos
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administrarPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarProfesionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarEspecialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarPacientesToolStripMenuItem,
            this.administrarProfesionalesToolStripMenuItem,
            this.administrarEspecialidadesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administrarPacientesToolStripMenuItem
            // 
            this.administrarPacientesToolStripMenuItem.Name = "administrarPacientesToolStripMenuItem";
            this.administrarPacientesToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.administrarPacientesToolStripMenuItem.Text = "Administrar Pacientes";
            this.administrarPacientesToolStripMenuItem.Click += new System.EventHandler(this.administrarPacientesToolStripMenuItem_Click);
            // 
            // administrarProfesionalesToolStripMenuItem
            // 
            this.administrarProfesionalesToolStripMenuItem.Name = "administrarProfesionalesToolStripMenuItem";
            this.administrarProfesionalesToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.administrarProfesionalesToolStripMenuItem.Text = "Administrar Profesionales";
            this.administrarProfesionalesToolStripMenuItem.Click += new System.EventHandler(this.administrarProfesionalesToolStripMenuItem_Click);
            // 
            // administrarEspecialidadesToolStripMenuItem
            // 
            this.administrarEspecialidadesToolStripMenuItem.Name = "administrarEspecialidadesToolStripMenuItem";
            this.administrarEspecialidadesToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
            this.administrarEspecialidadesToolStripMenuItem.Text = "Administrar Especialidades";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Turnos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administrarPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarProfesionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarEspecialidadesToolStripMenuItem;
    }
}