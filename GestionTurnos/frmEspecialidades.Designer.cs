﻿namespace GestionTurnos
{
    partial class frmEspecialidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEspecialidades));
            this.dgvEspecialidades = new System.Windows.Forms.DataGridView();
            this.btnAgregarEspecialidad = new System.Windows.Forms.Button();
            this.btnModificarEspecialidad = new System.Windows.Forms.Button();
            this.btnEliminarEspecialidad = new System.Windows.Forms.Button();
            this.btnSalirEspecialidad = new System.Windows.Forms.Button();
            this.txtAgregarEspecialidad = new System.Windows.Forms.TextBox();
            this.lblAgregarEspecialidad = new System.Windows.Forms.Label();
            this.lblTituloEspecialidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEspecialidades
            // 
            this.dgvEspecialidades.BackgroundColor = System.Drawing.Color.White;
            this.dgvEspecialidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidades.Location = new System.Drawing.Point(44, 23);
            this.dgvEspecialidades.Name = "dgvEspecialidades";
            this.dgvEspecialidades.ReadOnly = true;
            this.dgvEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecialidades.Size = new System.Drawing.Size(309, 150);
            this.dgvEspecialidades.TabIndex = 0;
            // 
            // btnAgregarEspecialidad
            // 
            this.btnAgregarEspecialidad.Location = new System.Drawing.Point(291, 350);
            this.btnAgregarEspecialidad.Name = "btnAgregarEspecialidad";
            this.btnAgregarEspecialidad.Size = new System.Drawing.Size(62, 22);
            this.btnAgregarEspecialidad.TabIndex = 1;
            this.btnAgregarEspecialidad.Text = "Agregar";
            this.btnAgregarEspecialidad.UseVisualStyleBackColor = true;
            this.btnAgregarEspecialidad.Click += new System.EventHandler(this.btnAgregarEspecialidad_Click);
            // 
            // btnModificarEspecialidad
            // 
            this.btnModificarEspecialidad.Location = new System.Drawing.Point(291, 196);
            this.btnModificarEspecialidad.Name = "btnModificarEspecialidad";
            this.btnModificarEspecialidad.Size = new System.Drawing.Size(62, 23);
            this.btnModificarEspecialidad.TabIndex = 2;
            this.btnModificarEspecialidad.Text = "Modificar";
            this.btnModificarEspecialidad.UseVisualStyleBackColor = true;
            this.btnModificarEspecialidad.Click += new System.EventHandler(this.btnModificarEspecialidad_Click);
            // 
            // btnEliminarEspecialidad
            // 
            this.btnEliminarEspecialidad.Location = new System.Drawing.Point(44, 196);
            this.btnEliminarEspecialidad.Name = "btnEliminarEspecialidad";
            this.btnEliminarEspecialidad.Size = new System.Drawing.Size(62, 23);
            this.btnEliminarEspecialidad.TabIndex = 3;
            this.btnEliminarEspecialidad.Text = "Eliminar";
            this.btnEliminarEspecialidad.UseVisualStyleBackColor = true;
            this.btnEliminarEspecialidad.Click += new System.EventHandler(this.btnEliminarEspecialidad_Click);
            // 
            // btnSalirEspecialidad
            // 
            this.btnSalirEspecialidad.Location = new System.Drawing.Point(112, 196);
            this.btnSalirEspecialidad.Name = "btnSalirEspecialidad";
            this.btnSalirEspecialidad.Size = new System.Drawing.Size(62, 23);
            this.btnSalirEspecialidad.TabIndex = 4;
            this.btnSalirEspecialidad.Text = "Salir";
            this.btnSalirEspecialidad.UseVisualStyleBackColor = true;
            this.btnSalirEspecialidad.Click += new System.EventHandler(this.btnSalirEspecialidad_Click);
            // 
            // txtAgregarEspecialidad
            // 
            this.txtAgregarEspecialidad.Location = new System.Drawing.Point(177, 313);
            this.txtAgregarEspecialidad.Name = "txtAgregarEspecialidad";
            this.txtAgregarEspecialidad.Size = new System.Drawing.Size(176, 20);
            this.txtAgregarEspecialidad.TabIndex = 5;
            // 
            // lblAgregarEspecialidad
            // 
            this.lblAgregarEspecialidad.AutoSize = true;
            this.lblAgregarEspecialidad.Location = new System.Drawing.Point(41, 316);
            this.lblAgregarEspecialidad.Name = "lblAgregarEspecialidad";
            this.lblAgregarEspecialidad.Size = new System.Drawing.Size(129, 13);
            this.lblAgregarEspecialidad.TabIndex = 6;
            this.lblAgregarEspecialidad.Text = "Descripción Especialidad:";
            // 
            // lblTituloEspecialidad
            // 
            this.lblTituloEspecialidad.AutoSize = true;
            this.lblTituloEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEspecialidad.Location = new System.Drawing.Point(40, 274);
            this.lblTituloEspecialidad.Name = "lblTituloEspecialidad";
            this.lblTituloEspecialidad.Size = new System.Drawing.Size(180, 20);
            this.lblTituloEspecialidad.TabIndex = 7;
            this.lblTituloEspecialidad.Text = "Agregar Especialidad";
            // 
            // frmEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 398);
            this.Controls.Add(this.lblTituloEspecialidad);
            this.Controls.Add(this.lblAgregarEspecialidad);
            this.Controls.Add(this.txtAgregarEspecialidad);
            this.Controls.Add(this.btnSalirEspecialidad);
            this.Controls.Add(this.btnEliminarEspecialidad);
            this.Controls.Add(this.btnModificarEspecialidad);
            this.Controls.Add(this.btnAgregarEspecialidad);
            this.Controls.Add(this.dgvEspecialidades);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEspecialidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Especialidades";
            this.Load += new System.EventHandler(this.frmEspecialidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEspecialidades;
        private System.Windows.Forms.Button btnAgregarEspecialidad;
        private System.Windows.Forms.Button btnModificarEspecialidad;
        private System.Windows.Forms.Button btnEliminarEspecialidad;
        private System.Windows.Forms.Button btnSalirEspecialidad;
        private System.Windows.Forms.TextBox txtAgregarEspecialidad;
        private System.Windows.Forms.Label lblAgregarEspecialidad;
        private System.Windows.Forms.Label lblTituloEspecialidad;
    }
}