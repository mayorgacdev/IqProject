namespace EconomicMF.Forms.FormsProject.FNE
{
    partial class FrmChargeData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChargeData));
            this.lblTasa = new System.Windows.Forms.Label();
            this.lblGetTmar = new System.Windows.Forms.Label();
            this.lblVpn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTir = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgFNE = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.flpInvestors = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblper = new System.Windows.Forms.Label();
            this.btnExport = new RJCodeAdvance.RJControls.RJButton();
            this.btnAmortizacion = new RJCodeAdvance.RJControls.RJButton();
            this.panelOpen = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFNE)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelOpen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTasa
            // 
            this.lblTasa.AutoSize = true;
            this.lblTasa.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTasa.ForeColor = System.Drawing.Color.White;
            this.lblTasa.Location = new System.Drawing.Point(98, 78);
            this.lblTasa.Name = "lblTasa";
            this.lblTasa.Size = new System.Drawing.Size(33, 17);
            this.lblTasa.TabIndex = 21;
            this.lblTasa.Text = "58%";
            // 
            // lblGetTmar
            // 
            this.lblGetTmar.AutoSize = true;
            this.lblGetTmar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGetTmar.ForeColor = System.Drawing.Color.White;
            this.lblGetTmar.Location = new System.Drawing.Point(15, 72);
            this.lblGetTmar.Name = "lblGetTmar";
            this.lblGetTmar.Size = new System.Drawing.Size(64, 25);
            this.lblGetTmar.TabIndex = 20;
            this.lblGetTmar.Text = "TMAR:";
            // 
            // lblVpn
            // 
            this.lblVpn.AutoSize = true;
            this.lblVpn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVpn.ForeColor = System.Drawing.Color.White;
            this.lblVpn.Location = new System.Drawing.Point(98, 49);
            this.lblVpn.Name = "lblVpn";
            this.lblVpn.Size = new System.Drawing.Size(31, 17);
            this.lblVpn.TabIndex = 19;
            this.lblVpn.Text = "Vpn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "VPN:";
            // 
            // lblTir
            // 
            this.lblTir.AutoSize = true;
            this.lblTir.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTir.ForeColor = System.Drawing.Color.White;
            this.lblTir.Location = new System.Drawing.Point(98, 21);
            this.lblTir.Name = "lblTir";
            this.lblTir.Size = new System.Drawing.Size(22, 17);
            this.lblTir.TabIndex = 17;
            this.lblTir.Text = "52";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "TIR:";
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
            this.dtgFNE.Location = new System.Drawing.Point(3, 21);
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
            this.dtgFNE.Size = new System.Drawing.Size(842, 295);
            this.dtgFNE.TabIndex = 25;
            // 
            // flpInvestors
            // 
            this.flpInvestors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flpInvestors.AutoScroll = true;
            this.flpInvestors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.flpInvestors.Location = new System.Drawing.Point(32, 70);
            this.flpInvestors.Name = "flpInvestors";
            this.flpInvestors.Size = new System.Drawing.Size(605, 224);
            this.flpInvestors.TabIndex = 94;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.lblPeriodo);
            this.panel1.Controls.Add(this.lblper);
            this.panel1.Controls.Add(this.lblTasa);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblTir);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblVpn);
            this.panel1.Controls.Add(this.lblGetTmar);
            this.panel1.Location = new System.Drawing.Point(674, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 251);
            this.panel1.TabIndex = 95;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPeriodo.ForeColor = System.Drawing.Color.White;
            this.lblPeriodo.Location = new System.Drawing.Point(98, 107);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(46, 17);
            this.lblPeriodo.TabIndex = 25;
            this.lblPeriodo.Text = "TMAR:";
            // 
            // lblper
            // 
            this.lblper.AutoSize = true;
            this.lblper.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblper.ForeColor = System.Drawing.Color.White;
            this.lblper.Location = new System.Drawing.Point(15, 101);
            this.lblper.Name = "lblper";
            this.lblper.Size = new System.Drawing.Size(77, 25);
            this.lblper.TabIndex = 24;
            this.lblper.Text = "Periodo:";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnExport.Location = new System.Drawing.Point(355, 721);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(167, 35);
            this.btnExport.TabIndex = 98;
            this.btnExport.Text = "Exportar E/P";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.TextColor = System.Drawing.Color.White;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnAmortizacion
            // 
            this.btnAmortizacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAmortizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnAmortizacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnAmortizacion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAmortizacion.BorderRadius = 5;
            this.btnAmortizacion.BorderSize = 0;
            this.btnAmortizacion.FlatAppearance.BorderSize = 0;
            this.btnAmortizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmortizacion.ForeColor = System.Drawing.Color.White;
            this.btnAmortizacion.Image = ((System.Drawing.Image)(resources.GetObject("btnAmortizacion.Image")));
            this.btnAmortizacion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAmortizacion.Location = new System.Drawing.Point(32, 309);
            this.btnAmortizacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAmortizacion.Name = "btnAmortizacion";
            this.btnAmortizacion.Size = new System.Drawing.Size(230, 35);
            this.btnAmortizacion.TabIndex = 99;
            this.btnAmortizacion.Text = "Ver tablas de amortización";
            this.btnAmortizacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAmortizacion.TextColor = System.Drawing.Color.White;
            this.btnAmortizacion.UseVisualStyleBackColor = false;
            this.btnAmortizacion.Click += new System.EventHandler(this.btnAmortizacion_Click);
            // 
            // panelOpen
            // 
            this.panelOpen.Controls.Add(this.dtgFNE);
            this.panelOpen.Location = new System.Drawing.Point(32, 360);
            this.panelOpen.Name = "panelOpen";
            this.panelOpen.Size = new System.Drawing.Size(848, 344);
            this.panelOpen.TabIndex = 101;
            // 
            // FrmChargeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(903, 776);
            this.Controls.Add(this.panelOpen);
            this.Controls.Add(this.btnAmortizacion);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpInvestors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmChargeData";
            this.Text = "FrmChargeData";
            this.Load += new System.EventHandler(this.FrmChargeData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFNE)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelOpen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTasa;
        private System.Windows.Forms.Label lblGetTmar;
        private System.Windows.Forms.Label lblVpn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTir;
        private System.Windows.Forms.Label label8;
        private ReaLTaiizor.Controls.PoisonDataGridView dtgFNE;
        private System.Windows.Forms.FlowLayoutPanel flpInvestors;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblper;
        private RJCodeAdvance.RJControls.RJButton btnExport;
        private RJCodeAdvance.RJControls.RJButton btnAmortizacion;
        private System.Windows.Forms.Panel panelOpen;
    }
}