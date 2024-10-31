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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administrarPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarProfesionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horariosProfesionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarEspecialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesPorEdadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coberturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarPacientesToolStripMenuItem,
            this.administrarProfesionalesToolStripMenuItem,
            this.horariosProfesionalesToolStripMenuItem,
            this.administrarEspecialidadesToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.coberturasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(989, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administrarPacientesToolStripMenuItem
            // 
            this.administrarPacientesToolStripMenuItem.Name = "administrarPacientesToolStripMenuItem";
            this.administrarPacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.administrarPacientesToolStripMenuItem.Text = "Pacientes";
            this.administrarPacientesToolStripMenuItem.Click += new System.EventHandler(this.administrarPacientesToolStripMenuItem_Click);
            // 
            // administrarProfesionalesToolStripMenuItem
            // 
            this.administrarProfesionalesToolStripMenuItem.Name = "administrarProfesionalesToolStripMenuItem";
            this.administrarProfesionalesToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.administrarProfesionalesToolStripMenuItem.Text = "Profesionales";
            this.administrarProfesionalesToolStripMenuItem.Click += new System.EventHandler(this.administrarProfesionalesToolStripMenuItem_Click);
            // 
            // horariosProfesionalesToolStripMenuItem
            // 
            this.horariosProfesionalesToolStripMenuItem.Name = "horariosProfesionalesToolStripMenuItem";
            this.horariosProfesionalesToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.horariosProfesionalesToolStripMenuItem.Text = "Horarios Profesionales";
            this.horariosProfesionalesToolStripMenuItem.Click += new System.EventHandler(this.horariosProfesionalesToolStripMenuItem_Click);
            // 
            // administrarEspecialidadesToolStripMenuItem
            // 
            this.administrarEspecialidadesToolStripMenuItem.Name = "administrarEspecialidadesToolStripMenuItem";
            this.administrarEspecialidadesToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administrarEspecialidadesToolStripMenuItem.Text = "Especialidades";
            this.administrarEspecialidadesToolStripMenuItem.Click += new System.EventHandler(this.administrarEspecialidadesToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesPorEdadToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // pacientesPorEdadToolStripMenuItem
            // 
            this.pacientesPorEdadToolStripMenuItem.Name = "pacientesPorEdadToolStripMenuItem";
            this.pacientesPorEdadToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.pacientesPorEdadToolStripMenuItem.Text = "Pacientes por edad";
            this.pacientesPorEdadToolStripMenuItem.Click += new System.EventHandler(this.pacientesPorEdadToolStripMenuItem_Click);
            // 
            // coberturasToolStripMenuItem
            // 
            this.coberturasToolStripMenuItem.Name = "coberturasToolStripMenuItem";
            this.coberturasToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.coberturasToolStripMenuItem.Text = "Coberturas";
            this.coberturasToolStripMenuItem.Click += new System.EventHandler(this.coberturasToolStripMenuItem_Click);
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Location = new System.Drawing.Point(22, 158);
            this.dgvTurnos.MultiSelect = false;
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.ReadOnly = true;
            this.dgvTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurnos.Size = new System.Drawing.Size(955, 314);
            this.dgvTurnos.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 573);
            this.Controls.Add(this.dgvTurnos);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Turnos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administrarPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarProfesionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarEspecialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coberturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horariosProfesionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesPorEdadToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvTurnos;
    }
}