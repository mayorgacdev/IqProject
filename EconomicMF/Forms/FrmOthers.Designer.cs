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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOthers));
            this.dtgvDepreciación = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnAgregar = new RJCodeAdvance.RJControls.RJButton();
            this.txtDescripcion = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtValorResidual = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtTiempo = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtPrecio = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtNombre = new RJCodeAdvance.RJControls.RJTextBox();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.btnResolver = new RJCodeAdvance.RJControls.RJButton();
            this.btnEliminar = new RJCodeAdvance.RJControls.RJButton();
            this.btnActualizar = new RJCodeAdvance.RJControls.RJButton();
            this.txtSearchReport = new RJCodeAdvance.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDepreciación)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvDepreciación
            // 
            this.dtgvDepreciación.AllowUserToOrderColumns = true;
            this.dtgvDepreciación.AllowUserToResizeRows = false;
            this.dtgvDepreciación.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvDepreciación.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dtgvDepreciación.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvDepreciación.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvDepreciación.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dtgvDepreciación.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDepreciación.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDepreciación.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDepreciación.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDepreciación.EnableHeadersVisualStyles = false;
            this.dtgvDepreciación.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgvDepreciación.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.dtgvDepreciación.Location = new System.Drawing.Point(31, 115);
            this.dtgvDepreciación.MultiSelect = false;
            this.dtgvDepreciación.Name = "dtgvDepreciación";
            this.dtgvDepreciación.ReadOnly = true;
            this.dtgvDepreciación.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDepreciación.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDepreciación.RowHeadersWidth = 51;
            this.dtgvDepreciación.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvDepreciación.RowTemplate.Height = 29;
            this.dtgvDepreciación.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDepreciación.Size = new System.Drawing.Size(810, 499);
            this.dtgvDepreciación.TabIndex = 26;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.panelButtons.Controls.Add(this.btnAgregar);
            this.panelButtons.Controls.Add(this.txtDescripcion);
            this.panelButtons.Controls.Add(this.txtValorResidual);
            this.panelButtons.Controls.Add(this.txtTiempo);
            this.panelButtons.Controls.Add(this.txtPrecio);
            this.panelButtons.Controls.Add(this.txtNombre);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(881, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(284, 776);
            this.panelButtons.TabIndex = 27;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 5;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(46, 681);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(194, 52);
            this.btnAgregar.TabIndex = 98;
            this.btnAgregar.Text = "Agregar activo";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtDescripcion.BorderColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDescripcion.BorderRadius = 0;
            this.txtDescripcion.BorderSize = 2;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(15, 359);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescripcion.Multiline = false;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtDescripcion.PasswordChar = false;
            this.txtDescripcion.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtDescripcion.PlaceholderText = "Descripción";
            this.txtDescripcion.Size = new System.Drawing.Size(255, 39);
            this.txtDescripcion.TabIndex = 63;
            this.txtDescripcion.Texts = "";
            this.txtDescripcion.UnderlinedStyle = true;
            // 
            // txtValorResidual
            // 
            this.txtValorResidual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorResidual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtValorResidual.BorderColor = System.Drawing.Color.White;
            this.txtValorResidual.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtValorResidual.BorderRadius = 0;
            this.txtValorResidual.BorderSize = 2;
            this.txtValorResidual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorResidual.ForeColor = System.Drawing.Color.White;
            this.txtValorResidual.Location = new System.Drawing.Point(17, 300);
            this.txtValorResidual.Margin = new System.Windows.Forms.Padding(5);
            this.txtValorResidual.Multiline = false;
            this.txtValorResidual.Name = "txtValorResidual";
            this.txtValorResidual.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtValorResidual.PasswordChar = false;
            this.txtValorResidual.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtValorResidual.PlaceholderText = "Valor residual";
            this.txtValorResidual.Size = new System.Drawing.Size(255, 39);
            this.txtValorResidual.TabIndex = 62;
            this.txtValorResidual.Texts = "";
            this.txtValorResidual.UnderlinedStyle = true;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTiempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtTiempo.BorderColor = System.Drawing.Color.White;
            this.txtTiempo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTiempo.BorderRadius = 0;
            this.txtTiempo.BorderSize = 2;
            this.txtTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTiempo.ForeColor = System.Drawing.Color.White;
            this.txtTiempo.Location = new System.Drawing.Point(15, 238);
            this.txtTiempo.Margin = new System.Windows.Forms.Padding(5);
            this.txtTiempo.Multiline = false;
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtTiempo.PasswordChar = false;
            this.txtTiempo.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtTiempo.PlaceholderText = "Tiempo";
            this.txtTiempo.Size = new System.Drawing.Size(255, 39);
            this.txtTiempo.TabIndex = 61;
            this.txtTiempo.Texts = "";
            this.txtTiempo.UnderlinedStyle = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtPrecio.BorderColor = System.Drawing.Color.White;
            this.txtPrecio.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPrecio.BorderRadius = 0;
            this.txtPrecio.BorderSize = 2;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecio.ForeColor = System.Drawing.Color.White;
            this.txtPrecio.Location = new System.Drawing.Point(17, 176);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrecio.Multiline = false;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtPrecio.PasswordChar = false;
            this.txtPrecio.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtPrecio.PlaceholderText = "Precio";
            this.txtPrecio.Size = new System.Drawing.Size(255, 39);
            this.txtPrecio.TabIndex = 60;
            this.txtPrecio.Texts = "";
            this.txtPrecio.UnderlinedStyle = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtNombre.BorderColor = System.Drawing.Color.White;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNombre.BorderRadius = 0;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(17, 115);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtNombre.PlaceholderText = "Nombre de activo";
            this.txtNombre.Size = new System.Drawing.Size(255, 39);
            this.txtNombre.TabIndex = 59;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = true;
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.panelOptions.Controls.Add(this.btnResolver);
            this.panelOptions.Controls.Add(this.btnEliminar);
            this.panelOptions.Controls.Add(this.btnActualizar);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOptions.Location = new System.Drawing.Point(0, 664);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(881, 112);
            this.panelOptions.TabIndex = 28;
            // 
            // btnResolver
            // 
            this.btnResolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnResolver.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnResolver.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnResolver.BorderRadius = 5;
            this.btnResolver.BorderSize = 0;
            this.btnResolver.FlatAppearance.BorderSize = 0;
            this.btnResolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolver.ForeColor = System.Drawing.Color.White;
            this.btnResolver.Image = ((System.Drawing.Image)(resources.GetObject("btnResolver.Image")));
            this.btnResolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResolver.Location = new System.Drawing.Point(323, 35);
            this.btnResolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(167, 34);
            this.btnResolver.TabIndex = 101;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.TextColor = System.Drawing.Color.White;
            this.btnResolver.UseVisualStyleBackColor = false;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BorderRadius = 5;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(79, 35);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(167, 34);
            this.btnEliminar.TabIndex = 100;
            this.btnEliminar.Text = "Eliminar activo";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnActualizar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnActualizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActualizar.BorderRadius = 5;
            this.btnActualizar.BorderSize = 0;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.Location = new System.Drawing.Point(569, 35);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(167, 34);
            this.btnActualizar.TabIndex = 99;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.White;
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // txtSearchReport
            // 
            this.txtSearchReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtSearchReport.BorderColor = System.Drawing.Color.White;
            this.txtSearchReport.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSearchReport.BorderRadius = 10;
            this.txtSearchReport.BorderSize = 2;
            this.txtSearchReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchReport.ForeColor = System.Drawing.Color.White;
            this.txtSearchReport.Location = new System.Drawing.Point(31, 31);
            this.txtSearchReport.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchReport.Multiline = false;
            this.txtSearchReport.Name = "txtSearchReport";
            this.txtSearchReport.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtSearchReport.PasswordChar = false;
            this.txtSearchReport.PlaceholderColor = System.Drawing.Color.White;
            this.txtSearchReport.PlaceholderText = "Search Report";
            this.txtSearchReport.Size = new System.Drawing.Size(810, 39);
            this.txtSearchReport.TabIndex = 29;
            this.txtSearchReport.Texts = "";
            this.txtSearchReport.UnderlinedStyle = true;
            // 
            // FrmOthers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1165, 776);
            this.Controls.Add(this.txtSearchReport);
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.dtgvDepreciación);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOthers";
            this.Text = "FrmOthers";
            this.Load += new System.EventHandler(this.FrmOthers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDepreciación)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView dtgvDepreciación;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelOptions;
        private RJCodeAdvance.RJControls.RJTextBox txtSearchReport;
        private RJCodeAdvance.RJControls.RJTextBox txtTiempo;
        private RJCodeAdvance.RJControls.RJTextBox txtPrecio;
        private RJCodeAdvance.RJControls.RJTextBox txtNombre;
        private RJCodeAdvance.RJControls.RJTextBox txtValorResidual;
        private RJCodeAdvance.RJControls.RJTextBox txtDescripcion;
        private RJCodeAdvance.RJControls.RJButton btnAgregar;
        private RJCodeAdvance.RJControls.RJButton btnResolver;
        private RJCodeAdvance.RJControls.RJButton btnEliminar;
        private RJCodeAdvance.RJControls.RJButton btnActualizar;
    }
}