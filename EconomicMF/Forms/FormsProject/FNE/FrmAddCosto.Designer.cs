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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnd = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblInit = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.cmbTipodeCrecimiento = new RJCodeAdvance.RJControls.RJComboBox();
            this.txtStart = new RJCodeAdvance.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCrecimiento = new RJCodeAdvance.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCosto = new RJCodeAdvance.RJControls.RJTextBox();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtTipoDeCosto = new RJCodeAdvance.RJControls.RJTextBox();
            this.panelOpen = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
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
            this.txtEnd.Size = new System.Drawing.Size(373, 39);
            this.txtEnd.TabIndex = 78;
            this.txtEnd.Texts = "";
            this.txtEnd.UnderlinedStyle = true;
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(77, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "Crecimiento";
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
            this.txtCrecimiento.Size = new System.Drawing.Size(393, 39);
            this.txtCrecimiento.TabIndex = 72;
            this.txtCrecimiento.Texts = "";
            this.txtCrecimiento.UnderlinedStyle = true;
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
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Image = ((System.Drawing.Image)(resources.GetObject("rjButton1.Image")));
            this.rjButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButton1.Location = new System.Drawing.Point(309, 703);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(197, 39);
            this.rjButton1.TabIndex = 82;
            this.rjButton1.Text = "Agregar";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
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
            this.txtTipoDeCosto.Size = new System.Drawing.Size(373, 39);
            this.txtTipoDeCosto.TabIndex = 84;
            this.txtTipoDeCosto.Texts = "";
            this.txtTipoDeCosto.UnderlinedStyle = true;
            // 
            // panelOpen
            // 
            this.panelOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOpen.Location = new System.Drawing.Point(65, 434);
            this.panelOpen.Name = "panelOpen";
            this.panelOpen.Size = new System.Drawing.Size(789, 239);
            this.panelOpen.TabIndex = 86;
            // 
            // FrmAddCosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(903, 776);
            this.Controls.Add(this.panelOpen);
            this.Controls.Add(this.txtCrecimiento);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTipoDeCosto);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.Controls.Add(this.rjButton1);
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
        private System.Windows.Forms.Label label4;
        private RJCodeAdvance.RJControls.RJTextBox txtCrecimiento;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJTextBox txtCosto;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Label lblCosto;
        private RJCodeAdvance.RJControls.RJTextBox txtTipoDeCosto;
        private System.Windows.Forms.Panel panelOpen;
    }
}