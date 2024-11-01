namespace GestionTurnos
{
    partial class frmReportesRecaudacionAnual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportesRecaudacionAnual));
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.btnReporteRecaudacionSalir = new System.Windows.Forms.Button();
            this.btnReporteRecaudacionBuscar = new System.Windows.Forms.Button();
            this.dgvRecaudacionAnual = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecaudacionAnual)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(183, 51);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(109, 20);
            this.txtAnio.TabIndex = 0;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(135, 54);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(33, 13);
            this.lblAnio.TabIndex = 1;
            this.lblAnio.Text = "AÑO:";
            // 
            // btnReporteRecaudacionSalir
            // 
            this.btnReporteRecaudacionSalir.Location = new System.Drawing.Point(305, 313);
            this.btnReporteRecaudacionSalir.Name = "btnReporteRecaudacionSalir";
            this.btnReporteRecaudacionSalir.Size = new System.Drawing.Size(75, 23);
            this.btnReporteRecaudacionSalir.TabIndex = 2;
            this.btnReporteRecaudacionSalir.Text = "Salir";
            this.btnReporteRecaudacionSalir.UseVisualStyleBackColor = true;
            this.btnReporteRecaudacionSalir.Click += new System.EventHandler(this.btnReporteRecaudacionSalir_Click);
            // 
            // btnReporteRecaudacionBuscar
            // 
            this.btnReporteRecaudacionBuscar.Location = new System.Drawing.Point(311, 49);
            this.btnReporteRecaudacionBuscar.Name = "btnReporteRecaudacionBuscar";
            this.btnReporteRecaudacionBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnReporteRecaudacionBuscar.TabIndex = 3;
            this.btnReporteRecaudacionBuscar.Text = "Buscar";
            this.btnReporteRecaudacionBuscar.UseVisualStyleBackColor = true;
            this.btnReporteRecaudacionBuscar.Click += new System.EventHandler(this.btnReporteRecaudacionBuscar_Click);
            // 
            // dgvRecaudacionAnual
            // 
            this.dgvRecaudacionAnual.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecaudacionAnual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecaudacionAnual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecaudacionAnual.Location = new System.Drawing.Point(140, 119);
            this.dgvRecaudacionAnual.MultiSelect = false;
            this.dgvRecaudacionAnual.Name = "dgvRecaudacionAnual";
            this.dgvRecaudacionAnual.ReadOnly = true;
            this.dgvRecaudacionAnual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecaudacionAnual.Size = new System.Drawing.Size(246, 150);
            this.dgvRecaudacionAnual.TabIndex = 4;
            // 
            // frmReportesRecaudacionAnual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 385);
            this.Controls.Add(this.dgvRecaudacionAnual);
            this.Controls.Add(this.btnReporteRecaudacionBuscar);
            this.Controls.Add(this.btnReporteRecaudacionSalir);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.txtAnio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportesRecaudacionAnual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recaudacion Anual";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecaudacionAnual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Button btnReporteRecaudacionSalir;
        private System.Windows.Forms.Button btnReporteRecaudacionBuscar;
        private System.Windows.Forms.DataGridView dgvRecaudacionAnual;
    }
}