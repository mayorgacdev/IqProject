namespace EconomicMF.Forms.FormsProject.FNE
{
    partial class FrmAddExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddExpense));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFInd = new System.Windows.Forms.PictureBox();
            this.dtgFNE = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.txtSearch = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtCrecimiento = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblCrecimiento = new System.Windows.Forms.Label();
            this.txtTipoDeCosto = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnd = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblInit = new System.Windows.Forms.Label();
            this.lblTipoDeCrecimiento = new System.Windows.Forms.Label();
            this.cmbTipodeCrecimiento = new RJCodeAdvance.RJControls.RJComboBox();
            this.txtStart = new RJCodeAdvance.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCosto = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnEliminar = new RJCodeAdvance.RJControls.RJButton();
            this.btnAgregar = new RJCodeAdvance.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnFInd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFNE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFInd
            // 
            this.btnFInd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFInd.Image = ((System.Drawing.Image)(resources.GetObject("btnFInd.Image")));
            this.btnFInd.Location = new System.Drawing.Point(794, 396);
            this.btnFInd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFInd.Name = "btnFInd";
            this.btnFInd.Size = new System.Drawing.Size(30, 38);
            this.btnFInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFInd.TabIndex = 109;
            this.btnFInd.TabStop = false;
            this.btnFInd.Click += new System.EventHandler(this.btnFInd_Click);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgFNE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgFNE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgFNE.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgFNE.EnableHeadersVisualStyles = false;
            this.dtgFNE.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgFNE.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.dtgFNE.Location = new System.Drawing.Point(91, 451);
            this.dtgFNE.Name = "dtgFNE";
            this.dtgFNE.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgFNE.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgFNE.RowHeadersWidth = 51;
            this.dtgFNE.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgFNE.RowTemplate.Height = 29;
            this.dtgFNE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgFNE.Size = new System.Drawing.Size(733, 212);
            this.dtgFNE.TabIndex = 107;
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
            this.txtSearch.Location = new System.Drawing.Point(102, 395);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.White;
            this.txtSearch.PlaceholderText = "Buscar gasto";
            this.txtSearch.Size = new System.Drawing.Size(676, 39);
            this.txtSearch.TabIndex = 106;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = true;
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
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
            this.txtCrecimiento.Location = new System.Drawing.Point(64, 237);
            this.txtCrecimiento.Margin = new System.Windows.Forms.Padding(5);
            this.txtCrecimiento.Multiline = false;
            this.txtCrecimiento.Name = "txtCrecimiento";
            this.txtCrecimiento.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtCrecimiento.PasswordChar = false;
            this.txtCrecimiento.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtCrecimiento.PlaceholderText = "Crecimiento";
            this.txtCrecimiento.Size = new System.Drawing.Size(401, 39);
            this.txtCrecimiento.TabIndex = 94;
            this.txtCrecimiento.Texts = "";
            this.txtCrecimiento.UnderlinedStyle = true;
            this.txtCrecimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCrecimiento_KeyPress);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.ForeColor = System.Drawing.Color.White;
            this.lblCosto.Location = new System.Drawing.Point(476, 212);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(104, 20);
            this.lblCosto.TabIndex = 105;
            this.lblCosto.Text = "Tipo de gasto:";
            // 
            // lblCrecimiento
            // 
            this.lblCrecimiento.AutoSize = true;
            this.lblCrecimiento.ForeColor = System.Drawing.Color.White;
            this.lblCrecimiento.Location = new System.Drawing.Point(75, 212);
            this.lblCrecimiento.Name = "lblCrecimiento";
            this.lblCrecimiento.Size = new System.Drawing.Size(89, 20);
            this.lblCrecimiento.TabIndex = 95;
            this.lblCrecimiento.Text = "Crecimiento";
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
            this.txtTipoDeCosto.Location = new System.Drawing.Point(465, 237);
            this.txtTipoDeCosto.Margin = new System.Windows.Forms.Padding(5);
            this.txtTipoDeCosto.Multiline = false;
            this.txtTipoDeCosto.Name = "txtTipoDeCosto";
            this.txtTipoDeCosto.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtTipoDeCosto.PasswordChar = false;
            this.txtTipoDeCosto.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtTipoDeCosto.PlaceholderText = "Tipo de gasto";
            this.txtTipoDeCosto.Size = new System.Drawing.Size(381, 39);
            this.txtTipoDeCosto.TabIndex = 104;
            this.txtTipoDeCosto.Texts = "";
            this.txtTipoDeCosto.UnderlinedStyle = true;
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
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(64, 42);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(117, 117);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 103;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(476, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 101;
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
            this.txtEnd.Location = new System.Drawing.Point(465, 311);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(5);
            this.txtEnd.Multiline = false;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtEnd.PasswordChar = false;
            this.txtEnd.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtEnd.PlaceholderText = "Fin";
            this.txtEnd.Size = new System.Drawing.Size(381, 39);
            this.txtEnd.TabIndex = 100;
            this.txtEnd.Texts = "";
            this.txtEnd.UnderlinedStyle = true;
            this.txtEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnd_KeyPress);
            // 
            // lblInit
            // 
            this.lblInit.AutoSize = true;
            this.lblInit.ForeColor = System.Drawing.Color.White;
            this.lblInit.Location = new System.Drawing.Point(75, 285);
            this.lblInit.Name = "lblInit";
            this.lblInit.Size = new System.Drawing.Size(45, 20);
            this.lblInit.TabIndex = 99;
            this.lblInit.Text = "Inicio";
            // 
            // lblTipoDeCrecimiento
            // 
            this.lblTipoDeCrecimiento.AutoSize = true;
            this.lblTipoDeCrecimiento.ForeColor = System.Drawing.Color.White;
            this.lblTipoDeCrecimiento.Location = new System.Drawing.Point(259, 132);
            this.lblTipoDeCrecimiento.Name = "lblTipoDeCrecimiento";
            this.lblTipoDeCrecimiento.Size = new System.Drawing.Size(142, 20);
            this.lblTipoDeCrecimiento.TabIndex = 98;
            this.lblTipoDeCrecimiento.Text = "Tipo de crecimiento";
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
            this.cmbTipodeCrecimiento.Location = new System.Drawing.Point(248, 156);
            this.cmbTipodeCrecimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTipodeCrecimiento.MinimumSize = new System.Drawing.Size(229, 40);
            this.cmbTipodeCrecimiento.Name = "cmbTipodeCrecimiento";
            this.cmbTipodeCrecimiento.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTipodeCrecimiento.Size = new System.Drawing.Size(480, 42);
            this.cmbTipodeCrecimiento.TabIndex = 97;
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
            this.txtStart.Location = new System.Drawing.Point(64, 311);
            this.txtStart.Margin = new System.Windows.Forms.Padding(5);
            this.txtStart.Multiline = false;
            this.txtStart.Name = "txtStart";
            this.txtStart.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtStart.PasswordChar = false;
            this.txtStart.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtStart.PlaceholderText = "Inicio";
            this.txtStart.Size = new System.Drawing.Size(393, 39);
            this.txtStart.TabIndex = 96;
            this.txtStart.Texts = "";
            this.txtStart.UnderlinedStyle = true;
            this.txtStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStart_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(269, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 93;
            this.label2.Text = "Gasto";
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
            this.txtCosto.Location = new System.Drawing.Point(248, 78);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(5);
            this.txtCosto.Multiline = false;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtCosto.PasswordChar = false;
            this.txtCosto.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtCosto.PlaceholderText = "Gasto";
            this.txtCosto.Size = new System.Drawing.Size(488, 39);
            this.txtCosto.TabIndex = 92;
            this.txtCosto.Texts = "";
            this.txtCosto.UnderlinedStyle = true;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
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
            this.btnEliminar.Location = new System.Drawing.Point(298, 704);
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
            this.btnAgregar.Location = new System.Drawing.Point(436, 704);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(144, 39);
            this.btnAgregar.TabIndex = 110;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmAddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(911, 776);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnFInd);
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
            this.Controls.Add(this.lblTipoDeCrecimiento);
            this.Controls.Add(this.cmbTipodeCrecimiento);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCosto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddExpense";
            this.Text = "FrmAddExpense";
            this.Load += new System.EventHandler(this.FrmAddExpense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnFInd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFNE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnFInd;
        private ReaLTaiizor.Controls.PoisonDataGridView dtgFNE;
        private RJCodeAdvance.RJControls.RJTextBox txtSearch;
        private RJCodeAdvance.RJControls.RJTextBox txtCrecimiento;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblCrecimiento;
        private RJCodeAdvance.RJControls.RJTextBox txtTipoDeCosto;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJTextBox txtEnd;
        private System.Windows.Forms.Label lblInit;
        private System.Windows.Forms.Label lblTipoDeCrecimiento;
        private RJCodeAdvance.RJControls.RJComboBox cmbTipodeCrecimiento;
        private RJCodeAdvance.RJControls.RJTextBox txtStart;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJTextBox txtCosto;
        private RJCodeAdvance.RJControls.RJButton btnEliminar;
        private RJCodeAdvance.RJControls.RJButton btnAgregar;
    }
}