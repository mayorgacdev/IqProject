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
            this.cmbTipoDeCalculos = new RJCodeAdvance.RJControls.RJComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCalculus = new System.Windows.Forms.Label();
            this.panelOpen = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTipoDeCalculos
            // 
            this.cmbTipoDeCalculos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoDeCalculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.cmbTipoDeCalculos.BorderColor = System.Drawing.Color.White;
            this.cmbTipoDeCalculos.BorderSize = 1;
            this.cmbTipoDeCalculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDeCalculos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTipoDeCalculos.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTipoDeCalculos.IconColor = System.Drawing.Color.MediumSpringGreen;
            this.cmbTipoDeCalculos.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTipoDeCalculos.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTipoDeCalculos.Location = new System.Drawing.Point(50, 67);
            this.cmbTipoDeCalculos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTipoDeCalculos.MinimumSize = new System.Drawing.Size(229, 40);
            this.cmbTipoDeCalculos.Name = "cmbTipoDeCalculos";
            this.cmbTipoDeCalculos.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTipoDeCalculos.Size = new System.Drawing.Size(1072, 40);
            this.cmbTipoDeCalculos.TabIndex = 144;
            this.cmbTipoDeCalculos.Texts = "Tipo de Calculo";
            this.cmbTipoDeCalculos.OnSelectedIndexChanged += new System.EventHandler(this.cmbTipoDeCalculos_OnSelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.lblCalculus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 49);
            this.panel1.TabIndex = 145;
            // 
            // lblCalculus
            // 
            this.lblCalculus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCalculus.AutoSize = true;
            this.lblCalculus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCalculus.ForeColor = System.Drawing.Color.White;
            this.lblCalculus.Location = new System.Drawing.Point(12, 9);
            this.lblCalculus.Name = "lblCalculus";
            this.lblCalculus.Size = new System.Drawing.Size(177, 28);
            this.lblCalculus.TabIndex = 7;
            this.lblCalculus.Text = "Otras herramientas";
            // 
            // panelOpen
            // 
            this.panelOpen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOpen.Location = new System.Drawing.Point(0, 145);
            this.panelOpen.Name = "panelOpen";
            this.panelOpen.Size = new System.Drawing.Size(1165, 631);
            this.panelOpen.TabIndex = 146;
            // 
            // FrmOthers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1165, 776);
            this.Controls.Add(this.panelOpen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbTipoDeCalculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOthers";
            this.Text = "s";
            this.Load += new System.EventHandler(this.FrmOthers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private RJCodeAdvance.RJControls.RJComboBox cmbTipoDeCalculos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCalculus;
        private System.Windows.Forms.Panel panelOpen;
    }
}