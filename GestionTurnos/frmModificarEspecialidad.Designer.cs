namespace GestionTurnos
{
    partial class frmModificarEspecialidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarEspecialidad));
            this.txtDescripcionEspecialidad = new System.Windows.Forms.TextBox();
            this.btnModificarEspecialidadAceptar = new System.Windows.Forms.Button();
            this.btnModificarEspecialidadSalir = new System.Windows.Forms.Button();
            this.lblDescEspe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDescripcionEspecialidad
            // 
            this.txtDescripcionEspecialidad.Location = new System.Drawing.Point(147, 54);
            this.txtDescripcionEspecialidad.Name = "txtDescripcionEspecialidad";
            this.txtDescripcionEspecialidad.Size = new System.Drawing.Size(164, 20);
            this.txtDescripcionEspecialidad.TabIndex = 0;
            // 
            // btnModificarEspecialidadAceptar
            // 
            this.btnModificarEspecialidadAceptar.Location = new System.Drawing.Point(236, 90);
            this.btnModificarEspecialidadAceptar.Name = "btnModificarEspecialidadAceptar";
            this.btnModificarEspecialidadAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnModificarEspecialidadAceptar.TabIndex = 1;
            this.btnModificarEspecialidadAceptar.Text = "Aceptar";
            this.btnModificarEspecialidadAceptar.UseVisualStyleBackColor = true;
            this.btnModificarEspecialidadAceptar.Click += new System.EventHandler(this.btnModificarEspecialidadAceptar_Click);
            // 
            // btnModificarEspecialidadSalir
            // 
            this.btnModificarEspecialidadSalir.Location = new System.Drawing.Point(147, 90);
            this.btnModificarEspecialidadSalir.Name = "btnModificarEspecialidadSalir";
            this.btnModificarEspecialidadSalir.Size = new System.Drawing.Size(75, 23);
            this.btnModificarEspecialidadSalir.TabIndex = 2;
            this.btnModificarEspecialidadSalir.Text = "Salir";
            this.btnModificarEspecialidadSalir.UseVisualStyleBackColor = true;
            this.btnModificarEspecialidadSalir.Click += new System.EventHandler(this.btnModificarEspecialidadSalir_Click);
            // 
            // lblDescEspe
            // 
            this.lblDescEspe.AutoSize = true;
            this.lblDescEspe.Location = new System.Drawing.Point(12, 57);
            this.lblDescEspe.Name = "lblDescEspe";
            this.lblDescEspe.Size = new System.Drawing.Size(129, 13);
            this.lblDescEspe.TabIndex = 3;
            this.lblDescEspe.Text = "Descripción Especialidad:";
            // 
            // frmModificarEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 159);
            this.Controls.Add(this.lblDescEspe);
            this.Controls.Add(this.btnModificarEspecialidadSalir);
            this.Controls.Add(this.btnModificarEspecialidadAceptar);
            this.Controls.Add(this.txtDescripcionEspecialidad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificarEspecialidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Especialidad";
            this.Load += new System.EventHandler(this.frmModificarEspecialidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcionEspecialidad;
        private System.Windows.Forms.Button btnModificarEspecialidadAceptar;
        private System.Windows.Forms.Button btnModificarEspecialidadSalir;
        private System.Windows.Forms.Label lblDescEspe;
    }
}