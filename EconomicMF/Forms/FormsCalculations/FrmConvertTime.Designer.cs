﻿namespace EconomicMF.Forms.FormsCalculations
{
    partial class FrmConvertTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConvertTime));
            this.txtHoras = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtDias = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblMeses = new System.Windows.Forms.Label();
            this.txtMeses = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.txtAños = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblHoras = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnConvertir = new RJCodeAdvance.RJControls.RJButton();
            this.txtResultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHoras
            // 
            this.txtHoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtHoras.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.txtHoras.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtHoras.BorderRadius = 10;
            this.txtHoras.BorderSize = 2;
            this.txtHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHoras.ForeColor = System.Drawing.Color.White;
            this.txtHoras.Location = new System.Drawing.Point(131, 167);
            this.txtHoras.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoras.Multiline = false;
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtHoras.PasswordChar = false;
            this.txtHoras.PlaceholderColor = System.Drawing.Color.White;
            this.txtHoras.PlaceholderText = "Horas";
            this.txtHoras.Size = new System.Drawing.Size(144, 31);
            this.txtHoras.TabIndex = 88;
            this.txtHoras.Texts = "";
            this.txtHoras.UnderlinedStyle = false;
            this.txtHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAños_KeyPress);
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAño.ForeColor = System.Drawing.Color.White;
            this.lblAño.Location = new System.Drawing.Point(57, 52);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(48, 21);
            this.lblAño.TabIndex = 81;
            this.lblAño.Text = "Años:";
            // 
            // txtDias
            // 
            this.txtDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtDias.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.txtDias.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDias.BorderRadius = 10;
            this.txtDias.BorderSize = 2;
            this.txtDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDias.ForeColor = System.Drawing.Color.White;
            this.txtDias.Location = new System.Drawing.Point(131, 125);
            this.txtDias.Margin = new System.Windows.Forms.Padding(4);
            this.txtDias.Multiline = false;
            this.txtDias.Name = "txtDias";
            this.txtDias.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDias.PasswordChar = false;
            this.txtDias.PlaceholderColor = System.Drawing.Color.White;
            this.txtDias.PlaceholderText = "Días";
            this.txtDias.Size = new System.Drawing.Size(144, 31);
            this.txtDias.TabIndex = 87;
            this.txtDias.Texts = "";
            this.txtDias.UnderlinedStyle = false;
            this.txtDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAños_KeyPress);
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMeses.ForeColor = System.Drawing.Color.White;
            this.lblMeses.Location = new System.Drawing.Point(57, 94);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(57, 21);
            this.lblMeses.TabIndex = 82;
            this.lblMeses.Text = "Meses:";
            // 
            // txtMeses
            // 
            this.txtMeses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtMeses.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.txtMeses.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMeses.BorderRadius = 10;
            this.txtMeses.BorderSize = 2;
            this.txtMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMeses.ForeColor = System.Drawing.Color.White;
            this.txtMeses.Location = new System.Drawing.Point(131, 86);
            this.txtMeses.Margin = new System.Windows.Forms.Padding(4);
            this.txtMeses.Multiline = false;
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMeses.PasswordChar = false;
            this.txtMeses.PlaceholderColor = System.Drawing.Color.White;
            this.txtMeses.PlaceholderText = "Meses";
            this.txtMeses.Size = new System.Drawing.Size(144, 31);
            this.txtMeses.TabIndex = 86;
            this.txtMeses.Texts = "";
            this.txtMeses.UnderlinedStyle = false;
            this.txtMeses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAños_KeyPress);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDias.ForeColor = System.Drawing.Color.White;
            this.lblDias.Location = new System.Drawing.Point(57, 132);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(43, 21);
            this.lblDias.TabIndex = 83;
            this.lblDias.Text = "Días:";
            // 
            // txtAños
            // 
            this.txtAños.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtAños.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.txtAños.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAños.BorderRadius = 10;
            this.txtAños.BorderSize = 2;
            this.txtAños.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAños.ForeColor = System.Drawing.Color.White;
            this.txtAños.Location = new System.Drawing.Point(131, 44);
            this.txtAños.Margin = new System.Windows.Forms.Padding(4);
            this.txtAños.Multiline = false;
            this.txtAños.Name = "txtAños";
            this.txtAños.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAños.PasswordChar = false;
            this.txtAños.PlaceholderColor = System.Drawing.Color.White;
            this.txtAños.PlaceholderText = "Años";
            this.txtAños.Size = new System.Drawing.Size(144, 31);
            this.txtAños.TabIndex = 85;
            this.txtAños.Texts = "";
            this.txtAños.UnderlinedStyle = false;
            this.txtAños.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAños_KeyPress);
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoras.ForeColor = System.Drawing.Color.White;
            this.lblHoras.Location = new System.Drawing.Point(60, 167);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(54, 21);
            this.lblHoras.TabIndex = 84;
            this.lblHoras.Text = "Horas:";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(131, 299);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 38);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 89;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(57, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(188, 25);
            this.lblTitle.TabIndex = 90;
            this.lblTitle.Text = "Conversor de tiempo";
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnConvertir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.btnConvertir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConvertir.BorderRadius = 5;
            this.btnConvertir.BorderSize = 0;
            this.btnConvertir.FlatAppearance.BorderSize = 0;
            this.btnConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertir.ForeColor = System.Drawing.Color.White;
            this.btnConvertir.Location = new System.Drawing.Point(44, 262);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(231, 29);
            this.btnConvertir.TabIndex = 92;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.TextColor = System.Drawing.Color.White;
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(44, 223);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(231, 33);
            this.txtResultado.TabIndex = 98;
            // 
            // FrmConvertTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(316, 347);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.txtAños);
            this.Controls.Add(this.lblHoras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConvertTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConvertTime";
            this.Load += new System.EventHandler(this.FrmConvertTime_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmConvertTime_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJTextBox txtHoras;
        private System.Windows.Forms.Label lblAño;
        private RJCodeAdvance.RJControls.RJTextBox txtDias;
        private System.Windows.Forms.Label lblMeses;
        private RJCodeAdvance.RJControls.RJTextBox txtMeses;
        private System.Windows.Forms.Label lblDias;
        private RJCodeAdvance.RJControls.RJTextBox txtAños;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblTitle;
        private RJCodeAdvance.RJControls.RJButton btnConvertir;
        private System.Windows.Forms.TextBox txtResultado;
    }
}