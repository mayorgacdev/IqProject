namespace EconomicMF.UserControls.Export
{
    partial class UCforAmt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCforAmt));
            this.btnDowloadReport = new RJCodeAdvance.RJControls.RJButton();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblVF = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDowloadReport
            // 
            this.btnDowloadReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnDowloadReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnDowloadReport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDowloadReport.BorderRadius = 10;
            this.btnDowloadReport.BorderSize = 0;
            this.btnDowloadReport.FlatAppearance.BorderSize = 0;
            this.btnDowloadReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDowloadReport.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDowloadReport.ForeColor = System.Drawing.Color.White;
            this.btnDowloadReport.Location = new System.Drawing.Point(505, 23);
            this.btnDowloadReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDowloadReport.Name = "btnDowloadReport";
            this.btnDowloadReport.Size = new System.Drawing.Size(283, 35);
            this.btnDowloadReport.TabIndex = 99;
            this.btnDowloadReport.Text = "Exportar a excel";
            this.btnDowloadReport.TextColor = System.Drawing.Color.White;
            this.btnDowloadReport.UseVisualStyleBackColor = false;
            this.btnDowloadReport.Click += new System.EventHandler(this.btnDowloadReport_Click);
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPeriod.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblPeriod.Location = new System.Drawing.Point(268, 41);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(64, 17);
            this.lblPeriod.TabIndex = 98;
            this.lblPeriod.Text = "<Period>";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblName.Location = new System.Drawing.Point(268, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 17);
            this.lblName.TabIndex = 97;
            this.lblName.Text = "<name project>";
            // 
            // lblVF
            // 
            this.lblVF.AutoSize = true;
            this.lblVF.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVF.ForeColor = System.Drawing.Color.White;
            this.lblVF.Location = new System.Drawing.Point(127, 41);
            this.lblVF.Name = "lblVF";
            this.lblVF.Size = new System.Drawing.Size(72, 17);
            this.lblVF.TabIndex = 96;
            this.lblVF.Text = "Prestamos:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // lblVP
            // 
            this.lblVP.AutoSize = true;
            this.lblVP.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVP.ForeColor = System.Drawing.Color.White;
            this.lblVP.Location = new System.Drawing.Point(127, 19);
            this.lblVP.Name = "lblVP";
            this.lblVP.Size = new System.Drawing.Size(117, 17);
            this.lblVP.TabIndex = 95;
            this.lblVP.Text = "Nombre de activo:";
            // 
            // UCforAmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.btnDowloadReport);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblVF);
            this.Controls.Add(this.lblVP);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCforAmt";
            this.Size = new System.Drawing.Size(817, 75);
            this.Load += new System.EventHandler(this.UCforAmt_Load);
            this.MouseEnter += new System.EventHandler(this.UCforAmt_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCforAmt_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJButton btnDowloadReport;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblVF;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVP;
    }
}
