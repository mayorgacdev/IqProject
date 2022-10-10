namespace EconomicMF.Forms.FormsProject.FNE
{
    partial class FrmAddInversion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddInversion));
            this.btnAdd = new RJCodeAdvance.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInicio = new RJCodeAdvance.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMonto = new RJCodeAdvance.RJControls.RJTextBox();
            this.tgIsDiferida = new RJCodeAdvance.RJControls.RJToggleButton();
            this.panelOpen = new System.Windows.Forms.Panel();
            this.lblIsDiferida = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nupRecuperaciónCt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupRecuperaciónCt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(346, 690);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(204, 39);
            this.btnAdd.TabIndex = 69;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(260, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Nombre de inversión";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtName.BorderColor = System.Drawing.Color.White;
            this.txtName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtName.BorderRadius = 0;
            this.txtName.BorderSize = 2;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(242, 75);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtName.PlaceholderText = "Nombre de inversión";
            this.txtName.Size = new System.Drawing.Size(481, 39);
            this.txtName.TabIndex = 58;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = true;
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
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(66, 53);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(117, 117);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 76;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 78;
            this.label1.Text = "Inicio";
            // 
            // txtInicio
            // 
            this.txtInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtInicio.BorderColor = System.Drawing.Color.White;
            this.txtInicio.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtInicio.BorderRadius = 0;
            this.txtInicio.BorderSize = 2;
            this.txtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInicio.ForeColor = System.Drawing.Color.White;
            this.txtInicio.Location = new System.Drawing.Point(242, 146);
            this.txtInicio.Margin = new System.Windows.Forms.Padding(5);
            this.txtInicio.Multiline = false;
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtInicio.PasswordChar = false;
            this.txtInicio.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtInicio.PlaceholderText = "Inicio";
            this.txtInicio.Size = new System.Drawing.Size(481, 39);
            this.txtInicio.TabIndex = 77;
            this.txtInicio.Texts = "";
            this.txtInicio.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(260, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 82;
            this.label4.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtMonto.BorderColor = System.Drawing.Color.White;
            this.txtMonto.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMonto.BorderRadius = 0;
            this.txtMonto.BorderSize = 2;
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMonto.ForeColor = System.Drawing.Color.White;
            this.txtMonto.Location = new System.Drawing.Point(242, 223);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(5);
            this.txtMonto.Multiline = false;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtMonto.PasswordChar = false;
            this.txtMonto.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtMonto.PlaceholderText = "Monto";
            this.txtMonto.Size = new System.Drawing.Size(481, 39);
            this.txtMonto.TabIndex = 81;
            this.txtMonto.Texts = "";
            this.txtMonto.UnderlinedStyle = true;
            // 
            // tgIsDiferida
            // 
            this.tgIsDiferida.AutoSize = true;
            this.tgIsDiferida.Location = new System.Drawing.Point(505, 364);
            this.tgIsDiferida.MinimumSize = new System.Drawing.Size(45, 22);
            this.tgIsDiferida.Name = "tgIsDiferida";
            this.tgIsDiferida.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(120)))));
            this.tgIsDiferida.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgIsDiferida.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tgIsDiferida.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgIsDiferida.Size = new System.Drawing.Size(45, 22);
            this.tgIsDiferida.TabIndex = 89;
            this.tgIsDiferida.UseVisualStyleBackColor = true;
            // 
            // panelOpen
            // 
            this.panelOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOpen.Location = new System.Drawing.Point(66, 417);
            this.panelOpen.Name = "panelOpen";
            this.panelOpen.Size = new System.Drawing.Size(789, 253);
            this.panelOpen.TabIndex = 100;
            // 
            // lblIsDiferida
            // 
            this.lblIsDiferida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIsDiferida.AutoSize = true;
            this.lblIsDiferida.ForeColor = System.Drawing.Color.White;
            this.lblIsDiferida.Location = new System.Drawing.Point(362, 364);
            this.lblIsDiferida.Name = "lblIsDiferida";
            this.lblIsDiferida.Size = new System.Drawing.Size(79, 20);
            this.lblIsDiferida.TabIndex = 90;
            this.lblIsDiferida.Text = "Es diferida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(260, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 102;
            this.label3.Text = "Recuperación de capital";
            // 
            // nupRecuperaciónCt
            // 
            this.nupRecuperaciónCt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.nupRecuperaciónCt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nupRecuperaciónCt.ForeColor = System.Drawing.Color.White;
            this.nupRecuperaciónCt.Location = new System.Drawing.Point(242, 320);
            this.nupRecuperaciónCt.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupRecuperaciónCt.Name = "nupRecuperaciónCt";
            this.nupRecuperaciónCt.Size = new System.Drawing.Size(481, 23);
            this.nupRecuperaciónCt.TabIndex = 103;
            // 
            // FrmAddInversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(903, 776);
            this.Controls.Add(this.nupRecuperaciónCt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelOpen);
            this.Controls.Add(this.lblIsDiferida);
            this.Controls.Add(this.tgIsDiferida);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddInversion";
            this.Text = "FrmInversion";
            this.Load += new System.EventHandler(this.FrmInversion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupRecuperaciónCt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJButton btnAdd;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJTextBox txtName;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJTextBox txtInicio;
        private System.Windows.Forms.Label label4;
        private RJCodeAdvance.RJControls.RJTextBox txtMonto;
        private RJCodeAdvance.RJControls.RJToggleButton tgIsDiferida;
        private System.Windows.Forms.Panel panelOpen;
        private System.Windows.Forms.Label lblIsDiferida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nupRecuperaciónCt;
    }
}