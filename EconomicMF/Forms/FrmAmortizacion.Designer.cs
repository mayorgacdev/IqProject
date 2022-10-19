namespace EconomicMF.Forms
{
    partial class FrmAmortizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAmortizacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExport = new RJCodeAdvance.RJControls.RJButton();
            this.btnEliminar = new RJCodeAdvance.RJControls.RJButton();
            this.btnAgregar = new RJCodeAdvance.RJControls.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtN = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtInteres = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblTMAR = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.PictureBox();
            this.dtgFNE = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.txtSearchAsset = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblTipoDeMetodo = new System.Windows.Forms.Label();
            this.cmbTipoMetodo = new RJCodeAdvance.RJControls.RJComboBox();
            this.txtName = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtMonto = new RJCodeAdvance.RJControls.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFNE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(945, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 631);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 165;
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
            this.btnExport.Location = new System.Drawing.Point(37, 507);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(159, 39);
            this.btnExport.TabIndex = 164;
            this.btnExport.Text = "Exportar E/P";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.TextColor = System.Drawing.Color.White;
            this.btnExport.UseVisualStyleBackColor = false;
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
            this.btnEliminar.Location = new System.Drawing.Point(37, 554);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(159, 39);
            this.btnEliminar.TabIndex = 163;
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
            this.btnAgregar.Location = new System.Drawing.Point(34, 460);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(159, 39);
            this.btnAgregar.TabIndex = 162;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtN);
            this.panel2.Controls.Add(this.txtInteres);
            this.panel2.Controls.Add(this.lblTMAR);
            this.panel2.Controls.Add(this.btnFind);
            this.panel2.Controls.Add(this.dtgFNE);
            this.panel2.Controls.Add(this.txtSearchAsset);
            this.panel2.Controls.Add(this.lblTipoDeMetodo);
            this.panel2.Controls.Add(this.cmbTipoMetodo);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.txtMonto);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.rjCircularPictureBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 631);
            this.panel2.TabIndex = 1;
            // 
            // txtN
            // 
            this.txtN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtN.BorderColor = System.Drawing.Color.White;
            this.txtN.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtN.BorderRadius = 10;
            this.txtN.BorderSize = 2;
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtN.ForeColor = System.Drawing.Color.White;
            this.txtN.Location = new System.Drawing.Point(635, 228);
            this.txtN.Margin = new System.Windows.Forms.Padding(5);
            this.txtN.Multiline = false;
            this.txtN.Name = "txtN";
            this.txtN.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtN.PasswordChar = false;
            this.txtN.PlaceholderColor = System.Drawing.Color.White;
            this.txtN.PlaceholderText = "Años";
            this.txtN.Size = new System.Drawing.Size(117, 39);
            this.txtN.TabIndex = 65;
            this.txtN.Texts = "";
            this.txtN.UnderlinedStyle = true;
            // 
            // txtInteres
            // 
            this.txtInteres.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtInteres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtInteres.BorderColor = System.Drawing.Color.White;
            this.txtInteres.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtInteres.BorderRadius = 0;
            this.txtInteres.BorderSize = 2;
            this.txtInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInteres.ForeColor = System.Drawing.Color.White;
            this.txtInteres.Location = new System.Drawing.Point(72, 228);
            this.txtInteres.Margin = new System.Windows.Forms.Padding(5);
            this.txtInteres.Multiline = false;
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtInteres.PasswordChar = false;
            this.txtInteres.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtInteres.PlaceholderText = "Interés";
            this.txtInteres.Size = new System.Drawing.Size(545, 39);
            this.txtInteres.TabIndex = 220;
            this.txtInteres.Texts = "";
            this.txtInteres.UnderlinedStyle = true;
            // 
            // lblTMAR
            // 
            this.lblTMAR.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTMAR.AutoSize = true;
            this.lblTMAR.ForeColor = System.Drawing.Color.White;
            this.lblTMAR.Location = new System.Drawing.Point(170, 203);
            this.lblTMAR.Name = "lblTMAR";
            this.lblTMAR.Size = new System.Drawing.Size(53, 20);
            this.lblTMAR.TabIndex = 219;
            this.lblTMAR.Text = "Interés";
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(883, 395);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(36, 38);
            this.btnFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFind.TabIndex = 218;
            this.btnFind.TabStop = false;
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
            this.dtgFNE.Location = new System.Drawing.Point(49, 451);
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
            this.dtgFNE.TabIndex = 217;
            this.dtgFNE.Click += new System.EventHandler(this.dtgFNE_Click);
            // 
            // txtSearchAsset
            // 
            this.txtSearchAsset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSearchAsset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtSearchAsset.BorderColor = System.Drawing.Color.White;
            this.txtSearchAsset.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSearchAsset.BorderRadius = 0;
            this.txtSearchAsset.BorderSize = 2;
            this.txtSearchAsset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchAsset.ForeColor = System.Drawing.Color.White;
            this.txtSearchAsset.Location = new System.Drawing.Point(55, 394);
            this.txtSearchAsset.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchAsset.Multiline = false;
            this.txtSearchAsset.Name = "txtSearchAsset";
            this.txtSearchAsset.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtSearchAsset.PasswordChar = false;
            this.txtSearchAsset.PlaceholderColor = System.Drawing.Color.White;
            this.txtSearchAsset.PlaceholderText = "Buscar amortización";
            this.txtSearchAsset.Size = new System.Drawing.Size(820, 39);
            this.txtSearchAsset.TabIndex = 216;
            this.txtSearchAsset.Texts = "";
            this.txtSearchAsset.UnderlinedStyle = true;
            // 
            // lblTipoDeMetodo
            // 
            this.lblTipoDeMetodo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTipoDeMetodo.AutoSize = true;
            this.lblTipoDeMetodo.ForeColor = System.Drawing.Color.White;
            this.lblTipoDeMetodo.Location = new System.Drawing.Point(66, 287);
            this.lblTipoDeMetodo.Name = "lblTipoDeMetodo";
            this.lblTipoDeMetodo.Size = new System.Drawing.Size(117, 20);
            this.lblTipoDeMetodo.TabIndex = 215;
            this.lblTipoDeMetodo.Text = "Tipo de metodo";
            // 
            // cmbTipoMetodo
            // 
            this.cmbTipoMetodo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbTipoMetodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.cmbTipoMetodo.BorderColor = System.Drawing.Color.White;
            this.cmbTipoMetodo.BorderSize = 1;
            this.cmbTipoMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMetodo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTipoMetodo.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTipoMetodo.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.cmbTipoMetodo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTipoMetodo.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTipoMetodo.Location = new System.Drawing.Point(66, 311);
            this.cmbTipoMetodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTipoMetodo.MinimumSize = new System.Drawing.Size(229, 40);
            this.cmbTipoMetodo.Name = "cmbTipoMetodo";
            this.cmbTipoMetodo.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTipoMetodo.Size = new System.Drawing.Size(551, 42);
            this.cmbTipoMetodo.TabIndex = 214;
            this.cmbTipoMetodo.Texts = "Tipo de metodo";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtName.BorderColor = System.Drawing.Color.White;
            this.txtName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtName.BorderRadius = 0;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(254, 72);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtName.PlaceholderText = "Nombre";
            this.txtName.Size = new System.Drawing.Size(363, 39);
            this.txtName.TabIndex = 208;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = true;
            // 
            // txtMonto
            // 
            this.txtMonto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtMonto.BorderColor = System.Drawing.Color.White;
            this.txtMonto.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMonto.BorderRadius = 0;
            this.txtMonto.BorderSize = 2;
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMonto.ForeColor = System.Drawing.Color.White;
            this.txtMonto.Location = new System.Drawing.Point(221, 141);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(5);
            this.txtMonto.Multiline = false;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtMonto.PasswordChar = false;
            this.txtMonto.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtMonto.PlaceholderText = "Monto";
            this.txtMonto.Size = new System.Drawing.Size(396, 39);
            this.txtMonto.TabIndex = 207;
            this.txtMonto.Texts = "";
            this.txtMonto.UnderlinedStyle = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(267, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 206;
            this.label5.Text = "Nombre";
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("rjCircularPictureBox1.Image")));
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(33, 12);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(180, 180);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 205;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(254, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 204;
            this.label4.Text = "Monto";
            // 
            // FrmAmortizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1165, 631);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAmortizacion";
            this.Text = "FrmAmortizacion";
            this.Load += new System.EventHandler(this.FrmAmortizacion_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFNE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private RJCodeAdvance.RJControls.RJTextBox txtName;
        private RJCodeAdvance.RJControls.RJTextBox txtMonto;
        private System.Windows.Forms.Label label5;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTipoDeMetodo;
        private RJCodeAdvance.RJControls.RJComboBox cmbTipoMetodo;
        private System.Windows.Forms.PictureBox btnFind;
        private ReaLTaiizor.Controls.PoisonDataGridView dtgFNE;
        private RJCodeAdvance.RJControls.RJTextBox txtSearchAsset;
        private System.Windows.Forms.Label lblTMAR;
        private RJCodeAdvance.RJControls.RJTextBox txtInteres;
        private RJCodeAdvance.RJControls.RJTextBox txtN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJCodeAdvance.RJControls.RJButton btnExport;
        private RJCodeAdvance.RJControls.RJButton btnEliminar;
        private RJCodeAdvance.RJControls.RJButton btnAgregar;
    }
}