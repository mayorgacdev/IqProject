namespace EconomicMF.UserControls
{
    partial class UCSolutions
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSolutions));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNameSolution = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumberOfProjects = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNameSolution
            // 
            this.lblNameSolution.AutoSize = true;
            this.lblNameSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameSolution.ForeColor = System.Drawing.Color.White;
            this.lblNameSolution.Location = new System.Drawing.Point(66, 12);
            this.lblNameSolution.Name = "lblNameSolution";
            this.lblNameSolution.Size = new System.Drawing.Size(184, 20);
            this.lblNameSolution.TabIndex = 1;
            this.lblNameSolution.Text = "Equipos de contruccion";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(427, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(112, 18);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "2022/02/10 8:32";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(81, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Proyectos: ";
            // 
            // lblNumberOfProjects
            // 
            this.lblNumberOfProjects.AutoSize = true;
            this.lblNumberOfProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumberOfProjects.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfProjects.Location = new System.Drawing.Point(154, 33);
            this.lblNumberOfProjects.Name = "lblNumberOfProjects";
            this.lblNumberOfProjects.Size = new System.Drawing.Size(16, 17);
            this.lblNumberOfProjects.TabIndex = 4;
            this.lblNumberOfProjects.Text = "1";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(427, 33);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 17);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Id:";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldata.ForeColor = System.Drawing.Color.White;
            this.lbldata.Location = new System.Drawing.Point(493, 33);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(16, 17);
            this.lbldata.TabIndex = 6;
            this.lbldata.Text = "1";
            // 
            // UCSolutions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblNumberOfProjects);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNameSolution);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCSolutions";
            this.Size = new System.Drawing.Size(571, 71);
            this.Load += new System.EventHandler(this.UCSolutions_Load);
            this.Click += new System.EventHandler(this.UCSolutions_Click);
            this.MouseEnter += new System.EventHandler(this.UCSolutions_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCSolutions_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNameSolution;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumberOfProjects;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lbldata;
    }
}
