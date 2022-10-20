namespace EconomicMF.Forms.FormsCalculations
{
    partial class FrmConversor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConversor));
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.txtOriginal = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtActual = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnAddFlow = new RJCodeAdvance.RJControls.RJButton();
            this.cmbInteresOriginal = new ReaLTaiizor.Controls.DungeonComboBox();
            this.cmbInteresActual = new ReaLTaiizor.Controls.DungeonComboBox();
            this.cmbFrecOriginal = new ReaLTaiizor.Controls.DungeonComboBox();
            this.cmbFrecActual = new ReaLTaiizor.Controls.DungeonComboBox();
            this.lblTipoOriginal = new System.Windows.Forms.Label();
            this.lblTipoActual = new System.Windows.Forms.Label();
            this.lblTasaActual = new System.Windows.Forms.Label();
            this.lblTasaOriginal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(256, 258);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 38);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtOriginal
            // 
            this.txtOriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtOriginal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.txtOriginal.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtOriginal.BorderRadius = 10;
            this.txtOriginal.BorderSize = 2;
            this.txtOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOriginal.ForeColor = System.Drawing.Color.White;
            this.txtOriginal.Location = new System.Drawing.Point(37, 116);
            this.txtOriginal.Margin = new System.Windows.Forms.Padding(4);
            this.txtOriginal.Multiline = false;
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtOriginal.PasswordChar = false;
            this.txtOriginal.PlaceholderColor = System.Drawing.Color.White;
            this.txtOriginal.PlaceholderText = "Original";
            this.txtOriginal.Size = new System.Drawing.Size(200, 31);
            this.txtOriginal.TabIndex = 57;
            this.txtOriginal.Texts = "";
            this.txtOriginal.UnderlinedStyle = false;
            this.txtOriginal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOriginal_KeyPress);
            // 
            // txtActual
            // 
            this.txtActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtActual.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.txtActual.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtActual.BorderRadius = 10;
            this.txtActual.BorderSize = 2;
            this.txtActual.Enabled = false;
            this.txtActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtActual.ForeColor = System.Drawing.Color.White;
            this.txtActual.Location = new System.Drawing.Point(294, 116);
            this.txtActual.Margin = new System.Windows.Forms.Padding(4);
            this.txtActual.Multiline = false;
            this.txtActual.Name = "txtActual";
            this.txtActual.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtActual.PasswordChar = false;
            this.txtActual.PlaceholderColor = System.Drawing.Color.White;
            this.txtActual.PlaceholderText = "Actual";
            this.txtActual.Size = new System.Drawing.Size(200, 31);
            this.txtActual.TabIndex = 58;
            this.txtActual.Texts = "";
            this.txtActual.UnderlinedStyle = false;
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
            this.btnAddFlow.Location = new System.Drawing.Point(33, 211);
            this.btnAddFlow.Name = "btnAddFlow";
            this.btnAddFlow.Size = new System.Drawing.Size(461, 29);
            this.btnAddFlow.TabIndex = 59;
            this.btnAddFlow.Text = "Crear conversion";
            this.btnAddFlow.TextColor = System.Drawing.Color.White;
            this.btnAddFlow.UseVisualStyleBackColor = false;
            this.btnAddFlow.Click += new System.EventHandler(this.btnAddFlow_Click);
            // 
            // cmbInteresOriginal
            // 
            this.cmbInteresOriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbInteresOriginal.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbInteresOriginal.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbInteresOriginal.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbInteresOriginal.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbInteresOriginal.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbInteresOriginal.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.cmbInteresOriginal.ColorG = System.Drawing.Color.White;
            this.cmbInteresOriginal.ColorH = System.Drawing.Color.White;
            this.cmbInteresOriginal.ColorI = System.Drawing.Color.White;
            this.cmbInteresOriginal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbInteresOriginal.DropDownHeight = 100;
            this.cmbInteresOriginal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInteresOriginal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbInteresOriginal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.cmbInteresOriginal.FormattingEnabled = true;
            this.cmbInteresOriginal.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbInteresOriginal.IntegralHeight = false;
            this.cmbInteresOriginal.ItemHeight = 20;
            this.cmbInteresOriginal.Location = new System.Drawing.Point(37, 49);
            this.cmbInteresOriginal.Name = "cmbInteresOriginal";
            this.cmbInteresOriginal.Size = new System.Drawing.Size(200, 26);
            this.cmbInteresOriginal.StartIndex = 0;
            this.cmbInteresOriginal.TabIndex = 62;
            this.cmbInteresOriginal.SelectedIndexChanged += new System.EventHandler(this.cmbInteresOriginal_SelectedIndexChanged);
            // 
            // cmbInteresActual
            // 
            this.cmbInteresActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbInteresActual.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbInteresActual.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbInteresActual.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbInteresActual.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbInteresActual.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbInteresActual.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.cmbInteresActual.ColorG = System.Drawing.Color.White;
            this.cmbInteresActual.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbInteresActual.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbInteresActual.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbInteresActual.DropDownHeight = 100;
            this.cmbInteresActual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInteresActual.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbInteresActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.cmbInteresActual.FormattingEnabled = true;
            this.cmbInteresActual.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbInteresActual.IntegralHeight = false;
            this.cmbInteresActual.ItemHeight = 20;
            this.cmbInteresActual.Location = new System.Drawing.Point(294, 49);
            this.cmbInteresActual.Name = "cmbInteresActual";
            this.cmbInteresActual.Size = new System.Drawing.Size(200, 26);
            this.cmbInteresActual.StartIndex = 0;
            this.cmbInteresActual.TabIndex = 63;
            this.cmbInteresActual.SelectedIndexChanged += new System.EventHandler(this.cmbInteresActual_SelectedIndexChanged);
            // 
            // cmbFrecOriginal
            // 
            this.cmbFrecOriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbFrecOriginal.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbFrecOriginal.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbFrecOriginal.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbFrecOriginal.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbFrecOriginal.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbFrecOriginal.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.cmbFrecOriginal.ColorG = System.Drawing.Color.White;
            this.cmbFrecOriginal.ColorH = System.Drawing.Color.White;
            this.cmbFrecOriginal.ColorI = System.Drawing.Color.White;
            this.cmbFrecOriginal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFrecOriginal.DropDownHeight = 100;
            this.cmbFrecOriginal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrecOriginal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbFrecOriginal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.cmbFrecOriginal.FormattingEnabled = true;
            this.cmbFrecOriginal.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbFrecOriginal.IntegralHeight = false;
            this.cmbFrecOriginal.ItemHeight = 20;
            this.cmbFrecOriginal.Location = new System.Drawing.Point(37, 166);
            this.cmbFrecOriginal.Name = "cmbFrecOriginal";
            this.cmbFrecOriginal.Size = new System.Drawing.Size(200, 26);
            this.cmbFrecOriginal.StartIndex = 0;
            this.cmbFrecOriginal.TabIndex = 64;
            // 
            // cmbFrecActual
            // 
            this.cmbFrecActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbFrecActual.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbFrecActual.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbFrecActual.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbFrecActual.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbFrecActual.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbFrecActual.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.cmbFrecActual.ColorG = System.Drawing.Color.White;
            this.cmbFrecActual.ColorH = System.Drawing.Color.White;
            this.cmbFrecActual.ColorI = System.Drawing.Color.White;
            this.cmbFrecActual.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFrecActual.DropDownHeight = 100;
            this.cmbFrecActual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrecActual.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbFrecActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.cmbFrecActual.FormattingEnabled = true;
            this.cmbFrecActual.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbFrecActual.IntegralHeight = false;
            this.cmbFrecActual.ItemHeight = 20;
            this.cmbFrecActual.Location = new System.Drawing.Point(294, 166);
            this.cmbFrecActual.Name = "cmbFrecActual";
            this.cmbFrecActual.Size = new System.Drawing.Size(200, 26);
            this.cmbFrecActual.StartIndex = 0;
            this.cmbFrecActual.TabIndex = 65;
            // 
            // lblTipoOriginal
            // 
            this.lblTipoOriginal.AutoSize = true;
            this.lblTipoOriginal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoOriginal.ForeColor = System.Drawing.Color.White;
            this.lblTipoOriginal.Location = new System.Drawing.Point(37, 16);
            this.lblTipoOriginal.Name = "lblTipoOriginal";
            this.lblTipoOriginal.Size = new System.Drawing.Size(100, 21);
            this.lblTipoOriginal.TabIndex = 84;
            this.lblTipoOriginal.Text = "Tipo original:";
            // 
            // lblTipoActual
            // 
            this.lblTipoActual.AutoSize = true;
            this.lblTipoActual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoActual.ForeColor = System.Drawing.Color.White;
            this.lblTipoActual.Location = new System.Drawing.Point(294, 16);
            this.lblTipoActual.Name = "lblTipoActual";
            this.lblTipoActual.Size = new System.Drawing.Size(88, 21);
            this.lblTipoActual.TabIndex = 85;
            this.lblTipoActual.Text = "Tipo actual:";
            // 
            // lblTasaActual
            // 
            this.lblTasaActual.AutoSize = true;
            this.lblTasaActual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTasaActual.ForeColor = System.Drawing.Color.White;
            this.lblTasaActual.Location = new System.Drawing.Point(294, 92);
            this.lblTasaActual.Name = "lblTasaActual";
            this.lblTasaActual.Size = new System.Drawing.Size(114, 21);
            this.lblTasaActual.TabIndex = 87;
            this.lblTasaActual.Text = "Tasa actual (%):";
            // 
            // lblTasaOriginal
            // 
            this.lblTasaOriginal.AutoSize = true;
            this.lblTasaOriginal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTasaOriginal.ForeColor = System.Drawing.Color.White;
            this.lblTasaOriginal.Location = new System.Drawing.Point(37, 87);
            this.lblTasaOriginal.Name = "lblTasaOriginal";
            this.lblTasaOriginal.Size = new System.Drawing.Size(130, 21);
            this.lblTasaOriginal.TabIndex = 86;
            this.lblTasaOriginal.Text = "Tasa original (%): ";
            // 
            // FrmConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(532, 304);
            this.Controls.Add(this.lblTasaActual);
            this.Controls.Add(this.lblTasaOriginal);
            this.Controls.Add(this.lblTipoActual);
            this.Controls.Add(this.lblTipoOriginal);
            this.Controls.Add(this.cmbFrecActual);
            this.Controls.Add(this.cmbFrecOriginal);
            this.Controls.Add(this.cmbInteresActual);
            this.Controls.Add(this.cmbInteresOriginal);
            this.Controls.Add(this.btnAddFlow);
            this.Controls.Add(this.txtActual);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmConversor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConversor";
            this.Load += new System.EventHandler(this.FrmConversor_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmConversor_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClose;
        private RJCodeAdvance.RJControls.RJTextBox txtOriginal;
        private RJCodeAdvance.RJControls.RJTextBox txtActual;
        private RJCodeAdvance.RJControls.RJButton btnAddFlow;
        private ReaLTaiizor.Controls.DungeonComboBox cmbInteresOriginal;
        private ReaLTaiizor.Controls.DungeonComboBox cmbInteresActual;
        private ReaLTaiizor.Controls.DungeonComboBox cmbFrecOriginal;
        private ReaLTaiizor.Controls.DungeonComboBox cmbFrecActual;
        private System.Windows.Forms.Label lblTipoOriginal;
        private System.Windows.Forms.Label lblTipoActual;
        private System.Windows.Forms.Label lblTasaActual;
        private System.Windows.Forms.Label lblTasaOriginal;
    }
}