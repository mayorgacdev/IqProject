namespace EconomicMF.UserControls
{
    partial class UCInversor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCInversor));
            this.lblNameInversor = new System.Windows.Forms.Label();
            this.pbProfileImage = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameInversor
            // 
            this.lblNameInversor.AutoSize = true;
            this.lblNameInversor.Font = new System.Drawing.Font("Yu Gothic UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameInversor.ForeColor = System.Drawing.Color.White;
            this.lblNameInversor.Location = new System.Drawing.Point(55, 16);
            this.lblNameInversor.Name = "lblNameInversor";
            this.lblNameInversor.Size = new System.Drawing.Size(120, 23);
            this.lblNameInversor.TabIndex = 1;
            this.lblNameInversor.Text = "Pepito Inversor";
            // 
            // pbProfileImage
            // 
            this.pbProfileImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbProfileImage.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pbProfileImage.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbProfileImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbProfileImage.BorderSize = 2;
            this.pbProfileImage.GradientAngle = 50F;
            this.pbProfileImage.Image = ((System.Drawing.Image)(resources.GetObject("pbProfileImage.Image")));
            this.pbProfileImage.Location = new System.Drawing.Point(10, 10);
            this.pbProfileImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbProfileImage.Name = "pbProfileImage";
            this.pbProfileImage.Size = new System.Drawing.Size(36, 36);
            this.pbProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfileImage.TabIndex = 2;
            this.pbProfileImage.TabStop = false;
            // 
            // UCInversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.pbProfileImage);
            this.Controls.Add(this.lblNameInversor);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCInversor";
            this.Size = new System.Drawing.Size(242, 53);
            this.Load += new System.EventHandler(this.UCInversor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNameInversor;
        private RJCodeAdvance.RJControls.RJCircularPictureBox pbProfileImage;
    }
}
