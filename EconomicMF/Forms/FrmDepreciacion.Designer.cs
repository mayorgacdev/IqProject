namespace EconomicMF.Forms
{
    partial class FrmDepreciacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepreciacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExport = new RJCodeAdvance.RJControls.RJButton();
            this.btnEliminar = new RJCodeAdvance.RJControls.RJButton();
            this.btnAgregar = new RJCodeAdvance.RJControls.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgFNE = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.btnFind = new System.Windows.Forms.PictureBox();
            this.txtSearchAsset = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblTipoDeMetodo = new System.Windows.Forms.Label();
            this.cmbVidaActivos = new RJCodeAdvance.RJControls.RJComboBox();
            this.cmbTipoMetodo = new RJCodeAdvance.RJControls.RJComboBox();
            this.txtVidaUtil = new RJCodeAdvance.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tglsVidaDeActivo = new RJCodeAdvance.RJControls.RJToggleButton();
            this.lblDepreciación = new System.Windows.Forms.Label();
            this.tgDepreciacion = new RJCodeAdvance.RJControls.RJToggleButton();
            this.lblValorResidual = new System.Windows.Forms.Label();
            this.txtValorResidual = new RJCodeAdvance.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtName = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtMonto = new RJCodeAdvance.RJControls.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFNE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Location = new System.Drawing.Point(955, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 631);
            this.panel1.TabIndex = 171;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 161;
            this.pictureBox1.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnExport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnExport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExport.BorderRadius = 5;
            this.btnExport.BorderSize = 0;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.Location = new System.Drawing.Point(31, 510);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(159, 39);
            this.btnExport.TabIndex = 160;
            this.btnExport.Text = "Exportar E/P";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.TextColor = System.Drawing.Color.White;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BorderRadius = 0;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(31, 557);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(159, 39);
            this.btnEliminar.TabIndex = 159;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnAgregar.Location = new System.Drawing.Point(28, 463);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(159, 39);
            this.btnAgregar.TabIndex = 158;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.Controls.Add(this.dtgFNE);
            this.panel2.Controls.Add(this.btnFind);
            this.panel2.Controls.Add(this.txtSearchAsset);
            this.panel2.Controls.Add(this.lblTipoDeMetodo);
            this.panel2.Controls.Add(this.cmbVidaActivos);
            this.panel2.Controls.Add(this.cmbTipoMetodo);
            this.panel2.Controls.Add(this.txtVidaUtil);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tglsVidaDeActivo);
            this.panel2.Controls.Add(this.lblDepreciación);
            this.panel2.Controls.Add(this.tgDepreciacion);
            this.panel2.Controls.Add(this.lblValorResidual);
            this.panel2.Controls.Add(this.txtValorResidual);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.txtMonto);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.rjCircularPictureBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 631);
            this.panel2.TabIndex = 172;
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
            this.dtgFNE.Location = new System.Drawing.Point(38, 474);
            this.dtgFNE.MultiSelect = false;
            this.dtgFNE.Name = "dtgFNE";
            this.dtgFNE.ReadOnly = true;
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
            this.dtgFNE.Size = new System.Drawing.Size(879, 136);
            this.dtgFNE.TabIndex = 218;
            this.dtgFNE.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFNE_CellDoubleClick);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(881, 416);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(36, 38);
            this.btnFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFind.TabIndex = 210;
            this.btnFind.TabStop = false;
            // 
            // txtSearchAsset
            // 
            this.txtSearchAsset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchAsset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtSearchAsset.BorderColor = System.Drawing.Color.White;
            this.txtSearchAsset.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSearchAsset.BorderRadius = 0;
            this.txtSearchAsset.BorderSize = 2;
            this.txtSearchAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchAsset.ForeColor = System.Drawing.Color.White;
            this.txtSearchAsset.Location = new System.Drawing.Point(53, 415);
            this.txtSearchAsset.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchAsset.Multiline = false;
            this.txtSearchAsset.Name = "txtSearchAsset";
            this.txtSearchAsset.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtSearchAsset.PasswordChar = false;
            this.txtSearchAsset.PlaceholderColor = System.Drawing.Color.White;
            this.txtSearchAsset.PlaceholderText = "Buscar activo";
            this.txtSearchAsset.Size = new System.Drawing.Size(820, 39);
            this.txtSearchAsset.TabIndex = 208;
            this.txtSearchAsset.Texts = "";
            this.txtSearchAsset.UnderlinedStyle = true;
            // 
            // lblTipoDeMetodo
            // 
            this.lblTipoDeMetodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoDeMetodo.AutoSize = true;
            this.lblTipoDeMetodo.ForeColor = System.Drawing.Color.White;
            this.lblTipoDeMetodo.Location = new System.Drawing.Point(653, 303);
            this.lblTipoDeMetodo.Name = "lblTipoDeMetodo";
            this.lblTipoDeMetodo.Size = new System.Drawing.Size(117, 20);
            this.lblTipoDeMetodo.TabIndex = 207;
            this.lblTipoDeMetodo.Text = "Tipo de metodo";
            // 
            // cmbVidaActivos
            // 
            this.cmbVidaActivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVidaActivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.cmbVidaActivos.BorderColor = System.Drawing.Color.White;
            this.cmbVidaActivos.BorderSize = 1;
            this.cmbVidaActivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVidaActivos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbVidaActivos.ForeColor = System.Drawing.Color.DimGray;
            this.cmbVidaActivos.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.cmbVidaActivos.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbVidaActivos.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbVidaActivos.Location = new System.Drawing.Point(647, 241);
            this.cmbVidaActivos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbVidaActivos.MinimumSize = new System.Drawing.Size(229, 40);
            this.cmbVidaActivos.Name = "cmbVidaActivos";
            this.cmbVidaActivos.Padding = new System.Windows.Forms.Padding(1);
            this.cmbVidaActivos.Size = new System.Drawing.Size(235, 42);
            this.cmbVidaActivos.TabIndex = 206;
            this.cmbVidaActivos.Texts = "Tipo de metodo";
            this.cmbVidaActivos.OnSelectedIndexChanged += new System.EventHandler(this.cmbVidaActivos_OnSelectedIndexChanged);
            // 
            // cmbTipoMetodo
            // 
            this.cmbTipoMetodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoMetodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.cmbTipoMetodo.BorderColor = System.Drawing.Color.White;
            this.cmbTipoMetodo.BorderSize = 1;
            this.cmbTipoMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMetodo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTipoMetodo.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTipoMetodo.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.cmbTipoMetodo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTipoMetodo.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTipoMetodo.Location = new System.Drawing.Point(647, 336);
            this.cmbTipoMetodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTipoMetodo.MinimumSize = new System.Drawing.Size(229, 40);
            this.cmbTipoMetodo.Name = "cmbTipoMetodo";
            this.cmbTipoMetodo.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTipoMetodo.Size = new System.Drawing.Size(229, 42);
            this.cmbTipoMetodo.TabIndex = 205;
            this.cmbTipoMetodo.Texts = "Tipo de metodo";
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
            this.txtVidaUtil.Location = new System.Drawing.Point(647, 245);
            this.txtVidaUtil.Margin = new System.Windows.Forms.Padding(5);
            this.txtVidaUtil.Multiline = false;
            this.txtVidaUtil.Name = "txtVidaUtil";
            this.txtVidaUtil.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtVidaUtil.PasswordChar = false;
            this.txtVidaUtil.PlaceholderColor = System.Drawing.Color.White;
            this.txtVidaUtil.PlaceholderText = "Vida util";
            this.txtVidaUtil.Size = new System.Drawing.Size(229, 39);
            this.txtVidaUtil.TabIndex = 204;
            this.txtVidaUtil.Texts = "";
            this.txtVidaUtil.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(647, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 203;
            this.label2.Text = "Años como en Ni";
            // 
            // tglsVidaDeActivo
            // 
            this.tglsVidaDeActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tglsVidaDeActivo.AutoSize = true;
            this.tglsVidaDeActivo.Location = new System.Drawing.Point(776, 175);
            this.tglsVidaDeActivo.MinimumSize = new System.Drawing.Size(45, 22);
            this.tglsVidaDeActivo.Name = "tglsVidaDeActivo";
            this.tglsVidaDeActivo.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(120)))));
            this.tglsVidaDeActivo.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tglsVidaDeActivo.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tglsVidaDeActivo.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tglsVidaDeActivo.Size = new System.Drawing.Size(45, 22);
            this.tglsVidaDeActivo.TabIndex = 202;
            this.tglsVidaDeActivo.UseVisualStyleBackColor = true;
            // 
            // lblDepreciación
            // 
            this.lblDepreciación.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepreciación.AutoSize = true;
            this.lblDepreciación.ForeColor = System.Drawing.Color.White;
            this.lblDepreciación.Location = new System.Drawing.Point(647, 101);
            this.lblDepreciación.Name = "lblDepreciación";
            this.lblDepreciación.Size = new System.Drawing.Size(97, 20);
            this.lblDepreciación.TabIndex = 201;
            this.lblDepreciación.Text = "Depreciación";
            // 
            // tgDepreciacion
            // 
            this.tgDepreciacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tgDepreciacion.AutoSize = true;
            this.tgDepreciacion.Location = new System.Drawing.Point(771, 101);
            this.tgDepreciacion.MinimumSize = new System.Drawing.Size(45, 22);
            this.tgDepreciacion.Name = "tgDepreciacion";
            this.tgDepreciacion.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(120)))));
            this.tgDepreciacion.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgDepreciacion.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tgDepreciacion.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgDepreciacion.Size = new System.Drawing.Size(45, 22);
            this.tgDepreciacion.TabIndex = 200;
            this.tgDepreciacion.UseVisualStyleBackColor = true;
            // 
            // lblValorResidual
            // 
            this.lblValorResidual.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValorResidual.AutoSize = true;
            this.lblValorResidual.ForeColor = System.Drawing.Color.White;
            this.lblValorResidual.Location = new System.Drawing.Point(57, 302);
            this.lblValorResidual.Name = "lblValorResidual";
            this.lblValorResidual.Size = new System.Drawing.Size(99, 20);
            this.lblValorResidual.TabIndex = 199;
            this.lblValorResidual.Text = "Valor residual";
            // 
            // txtValorResidual
            // 
            this.txtValorResidual.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtValorResidual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtValorResidual.BorderColor = System.Drawing.Color.White;
            this.txtValorResidual.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtValorResidual.BorderRadius = 0;
            this.txtValorResidual.BorderSize = 2;
            this.txtValorResidual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorResidual.ForeColor = System.Drawing.Color.White;
            this.txtValorResidual.Location = new System.Drawing.Point(53, 324);
            this.txtValorResidual.Margin = new System.Windows.Forms.Padding(5);
            this.txtValorResidual.Multiline = false;
            this.txtValorResidual.Name = "txtValorResidual";
            this.txtValorResidual.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtValorResidual.PasswordChar = false;
            this.txtValorResidual.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtValorResidual.PlaceholderText = "Valor residual";
            this.txtValorResidual.Size = new System.Drawing.Size(561, 39);
            this.txtValorResidual.TabIndex = 198;
            this.txtValorResidual.Texts = "";
            this.txtValorResidual.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 197;
            this.label1.Text = "Descripción";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtDescription.BorderColor = System.Drawing.Color.White;
            this.txtDescription.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDescription.BorderRadius = 0;
            this.txtDescription.BorderSize = 2;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(57, 244);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescription.Multiline = false;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtDescription.PasswordChar = false;
            this.txtDescription.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtDescription.PlaceholderText = "Descripción";
            this.txtDescription.Size = new System.Drawing.Size(557, 39);
            this.txtDescription.TabIndex = 196;
            this.txtDescription.Texts = "";
            this.txtDescription.UnderlinedStyle = true;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtName.BorderColor = System.Drawing.Color.White;
            this.txtName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtName.BorderRadius = 0;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(251, 83);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtName.PlaceholderText = "Nombre";
            this.txtName.Size = new System.Drawing.Size(363, 39);
            this.txtName.TabIndex = 195;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = true;
            // 
            // txtMonto
            // 
            this.txtMonto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtMonto.BorderColor = System.Drawing.Color.White;
            this.txtMonto.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMonto.BorderRadius = 0;
            this.txtMonto.BorderSize = 2;
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMonto.ForeColor = System.Drawing.Color.White;
            this.txtMonto.Location = new System.Drawing.Point(218, 152);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(5);
            this.txtMonto.Multiline = false;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtMonto.PasswordChar = false;
            this.txtMonto.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtMonto.PlaceholderText = "Monto";
            this.txtMonto.Size = new System.Drawing.Size(396, 39);
            this.txtMonto.TabIndex = 194;
            this.txtMonto.Texts = "";
            this.txtMonto.UnderlinedStyle = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(264, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 193;
            this.label5.Text = "Nombre";
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("rjCircularPictureBox1.Image")));
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(30, 23);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(180, 180);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 192;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(251, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 191;
            this.label4.Text = "Monto";
            // 
            // FrmDepreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1165, 631);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDepreciacion";
            this.Text = "FrmDepreciacion";
            this.Load += new System.EventHandler(this.FrmDepreciacion_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFNE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnFind;
        private RJCodeAdvance.RJControls.RJTextBox txtSearchAsset;
        private System.Windows.Forms.Label lblTipoDeMetodo;
        private RJCodeAdvance.RJControls.RJComboBox cmbTipoMetodo;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJTextBox txtDescription;
        private RJCodeAdvance.RJControls.RJTextBox txtName;
        private RJCodeAdvance.RJControls.RJTextBox txtMonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private RJCodeAdvance.RJControls.RJButton btnEliminar;
        private RJCodeAdvance.RJControls.RJButton btnAgregar;
        private RJCodeAdvance.RJControls.RJButton btnExport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private RJCodeAdvance.RJControls.RJComboBox cmbVidaActivos;
        private RJCodeAdvance.RJControls.RJTextBox txtVidaUtil;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJToggleButton tglsVidaDeActivo;
        private System.Windows.Forms.Label lblDepreciación;
        private RJCodeAdvance.RJControls.RJToggleButton tgDepreciacion;
        private System.Windows.Forms.Label lblValorResidual;
        private RJCodeAdvance.RJControls.RJTextBox txtValorResidual;
        private ReaLTaiizor.Controls.PoisonDataGridView dtgFNE;
    }
}