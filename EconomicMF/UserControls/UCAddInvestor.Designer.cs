namespace EconomicMF.UserControls
{
    partial class UCAddInvestor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAddInvestor));
            this.cpImageInversor = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.lblNameInversor = new System.Windows.Forms.Label();
            this.lblAportación = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cpImageInversor)).BeginInit();
            this.SuspendLayout();
            // 
            // cpImageInversor
            // 
            this.cpImageInversor.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.cpImageInversor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.cpImageInversor.BorderColor2 = System.Drawing.Color.HotPink;
            this.cpImageInversor.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.cpImageInversor.BorderSize = 2;
            this.cpImageInversor.GradientAngle = 50F;
            this.cpImageInversor.Image = ((System.Drawing.Image)(resources.GetObject("cpImageInversor.Image")));
            this.cpImageInversor.Location = new System.Drawing.Point(13, 7);
            this.cpImageInversor.Name = "cpImageInversor";
            this.cpImageInversor.Size = new System.Drawing.Size(37, 37);
            this.cpImageInversor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cpImageInversor.TabIndex = 53;
            this.cpImageInversor.TabStop = false;
            // 
            // lblNameInversor
            // 
            this.lblNameInversor.AutoSize = true;
            this.lblNameInversor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameInversor.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblNameInversor.Location = new System.Drawing.Point(76, 7);
            this.lblNameInversor.Name = "lblNameInversor";
            this.lblNameInversor.Size = new System.Drawing.Size(109, 17);
            this.lblNameInversor.TabIndex = 54;
            this.lblNameInversor.Text = "<name inversor>";
            // 
            // lblAportación
            // 
            this.lblAportación.AutoSize = true;
            this.lblAportación.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAportación.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblAportación.Location = new System.Drawing.Point(76, 27);
            this.lblAportación.Name = "lblAportación";
            this.lblAportación.Size = new System.Drawing.Size(90, 17);
            this.lblAportación.TabIndex = 55;
            this.lblAportación.Text = "<Aportación>";
            // 
            // UCAddInvestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.lblAportación);
            this.Controls.Add(this.lblNameInversor);
            this.Controls.Add(this.cpImageInversor);
            this.Name = "UCAddInvestor";
            this.Size = new System.Drawing.Size(287, 53);
            this.Load += new System.EventHandler(this.UCAddInvestor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpImageInversor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJCircularPictureBox cpImageInversor;
        private System.Windows.Forms.Label lblNameInversor;
        private System.Windows.Forms.Label lblAportación;
    }
}
