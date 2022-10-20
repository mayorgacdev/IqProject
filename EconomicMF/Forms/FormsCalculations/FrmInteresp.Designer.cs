namespace EconomicMF.Forms.FormsCalculations
{
    partial class FrmInteresp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInteresp));
            this.txtVF = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtTasa = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtVP = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnAddFlow = new RJCodeAdvance.RJControls.RJButton();
            this.cmbType = new ReaLTaiizor.Controls.DungeonComboBox();
            this.cmbCalculus = new ReaLTaiizor.Controls.DungeonComboBox();
            this.cmbPaymentFrec = new ReaLTaiizor.Controls.DungeonComboBox();
            this.lblInteres = new System.Windows.Forms.Label();
            this.lblPresente = new System.Windows.Forms.Label();
            this.lblFuturo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCalculo = new System.Windows.Forms.Label();
            this.lblFrecuencia = new System.Windows.Forms.Label();
            this.txtDuracion = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.btnConverTime = new RJCodeAdvance.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVF
            // 
            this.txtVF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtVF.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(150)))));
            this.txtVF.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtVF.BorderRadius = 10;
            this.txtVF.BorderSize = 2;
            this.txtVF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVF.ForeColor = System.Drawing.Color.White;
            this.txtVF.Location = new System.Drawing.Point(519, 108);
            this.txtVF.Margin = new System.Windows.Forms.Padding(4);
            this.txtVF.Multiline = false;
            this.txtVF.Name = "txtVF";
            this.txtVF.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtVF.PasswordChar = false;
            this.txtVF.PlaceholderColor = System.Drawing.Color.White;
            this.txtVF.PlaceholderText = "Valor futuro";
            this.txtVF.Size = new System.Drawing.Size(202, 31);
            this.txtVF.TabIndex = 54;
            this.txtVF.Texts = "";
            this.txtVF.UnderlinedStyle = false;
            this.txtVF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidation_KeyPress);
            // 
            // txtTasa
            // 
            this.txtTasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtTasa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(150)))));
            this.txtTasa.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTasa.BorderRadius = 10;
            this.txtTasa.BorderSize = 2;
            this.txtTasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTasa.ForeColor = System.Drawing.Color.White;
            this.txtTasa.Location = new System.Drawing.Point(177, 154);
            this.txtTasa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTasa.Multiline = false;
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTasa.PasswordChar = false;
            this.txtTasa.PlaceholderColor = System.Drawing.Color.White;
            this.txtTasa.PlaceholderText = "Tasa de interés (%)";
            this.txtTasa.Size = new System.Drawing.Size(212, 31);
            this.txtTasa.TabIndex = 52;
            this.txtTasa.Texts = "";
            this.txtTasa.UnderlinedStyle = false;
            this.txtTasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidation_KeyPress);
            // 
            // txtVP
            // 
            this.txtVP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtVP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(150)))));
            this.txtVP.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtVP.BorderRadius = 10;
            this.txtVP.BorderSize = 2;
            this.txtVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVP.ForeColor = System.Drawing.Color.White;
            this.txtVP.Location = new System.Drawing.Point(177, 108);
            this.txtVP.Margin = new System.Windows.Forms.Padding(4);
            this.txtVP.Multiline = false;
            this.txtVP.Name = "txtVP";
            this.txtVP.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtVP.PasswordChar = false;
            this.txtVP.PlaceholderColor = System.Drawing.Color.White;
            this.txtVP.PlaceholderText = "Valor presente";
            this.txtVP.Size = new System.Drawing.Size(212, 31);
            this.txtVP.TabIndex = 51;
            this.txtVP.Texts = "";
            this.txtVP.UnderlinedStyle = false;
            this.txtVP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidation_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(359, 290);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 38);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 59;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddFlow
            // 
            this.btnAddFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnAddFlow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnAddFlow.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddFlow.BorderRadius = 5;
            this.btnAddFlow.BorderSize = 0;
            this.btnAddFlow.FlatAppearance.BorderSize = 0;
            this.btnAddFlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFlow.ForeColor = System.Drawing.Color.White;
            this.btnAddFlow.Location = new System.Drawing.Point(17, 244);
            this.btnAddFlow.Name = "btnAddFlow";
            this.btnAddFlow.Size = new System.Drawing.Size(708, 29);
            this.btnAddFlow.TabIndex = 60;
            this.btnAddFlow.Text = "Calcular";
            this.btnAddFlow.TextColor = System.Drawing.Color.White;
            this.btnAddFlow.UseVisualStyleBackColor = false;
            this.btnAddFlow.Click += new System.EventHandler(this.btnAddFlow_Click);
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbType.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbType.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbType.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbType.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbType.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbType.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbType.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbType.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbType.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbType.DropDownHeight = 100;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbType.IntegralHeight = false;
            this.cmbType.ItemHeight = 20;
            this.cmbType.Location = new System.Drawing.Point(20, 46);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 26);
            this.cmbType.StartIndex = 0;
            this.cmbType.TabIndex = 61;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            this.cmbType.SelectionChangeCommitted += new System.EventHandler(this.cmbType_SelectionChangeCommitted);
            // 
            // cmbCalculus
            // 
            this.cmbCalculus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbCalculus.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbCalculus.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbCalculus.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbCalculus.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbCalculus.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbCalculus.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbCalculus.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbCalculus.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbCalculus.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbCalculus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCalculus.DropDownHeight = 100;
            this.cmbCalculus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalculus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCalculus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.cmbCalculus.FormattingEnabled = true;
            this.cmbCalculus.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbCalculus.IntegralHeight = false;
            this.cmbCalculus.ItemHeight = 20;
            this.cmbCalculus.Location = new System.Drawing.Point(525, 46);
            this.cmbCalculus.Name = "cmbCalculus";
            this.cmbCalculus.Size = new System.Drawing.Size(200, 26);
            this.cmbCalculus.StartIndex = 0;
            this.cmbCalculus.TabIndex = 62;
            this.cmbCalculus.SelectedIndexChanged += new System.EventHandler(this.cmbCalculus_SelectedIndexChanged);
            // 
            // cmbPaymentFrec
            // 
            this.cmbPaymentFrec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbPaymentFrec.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbPaymentFrec.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbPaymentFrec.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbPaymentFrec.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbPaymentFrec.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbPaymentFrec.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbPaymentFrec.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbPaymentFrec.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbPaymentFrec.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbPaymentFrec.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPaymentFrec.DropDownHeight = 100;
            this.cmbPaymentFrec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentFrec.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbPaymentFrec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.cmbPaymentFrec.FormattingEnabled = true;
            this.cmbPaymentFrec.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbPaymentFrec.IntegralHeight = false;
            this.cmbPaymentFrec.ItemHeight = 20;
            this.cmbPaymentFrec.Location = new System.Drawing.Point(272, 46);
            this.cmbPaymentFrec.Name = "cmbPaymentFrec";
            this.cmbPaymentFrec.Size = new System.Drawing.Size(200, 26);
            this.cmbPaymentFrec.StartIndex = 0;
            this.cmbPaymentFrec.TabIndex = 63;
            this.cmbPaymentFrec.SelectionChangeCommitted += new System.EventHandler(this.cmbPaymentFrec_SelectionChangeCommitted);
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInteres.ForeColor = System.Drawing.Color.White;
            this.lblInteres.Location = new System.Drawing.Point(17, 154);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(141, 21);
            this.lblInteres.TabIndex = 66;
            this.lblInteres.Text = "Tasa de interés (%):";
            // 
            // lblPresente
            // 
            this.lblPresente.AutoSize = true;
            this.lblPresente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPresente.ForeColor = System.Drawing.Color.White;
            this.lblPresente.Location = new System.Drawing.Point(17, 109);
            this.lblPresente.Name = "lblPresente";
            this.lblPresente.Size = new System.Drawing.Size(110, 21);
            this.lblPresente.TabIndex = 67;
            this.lblPresente.Text = "Valor presente";
            // 
            // lblFuturo
            // 
            this.lblFuturo.AutoSize = true;
            this.lblFuturo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFuturo.ForeColor = System.Drawing.Color.White;
            this.lblFuturo.Location = new System.Drawing.Point(400, 109);
            this.lblFuturo.Name = "lblFuturo";
            this.lblFuturo.Size = new System.Drawing.Size(100, 21);
            this.lblFuturo.TabIndex = 68;
            this.lblFuturo.Text = "Valor futuro: ";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(41, 9);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(112, 21);
            this.lblTipo.TabIndex = 81;
            this.lblTipo.Text = "Tipo de interés";
            // 
            // lblCalculo
            // 
            this.lblCalculo.AutoSize = true;
            this.lblCalculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCalculo.ForeColor = System.Drawing.Color.White;
            this.lblCalculo.Location = new System.Drawing.Point(587, 9);
            this.lblCalculo.Name = "lblCalculo";
            this.lblCalculo.Size = new System.Drawing.Size(66, 21);
            this.lblCalculo.TabIndex = 82;
            this.lblCalculo.Text = "Calcular";
            // 
            // lblFrecuencia
            // 
            this.lblFrecuencia.AutoSize = true;
            this.lblFrecuencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFrecuencia.ForeColor = System.Drawing.Color.White;
            this.lblFrecuencia.Location = new System.Drawing.Point(292, 9);
            this.lblFrecuencia.Name = "lblFrecuencia";
            this.lblFrecuencia.Size = new System.Drawing.Size(144, 21);
            this.lblFrecuencia.TabIndex = 83;
            this.lblFrecuencia.Text = "Frecuencia de pago";
            // 
            // txtDuracion
            // 
            this.txtDuracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtDuracion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(150)))));
            this.txtDuracion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDuracion.BorderRadius = 10;
            this.txtDuracion.BorderSize = 2;
            this.txtDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDuracion.ForeColor = System.Drawing.Color.White;
            this.txtDuracion.Location = new System.Drawing.Point(519, 154);
            this.txtDuracion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuracion.Multiline = false;
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDuracion.PasswordChar = false;
            this.txtDuracion.PlaceholderColor = System.Drawing.Color.White;
            this.txtDuracion.PlaceholderText = "Duración";
            this.txtDuracion.Size = new System.Drawing.Size(202, 31);
            this.txtDuracion.TabIndex = 53;
            this.txtDuracion.Texts = "";
            this.txtDuracion.UnderlinedStyle = false;
            this.txtDuracion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidation_KeyPress);
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDuracion.ForeColor = System.Drawing.Color.White;
            this.lblDuracion.Location = new System.Drawing.Point(400, 154);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(80, 21);
            this.lblDuracion.TabIndex = 69;
            this.lblDuracion.Text = "Duración: ";
            // 
            // btnConverTime
            // 
            this.btnConverTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnConverTime.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnConverTime.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConverTime.BorderRadius = 5;
            this.btnConverTime.BorderSize = 0;
            this.btnConverTime.FlatAppearance.BorderSize = 0;
            this.btnConverTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverTime.ForeColor = System.Drawing.Color.White;
            this.btnConverTime.Location = new System.Drawing.Point(17, 209);
            this.btnConverTime.Name = "btnConverTime";
            this.btnConverTime.Size = new System.Drawing.Size(708, 29);
            this.btnConverTime.TabIndex = 91;
            this.btnConverTime.Text = "Convertir tiempo";
            this.btnConverTime.TextColor = System.Drawing.Color.White;
            this.btnConverTime.UseVisualStyleBackColor = false;
            this.btnConverTime.Click += new System.EventHandler(this.btnConverTime_Click);
            // 
            // FrmInteresp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(750, 344);
            this.Controls.Add(this.btnConverTime);
            this.Controls.Add(this.lblFrecuencia);
            this.Controls.Add(this.lblCalculo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblFuturo);
            this.Controls.Add(this.lblPresente);
            this.Controls.Add(this.lblInteres);
            this.Controls.Add(this.cmbPaymentFrec);
            this.Controls.Add(this.cmbCalculus);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnAddFlow);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtVF);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtTasa);
            this.Controls.Add(this.txtVP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmInteresp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInteresp";
            this.Load += new System.EventHandler(this.FrmInteresp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJTextBox txtVF;
        private RJCodeAdvance.RJControls.RJTextBox txtTasa;
        private RJCodeAdvance.RJControls.RJTextBox txtVP;
        private System.Windows.Forms.PictureBox btnClose;
        private RJCodeAdvance.RJControls.RJButton btnAddFlow;
        private ReaLTaiizor.Controls.DungeonComboBox cmbType;
        private ReaLTaiizor.Controls.DungeonComboBox cmbCalculus;
        private ReaLTaiizor.Controls.DungeonComboBox cmbPaymentFrec;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.Label lblPresente;
        private System.Windows.Forms.Label lblFuturo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCalculo;
        private System.Windows.Forms.Label lblFrecuencia;
        private RJCodeAdvance.RJControls.RJTextBox txtDuracion;
        private System.Windows.Forms.Label lblDuracion;
        private RJCodeAdvance.RJControls.RJButton btnConverTime;
    }
}