namespace EconomicMF.Forms.FormsProject
{
    partial class FrmAddInvestors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddInvestors));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblTMAR = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.txtNameInvestor = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnSiguiente = new RJCodeAdvance.RJControls.RJButton();
            this.lblNameProject = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddInvestor = new RJCodeAdvance.RJControls.RJButton();
            this.txtEmail = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.dtgvData = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTmarProject = new System.Windows.Forms.Label();
            this.cmbAmortización = new RJCodeAdvance.RJControls.RJComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultTMAR = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nupAportacionUser = new System.Windows.Forms.NumericUpDown();
            this.txtInteresPrestamo = new System.Windows.Forms.NumericUpDown();
            this.txtSumTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAportacionUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteresPrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 48);
            this.panel1.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1082, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(26, 31);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 18;
            this.btnMinimize.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1115, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 31);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 17;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTMAR
            // 
            this.lblTMAR.AutoSize = true;
            this.lblTMAR.ForeColor = System.Drawing.Color.White;
            this.lblTMAR.Location = new System.Drawing.Point(90, 380);
            this.lblTMAR.Name = "lblTMAR";
            this.lblTMAR.Size = new System.Drawing.Size(53, 20);
            this.lblTMAR.TabIndex = 40;
            this.lblTMAR.Text = "Interés";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(219, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Monto de prestamo en %";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.ForeColor = System.Drawing.Color.White;
            this.lblPeriodo.Location = new System.Drawing.Point(284, 234);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(52, 20);
            this.lblPeriodo.TabIndex = 38;
            this.lblPeriodo.Text = "E-Mail";
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.ForeColor = System.Drawing.Color.White;
            this.lbldescription.Location = new System.Drawing.Point(250, 151);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(49, 20);
            this.lbldescription.TabIndex = 37;
            this.lbldescription.Text = "Name";
            // 
            // txtNameInvestor
            // 
            this.txtNameInvestor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtNameInvestor.BorderColor = System.Drawing.Color.White;
            this.txtNameInvestor.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNameInvestor.BorderRadius = 0;
            this.txtNameInvestor.BorderSize = 2;
            this.txtNameInvestor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNameInvestor.ForeColor = System.Drawing.Color.White;
            this.txtNameInvestor.Location = new System.Drawing.Point(260, 176);
            this.txtNameInvestor.Margin = new System.Windows.Forms.Padding(5);
            this.txtNameInvestor.Multiline = false;
            this.txtNameInvestor.Name = "txtNameInvestor";
            this.txtNameInvestor.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtNameInvestor.PasswordChar = false;
            this.txtNameInvestor.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtNameInvestor.PlaceholderText = "Name";
            this.txtNameInvestor.Size = new System.Drawing.Size(460, 39);
            this.txtNameInvestor.TabIndex = 27;
            this.txtNameInvestor.Texts = "";
            this.txtNameInvestor.UnderlinedStyle = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnSiguiente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnSiguiente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSiguiente.BorderRadius = 0;
            this.btnSiguiente.BorderSize = 0;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(584, 622);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(120, 41);
            this.btnSiguiente.TabIndex = 41;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.TextColor = System.Drawing.Color.White;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Visible = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblNameProject
            // 
            this.lblNameProject.AutoSize = true;
            this.lblNameProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameProject.ForeColor = System.Drawing.Color.White;
            this.lblNameProject.Location = new System.Drawing.Point(321, 52);
            this.lblNameProject.Name = "lblNameProject";
            this.lblNameProject.Size = new System.Drawing.Size(203, 31);
            this.lblNameProject.TabIndex = 49;
            this.lblNameProject.Text = "<NameProject>";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(673, 51);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(47, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 48;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(639, 51);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(47, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 47;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(602, 51);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(47, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 46;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(567, 51);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(47, 32);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 45;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(530, 51);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(47, 32);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 44;
            this.pictureBox10.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 31);
            this.label3.TabIndex = 43;
            this.label3.Text = "Agregar financiamiento";
            // 
            // btnAddInvestor
            // 
            this.btnAddInvestor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnAddInvestor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnAddInvestor.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddInvestor.BorderRadius = 0;
            this.btnAddInvestor.BorderSize = 0;
            this.btnAddInvestor.FlatAppearance.BorderSize = 0;
            this.btnAddInvestor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInvestor.ForeColor = System.Drawing.Color.White;
            this.btnAddInvestor.Location = new System.Drawing.Point(454, 622);
            this.btnAddInvestor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddInvestor.Name = "btnAddInvestor";
            this.btnAddInvestor.Size = new System.Drawing.Size(123, 41);
            this.btnAddInvestor.TabIndex = 54;
            this.btnAddInvestor.Text = "Add";
            this.btnAddInvestor.TextColor = System.Drawing.Color.White;
            this.btnAddInvestor.UseVisualStyleBackColor = false;
            this.btnAddInvestor.Click += new System.EventHandler(this.btnAddInvestor_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtEmail.BorderColor = System.Drawing.Color.White;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.BorderRadius = 0;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(260, 259);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtEmail.PlaceholderText = "E-Mail";
            this.txtEmail.Size = new System.Drawing.Size(460, 39);
            this.txtEmail.TabIndex = 55;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = true;
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("rjCircularPictureBox1.Image")));
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(71, 167);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(167, 167);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 58;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // dtgvData
            // 
            this.dtgvData.AllowUserToResizeRows = false;
            this.dtgvData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.dtgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvData.EnableHeadersVisualStyles = false;
            this.dtgvData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgvData.Location = new System.Drawing.Point(785, 157);
            this.dtgvData.MultiSelect = false;
            this.dtgvData.Name = "dtgvData";
            this.dtgvData.ReadOnly = true;
            this.dtgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvData.RowHeadersWidth = 20;
            this.dtgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvData.RowTemplate.Height = 29;
            this.dtgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvData.Size = new System.Drawing.Size(323, 466);
            this.dtgvData.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "TMAR:";
            // 
            // lblTmarProject
            // 
            this.lblTmarProject.AutoSize = true;
            this.lblTmarProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTmarProject.ForeColor = System.Drawing.Color.White;
            this.lblTmarProject.Location = new System.Drawing.Point(152, 104);
            this.lblTmarProject.Name = "lblTmarProject";
            this.lblTmarProject.Size = new System.Drawing.Size(80, 25);
            this.lblTmarProject.TabIndex = 65;
            this.lblTmarProject.Text = "TMAR: ";
            // 
            // cmbAmortización
            // 
            this.cmbAmortización.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.cmbAmortización.BorderColor = System.Drawing.Color.White;
            this.cmbAmortización.BorderSize = 1;
            this.cmbAmortización.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAmortización.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbAmortización.ForeColor = System.Drawing.Color.DimGray;
            this.cmbAmortización.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.cmbAmortización.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbAmortización.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbAmortización.Location = new System.Drawing.Point(79, 490);
            this.cmbAmortización.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbAmortización.MinimumSize = new System.Drawing.Size(229, 40);
            this.cmbAmortización.Name = "cmbAmortización";
            this.cmbAmortización.Padding = new System.Windows.Forms.Padding(1);
            this.cmbAmortización.Size = new System.Drawing.Size(638, 48);
            this.cmbAmortización.TabIndex = 66;
            this.cmbAmortización.Texts = "Tipo de amortización";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(90, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Tipo de amortización";
            // 
            // lblResultTMAR
            // 
            this.lblResultTMAR.AutoSize = true;
            this.lblResultTMAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultTMAR.ForeColor = System.Drawing.Color.White;
            this.lblResultTMAR.Location = new System.Drawing.Point(832, 104);
            this.lblResultTMAR.Name = "lblResultTMAR";
            this.lblResultTMAR.Size = new System.Drawing.Size(120, 25);
            this.lblResultTMAR.TabIndex = 69;
            this.lblResultTMAR.Text = "esperando...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(700, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 68;
            this.label6.Text = "TMAR mixta:";
            // 
            // nupAportacionUser
            // 
            this.nupAportacionUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.nupAportacionUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupAportacionUser.ForeColor = System.Drawing.Color.White;
            this.nupAportacionUser.Location = new System.Drawing.Point(208, 349);
            this.nupAportacionUser.Name = "nupAportacionUser";
            this.nupAportacionUser.Size = new System.Drawing.Size(450, 23);
            this.nupAportacionUser.TabIndex = 71;
            // 
            // txtInteresPrestamo
            // 
            this.txtInteresPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtInteresPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInteresPrestamo.ForeColor = System.Drawing.Color.White;
            this.txtInteresPrestamo.Location = new System.Drawing.Point(79, 418);
            this.txtInteresPrestamo.Name = "txtInteresPrestamo";
            this.txtInteresPrestamo.Size = new System.Drawing.Size(641, 23);
            this.txtInteresPrestamo.TabIndex = 72;
            // 
            // txtSumTotal
            // 
            this.txtSumTotal.AutoSize = true;
            this.txtSumTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSumTotal.ForeColor = System.Drawing.Color.White;
            this.txtSumTotal.Location = new System.Drawing.Point(664, 350);
            this.txtSumTotal.Name = "txtSumTotal";
            this.txtSumTotal.Size = new System.Drawing.Size(56, 20);
            this.txtSumTotal.TabIndex = 73;
            this.txtSumTotal.Text = "100 %";
            // 
            // FrmAddInvestors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1145, 730);
            this.Controls.Add(this.txtSumTotal);
            this.Controls.Add(this.txtInteresPrestamo);
            this.Controls.Add(this.nupAportacionUser);
            this.Controls.Add(this.lblResultTMAR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAmortización);
            this.Controls.Add(this.lblTmarProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvData);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnAddInvestor);
            this.Controls.Add(this.lblNameProject);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblTMAR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.txtNameInvestor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAddInvestors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddInvestors";
            this.Load += new System.EventHandler(this.FrmAddInvestors_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmAddInvestors_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAportacionUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteresPrestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTMAR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lbldescription;
        private RJCodeAdvance.RJControls.RJTextBox txtNameInvestor;
        private RJCodeAdvance.RJControls.RJButton btnSiguiente;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblNameProject;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJButton btnAddInvestor;
        private RJCodeAdvance.RJControls.RJTextBox txtEmail;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private ReaLTaiizor.Controls.PoisonDataGridView dtgvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTmarProject;
        private RJCodeAdvance.RJControls.RJComboBox cmbAmortización;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultTMAR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nupAportacionUser;
        private System.Windows.Forms.NumericUpDown txtInteresPrestamo;
        private System.Windows.Forms.Label txtSumTotal;
    }
}