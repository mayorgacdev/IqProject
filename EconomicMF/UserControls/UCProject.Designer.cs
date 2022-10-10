namespace EconomicMF.UserControls
{
    partial class UCProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProject));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNameProject = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblDuracionValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(146, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNameProject
            // 
            this.lblNameProject.AutoSize = true;
            this.lblNameProject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameProject.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNameProject.Location = new System.Drawing.Point(8, 28);
            this.lblNameProject.Name = "lblNameProject";
            this.lblNameProject.Size = new System.Drawing.Size(109, 23);
            this.lblNameProject.TabIndex = 1;
            this.lblNameProject.Text = "NameProject";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPeriodo.Location = new System.Drawing.Point(6, 77);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(60, 20);
            this.lblPeriodo.TabIndex = 3;
            this.lblPeriodo.Text = "Periodo";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResult.Location = new System.Drawing.Point(71, 77);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(74, 20);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Trimestral";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDuracion.Location = new System.Drawing.Point(6, 112);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(72, 20);
            this.lblDuracion.TabIndex = 5;
            this.lblDuracion.Text = "Duración:";
            // 
            // lblDuracionValue
            // 
            this.lblDuracionValue.AutoSize = true;
            this.lblDuracionValue.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDuracionValue.Location = new System.Drawing.Point(79, 112);
            this.lblDuracionValue.Name = "lblDuracionValue";
            this.lblDuracionValue.Size = new System.Drawing.Size(25, 20);
            this.lblDuracionValue.TabIndex = 6;
            this.lblDuracionValue.Text = "10";
            // 
            // UCProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.lblDuracionValue);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblNameProject);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCProject";
            this.Size = new System.Drawing.Size(208, 164);
            this.Load += new System.EventHandler(this.UCProject_Load);
            this.Click += new System.EventHandler(this.UCProject_Click);
            this.MouseEnter += new System.EventHandler(this.UCProject_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCProject_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNameProject;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblDuracionValue;
    }
}
