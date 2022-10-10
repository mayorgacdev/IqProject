namespace EconomicMF.UserControls
{
    partial class UCAddInversionToProject
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAddInversionToProject));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInit = new System.Windows.Forms.Label();
            this.lblinversion = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblNameInversor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblInit
            // 
            this.lblInit.AutoSize = true;
            this.lblInit.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInit.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblInit.Location = new System.Drawing.Point(473, 18);
            this.lblInit.Name = "lblInit";
            this.lblInit.Size = new System.Drawing.Size(39, 17);
            this.lblInit.TabIndex = 71;
            this.lblInit.Text = "lblinit";
            // 
            // lblinversion
            // 
            this.lblinversion.AutoSize = true;
            this.lblinversion.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblinversion.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblinversion.Location = new System.Drawing.Point(187, 18);
            this.lblinversion.Name = "lblinversion";
            this.lblinversion.Size = new System.Drawing.Size(103, 17);
            this.lblinversion.TabIndex = 70;
            this.lblinversion.Text = "<name project>";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInicio.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblInicio.Location = new System.Drawing.Point(417, 18);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(38, 17);
            this.lblInicio.TabIndex = 69;
            this.lblInicio.Text = "Inicio";
            // 
            // lblNameInversor
            // 
            this.lblNameInversor.AutoSize = true;
            this.lblNameInversor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameInversor.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblNameInversor.Location = new System.Drawing.Point(103, 18);
            this.lblNameInversor.Name = "lblNameInversor";
            this.lblNameInversor.Size = new System.Drawing.Size(63, 17);
            this.lblNameInversor.TabIndex = 68;
            this.lblNameInversor.Text = "Inversion:";
            // 
            // UCAddInversionToProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.lblInit);
            this.Controls.Add(this.lblinversion);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.lblNameInversor);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCAddInversionToProject";
            this.Size = new System.Drawing.Size(758, 56);
            this.Load += new System.EventHandler(this.UCAddInversionToProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInit;
        private System.Windows.Forms.Label lblinversion;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblNameInversor;
    }
}
