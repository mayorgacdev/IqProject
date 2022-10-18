namespace EconomicMF.Forms
{
    partial class FrmOthers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOthers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbTipoDeCalculos = new RJCodeAdvance.RJControls.RJComboBox();
            this.btnAgregar = new RJCodeAdvance.RJControls.RJButton();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTipoAsset = new System.Windows.Forms.Label();
            this.cmbVidaActivosAsset = new RJCodeAdvance.RJControls.RJComboBox();
            this.lblTipoDeMetodoAsset = new System.Windows.Forms.Label();
            this.cmbTipoMetodoAsset = new RJCodeAdvance.RJControls.RJComboBox();
            this.txtVidaUtil = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblAñosComoNiAsset = new System.Windows.Forms.Label();
            this.tglsVidaDeActivoAsset = new RJCodeAdvance.RJControls.RJToggleButton();
            this.lblDepreciaciónAsset = new System.Windows.Forms.Label();
            this.tgDepreciacionAsset = new RJCodeAdvance.RJControls.RJToggleButton();
            this.lblValorResidualAsset = new System.Windows.Forms.Label();
            this.txtValorResidualAsset = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblMontoAsset = new System.Windows.Forms.Label();
            this.txtMontoAsset = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtInteresPrestamoAmrt = new System.Windows.Forms.NumericUpDown();
            this.nupAportacionAmrt = new System.Windows.Forms.NumericUpDown();
            this.lblInteresAmrt = new System.Windows.Forms.Label();
            this.lbMontoAmrt = new System.Windows.Forms.Label();
            this.lblTipoMetodoAmrt = new System.Windows.Forms.Label();
            this.cmbTipoAmortizaciónAmrt = new RJCodeAdvance.RJControls.RJComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblAñoAmrt = new System.Windows.Forms.Label();
            this.txtAñosAmrt = new RJCodeAdvance.RJControls.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new RJCodeAdvance.RJControls.RJTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtgFNE = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.txtNameProject = new RJCodeAdvance.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteresPrestamoAmrt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAportacionAmrt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFNE)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoDeCalculos
            // 
            this.cmbTipoDeCalculos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoDeCalculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.cmbTipoDeCalculos.BorderColor = System.Drawing.Color.White;
            this.cmbTipoDeCalculos.BorderSize = 1;
            this.cmbTipoDeCalculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDeCalculos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTipoDeCalculos.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTipoDeCalculos.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.cmbTipoDeCalculos.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTipoDeCalculos.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTipoDeCalculos.Location = new System.Drawing.Point(77, 54);
            this.cmbTipoDeCalculos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTipoDeCalculos.MinimumSize = new System.Drawing.Size(229, 40);
            this.cmbTipoDeCalculos.Name = "cmbTipoDeCalculos";
            this.cmbTipoDeCalculos.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTipoDeCalculos.Size = new System.Drawing.Size(759, 40);
            this.cmbTipoDeCalculos.TabIndex = 144;
            this.cmbTipoDeCalculos.Texts = "Tipo de Calculo";
            this.cmbTipoDeCalculos.OnSelectedIndexChanged += new System.EventHandler(this.cmbTipoDeCalculos_OnSelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 0;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(27, 537);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(157, 39);
            this.btnAgregar.TabIndex = 137;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(52, 26);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(132, 132);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 140;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rjCircularPictureBox1);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Location = new System.Drawing.Point(879, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 600);
            this.panel1.TabIndex = 145;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTipoAsset);
            this.panel2.Controls.Add(this.cmbVidaActivosAsset);
            this.panel2.Controls.Add(this.lblTipoDeMetodoAsset);
            this.panel2.Controls.Add(this.cmbTipoMetodoAsset);
            this.panel2.Controls.Add(this.txtVidaUtil);
            this.panel2.Controls.Add(this.lblAñosComoNiAsset);
            this.panel2.Controls.Add(this.tglsVidaDeActivoAsset);
            this.panel2.Controls.Add(this.lblDepreciaciónAsset);
            this.panel2.Controls.Add(this.tgDepreciacionAsset);
            this.panel2.Controls.Add(this.lblValorResidualAsset);
            this.panel2.Controls.Add(this.txtValorResidualAsset);
            this.panel2.Controls.Add(this.lblMontoAsset);
            this.panel2.Controls.Add(this.txtMontoAsset);
            this.panel2.Controls.Add(this.txtInteresPrestamoAmrt);
            this.panel2.Controls.Add(this.nupAportacionAmrt);
            this.panel2.Controls.Add(this.lblInteresAmrt);
            this.panel2.Controls.Add(this.lbMontoAmrt);
            this.panel2.Controls.Add(this.lblTipoMetodoAmrt);
            this.panel2.Controls.Add(this.cmbTipoAmortizaciónAmrt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.lblAñoAmrt);
            this.panel2.Controls.Add(this.txtAñosAmrt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Location = new System.Drawing.Point(52, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 320);
            this.panel2.TabIndex = 146;
            // 
            // lblTipoAsset
            // 
            this.lblTipoAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoAsset.AutoSize = true;
            this.lblTipoAsset.ForeColor = System.Drawing.Color.White;
            this.lblTipoAsset.Location = new System.Drawing.Point(354, 211);
            this.lblTipoAsset.Name = "lblTipoAsset";
            this.lblTipoAsset.Size = new System.Drawing.Size(117, 20);
            this.lblTipoAsset.TabIndex = 250;
            this.lblTipoAsset.Text = "Tipo de metodo";
            // 
            // cmbVidaActivosAsset
            // 
            this.cmbVidaActivosAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVidaActivosAsset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.cmbVidaActivosAsset.BorderColor = System.Drawing.Color.White;
            this.cmbVidaActivosAsset.BorderSize = 1;
            this.cmbVidaActivosAsset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVidaActivosAsset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbVidaActivosAsset.ForeColor = System.Drawing.Color.DimGray;
            this.cmbVidaActivosAsset.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.cmbVidaActivosAsset.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbVidaActivosAsset.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbVidaActivosAsset.Location = new System.Drawing.Point(493, 193);
            this.cmbVidaActivosAsset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbVidaActivosAsset.MinimumSize = new System.Drawing.Size(229, 40);
            this.cmbVidaActivosAsset.Name = "cmbVidaActivosAsset";
            this.cmbVidaActivosAsset.Padding = new System.Windows.Forms.Padding(1);
            this.cmbVidaActivosAsset.Size = new System.Drawing.Size(229, 49);
            this.cmbVidaActivosAsset.TabIndex = 249;
            this.cmbVidaActivosAsset.Texts = "Tipo de metodo";
            // 
            // lblTipoDeMetodoAsset
            // 
            this.lblTipoDeMetodoAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoDeMetodoAsset.AutoSize = true;
            this.lblTipoDeMetodoAsset.ForeColor = System.Drawing.Color.White;
            this.lblTipoDeMetodoAsset.Location = new System.Drawing.Point(354, 272);
            this.lblTipoDeMetodoAsset.Name = "lblTipoDeMetodoAsset";
            this.lblTipoDeMetodoAsset.Size = new System.Drawing.Size(117, 20);
            this.lblTipoDeMetodoAsset.TabIndex = 248;
            this.lblTipoDeMetodoAsset.Text = "Tipo de metodo";
            // 
            // cmbTipoMetodoAsset
            // 
            this.cmbTipoMetodoAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoMetodoAsset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.cmbTipoMetodoAsset.BorderColor = System.Drawing.Color.White;
            this.cmbTipoMetodoAsset.BorderSize = 1;
            this.cmbTipoMetodoAsset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMetodoAsset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTipoMetodoAsset.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTipoMetodoAsset.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.cmbTipoMetodoAsset.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTipoMetodoAsset.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTipoMetodoAsset.Location = new System.Drawing.Point(493, 267);
            this.cmbTipoMetodoAsset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTipoMetodoAsset.MinimumSize = new System.Drawing.Size(229, 40);
            this.cmbTipoMetodoAsset.Name = "cmbTipoMetodoAsset";
            this.cmbTipoMetodoAsset.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTipoMetodoAsset.Size = new System.Drawing.Size(229, 49);
            this.cmbTipoMetodoAsset.TabIndex = 247;
            this.cmbTipoMetodoAsset.Texts = "Tipo de metodo";
            // 
            // txtVidaUtil
            // 
            this.txtVidaUtil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVidaUtil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtVidaUtil.BorderColor = System.Drawing.Color.White;
            this.txtVidaUtil.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtVidaUtil.BorderRadius = 0;
            this.txtVidaUtil.BorderSize = 2;
            this.txtVidaUtil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVidaUtil.ForeColor = System.Drawing.Color.White;
            this.txtVidaUtil.Location = new System.Drawing.Point(493, 202);
            this.txtVidaUtil.Margin = new System.Windows.Forms.Padding(5);
            this.txtVidaUtil.Multiline = false;
            this.txtVidaUtil.Name = "txtVidaUtil";
            this.txtVidaUtil.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtVidaUtil.PasswordChar = false;
            this.txtVidaUtil.PlaceholderColor = System.Drawing.Color.White;
            this.txtVidaUtil.PlaceholderText = "Vida util";
            this.txtVidaUtil.Size = new System.Drawing.Size(229, 39);
            this.txtVidaUtil.TabIndex = 246;
            this.txtVidaUtil.Texts = "";
            this.txtVidaUtil.UnderlinedStyle = true;
            // 
            // lblAñosComoNiAsset
            // 
            this.lblAñosComoNiAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAñosComoNiAsset.AutoSize = true;
            this.lblAñosComoNiAsset.ForeColor = System.Drawing.Color.White;
            this.lblAñosComoNiAsset.Location = new System.Drawing.Point(354, 125);
            this.lblAñosComoNiAsset.Name = "lblAñosComoNiAsset";
            this.lblAñosComoNiAsset.Size = new System.Drawing.Size(123, 20);
            this.lblAñosComoNiAsset.TabIndex = 245;
            this.lblAñosComoNiAsset.Text = "Años como en Ni";
            // 
            // tglsVidaDeActivoAsset
            // 
            this.tglsVidaDeActivoAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tglsVidaDeActivoAsset.AutoSize = true;
            this.tglsVidaDeActivoAsset.Location = new System.Drawing.Point(488, 125);
            this.tglsVidaDeActivoAsset.MinimumSize = new System.Drawing.Size(45, 22);
            this.tglsVidaDeActivoAsset.Name = "tglsVidaDeActivoAsset";
            this.tglsVidaDeActivoAsset.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(120)))));
            this.tglsVidaDeActivoAsset.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tglsVidaDeActivoAsset.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tglsVidaDeActivoAsset.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tglsVidaDeActivoAsset.Size = new System.Drawing.Size(45, 22);
            this.tglsVidaDeActivoAsset.TabIndex = 244;
            this.tglsVidaDeActivoAsset.UseVisualStyleBackColor = true;
            // 
            // lblDepreciaciónAsset
            // 
            this.lblDepreciaciónAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepreciaciónAsset.AutoSize = true;
            this.lblDepreciaciónAsset.ForeColor = System.Drawing.Color.White;
            this.lblDepreciaciónAsset.Location = new System.Drawing.Point(555, 127);
            this.lblDepreciaciónAsset.Name = "lblDepreciaciónAsset";
            this.lblDepreciaciónAsset.Size = new System.Drawing.Size(97, 20);
            this.lblDepreciaciónAsset.TabIndex = 243;
            this.lblDepreciaciónAsset.Text = "Depreciación";
            // 
            // tgDepreciacionAsset
            // 
            this.tgDepreciacionAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tgDepreciacionAsset.AutoSize = true;
            this.tgDepreciacionAsset.Location = new System.Drawing.Point(667, 127);
            this.tgDepreciacionAsset.MinimumSize = new System.Drawing.Size(45, 22);
            this.tgDepreciacionAsset.Name = "tgDepreciacionAsset";
            this.tgDepreciacionAsset.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(120)))));
            this.tgDepreciacionAsset.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgDepreciacionAsset.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tgDepreciacionAsset.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgDepreciacionAsset.Size = new System.Drawing.Size(45, 22);
            this.tgDepreciacionAsset.TabIndex = 242;
            this.tgDepreciacionAsset.UseVisualStyleBackColor = true;
            // 
            // lblValorResidualAsset
            // 
            this.lblValorResidualAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorResidualAsset.AutoSize = true;
            this.lblValorResidualAsset.ForeColor = System.Drawing.Color.White;
            this.lblValorResidualAsset.Location = new System.Drawing.Point(33, 251);
            this.lblValorResidualAsset.Name = "lblValorResidualAsset";
            this.lblValorResidualAsset.Size = new System.Drawing.Size(99, 20);
            this.lblValorResidualAsset.TabIndex = 241;
            this.lblValorResidualAsset.Text = "Valor residual";
            // 
            // txtValorResidualAsset
            // 
            this.txtValorResidualAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorResidualAsset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtValorResidualAsset.BorderColor = System.Drawing.Color.White;
            this.txtValorResidualAsset.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtValorResidualAsset.BorderRadius = 0;
            this.txtValorResidualAsset.BorderSize = 2;
            this.txtValorResidualAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorResidualAsset.ForeColor = System.Drawing.Color.White;
            this.txtValorResidualAsset.Location = new System.Drawing.Point(25, 272);
            this.txtValorResidualAsset.Margin = new System.Windows.Forms.Padding(5);
            this.txtValorResidualAsset.Multiline = false;
            this.txtValorResidualAsset.Name = "txtValorResidualAsset";
            this.txtValorResidualAsset.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtValorResidualAsset.PasswordChar = false;
            this.txtValorResidualAsset.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtValorResidualAsset.PlaceholderText = "Valor residual";
            this.txtValorResidualAsset.Size = new System.Drawing.Size(261, 39);
            this.txtValorResidualAsset.TabIndex = 240;
            this.txtValorResidualAsset.Texts = "";
            this.txtValorResidualAsset.UnderlinedStyle = true;
            // 
            // lblMontoAsset
            // 
            this.lblMontoAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMontoAsset.AutoSize = true;
            this.lblMontoAsset.ForeColor = System.Drawing.Color.White;
            this.lblMontoAsset.Location = new System.Drawing.Point(33, 102);
            this.lblMontoAsset.Name = "lblMontoAsset";
            this.lblMontoAsset.Size = new System.Drawing.Size(53, 20);
            this.lblMontoAsset.TabIndex = 239;
            this.lblMontoAsset.Text = "Monto";
            // 
            // txtMontoAsset
            // 
            this.txtMontoAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMontoAsset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtMontoAsset.BorderColor = System.Drawing.Color.White;
            this.txtMontoAsset.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMontoAsset.BorderRadius = 0;
            this.txtMontoAsset.BorderSize = 2;
            this.txtMontoAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMontoAsset.ForeColor = System.Drawing.Color.White;
            this.txtMontoAsset.Location = new System.Drawing.Point(25, 125);
            this.txtMontoAsset.Margin = new System.Windows.Forms.Padding(5);
            this.txtMontoAsset.Multiline = false;
            this.txtMontoAsset.Name = "txtMontoAsset";
            this.txtMontoAsset.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtMontoAsset.PasswordChar = false;
            this.txtMontoAsset.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtMontoAsset.PlaceholderText = "Monto";
            this.txtMontoAsset.Size = new System.Drawing.Size(261, 39);
            this.txtMontoAsset.TabIndex = 238;
            this.txtMontoAsset.Texts = "";
            this.txtMontoAsset.UnderlinedStyle = true;
            // 
            // txtInteresPrestamoAmrt
            // 
            this.txtInteresPrestamoAmrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtInteresPrestamoAmrt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInteresPrestamoAmrt.ForeColor = System.Drawing.Color.White;
            this.txtInteresPrestamoAmrt.Location = new System.Drawing.Point(333, 248);
            this.txtInteresPrestamoAmrt.Name = "txtInteresPrestamoAmrt";
            this.txtInteresPrestamoAmrt.Size = new System.Drawing.Size(384, 23);
            this.txtInteresPrestamoAmrt.TabIndex = 237;
            // 
            // nupAportacionAmrt
            // 
            this.nupAportacionAmrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.nupAportacionAmrt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupAportacionAmrt.ForeColor = System.Drawing.Color.White;
            this.nupAportacionAmrt.Location = new System.Drawing.Point(333, 172);
            this.nupAportacionAmrt.Name = "nupAportacionAmrt";
            this.nupAportacionAmrt.Size = new System.Drawing.Size(384, 23);
            this.nupAportacionAmrt.TabIndex = 236;
            // 
            // lblInteresAmrt
            // 
            this.lblInteresAmrt.AutoSize = true;
            this.lblInteresAmrt.ForeColor = System.Drawing.Color.White;
            this.lblInteresAmrt.Location = new System.Drawing.Point(357, 211);
            this.lblInteresAmrt.Name = "lblInteresAmrt";
            this.lblInteresAmrt.Size = new System.Drawing.Size(53, 20);
            this.lblInteresAmrt.TabIndex = 234;
            this.lblInteresAmrt.Text = "Interés";
            // 
            // lbMontoAmrt
            // 
            this.lbMontoAmrt.AutoSize = true;
            this.lbMontoAmrt.ForeColor = System.Drawing.Color.White;
            this.lbMontoAmrt.Location = new System.Drawing.Point(344, 133);
            this.lbMontoAmrt.Name = "lbMontoAmrt";
            this.lbMontoAmrt.Size = new System.Drawing.Size(177, 20);
            this.lbMontoAmrt.TabIndex = 233;
            this.lbMontoAmrt.Text = "Monto de prestamo en %";
            // 
            // lblTipoMetodoAmrt
            // 
            this.lblTipoMetodoAmrt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoMetodoAmrt.AutoSize = true;
            this.lblTipoMetodoAmrt.ForeColor = System.Drawing.Color.White;
            this.lblTipoMetodoAmrt.Location = new System.Drawing.Point(349, 62);
            this.lblTipoMetodoAmrt.Name = "lblTipoMetodoAmrt";
            this.lblTipoMetodoAmrt.Size = new System.Drawing.Size(117, 20);
            this.lblTipoMetodoAmrt.TabIndex = 232;
            this.lblTipoMetodoAmrt.Text = "Tipo de metodo";
            // 
            // cmbTipoAmortizaciónAmrt
            // 
            this.cmbTipoAmortizaciónAmrt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoAmortizaciónAmrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.cmbTipoAmortizaciónAmrt.BorderColor = System.Drawing.Color.White;
            this.cmbTipoAmortizaciónAmrt.BorderSize = 1;
            this.cmbTipoAmortizaciónAmrt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAmortizaciónAmrt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTipoAmortizaciónAmrt.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTipoAmortizaciónAmrt.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.cmbTipoAmortizaciónAmrt.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTipoAmortizaciónAmrt.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTipoAmortizaciónAmrt.Location = new System.Drawing.Point(488, 40);
            this.cmbTipoAmortizaciónAmrt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTipoAmortizaciónAmrt.MinimumSize = new System.Drawing.Size(229, 40);
            this.cmbTipoAmortizaciónAmrt.Name = "cmbTipoAmortizaciónAmrt";
            this.cmbTipoAmortizaciónAmrt.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTipoAmortizaciónAmrt.Size = new System.Drawing.Size(229, 49);
            this.cmbTipoAmortizaciónAmrt.TabIndex = 231;
            this.cmbTipoAmortizaciónAmrt.Texts = "Tipo de metodo";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 225;
            this.label3.Text = "Descripción";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtDescription.BorderColor = System.Drawing.Color.White;
            this.txtDescription.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDescription.BorderRadius = 0;
            this.txtDescription.BorderSize = 2;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(25, 203);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescription.Multiline = false;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtDescription.PasswordChar = false;
            this.txtDescription.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtDescription.PlaceholderText = "Descripción";
            this.txtDescription.Size = new System.Drawing.Size(261, 39);
            this.txtDescription.TabIndex = 223;
            this.txtDescription.Texts = "";
            this.txtDescription.UnderlinedStyle = true;
            // 
            // lblAñoAmrt
            // 
            this.lblAñoAmrt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAñoAmrt.AutoSize = true;
            this.lblAñoAmrt.ForeColor = System.Drawing.Color.White;
            this.lblAñoAmrt.Location = new System.Drawing.Point(33, 102);
            this.lblAñoAmrt.Name = "lblAñoAmrt";
            this.lblAñoAmrt.Size = new System.Drawing.Size(42, 20);
            this.lblAñoAmrt.TabIndex = 222;
            this.lblAñoAmrt.Text = "Años";
            // 
            // txtAñosAmrt
            // 
            this.txtAñosAmrt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAñosAmrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtAñosAmrt.BorderColor = System.Drawing.Color.White;
            this.txtAñosAmrt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAñosAmrt.BorderRadius = 0;
            this.txtAñosAmrt.BorderSize = 2;
            this.txtAñosAmrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAñosAmrt.ForeColor = System.Drawing.Color.White;
            this.txtAñosAmrt.Location = new System.Drawing.Point(25, 125);
            this.txtAñosAmrt.Margin = new System.Windows.Forms.Padding(5);
            this.txtAñosAmrt.Multiline = false;
            this.txtAñosAmrt.Name = "txtAñosAmrt";
            this.txtAñosAmrt.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtAñosAmrt.PasswordChar = false;
            this.txtAñosAmrt.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtAñosAmrt.PlaceholderText = "Años";
            this.txtAñosAmrt.Size = new System.Drawing.Size(261, 39);
            this.txtAñosAmrt.TabIndex = 221;
            this.txtAñosAmrt.Texts = "";
            this.txtAñosAmrt.UnderlinedStyle = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 220;
            this.label5.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtName.BorderColor = System.Drawing.Color.White;
            this.txtName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtName.BorderRadius = 0;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(25, 50);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtName.PlaceholderText = "Nombre";
            this.txtName.Size = new System.Drawing.Size(261, 39);
            this.txtName.TabIndex = 219;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(780, 480);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 163;
            this.pictureBox1.TabStop = false;
            // 
            // dtgFNE
            // 
            this.dtgFNE.AllowUserToResizeRows = false;
            this.dtgFNE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgFNE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dtgFNE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgFNE.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgFNE.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dtgFNE.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgFNE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgFNE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgFNE.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgFNE.EnableHeadersVisualStyles = false;
            this.dtgFNE.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgFNE.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.dtgFNE.Location = new System.Drawing.Point(77, 536);
            this.dtgFNE.Name = "dtgFNE";
            this.dtgFNE.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgFNE.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgFNE.RowHeadersWidth = 51;
            this.dtgFNE.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgFNE.RowTemplate.Height = 29;
            this.dtgFNE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgFNE.Size = new System.Drawing.Size(756, 212);
            this.dtgFNE.TabIndex = 162;
            this.dtgFNE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFNE_CellClick);
            // 
            // txtNameProject
            // 
            this.txtNameProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtNameProject.BorderColor = System.Drawing.Color.White;
            this.txtNameProject.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNameProject.BorderRadius = 0;
            this.txtNameProject.BorderSize = 2;
            this.txtNameProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNameProject.ForeColor = System.Drawing.Color.White;
            this.txtNameProject.Location = new System.Drawing.Point(88, 480);
            this.txtNameProject.Margin = new System.Windows.Forms.Padding(5);
            this.txtNameProject.Multiline = false;
            this.txtNameProject.Name = "txtNameProject";
            this.txtNameProject.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtNameProject.PasswordChar = false;
            this.txtNameProject.PlaceholderColor = System.Drawing.Color.White;
            this.txtNameProject.PlaceholderText = "Buscar entidad";
            this.txtNameProject.Size = new System.Drawing.Size(676, 39);
            this.txtNameProject.TabIndex = 161;
            this.txtNameProject.Texts = "";
            this.txtNameProject.UnderlinedStyle = true;
            // 
            // FrmOthers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1165, 776);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtgFNE);
            this.Controls.Add(this.txtNameProject);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbTipoDeCalculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOthers";
            this.Text = "s";
            this.Load += new System.EventHandler(this.FrmOthers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteresPrestamoAmrt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAportacionAmrt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFNE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RJCodeAdvance.RJControls.RJComboBox cmbTipoDeCalculos;
        private RJCodeAdvance.RJControls.RJButton btnAgregar;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.PoisonDataGridView dtgFNE;
        private RJCodeAdvance.RJControls.RJTextBox txtNameProject;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJTextBox txtDescription;
        private System.Windows.Forms.Label lblAñoAmrt;
        private System.Windows.Forms.Label label5;
        private RJCodeAdvance.RJControls.RJTextBox txtName;
        private System.Windows.Forms.Label lblTipoMetodoAmrt;
        private RJCodeAdvance.RJControls.RJComboBox cmbTipoAmortizaciónAmrt;
        private System.Windows.Forms.NumericUpDown txtInteresPrestamoAmrt;
        private System.Windows.Forms.NumericUpDown nupAportacionAmrt;
        private System.Windows.Forms.Label lblInteresAmrt;
        private System.Windows.Forms.Label lbMontoAmrt;
        private RJCodeAdvance.RJControls.RJTextBox txtAñosAmrt;
        private System.Windows.Forms.Label lblTipoAsset;
        private RJCodeAdvance.RJControls.RJComboBox cmbVidaActivosAsset;
        private System.Windows.Forms.Label lblTipoDeMetodoAsset;
        private RJCodeAdvance.RJControls.RJComboBox cmbTipoMetodoAsset;
        private RJCodeAdvance.RJControls.RJTextBox txtVidaUtil;
        private System.Windows.Forms.Label lblAñosComoNiAsset;
        private RJCodeAdvance.RJControls.RJToggleButton tglsVidaDeActivoAsset;
        private System.Windows.Forms.Label lblDepreciaciónAsset;
        private RJCodeAdvance.RJControls.RJToggleButton tgDepreciacionAsset;
        private System.Windows.Forms.Label lblValorResidualAsset;
        private RJCodeAdvance.RJControls.RJTextBox txtValorResidualAsset;
        private System.Windows.Forms.Label lblMontoAsset;
        private RJCodeAdvance.RJControls.RJTextBox txtMontoAsset;
    }
}