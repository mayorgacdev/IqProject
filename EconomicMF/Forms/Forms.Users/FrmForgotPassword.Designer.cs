namespace EconomicMF.Forms.Forms.Users
{
    partial class FrmForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmForgotPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecovery = new RJCodeAdvance.RJControls.RJButton();
            this.txtNameOrEmail = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Has olvidado tu contraseña";
            // 
            // btnRecovery
            // 
            this.btnRecovery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(206)))), ((int)(((byte)(171)))));
            this.btnRecovery.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(206)))), ((int)(((byte)(171)))));
            this.btnRecovery.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRecovery.BorderRadius = 5;
            this.btnRecovery.BorderSize = 0;
            this.btnRecovery.FlatAppearance.BorderSize = 0;
            this.btnRecovery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecovery.ForeColor = System.Drawing.Color.Black;
            this.btnRecovery.Location = new System.Drawing.Point(89, 259);
            this.btnRecovery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRecovery.Name = "btnRecovery";
            this.btnRecovery.Size = new System.Drawing.Size(298, 45);
            this.btnRecovery.TabIndex = 1;
            this.btnRecovery.Text = "Recuperar contraseña";
            this.btnRecovery.TextColor = System.Drawing.Color.Black;
            this.btnRecovery.UseVisualStyleBackColor = false;
            this.btnRecovery.Click += new System.EventHandler(this.btnRecovery_Click);
            // 
            // txtNameOrEmail
            // 
            this.txtNameOrEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtNameOrEmail.BorderColor = System.Drawing.Color.White;
            this.txtNameOrEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNameOrEmail.BorderRadius = 0;
            this.txtNameOrEmail.BorderSize = 2;
            this.txtNameOrEmail.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNameOrEmail.ForeColor = System.Drawing.Color.White;
            this.txtNameOrEmail.Location = new System.Drawing.Point(89, 162);
            this.txtNameOrEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNameOrEmail.Multiline = false;
            this.txtNameOrEmail.Name = "txtNameOrEmail";
            this.txtNameOrEmail.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtNameOrEmail.PasswordChar = false;
            this.txtNameOrEmail.PlaceholderColor = System.Drawing.Color.White;
            this.txtNameOrEmail.PlaceholderText = "Email";
            this.txtNameOrEmail.Size = new System.Drawing.Size(298, 56);
            this.txtNameOrEmail.TabIndex = 7;
            this.txtNameOrEmail.Texts = "";
            this.txtNameOrEmail.UnderlinedStyle = true;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(455, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 8;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(489, 356);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtNameOrEmail);
            this.Controls.Add(this.btnRecovery);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmForgotPassword";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmForgotPassword_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJButton btnRecovery;
        private RJCodeAdvance.RJControls.RJTextBox txtNameOrEmail;
        private System.Windows.Forms.PictureBox btnClose;
    }
}