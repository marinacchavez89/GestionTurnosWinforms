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
            this.SuspendLayout();
            // 
            // btnModificarCoberturaSalir
            // 
            this.btnModificarCoberturaSalir.Location = new System.Drawing.Point(92, 120);
            this.btnModificarCoberturaSalir.Name = "btnModificarCoberturaSalir";
            this.btnModificarCoberturaSalir.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCoberturaSalir.TabIndex = 5;
            this.btnModificarCoberturaSalir.Text = "Salir";
            this.btnModificarCoberturaSalir.UseVisualStyleBackColor = true;
            this.btnModificarCoberturaSalir.Click += new System.EventHandler(this.btnSalirCoberturaSalir_Click);
            // 
            // btnModificarCoberturaAceptar
            // 
            this.btnModificarCoberturaAceptar.Location = new System.Drawing.Point(220, 120);
            this.btnModificarCoberturaAceptar.Name = "btnModificarCoberturaAceptar";
            this.btnModificarCoberturaAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCoberturaAceptar.TabIndex = 4;
            this.btnModificarCoberturaAceptar.Text = "Aceptar";
            this.btnModificarCoberturaAceptar.UseVisualStyleBackColor = true;
            this.btnModificarCoberturaAceptar.Click += new System.EventHandler(this.btnModificarCoberturaAceptar_Click);
            // 
            // txtDescripcionCobertura
            // 
            this.txtDescripcionCobertura.Location = new System.Drawing.Point(92, 39);
            this.txtDescripcionCobertura.Name = "txtDescripcionCobertura";
            this.txtDescripcionCobertura.Size = new System.Drawing.Size(203, 20);
            this.txtDescripcionCobertura.TabIndex = 3;
            // 
            // txtPorcentajeCobertura
            // 
            this.txtPorcentajeCobertura.Location = new System.Drawing.Point(92, 72);
            this.txtPorcentajeCobertura.Name = "txtPorcentajeCobertura";
            this.txtPorcentajeCobertura.Size = new System.Drawing.Size(203, 20);
            this.txtPorcentajeCobertura.TabIndex = 6;
            // 
            // lblCobertura
            // 
            this.lblCobertura.AutoSize = true;
            this.lblCobertura.Location = new System.Drawing.Point(33, 42);
            this.lblCobertura.Name = "lblCobertura";
            this.lblCobertura.Size = new System.Drawing.Size(53, 13);
            this.lblCobertura.TabIndex = 7;
            this.lblCobertura.Text = "Cobertura";
            // 
            // lblPorcentajeCobertura
            // 
            this.lblPorcentajeCobertura.AutoSize = true;
            this.lblPorcentajeCobertura.Location = new System.Drawing.Point(33, 72);
            this.lblPorcentajeCobertura.Name = "lblPorcentajeCobertura";
            this.lblPorcentajeCobertura.Size = new System.Drawing.Size(58, 13);
            this.lblPorcentajeCobertura.TabIndex = 8;
            this.lblPorcentajeCobertura.Text = "Porcentaje";
            // 
            // frmModificarCobertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 171);
            this.Controls.Add(this.lblPorcentajeCobertura);
            this.Controls.Add(this.lblCobertura);
            this.Controls.Add(this.txtPorcentajeCobertura);
            this.Controls.Add(this.btnModificarCoberturaSalir);
            this.Controls.Add(this.btnModificarCoberturaAceptar);
            this.Controls.Add(this.txtDescripcionCobertura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificarCobertura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
    }
}