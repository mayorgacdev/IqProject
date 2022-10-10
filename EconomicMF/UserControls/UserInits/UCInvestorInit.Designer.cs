namespace EconomicMF.UserControls.UserInits
{
    partial class UCInvestorInit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCInvestorInit));
            this.lblAportación = new System.Windows.Forms.Label();
            this.lblNameInversor = new System.Windows.Forms.Label();
            this.cpImageInversor = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cpImageInversor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAportación
            // 
            this.lblAportación.AutoSize = true;
            this.lblAportación.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAportación.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblAportación.Location = new System.Drawing.Point(129, 37);
            this.lblAportación.Name = "lblAportación";
            this.lblAportación.Size = new System.Drawing.Size(118, 23);
            this.lblAportación.TabIndex = 58;
            this.lblAportación.Text = "<Aportación>";
            // 
            // lblNameInversor
            // 
            this.lblNameInversor.AutoSize = true;
            this.lblNameInversor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameInversor.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblNameInversor.Location = new System.Drawing.Point(129, 10);
            this.lblNameInversor.Name = "lblNameInversor";
            this.lblNameInversor.Size = new System.Drawing.Size(142, 23);
            this.lblNameInversor.TabIndex = 57;
            this.lblNameInversor.Text = "<name inversor>";
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
            this.cpImageInversor.Location = new System.Drawing.Point(57, 10);
            this.cpImageInversor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cpImageInversor.Name = "cpImageInversor";
            this.cpImageInversor.Size = new System.Drawing.Size(42, 42);
            this.cpImageInversor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cpImageInversor.TabIndex = 56;
            this.cpImageInversor.TabStop = false;
            // 
            // UCInvestorInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.lblAportación);
            this.Controls.Add(this.lblNameInversor);
            this.Controls.Add(this.cpImageInversor);
            this.Name = "UCInvestorInit";
            this.Size = new System.Drawing.Size(328, 71);
            ((System.ComponentModel.ISupportInitialize)(this.cpImageInversor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAportación;
        private System.Windows.Forms.Label lblNameInversor;
        private RJCodeAdvance.RJControls.RJCircularPictureBox cpImageInversor;
    }
}
