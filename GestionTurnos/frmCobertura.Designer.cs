﻿namespace GestionTurnos
{
    partial class frmCobertura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCobertura));
            this.txtAgregarCobertura = new System.Windows.Forms.TextBox();
            this.btnSalirCobertura = new System.Windows.Forms.Button();
            this.btnEliminarCobertura = new System.Windows.Forms.Button();
            this.btnModificarCobertura = new System.Windows.Forms.Button();
            this.btnAgregarCobertura = new System.Windows.Forms.Button();
            this.dgvCobertura = new System.Windows.Forms.DataGridView();
            this.lblAgregarCobertura = new System.Windows.Forms.Label();
            this.txtAgregarPorcentajeCobertura = new System.Windows.Forms.TextBox();
            this.lblAgregarPorcentajeCobertura = new System.Windows.Forms.Label();
            this.lblTituloAltaCobertuea = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobertura)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAgregarCobertura
            // 
            this.txtAgregarCobertura.Location = new System.Drawing.Point(153, 320);
            this.txtAgregarCobertura.Name = "txtAgregarCobertura";
            this.txtAgregarCobertura.Size = new System.Drawing.Size(207, 20);
            this.txtAgregarCobertura.TabIndex = 4;
            // 
            // btnSalirCobertura
            // 
            this.btnSalirCobertura.Location = new System.Drawing.Point(94, 206);
            this.btnSalirCobertura.Name = "btnSalirCobertura";
            this.btnSalirCobertura.Size = new System.Drawing.Size(62, 23);
            this.btnSalirCobertura.TabIndex = 7;
            this.btnSalirCobertura.Text = "Salir";
            this.btnSalirCobertura.UseVisualStyleBackColor = true;
            this.btnSalirCobertura.Click += new System.EventHandler(this.btnSalirCobertura_Click);
            // 
            // btnEliminarCobertura
            // 
            this.btnEliminarCobertura.Location = new System.Drawing.Point(26, 206);
            this.btnEliminarCobertura.Name = "btnEliminarCobertura";
            this.btnEliminarCobertura.Size = new System.Drawing.Size(62, 23);
            this.btnEliminarCobertura.TabIndex = 2;
            this.btnEliminarCobertura.Text = "Eliminar";
            this.btnEliminarCobertura.UseVisualStyleBackColor = true;
            this.btnEliminarCobertura.Click += new System.EventHandler(this.btnEliminarCobertura_Click);
            // 
            // btnModificarCobertura
            // 
            this.btnModificarCobertura.Location = new System.Drawing.Point(298, 206);
            this.btnModificarCobertura.Name = "btnModificarCobertura";
            this.btnModificarCobertura.Size = new System.Drawing.Size(62, 23);
            this.btnModificarCobertura.TabIndex = 1;
            this.btnModificarCobertura.Text = "Modificar";
            this.btnModificarCobertura.UseVisualStyleBackColor = true;
            this.btnModificarCobertura.Click += new System.EventHandler(this.btnModificarCobertura_Click);
            // 
            // btnAgregarCobertura
            // 
            this.btnAgregarCobertura.Location = new System.Drawing.Point(298, 404);
            this.btnAgregarCobertura.Name = "btnAgregarCobertura";
            this.btnAgregarCobertura.Size = new System.Drawing.Size(62, 22);
            this.btnAgregarCobertura.TabIndex = 6;
            this.btnAgregarCobertura.Text = "Agregar";
            this.btnAgregarCobertura.UseVisualStyleBackColor = true;
            this.btnAgregarCobertura.Click += new System.EventHandler(this.btnAgregarCobertura_Click);
            // 
            // dgvCobertura
            // 
            this.dgvCobertura.BackgroundColor = System.Drawing.Color.White;
            this.dgvCobertura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCobertura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCobertura.Location = new System.Drawing.Point(26, 28);
            this.dgvCobertura.Name = "dgvCobertura";
            this.dgvCobertura.ReadOnly = true;
            this.dgvCobertura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCobertura.Size = new System.Drawing.Size(334, 150);
            this.dgvCobertura.TabIndex = 0;
            // 
            // lblAgregarCobertura
            // 
            this.lblAgregarCobertura.AutoSize = true;
            this.lblAgregarCobertura.Location = new System.Drawing.Point(23, 323);
            this.lblAgregarCobertura.Name = "lblAgregarCobertura";
            this.lblAgregarCobertura.Size = new System.Drawing.Size(115, 13);
            this.lblAgregarCobertura.TabIndex = 10;
            this.lblAgregarCobertura.Text = "Descripción Cobertura:";
            // 
            // txtAgregarPorcentajeCobertura
            // 
            this.txtAgregarPorcentajeCobertura.Location = new System.Drawing.Point(153, 365);
            this.txtAgregarPorcentajeCobertura.Name = "txtAgregarPorcentajeCobertura";
            this.txtAgregarPorcentajeCobertura.Size = new System.Drawing.Size(207, 20);
            this.txtAgregarPorcentajeCobertura.TabIndex = 5;
            // 
            // lblAgregarPorcentajeCobertura
            // 
            this.lblAgregarPorcentajeCobertura.AutoSize = true;
            this.lblAgregarPorcentajeCobertura.Location = new System.Drawing.Point(23, 368);
            this.lblAgregarPorcentajeCobertura.Name = "lblAgregarPorcentajeCobertura";
            this.lblAgregarPorcentajeCobertura.Size = new System.Drawing.Size(110, 13);
            this.lblAgregarPorcentajeCobertura.TabIndex = 12;
            this.lblAgregarPorcentajeCobertura.Text = "Porcentaje Cobertura:";
            // 
            // lblTituloAltaCobertuea
            // 
            this.lblTituloAltaCobertuea.AutoSize = true;
            this.lblTituloAltaCobertuea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAltaCobertuea.Location = new System.Drawing.Point(22, 275);
            this.lblTituloAltaCobertuea.Name = "lblTituloAltaCobertuea";
            this.lblTituloAltaCobertuea.Size = new System.Drawing.Size(158, 20);
            this.lblTituloAltaCobertuea.TabIndex = 3;
            this.lblTituloAltaCobertuea.Text = "Agregar Cobertura";
            // 
            // frmCobertura
            // 
            this.ClientSize = new System.Drawing.Size(401, 461);
            this.Controls.Add(this.lblTituloAltaCobertuea);
            this.Controls.Add(this.lblAgregarPorcentajeCobertura);
            this.Controls.Add(this.txtAgregarPorcentajeCobertura);
            this.Controls.Add(this.lblAgregarCobertura);
            this.Controls.Add(this.btnSalirCobertura);
            this.Controls.Add(this.btnEliminarCobertura);
            this.Controls.Add(this.btnModificarCobertura);
            this.Controls.Add(this.btnAgregarCobertura);
            this.Controls.Add(this.dgvCobertura);
            this.Controls.Add(this.txtAgregarCobertura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCobertura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Coberturas";
            this.Load += new System.EventHandler(this.frmCobertura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobertura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAgregarCobertura;
        private System.Windows.Forms.Button btnSalirCobertura;
        private System.Windows.Forms.Button btnEliminarCobertura;
        private System.Windows.Forms.Button btnModificarCobertura;
        private System.Windows.Forms.Button btnAgregarCobertura;
        private System.Windows.Forms.DataGridView dgvCobertura;
        private System.Windows.Forms.Label lblAgregarCobertura;
        private System.Windows.Forms.TextBox txtAgregarPorcentajeCobertura;
        private System.Windows.Forms.Label lblAgregarPorcentajeCobertura;
        private System.Windows.Forms.Label lblTituloAltaCobertuea;
    }
}