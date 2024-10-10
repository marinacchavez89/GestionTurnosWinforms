
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
            this.dgvprofesional = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprofesional)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvprofesional
            // 
            this.dgvprofesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprofesional.Location = new System.Drawing.Point(45, 73);
            this.dgvprofesional.Name = "dgvprofesional";
            this.dgvprofesional.Size = new System.Drawing.Size(610, 150);
            this.dgvprofesional.TabIndex = 0;
            // 
            // frmProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvprofesional);
            this.Name = "frmProfesional";
            this.Text = "frmProfesional";
            this.Load += new System.EventHandler(this.frmProfesional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvprofesional)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvprofesional;
    }
}