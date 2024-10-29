namespace GestionTurnos
{
    partial class frmHorariosProfesionales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHorariosProfesionales));
            this.dgvHorariosProfesionales = new System.Windows.Forms.DataGridView();
            this.btnSalirHorariosProfes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorariosProfesionales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHorariosProfesionales
            // 
            this.dgvHorariosProfesionales.AllowDrop = true;
            this.dgvHorariosProfesionales.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHorariosProfesionales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHorariosProfesionales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHorariosProfesionales.BackgroundColor = System.Drawing.Color.White;
            this.dgvHorariosProfesionales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHorariosProfesionales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHorariosProfesionales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHorariosProfesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorariosProfesionales.Location = new System.Drawing.Point(64, 67);
            this.dgvHorariosProfesionales.Name = "dgvHorariosProfesionales";
            this.dgvHorariosProfesionales.ReadOnly = true;
            this.dgvHorariosProfesionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHorariosProfesionales.Size = new System.Drawing.Size(672, 219);
            this.dgvHorariosProfesionales.TabIndex = 1;
            // 
            // btnSalirHorariosProfes
            // 
            this.btnSalirHorariosProfes.Location = new System.Drawing.Point(674, 320);
            this.btnSalirHorariosProfes.Name = "btnSalirHorariosProfes";
            this.btnSalirHorariosProfes.Size = new System.Drawing.Size(62, 23);
            this.btnSalirHorariosProfes.TabIndex = 5;
            this.btnSalirHorariosProfes.Text = "Salir";
            this.btnSalirHorariosProfes.UseVisualStyleBackColor = true;
            this.btnSalirHorariosProfes.Click += new System.EventHandler(this.btnSalirHorariosProfes_Click);
            // 
            // frmHorariosProfesionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalirHorariosProfes);
            this.Controls.Add(this.dgvHorariosProfesionales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHorariosProfesionales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horarios Profesionales";
            this.Load += new System.EventHandler(this.frmHorariosProfesionales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorariosProfesionales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHorariosProfesionales;
        private System.Windows.Forms.Button btnSalirHorariosProfes;
    }
}