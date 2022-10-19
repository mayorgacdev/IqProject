namespace EconomicMF.Forms
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnInversor = new RJCodeAdvance.RJControls.RJButton();
            this.btnOthers = new RJCodeAdvance.RJControls.RJButton();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnGestionar = new RJCodeAdvance.RJControls.RJButton();
            this.btnReporte = new RJCodeAdvance.RJControls.RJButton();
            this.btnProjects = new RJCodeAdvance.RJControls.RJButton();
            this.btnDashBoard = new RJCodeAdvance.RJControls.RJButton();
            this.panelUser = new System.Windows.Forms.Panel();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.pbImageProfileUser = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.panelOpen = new System.Windows.Forms.Panel();
            this.dtTIme = new System.Windows.Forms.Timer(this.components);
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageProfileUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panelButtons.Controls.Add(this.btnInversor);
            this.panelButtons.Controls.Add(this.btnOthers);
            this.panelButtons.Controls.Add(this.btnMenu);
            this.panelButtons.Controls.Add(this.pbLogo);
            this.panelButtons.Controls.Add(this.btnClose);
            this.panelButtons.Controls.Add(this.btnGestionar);
            this.panelButtons.Controls.Add(this.btnReporte);
            this.panelButtons.Controls.Add(this.btnProjects);
            this.panelButtons.Controls.Add(this.btnDashBoard);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(200, 905);
            this.panelButtons.TabIndex = 5;
            this.panelButtons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnInversor
            // 
            this.btnInversor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInversor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnInversor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnInversor.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInversor.BorderRadius = 0;
            this.btnInversor.BorderSize = 0;
            this.btnInversor.FlatAppearance.BorderSize = 0;
            this.btnInversor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInversor.ForeColor = System.Drawing.Color.White;
            this.btnInversor.Image = ((System.Drawing.Image)(resources.GetObject("btnInversor.Image")));
            this.btnInversor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInversor.Location = new System.Drawing.Point(0, 427);
            this.btnInversor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInversor.Name = "btnInversor";
            this.btnInversor.Size = new System.Drawing.Size(200, 54);
            this.btnInversor.TabIndex = 16;
            this.btnInversor.Text = "Config. Proyecto";
            this.btnInversor.TextColor = System.Drawing.Color.White;
            this.btnInversor.UseVisualStyleBackColor = false;
            this.btnInversor.Click += new System.EventHandler(this.btnInversor_Click);
            // 
            // btnOthers
            // 
            this.btnOthers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOthers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnOthers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnOthers.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOthers.BorderRadius = 0;
            this.btnOthers.BorderSize = 0;
            this.btnOthers.FlatAppearance.BorderSize = 0;
            this.btnOthers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOthers.ForeColor = System.Drawing.Color.White;
            this.btnOthers.Image = ((System.Drawing.Image)(resources.GetObject("btnOthers.Image")));
            this.btnOthers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOthers.Location = new System.Drawing.Point(0, 612);
            this.btnOthers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOthers.Name = "btnOthers";
            this.btnOthers.Size = new System.Drawing.Size(200, 53);
            this.btnOthers.TabIndex = 15;
            this.btnOthers.Text = "Otro";
            this.btnOthers.TextColor = System.Drawing.Color.White;
            this.btnOthers.UseVisualStyleBackColor = false;
            this.btnOthers.Click += new System.EventHandler(this.btnOthers_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(159, 4);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(38, 46);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 14;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(14, 85);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(180, 149);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 13;
            this.pbLogo.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(83, 825);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 50);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 12;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_2);
            // 
            // btnGestionar
            // 
            this.btnGestionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGestionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnGestionar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnGestionar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGestionar.BorderRadius = 0;
            this.btnGestionar.BorderSize = 0;
            this.btnGestionar.FlatAppearance.BorderSize = 0;
            this.btnGestionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionar.ForeColor = System.Drawing.Color.White;
            this.btnGestionar.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionar.Image")));
            this.btnGestionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionar.Location = new System.Drawing.Point(0, 551);
            this.btnGestionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGestionar.Name = "btnGestionar";
            this.btnGestionar.Size = new System.Drawing.Size(200, 53);
            this.btnGestionar.TabIndex = 4;
            this.btnGestionar.Text = "Herramientas";
            this.btnGestionar.TextColor = System.Drawing.Color.White;
            this.btnGestionar.UseVisualStyleBackColor = false;
            this.btnGestionar.Click += new System.EventHandler(this.btnGestionar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnReporte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnReporte.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReporte.BorderRadius = 0;
            this.btnReporte.BorderSize = 0;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporte.Location = new System.Drawing.Point(0, 489);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(200, 54);
            this.btnReporte.TabIndex = 3;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.TextColor = System.Drawing.Color.White;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnProjects
            // 
            this.btnProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnProjects.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnProjects.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnProjects.BorderRadius = 0;
            this.btnProjects.BorderSize = 0;
            this.btnProjects.FlatAppearance.BorderSize = 0;
            this.btnProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjects.ForeColor = System.Drawing.Color.White;
            this.btnProjects.Image = ((System.Drawing.Image)(resources.GetObject("btnProjects.Image")));
            this.btnProjects.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProjects.Location = new System.Drawing.Point(0, 366);
            this.btnProjects.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(197, 53);
            this.btnProjects.TabIndex = 1;
            this.btnProjects.Text = "Proyectos";
            this.btnProjects.TextColor = System.Drawing.Color.White;
            this.btnProjects.UseVisualStyleBackColor = false;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnDashBoard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnDashBoard.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDashBoard.BorderRadius = 0;
            this.btnDashBoard.BorderSize = 0;
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashBoard.Image")));
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashBoard.Location = new System.Drawing.Point(0, 305);
            this.btnDashBoard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(197, 53);
            this.btnDashBoard.TabIndex = 0;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.TextColor = System.Drawing.Color.White;
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panelUser.Controls.Add(this.labelFecha);
            this.panelUser.Controls.Add(this.labelHora);
            this.panelUser.Controls.Add(this.lblPhoneNumber);
            this.panelUser.Controls.Add(this.lblEmail);
            this.panelUser.Controls.Add(this.lblUserLogin);
            this.panelUser.Controls.Add(this.pbImageProfileUser);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUser.Location = new System.Drawing.Point(200, 776);
            this.panelUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(1165, 129);
            this.panelUser.TabIndex = 9;
            this.panelUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            // 
            // labelFecha
            // 
            this.labelFecha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFecha.AutoSize = true;
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(907, 95);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(175, 20);
            this.labelFecha.TabIndex = 6;
            this.labelFecha.Text = "Paulo José Jirón Mayorga";
            // 
            // labelHora
            // 
            this.labelHora.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHora.ForeColor = System.Drawing.Color.White;
            this.labelHora.Location = new System.Drawing.Point(870, 13);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(253, 81);
            this.labelHora.TabIndex = 5;
            this.labelHora.Text = "21:52:15";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Location = new System.Drawing.Point(104, 75);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(175, 20);
            this.lblPhoneNumber.TabIndex = 3;
            this.lblPhoneNumber.Text = "Paulo José Jirón Mayorga";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(115, 44);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(175, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Paulo José Jirón Mayorga";
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.AutoSize = true;
            this.lblUserLogin.ForeColor = System.Drawing.Color.White;
            this.lblUserLogin.Location = new System.Drawing.Point(103, 12);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(175, 20);
            this.lblUserLogin.TabIndex = 1;
            this.lblUserLogin.Text = "Paulo José Jirón Mayorga";
            // 
            // pbImageProfileUser
            // 
            this.pbImageProfileUser.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbImageProfileUser.BorderColor = System.Drawing.Color.White;
            this.pbImageProfileUser.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbImageProfileUser.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbImageProfileUser.BorderSize = 2;
            this.pbImageProfileUser.GradientAngle = 50F;
            this.pbImageProfileUser.Image = ((System.Drawing.Image)(resources.GetObject("pbImageProfileUser.Image")));
            this.pbImageProfileUser.Location = new System.Drawing.Point(11, 8);
            this.pbImageProfileUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbImageProfileUser.Name = "pbImageProfileUser";
            this.pbImageProfileUser.Size = new System.Drawing.Size(91, 91);
            this.pbImageProfileUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageProfileUser.TabIndex = 0;
            this.pbImageProfileUser.TabStop = false;
            // 
            // panelOpen
            // 
            this.panelOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpen.Location = new System.Drawing.Point(200, 0);
            this.panelOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelOpen.Name = "panelOpen";
            this.panelOpen.Size = new System.Drawing.Size(1165, 776);
            this.panelOpen.TabIndex = 11;
            this.panelOpen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelOpen_MouseDown);
            // 
            // dtTIme
            // 
            this.dtTIme.Enabled = true;
            this.dtTIme.Tick += new System.EventHandler(this.dtTIme_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1365, 905);
            this.Controls.Add(this.panelOpen);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageProfileUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelButtons;
        private RJCodeAdvance.RJControls.RJButton btnGestionar;
        private RJCodeAdvance.RJControls.RJButton btnReporte;
        private RJCodeAdvance.RJControls.RJButton btnProjects;
        private RJCodeAdvance.RJControls.RJButton btnDashBoard;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUserLogin;
        private RJCodeAdvance.RJControls.RJCircularPictureBox pbImageProfileUser;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Panel panelOpen;
        private System.Windows.Forms.Timer dtTIme;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.PictureBox btnMenu;
        private RJCodeAdvance.RJControls.RJButton btnOthers;
        private RJCodeAdvance.RJControls.RJButton btnInversor;
    }
}