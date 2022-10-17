namespace EconomicMF.Forms.FormsProject.FNE
{
    partial class FrmAddCosto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddCosto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnd = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblInit = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.cmbTipodeCrecimiento = new RJCodeAdvance.RJControls.RJComboBox();
            this.txtStart = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblCrecimiento = new System.Windows.Forms.Label();
            this.txtCrecimiento = new RJCodeAdvance.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCosto = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtTipoDeCosto = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.dtgFNE = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.txtSearch = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnEliminar = new RJCodeAdvance.RJControls.RJButton();
            this.btnAgregar = new RJCodeAdvance.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFNE)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(478, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 79;
            this.label1.Text = "Fin";
            // 
            // txtEnd
            // 
            this.txtEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtEnd.BorderColor = System.Drawing.Color.White;
            this.txtEnd.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEnd.BorderRadius = 0;
            this.txtEnd.BorderSize = 2;
            this.txtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEnd.ForeColor = System.Drawing.Color.White;
            this.txtEnd.Location = new System.Drawing.Point(467, 322);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(5);
            this.txtEnd.Multiline = false;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtEnd.PasswordChar = false;
            this.txtEnd.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtEnd.PlaceholderText = "Fin";
            this.txtEnd.Size = new System.Drawing.Size(381, 39);
            this.txtEnd.TabIndex = 78;
            this.txtEnd.Texts = "";
            this.txtEnd.UnderlinedStyle = true;
            this.txtEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnd_KeyPress);
            // 
            // lblInit
            // 
            this.lblInit.AutoSize = true;
            this.lblInit.ForeColor = System.Drawing.Color.White;
            this.lblInit.Location = new System.Drawing.Point(77, 296);
            this.lblInit.Name = "lblInit";
            this.lblInit.Size = new System.Drawing.Size(45, 20);
            this.lblInit.TabIndex = 77;
            this.lblInit.Text = "Inicio";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.ForeColor = System.Drawing.Color.White;
            this.lblPeriodo.Location = new System.Drawing.Point(261, 143);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(142, 20);
            this.lblPeriodo.TabIndex = 76;
            this.lblPeriodo.Text = "Tipo de crecimiento";
            // 
            // cmbTipodeCrecimiento
            // 
            this.cmbTipodeCrecimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipodeCrecimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.cmbTipodeCrecimiento.BorderColor = System.Drawing.Color.White;
            this.cmbTipodeCrecimiento.BorderSize = 1;
            this.cmbTipodeCrecimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipodeCrecimiento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTipodeCrecimiento.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTipodeCrecimiento.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.cmbTipodeCrecimiento.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTipodeCrecimiento.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTipodeCrecimiento.Location = new System.Drawing.Point(250, 167);
            this.cmbTipodeCrecimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTipodeCrecimiento.MinimumSize = new System.Drawing.Size(229, 40);
            this.cmbTipodeCrecimiento.Name = "cmbTipodeCrecimiento";
            this.cmbTipodeCrecimiento.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTipodeCrecimiento.Size = new System.Drawing.Size(480, 42);
            this.cmbTipodeCrecimiento.TabIndex = 75;
            this.cmbTipodeCrecimiento.Texts = "Tipo de crecimiento";
            this.cmbTipodeCrecimiento.OnSelectedIndexChanged += new System.EventHandler(this.cmbTipodeCrecimiento_OnSelectedIndexChanged);
            // 
            // txtStart
            // 
            this.txtStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtStart.BorderColor = System.Drawing.Color.White;
            this.txtStart.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtStart.BorderRadius = 0;
            this.txtStart.BorderSize = 2;
            this.txtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStart.ForeColor = System.Drawing.Color.White;
            this.txtStart.Location = new System.Drawing.Point(66, 322);
            this.txtStart.Margin = new System.Windows.Forms.Padding(5);
            this.txtStart.Multiline = false;
            this.txtStart.Name = "txtStart";
            this.txtStart.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtStart.PasswordChar = false;
            this.txtStart.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtStart.PlaceholderText = "Inicio";
            this.txtStart.Size = new System.Drawing.Size(393, 39);
            this.txtStart.TabIndex = 74;
            this.txtStart.Texts = "";
            this.txtStart.UnderlinedStyle = true;
            this.txtStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStart_KeyPress);
            // 
            // lblCrecimiento
            // 
            this.lblCrecimiento.AutoSize = true;
            this.lblCrecimiento.ForeColor = System.Drawing.Color.White;
            this.lblCrecimiento.Location = new System.Drawing.Point(77, 223);
            this.lblCrecimiento.Name = "lblCrecimiento";
            this.lblCrecimiento.Size = new System.Drawing.Size(89, 20);
            this.lblCrecimiento.TabIndex = 73;
            this.lblCrecimiento.Text = "Crecimiento";
            // 
            // txtCrecimiento
            // 
            this.txtCrecimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCrecimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtCrecimiento.BorderColor = System.Drawing.Color.White;
            this.txtCrecimiento.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCrecimiento.BorderRadius = 0;
            this.txtCrecimiento.BorderSize = 2;
            this.txtCrecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCrecimiento.ForeColor = System.Drawing.Color.White;
            this.txtCrecimiento.Location = new System.Drawing.Point(66, 248);
            this.txtCrecimiento.Margin = new System.Windows.Forms.Padding(5);
            this.txtCrecimiento.Multiline = false;
            this.txtCrecimiento.Name = "txtCrecimiento";
            this.txtCrecimiento.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtCrecimiento.PasswordChar = false;
            this.txtCrecimiento.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtCrecimiento.PlaceholderText = "Crecimiento";
            this.txtCrecimiento.Size = new System.Drawing.Size(391, 39);
            this.txtCrecimiento.TabIndex = 72;
            this.txtCrecimiento.Texts = "";
            this.txtCrecimiento.UnderlinedStyle = true;
            this.txtCrecimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCrecimiento_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(271, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 71;
            this.label2.Text = "Costo";
            // 
            // txtCosto
            // 
            this.txtCosto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtCosto.BorderColor = System.Drawing.Color.White;
            this.txtCosto.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCosto.BorderRadius = 0;
            this.txtCosto.BorderSize = 2;
            this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCosto.ForeColor = System.Drawing.Color.White;
            this.txtCosto.Location = new System.Drawing.Point(250, 89);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(5);
            this.txtCosto.Multiline = false;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtCosto.PasswordChar = false;
            this.txtCosto.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtCosto.PlaceholderText = "Costo";
            this.txtCosto.Size = new System.Drawing.Size(480, 39);
            this.txtCosto.TabIndex = 70;
            this.txtCosto.Texts = "";
            this.txtCosto.UnderlinedStyle = true;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
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
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(66, 38);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(125, 125);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 83;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.ForeColor = System.Drawing.Color.White;
            this.lblCosto.Location = new System.Drawing.Point(478, 223);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(103, 20);
            this.lblCosto.TabIndex = 85;
            this.lblCosto.Text = "Tipo de costo:";
            // 
            // txtTipoDeCosto
            // 
            this.txtTipoDeCosto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTipoDeCosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtTipoDeCosto.BorderColor = System.Drawing.Color.White;
            this.txtTipoDeCosto.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTipoDeCosto.BorderRadius = 0;
            this.txtTipoDeCosto.BorderSize = 2;
            this.txtTipoDeCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTipoDeCosto.ForeColor = System.Drawing.Color.White;
            this.txtTipoDeCosto.Location = new System.Drawing.Point(467, 248);
            this.txtTipoDeCosto.Margin = new System.Windows.Forms.Padding(5);
            this.txtTipoDeCosto.Multiline = false;
            this.txtTipoDeCosto.Name = "txtTipoDeCosto";
            this.txtTipoDeCosto.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtTipoDeCosto.PasswordChar = false;
            this.txtTipoDeCosto.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtTipoDeCosto.PlaceholderText = "Tipo de costo";
            this.txtTipoDeCosto.Size = new System.Drawing.Size(381, 39);
            this.txtTipoDeCosto.TabIndex = 84;
            this.txtTipoDeCosto.Texts = "";
            this.txtTipoDeCosto.UnderlinedStyle = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(794, 417);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 38);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 90;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.dtgFNE.Location = new System.Drawing.Point(91, 473);
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
            this.dtgFNE.Size = new System.Drawing.Size(733, 212);
            this.dtgFNE.TabIndex = 87;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtSearch.BorderColor = System.Drawing.Color.White;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSearch.BorderRadius = 0;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(102, 417);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.White;
            this.txtSearch.PlaceholderText = "Buscar costo";
            this.txtSearch.Size = new System.Drawing.Size(676, 39);
            this.txtSearch.TabIndex = 86;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = true;
            this.txtSearch._TextChanged += new System.EventHandler(this.txtNameProject__TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnEliminar.Location = new System.Drawing.Point(325, 706);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 39);
            this.btnEliminar.TabIndex = 112;
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
            this.btnAgregar.Location = new System.Drawing.Point(463, 706);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(154, 39);
            this.btnAgregar.TabIndex = 110;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmAddCosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(911, 776);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtgFNE);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtCrecimiento);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblCrecimiento);
            this.Controls.Add(this.txtTipoDeCosto);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.lblInit);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.cmbTipodeCrecimiento);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCosto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddCosto";
            this.Text = "S";
            this.Load += new System.EventHandler(this.FrmCosto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFNE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJTextBox txtEnd;
        private System.Windows.Forms.Label lblInit;
        private System.Windows.Forms.Label lblPeriodo;
        private RJCodeAdvance.RJControls.RJComboBox cmbTipodeCrecimiento;
        private RJCodeAdvance.RJControls.RJTextBox txtStart;
        private System.Windows.Forms.Label lblCrecimiento;
        private RJCodeAdvance.RJControls.RJTextBox txtCrecimiento;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJTextBox txtCosto;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Label lblCosto;
        private RJCodeAdvance.RJControls.RJTextBox txtTipoDeCosto;
        private System.Windows.Forms.PictureBox btnSearch;
        private ReaLTaiizor.Controls.PoisonDataGridView dtgFNE;
        private RJCodeAdvance.RJControls.RJTextBox txtSearch;
        private RJCodeAdvance.RJControls.RJButton btnEliminar;
        private RJCodeAdvance.RJControls.RJButton btnAgregar;
    }
}