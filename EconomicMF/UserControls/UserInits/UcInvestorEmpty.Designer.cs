namespace EconomicMF.UserControls.UserInits
{
    partial class UcInvestorEmpty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcInvestorEmpty));
            this.lblAportación = new System.Windows.Forms.Label();
            this.cpImageInversor = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cpImageInversor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAportación
            // 
            this.lblAportación.AutoSize = true;
            this.lblAportación.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAportación.ForeColor = System.Drawing.Color.Black;
            this.lblAportación.Location = new System.Drawing.Point(13, 98);
            this.lblAportación.Name = "lblAportación";
            this.lblAportación.Size = new System.Drawing.Size(171, 23);
            this.lblAportación.TabIndex = 61;
            this.lblAportación.Text = "Agrega inversionistas";
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
            this.cpImageInversor.Location = new System.Drawing.Point(3, 4);
            this.cpImageInversor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cpImageInversor.Name = "cpImageInversor";
            this.cpImageInversor.Size = new System.Drawing.Size(74, 74);
            this.cpImageInversor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cpImageInversor.TabIndex = 59;
            this.cpImageInversor.TabStop = false;
            // 
            // UcInvestorEmpty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(127)))), ((int)(((byte)(148)))));
            this.Controls.Add(this.lblAportación);
            this.Controls.Add(this.cpImageInversor);
            this.Name = "UcInvestorEmpty";
            this.Size = new System.Drawing.Size(190, 210);
            ((System.ComponentModel.ISupportInitialize)(this.cpImageInversor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAportación;
        private RJCodeAdvance.RJControls.RJCircularPictureBox cpImageInversor;
    }
}
