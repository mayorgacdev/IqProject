namespace EconomicMF.Forms.FormsProject.FNE
{
    partial class FrmAddEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddEntry));
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
            this.txtIngreso = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.txtTipoIngreso = new RJCodeAdvance.RJControls.RJTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtgFNE = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.txtNameProject = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnEliminar = new RJCodeAdvance.RJControls.RJButton();
            this.btnActualizar = new RJCodeAdvance.RJControls.RJButton();
            this.btnAgregar = new RJCodeAdvance.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFNE)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(481, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 92;
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
            this.txtEnd.Location = new System.Drawing.Point(481, 322);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(5);
            this.txtEnd.Multiline = false;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtEnd.PasswordChar = false;
            this.txtEnd.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtEnd.PlaceholderText = "Fin";
            this.txtEnd.Size = new System.Drawing.Size(373, 39);
            this.txtEnd.TabIndex = 91;
            this.txtEnd.Texts = "";
            this.txtEnd.UnderlinedStyle = true;
            // 
            // lblInit
            // 
            this.lblInit.AutoSize = true;
            this.lblInit.ForeColor = System.Drawing.Color.White;
            this.lblInit.Location = new System.Drawing.Point(66, 294);
            this.lblInit.Name = "lblInit";
            this.lblInit.Size = new System.Drawing.Size(45, 20);
            this.lblInit.TabIndex = 90;
            this.lblInit.Text = "Inicio";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.ForeColor = System.Drawing.Color.White;
            this.lblPeriodo.Location = new System.Drawing.Point(250, 149);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(142, 20);
            this.lblPeriodo.TabIndex = 89;
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
            this.cmbTipodeCrecimiento.Location = new System.Drawing.Point(250, 173);
            this.cmbTipodeCrecimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTipodeCrecimiento.MinimumSize = new System.Drawing.Size(229, 40);
            this.cmbTipodeCrecimiento.Name = "cmbTipodeCrecimiento";
            this.cmbTipodeCrecimiento.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTipodeCrecimiento.Size = new System.Drawing.Size(453, 42);
            this.cmbTipodeCrecimiento.TabIndex = 88;
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
            this.txtStart.TabIndex = 87;
            this.txtStart.Texts = "";
            this.txtStart.UnderlinedStyle = true;
            // 
            // lblCrecimiento
            // 
            this.lblCrecimiento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCrecimiento.AutoSize = true;
            this.lblCrecimiento.ForeColor = System.Drawing.Color.White;
            this.lblCrecimiento.Location = new System.Drawing.Point(70, 226);
            this.lblCrecimiento.Name = "lblCrecimiento";
            this.lblCrecimiento.Size = new System.Drawing.Size(89, 20);
            this.lblCrecimiento.TabIndex = 86;
            this.lblCrecimiento.Text = "Crecimiento";
            // 
            // txtCrecimiento
            // 
            this.txtCrecimiento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCrecimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtCrecimiento.BorderColor = System.Drawing.Color.White;
            this.txtCrecimiento.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCrecimiento.BorderRadius = 0;
            this.txtCrecimiento.BorderSize = 2;
            this.txtCrecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCrecimiento.ForeColor = System.Drawing.Color.White;
            this.txtCrecimiento.Location = new System.Drawing.Point(70, 251);
            this.txtCrecimiento.Margin = new System.Windows.Forms.Padding(5);
            this.txtCrecimiento.Multiline = false;
            this.txtCrecimiento.Name = "txtCrecimiento";
            this.txtCrecimiento.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtCrecimiento.PasswordChar = false;
            this.txtCrecimiento.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtCrecimiento.PlaceholderText = "Crecimiento";
            this.txtCrecimiento.Size = new System.Drawing.Size(401, 39);
            this.txtCrecimiento.TabIndex = 85;
            this.txtCrecimiento.Texts = "";
            this.txtCrecimiento.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(259, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 84;
            this.label2.Text = "Ingreso";
            // 
            // txtIngreso
            // 
            this.txtIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtIngreso.BorderColor = System.Drawing.Color.White;
            this.txtIngreso.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIngreso.BorderRadius = 0;
            this.txtIngreso.BorderSize = 2;
            this.txtIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIngreso.ForeColor = System.Drawing.Color.White;
            this.txtIngreso.Location = new System.Drawing.Point(250, 89);
            this.txtIngreso.Margin = new System.Windows.Forms.Padding(5);
            this.txtIngreso.Multiline = false;
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtIngreso.PasswordChar = false;
            this.txtIngreso.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtIngreso.PlaceholderText = "Ingreso";
            this.txtIngreso.Size = new System.Drawing.Size(461, 39);
            this.txtIngreso.TabIndex = 83;
            this.txtIngreso.Texts = "";
            this.txtIngreso.UnderlinedStyle = true;
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
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(70, 52);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(117, 117);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 97;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // lblIngreso
            // 
            this.lblIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.ForeColor = System.Drawing.Color.White;
            this.lblIngreso.Location = new System.Drawing.Point(493, 226);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(113, 20);
            this.lblIngreso.TabIndex = 99;
            this.lblIngreso.Text = "Tipo de ingreso";
            // 
            // txtTipoIngreso
            // 
            this.txtTipoIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTipoIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtTipoIngreso.BorderColor = System.Drawing.Color.White;
            this.txtTipoIngreso.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTipoIngreso.BorderRadius = 0;
            this.txtTipoIngreso.BorderSize = 2;
            this.txtTipoIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTipoIngreso.ForeColor = System.Drawing.Color.White;
            this.txtTipoIngreso.Location = new System.Drawing.Point(481, 251);
            this.txtTipoIngreso.Margin = new System.Windows.Forms.Padding(5);
            this.txtTipoIngreso.Multiline = false;
            this.txtTipoIngreso.Name = "txtTipoIngreso";
            this.txtTipoIngreso.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtTipoIngreso.PasswordChar = false;
            this.txtTipoIngreso.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtTipoIngreso.PlaceholderText = "Tipo de ingreso";
            this.txtTipoIngreso.Size = new System.Drawing.Size(373, 39);
            this.txtTipoIngreso.TabIndex = 98;
            this.txtTipoIngreso.Texts = "";
            this.txtTipoIngreso.UnderlinedStyle = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(787, 405);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 104;
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
            this.dtgFNE.Location = new System.Drawing.Point(84, 461);
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
            this.dtgFNE.TabIndex = 102;
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
            this.txtNameProject.Location = new System.Drawing.Point(95, 405);
            this.txtNameProject.Margin = new System.Windows.Forms.Padding(5);
            this.txtNameProject.Multiline = false;
            this.txtNameProject.Name = "txtNameProject";
            this.txtNameProject.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtNameProject.PasswordChar = false;
            this.txtNameProject.PlaceholderColor = System.Drawing.Color.White;
            this.txtNameProject.PlaceholderText = "Buscar entidad";
            this.txtNameProject.Size = new System.Drawing.Size(676, 39);
            this.txtNameProject.TabIndex = 101;
            this.txtNameProject.Texts = "";
            this.txtNameProject.UnderlinedStyle = true;
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
            this.btnEliminar.Location = new System.Drawing.Point(565, 704);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 39);
            this.btnEliminar.TabIndex = 112;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnActualizar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnActualizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActualizar.BorderRadius = 0;
            this.btnActualizar.BorderSize = 0;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.Location = new System.Drawing.Point(206, 704);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(132, 39);
            this.btnActualizar.TabIndex = 111;
            this.btnActualizar.Text = "Editar";
            this.btnActualizar.TextColor = System.Drawing.Color.White;
            this.btnActualizar.UseVisualStyleBackColor = false;
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
            this.btnAgregar.Location = new System.Drawing.Point(351, 704);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(205, 39);
            this.btnAgregar.TabIndex = 110;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // FrmAddEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(911, 776);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtgFNE);
            this.Controls.Add(this.txtNameProject);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.txtTipoIngreso);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.lblInit);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.cmbTipodeCrecimiento);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.lblCrecimiento);
            this.Controls.Add(this.txtCrecimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIngreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddEntry";
            this.Text = "FrmIngreso";
            this.Load += new System.EventHandler(this.FrmIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private RJCodeAdvance.RJControls.RJTextBox txtIngreso;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Label lblIngreso;
        private RJCodeAdvance.RJControls.RJTextBox txtTipoIngreso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.PoisonDataGridView dtgFNE;
        private RJCodeAdvance.RJControls.RJTextBox txtNameProject;
        private RJCodeAdvance.RJControls.RJButton btnEliminar;
        private RJCodeAdvance.RJControls.RJButton btnActualizar;
        private RJCodeAdvance.RJControls.RJButton btnAgregar;
    }
}