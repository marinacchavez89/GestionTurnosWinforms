
namespace GestionTurnos
{
    partial class frmProfesional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfesional));
            this.dgvProfesional = new System.Windows.Forms.DataGridView();
            this.btnAgregarProfesional = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalirProfesional = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesional)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProfesional
            // 
            this.dgvProfesional.BackgroundColor = System.Drawing.Color.White;
            this.dgvProfesional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesional.Location = new System.Drawing.Point(12, 41);
            this.dgvProfesional.Name = "dgvProfesional";
            this.dgvProfesional.ReadOnly = true;
            this.dgvProfesional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfesional.Size = new System.Drawing.Size(1043, 187);
            this.dgvProfesional.TabIndex = 0;
            // 
            // btnAgregarProfesional
            // 
            this.btnAgregarProfesional.Location = new System.Drawing.Point(12, 271);
            this.btnAgregarProfesional.Name = "btnAgregarProfesional";
            this.btnAgregarProfesional.Size = new System.Drawing.Size(82, 32);
            this.btnAgregarProfesional.TabIndex = 1;
            this.btnAgregarProfesional.Text = "Agregar";
            this.btnAgregarProfesional.UseVisualStyleBackColor = true;
            this.btnAgregarProfesional.Click += new System.EventHandler(this.btnAgregarProfesional_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(214, 271);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 32);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(112, 271);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(82, 32);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalirProfesional
            // 
            this.btnSalirProfesional.Location = new System.Drawing.Point(973, 271);
            this.btnSalirProfesional.Name = "btnSalirProfesional";
            this.btnSalirProfesional.Size = new System.Drawing.Size(82, 32);
            this.btnSalirProfesional.TabIndex = 4;
            this.btnSalirProfesional.Text = "Salir";
            this.btnSalirProfesional.UseVisualStyleBackColor = true;
            this.btnSalirProfesional.Click += new System.EventHandler(this.btnSalirProfesional_Click);
            // 
            // frmProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 345);
            this.Controls.Add(this.btnSalirProfesional);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarProfesional);
            this.Controls.Add(this.dgvProfesional);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProfesional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Profesionales";
            this.Load += new System.EventHandler(this.frmProfesional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesional)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProfesional;
        private System.Windows.Forms.Button btnAgregarProfesional;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalirProfesional;
    }
}