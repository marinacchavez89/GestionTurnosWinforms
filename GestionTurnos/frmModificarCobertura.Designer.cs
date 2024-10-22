namespace GestionTurnos
{
    partial class frmModificarCobertura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarCobertura));
            this.btnModificarCoberturaSalir = new System.Windows.Forms.Button();
            this.btnModificarCoberturaAceptar = new System.Windows.Forms.Button();
            this.txtDescripcionCobertura = new System.Windows.Forms.TextBox();
            this.txtPorcentajeCobertura = new System.Windows.Forms.TextBox();
            this.lblCobertura = new System.Windows.Forms.Label();
            this.lblPorcentajeCobertura = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModificarCoberturaSalir
            // 
            this.btnModificarCoberturaSalir.Location = new System.Drawing.Point(234, 127);
            this.btnModificarCoberturaSalir.Name = "btnModificarCoberturaSalir";
            this.btnModificarCoberturaSalir.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCoberturaSalir.TabIndex = 5;
            this.btnModificarCoberturaSalir.Text = "Salir";
            this.btnModificarCoberturaSalir.UseVisualStyleBackColor = true;
            this.btnModificarCoberturaSalir.Click += new System.EventHandler(this.btnSalirCoberturaSalir_Click);
            // 
            // btnModificarCoberturaAceptar
            // 
            this.btnModificarCoberturaAceptar.Location = new System.Drawing.Point(127, 127);
            this.btnModificarCoberturaAceptar.Name = "btnModificarCoberturaAceptar";
            this.btnModificarCoberturaAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCoberturaAceptar.TabIndex = 4;
            this.btnModificarCoberturaAceptar.Text = "Aceptar";
            this.btnModificarCoberturaAceptar.UseVisualStyleBackColor = true;
            this.btnModificarCoberturaAceptar.Click += new System.EventHandler(this.btnModificarCoberturaAceptar_Click);
            // 
            // txtDescripcionCobertura
            // 
            this.txtDescripcionCobertura.Location = new System.Drawing.Point(106, 36);
            this.txtDescripcionCobertura.Name = "txtDescripcionCobertura";
            this.txtDescripcionCobertura.Size = new System.Drawing.Size(128, 20);
            this.txtDescripcionCobertura.TabIndex = 3;
            // 
            // txtPorcentajeCobertura
            // 
            this.txtPorcentajeCobertura.Location = new System.Drawing.Point(140, 69);
            this.txtPorcentajeCobertura.Name = "txtPorcentajeCobertura";
            this.txtPorcentajeCobertura.Size = new System.Drawing.Size(45, 20);
            this.txtPorcentajeCobertura.TabIndex = 6;
            // 
            // lblCobertura
            // 
            this.lblCobertura.AutoSize = true;
            this.lblCobertura.Location = new System.Drawing.Point(47, 39);
            this.lblCobertura.Name = "lblCobertura";
            this.lblCobertura.Size = new System.Drawing.Size(53, 13);
            this.lblCobertura.TabIndex = 7;
            this.lblCobertura.Text = "Cobertura";
            // 
            // lblPorcentajeCobertura
            // 
            this.lblPorcentajeCobertura.AutoSize = true;
            this.lblPorcentajeCobertura.Location = new System.Drawing.Point(47, 69);
            this.lblPorcentajeCobertura.Name = "lblPorcentajeCobertura";
            this.lblPorcentajeCobertura.Size = new System.Drawing.Size(58, 13);
            this.lblPorcentajeCobertura.TabIndex = 8;
            this.lblPorcentajeCobertura.Text = "Porcentaje";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(154, 104);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(15, 14);
            this.chkActivo.TabIndex = 9;
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Activo";
            // 
            // frmModificarCobertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 171);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.lblPorcentajeCobertura);
            this.Controls.Add(this.lblCobertura);
            this.Controls.Add(this.txtPorcentajeCobertura);
            this.Controls.Add(this.btnModificarCoberturaSalir);
            this.Controls.Add(this.btnModificarCoberturaAceptar);
            this.Controls.Add(this.txtDescripcionCobertura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificarCobertura";
            this.Text = "Modificar Cobertura";
            this.Load += new System.EventHandler(this.frmModificarCobertura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificarCoberturaSalir;
        private System.Windows.Forms.Button btnModificarCoberturaAceptar;
        private System.Windows.Forms.TextBox txtDescripcionCobertura;
        private System.Windows.Forms.TextBox txtPorcentajeCobertura;
        private System.Windows.Forms.Label lblCobertura;
        private System.Windows.Forms.Label lblPorcentajeCobertura;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label label1;
    }
}