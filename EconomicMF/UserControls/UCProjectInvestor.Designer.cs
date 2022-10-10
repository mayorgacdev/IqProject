namespace EconomicMF.UserControls
{
    partial class UCProjectInvestor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblValorResidual = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblDuración = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValorResidual
            // 
            this.lblValorResidual.AutoSize = true;
            this.lblValorResidual.ForeColor = System.Drawing.SystemColors.Control;
            this.lblValorResidual.Location = new System.Drawing.Point(126, 110);
            this.lblValorResidual.Name = "lblValorResidual";
            this.lblValorResidual.Size = new System.Drawing.Size(25, 20);
            this.lblValorResidual.TabIndex = 10;
            this.lblValorResidual.Text = "10";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDuracion.Location = new System.Drawing.Point(18, 110);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(102, 20);
            this.lblDuracion.TabIndex = 9;
            this.lblDuracion.Text = "Valor residual:";
            // 
            // lblDuración
            // 
            this.lblDuración.AutoSize = true;
            this.lblDuración.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDuración.Location = new System.Drawing.Point(91, 85);
            this.lblDuración.Name = "lblDuración";
            this.lblDuración.Size = new System.Drawing.Size(74, 20);
            this.lblDuración.TabIndex = 8;
            this.lblDuración.Text = "Trimestral";
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.ForeColor = System.Drawing.SystemColors.Control;
            this.Label34.Location = new System.Drawing.Point(18, 85);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(72, 20);
            this.Label34.TabIndex = 7;
            this.Label34.Text = "Duración:";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPeriodo.Location = new System.Drawing.Point(91, 63);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(25, 20);
            this.lblPeriodo.TabIndex = 14;
            this.lblPeriodo.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Periodo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(91, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(74, 20);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Trimestral";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(18, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre:";
            // 
            // UCProjectInvestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblValorResidual);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblDuración);
            this.Controls.Add(this.Label34);
            this.Name = "UCProjectInvestor";
            this.Size = new System.Drawing.Size(208, 164);
            this.Load += new System.EventHandler(this.UCProjectInvestor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorResidual;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblDuración;
        private System.Windows.Forms.Label Label34;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label4;
    }
}
