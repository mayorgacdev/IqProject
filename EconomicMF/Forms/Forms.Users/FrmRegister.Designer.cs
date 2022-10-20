namespace EconomicMF.Forms.Forms.Users
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.panelUser = new System.Windows.Forms.Panel();
            this.txtDNI = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtPhone = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnImage = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.txtEmail = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new RJCodeAdvance.RJControls.RJButton();
            this.txtPassword = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtName = new RJCodeAdvance.RJControls.RJTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.panelUser.Controls.Add(this.txtDNI);
            this.panelUser.Controls.Add(this.txtPhone);
            this.panelUser.Controls.Add(this.btnImage);
            this.panelUser.Controls.Add(this.txtEmail);
            this.panelUser.Controls.Add(this.btnClose);
            this.panelUser.Controls.Add(this.btnSubmit);
            this.panelUser.Controls.Add(this.txtPassword);
            this.panelUser.Controls.Add(this.txtName);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelUser.Location = new System.Drawing.Point(903, 0);
            this.panelUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(344, 602);
            this.panelUser.TabIndex = 1;
            this.panelUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUser_MouseDown);
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtDNI.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            this.txtDNI.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDNI.BorderRadius = 0;
            this.txtDNI.BorderSize = 2;
            this.txtDNI.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            this.txtDNI.Location = new System.Drawing.Point(62, 341);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(5);
            this.txtDNI.Multiline = false;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtDNI.PasswordChar = false;
            this.txtDNI.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDNI.PlaceholderText = "Cedula de identidad";
            this.txtDNI.Size = new System.Drawing.Size(250, 56);
            this.txtDNI.TabIndex = 16;
            this.txtDNI.Texts = "";
            this.txtDNI.UnderlinedStyle = true;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            this.txtPhone.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPhone.BorderRadius = 0;
            this.txtPhone.BorderSize = 2;
            this.txtPhone.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            this.txtPhone.Location = new System.Drawing.Point(62, 272);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5);
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtPhone.PasswordChar = false;
            this.txtPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhone.PlaceholderText = "Número de celular ";
            this.txtPhone.Size = new System.Drawing.Size(250, 56);
            this.txtPhone.TabIndex = 15;
            this.txtPhone.Texts = "";
            this.txtPhone.UnderlinedStyle = true;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.btnImage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            this.btnImage.BorderColor2 = System.Drawing.Color.HotPink;
            this.btnImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.btnImage.BorderSize = 0;
            this.btnImage.GradientAngle = 10F;
            this.btnImage.Image = ((System.Drawing.Image)(resources.GetObject("btnImage.Image")));
            this.btnImage.Location = new System.Drawing.Point(222, 65);
            this.btnImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(98, 98);
            this.btnImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnImage.TabIndex = 14;
            this.btnImage.TabStop = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.BorderRadius = 0;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            this.txtEmail.Location = new System.Drawing.Point(62, 204);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(250, 56);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = true;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(170, 533);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            this.btnSubmit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            this.btnSubmit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            this.btnSubmit.BorderRadius = 6;
            this.btnSubmit.BorderSize = 0;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.btnSubmit.Location = new System.Drawing.Point(62, 457);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(245, 37);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassword.BorderRadius = 0;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            this.txtPassword.Location = new System.Drawing.Point(62, 135);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "Contraseña";
            this.txtPassword.Size = new System.Drawing.Size(141, 56);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = true;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            this.txtName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtName.BorderRadius = 0;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(226)))));
            this.txtName.Location = new System.Drawing.Point(62, 65);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "Nombre";
            this.txtName.Size = new System.Drawing.Size(143, 56);
            this.txtName.TabIndex = 6;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 602);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(903, 602);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegister";
            this.panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnClose;
        private RJCodeAdvance.RJControls.RJButton btnSubmit;
        private RJCodeAdvance.RJControls.RJTextBox txtPassword;
        private RJCodeAdvance.RJControls.RJTextBox txtName;
        private RJCodeAdvance.RJControls.RJTextBox txtDNI;
        private RJCodeAdvance.RJControls.RJTextBox txtPhone;
        private RJCodeAdvance.RJControls.RJCircularPictureBox btnImage;
        private RJCodeAdvance.RJControls.RJTextBox txtEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panelUser;
    }
}