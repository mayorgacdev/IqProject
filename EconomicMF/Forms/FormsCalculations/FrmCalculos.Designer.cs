namespace EconomicMF.Forms.FormsCalculations
{
    partial class FrmCalculos
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
            this.chcGrafica = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.btnAdd = new RJCodeAdvance.RJControls.RJButton();
            this.lblPago = new ReaLTaiizor.Controls.SkyLabel();
            this.lblVP = new ReaLTaiizor.Controls.SkyLabel();
            this.lblVF = new ReaLTaiizor.Controls.SkyLabel();
            this.skyLabel4 = new ReaLTaiizor.Controls.SkyLabel();
            this.skyLabel5 = new ReaLTaiizor.Controls.SkyLabel();
            this.txtPago = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtVP = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtVF = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtTasaInteres = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtDuracion = new RJCodeAdvance.RJControls.RJTextBox();
            this.cmbTipoCalculo = new ReaLTaiizor.Controls.DungeonComboBox();
            this.skyLabel6 = new ReaLTaiizor.Controls.SkyLabel();
            this.skyLabel7 = new ReaLTaiizor.Controls.SkyLabel();
            this.cmbTipoMovimiento = new ReaLTaiizor.Controls.DungeonComboBox();
            this.txtPerGracia = new RJCodeAdvance.RJControls.RJTextBox();
            this.skyLabel8 = new ReaLTaiizor.Controls.SkyLabel();
            this.txtIncremento = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblIncremento = new ReaLTaiizor.Controls.SkyLabel();
            this.skyLabel10 = new ReaLTaiizor.Controls.SkyLabel();
            this.cmbFrecPagos = new ReaLTaiizor.Controls.DungeonComboBox();
            this.txtInicio = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblInicio = new ReaLTaiizor.Controls.SkyLabel();
            this.txtFuturoGrad = new RJCodeAdvance.RJControls.RJTextBox();
            this.lblFuturoGrad = new ReaLTaiizor.Controls.SkyLabel();
            this.cmbIncremento = new ReaLTaiizor.Controls.DungeonComboBox();
            this.SuspendLayout();
            // 
            // chcGrafica
            // 
            this.chcGrafica.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chcGrafica.ChartArea.CursorReDraw = false;
            this.chcGrafica.IsWindowLess = false;
            // 
            // 
            // 
            this.chcGrafica.Legend.Location = new System.Drawing.Point(561, 81);
            this.chcGrafica.Legend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chcGrafica.Localize = null;
            this.chcGrafica.Location = new System.Drawing.Point(583, 118);
            this.chcGrafica.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chcGrafica.Name = "chcGrafica";
            this.chcGrafica.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chcGrafica.PrimaryXAxis.Margin = true;
            this.chcGrafica.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chcGrafica.PrimaryYAxis.Margin = true;
            this.chcGrafica.Size = new System.Drawing.Size(682, 443);
            this.chcGrafica.TabIndex = 0;
            this.chcGrafica.Text = "Flujo de caja";
            // 
            // 
            // 
            this.chcGrafica.Title.Name = "Default";
            this.chcGrafica.Titles.Add(this.chcGrafica.Title);
            this.chcGrafica.VisualTheme = "";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(247, 720);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 53);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.lblPago.Location = new System.Drawing.Point(34, 163);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(180, 25);
            this.lblPago.TabIndex = 2;
            this.lblPago.Text = "Pago periodico";
            // 
            // lblVP
            // 
            this.lblVP.AutoSize = true;
            this.lblVP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.lblVP.Location = new System.Drawing.Point(32, 229);
            this.lblVP.Name = "lblVP";
            this.lblVP.Size = new System.Drawing.Size(177, 25);
            this.lblVP.TabIndex = 3;
            this.lblVP.Text = "Valor Presente";
            // 
            // lblVF
            // 
            this.lblVF.AutoSize = true;
            this.lblVF.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.lblVF.Location = new System.Drawing.Point(32, 441);
            this.lblVF.Name = "lblVF";
            this.lblVF.Size = new System.Drawing.Size(159, 25);
            this.lblVF.TabIndex = 4;
            this.lblVF.Text = "Valor Futuro ";
            // 
            // skyLabel4
            // 
            this.skyLabel4.AutoSize = true;
            this.skyLabel4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.skyLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel4.Location = new System.Drawing.Point(32, 300);
            this.skyLabel4.Name = "skyLabel4";
            this.skyLabel4.Size = new System.Drawing.Size(190, 25);
            this.skyLabel4.TabIndex = 5;
            this.skyLabel4.Text = "Tasa de interés ";
            // 
            // skyLabel5
            // 
            this.skyLabel5.AutoSize = true;
            this.skyLabel5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.skyLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel5.Location = new System.Drawing.Point(32, 371);
            this.skyLabel5.Name = "skyLabel5";
            this.skyLabel5.Size = new System.Drawing.Size(113, 25);
            this.skyLabel5.TabIndex = 6;
            this.skyLabel5.Text = "Duración";
            // 
            // txtPago
            // 
            this.txtPago.BackColor = System.Drawing.SystemColors.Window;
            this.txtPago.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPago.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPago.BorderRadius = 0;
            this.txtPago.BorderSize = 2;
            this.txtPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPago.Location = new System.Drawing.Point(247, 163);
            this.txtPago.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPago.Multiline = false;
            this.txtPago.Name = "txtPago";
            this.txtPago.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtPago.PasswordChar = false;
            this.txtPago.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPago.PlaceholderText = "";
            this.txtPago.Size = new System.Drawing.Size(286, 39);
            this.txtPago.TabIndex = 7;
            this.txtPago.Texts = "";
            this.txtPago.UnderlinedStyle = false;
            this.txtPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPago_KeyPress);
            // 
            // txtVP
            // 
            this.txtVP.BackColor = System.Drawing.SystemColors.Window;
            this.txtVP.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtVP.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtVP.BorderRadius = 0;
            this.txtVP.BorderSize = 2;
            this.txtVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVP.Location = new System.Drawing.Point(246, 229);
            this.txtVP.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtVP.Multiline = false;
            this.txtVP.Name = "txtVP";
            this.txtVP.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtVP.PasswordChar = false;
            this.txtVP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtVP.PlaceholderText = "";
            this.txtVP.Size = new System.Drawing.Size(286, 39);
            this.txtVP.TabIndex = 8;
            this.txtVP.Texts = "";
            this.txtVP.UnderlinedStyle = false;
            this.txtVP._TextChanged += new System.EventHandler(this.txtVP__TextChanged);
            this.txtVP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPago_KeyPress);
            // 
            // txtVF
            // 
            this.txtVF.BackColor = System.Drawing.SystemColors.Window;
            this.txtVF.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtVF.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtVF.BorderRadius = 0;
            this.txtVF.BorderSize = 2;
            this.txtVF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVF.Location = new System.Drawing.Point(245, 441);
            this.txtVF.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtVF.Multiline = false;
            this.txtVF.Name = "txtVF";
            this.txtVF.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtVF.PasswordChar = false;
            this.txtVF.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtVF.PlaceholderText = "";
            this.txtVF.Size = new System.Drawing.Size(286, 39);
            this.txtVF.TabIndex = 9;
            this.txtVF.Texts = "";
            this.txtVF.UnderlinedStyle = false;
            this.txtVF._TextChanged += new System.EventHandler(this.txtVF__TextChanged);
            this.txtVF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPago_KeyPress);
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.BackColor = System.Drawing.SystemColors.Window;
            this.txtTasaInteres.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTasaInteres.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTasaInteres.BorderRadius = 0;
            this.txtTasaInteres.BorderSize = 2;
            this.txtTasaInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTasaInteres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTasaInteres.Location = new System.Drawing.Point(246, 300);
            this.txtTasaInteres.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTasaInteres.Multiline = false;
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtTasaInteres.PasswordChar = false;
            this.txtTasaInteres.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTasaInteres.PlaceholderText = "";
            this.txtTasaInteres.Size = new System.Drawing.Size(286, 39);
            this.txtTasaInteres.TabIndex = 10;
            this.txtTasaInteres.Texts = "";
            this.txtTasaInteres.UnderlinedStyle = false;
            this.txtTasaInteres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPago_KeyPress);
            // 
            // txtDuracion
            // 
            this.txtDuracion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDuracion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDuracion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDuracion.BorderRadius = 0;
            this.txtDuracion.BorderSize = 2;
            this.txtDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDuracion.Location = new System.Drawing.Point(245, 371);
            this.txtDuracion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDuracion.Multiline = false;
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtDuracion.PasswordChar = false;
            this.txtDuracion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDuracion.PlaceholderText = "";
            this.txtDuracion.Size = new System.Drawing.Size(286, 39);
            this.txtDuracion.TabIndex = 11;
            this.txtDuracion.Texts = "";
            this.txtDuracion.UnderlinedStyle = false;
            this.txtDuracion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPago_KeyPress);
            // 
            // cmbTipoCalculo
            // 
            this.cmbTipoCalculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbTipoCalculo.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.cmbTipoCalculo.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.cmbTipoCalculo.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.cmbTipoCalculo.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbTipoCalculo.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.cmbTipoCalculo.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbTipoCalculo.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbTipoCalculo.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbTipoCalculo.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbTipoCalculo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoCalculo.DropDownHeight = 100;
            this.cmbTipoCalculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCalculo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTipoCalculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.cmbTipoCalculo.FormattingEnabled = true;
            this.cmbTipoCalculo.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbTipoCalculo.IntegralHeight = false;
            this.cmbTipoCalculo.ItemHeight = 20;
            this.cmbTipoCalculo.Location = new System.Drawing.Point(713, 27);
            this.cmbTipoCalculo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTipoCalculo.Name = "cmbTipoCalculo";
            this.cmbTipoCalculo.Size = new System.Drawing.Size(265, 26);
            this.cmbTipoCalculo.StartIndex = 0;
            this.cmbTipoCalculo.TabIndex = 12;
            this.cmbTipoCalculo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCalculo_SelectedIndexChanged);
            // 
            // skyLabel6
            // 
            this.skyLabel6.AutoSize = true;
            this.skyLabel6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.skyLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel6.Location = new System.Drawing.Point(602, 29);
            this.skyLabel6.Name = "skyLabel6";
            this.skyLabel6.Size = new System.Drawing.Size(61, 25);
            this.skyLabel6.TabIndex = 13;
            this.skyLabel6.Text = "Tipo";
            // 
            // skyLabel7
            // 
            this.skyLabel7.AutoSize = true;
            this.skyLabel7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.skyLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel7.Location = new System.Drawing.Point(35, 27);
            this.skyLabel7.Name = "skyLabel7";
            this.skyLabel7.Size = new System.Drawing.Size(235, 25);
            this.skyLabel7.TabIndex = 15;
            this.skyLabel7.Text = "Tipo de movimiento";
            // 
            // cmbTipoMovimiento
            // 
            this.cmbTipoMovimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbTipoMovimiento.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.cmbTipoMovimiento.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.cmbTipoMovimiento.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.cmbTipoMovimiento.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbTipoMovimiento.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.cmbTipoMovimiento.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbTipoMovimiento.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbTipoMovimiento.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbTipoMovimiento.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbTipoMovimiento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoMovimiento.DropDownHeight = 100;
            this.cmbTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMovimiento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTipoMovimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.cmbTipoMovimiento.FormattingEnabled = true;
            this.cmbTipoMovimiento.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbTipoMovimiento.IntegralHeight = false;
            this.cmbTipoMovimiento.ItemHeight = 20;
            this.cmbTipoMovimiento.Location = new System.Drawing.Point(301, 24);
            this.cmbTipoMovimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTipoMovimiento.Name = "cmbTipoMovimiento";
            this.cmbTipoMovimiento.Size = new System.Drawing.Size(265, 26);
            this.cmbTipoMovimiento.StartIndex = 0;
            this.cmbTipoMovimiento.TabIndex = 14;
            this.cmbTipoMovimiento.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMovimiento_SelectedIndexChanged);
            // 
            // txtPerGracia
            // 
            this.txtPerGracia.BackColor = System.Drawing.SystemColors.Window;
            this.txtPerGracia.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPerGracia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPerGracia.BorderRadius = 0;
            this.txtPerGracia.BorderSize = 2;
            this.txtPerGracia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPerGracia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPerGracia.Location = new System.Drawing.Point(795, 671);
            this.txtPerGracia.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPerGracia.Multiline = false;
            this.txtPerGracia.Name = "txtPerGracia";
            this.txtPerGracia.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtPerGracia.PasswordChar = false;
            this.txtPerGracia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPerGracia.PlaceholderText = "";
            this.txtPerGracia.Size = new System.Drawing.Size(286, 39);
            this.txtPerGracia.TabIndex = 17;
            this.txtPerGracia.Texts = "";
            this.txtPerGracia.UnderlinedStyle = false;
            this.txtPerGracia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPago_KeyPress);
            // 
            // skyLabel8
            // 
            this.skyLabel8.AutoSize = true;
            this.skyLabel8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.skyLabel8.ForeColor = System.Drawing.Color.Red;
            this.skyLabel8.Location = new System.Drawing.Point(583, 671);
            this.skyLabel8.Name = "skyLabel8";
            this.skyLabel8.Size = new System.Drawing.Size(211, 25);
            this.skyLabel8.TabIndex = 16;
            this.skyLabel8.Text = "Periodo de Gracia";
            // 
            // txtIncremento
            // 
            this.txtIncremento.BackColor = System.Drawing.SystemColors.Window;
            this.txtIncremento.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtIncremento.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIncremento.BorderRadius = 0;
            this.txtIncremento.BorderSize = 2;
            this.txtIncremento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIncremento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIncremento.Location = new System.Drawing.Point(245, 585);
            this.txtIncremento.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtIncremento.Multiline = false;
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtIncremento.PasswordChar = false;
            this.txtIncremento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIncremento.PlaceholderText = "";
            this.txtIncremento.Size = new System.Drawing.Size(286, 39);
            this.txtIncremento.TabIndex = 19;
            this.txtIncremento.Texts = "";
            this.txtIncremento.UnderlinedStyle = false;
            this.txtIncremento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPago_KeyPress);
            // 
            // lblIncremento
            // 
            this.lblIncremento.AutoSize = true;
            this.lblIncremento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIncremento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.lblIncremento.Location = new System.Drawing.Point(32, 603);
            this.lblIncremento.Name = "lblIncremento";
            this.lblIncremento.Size = new System.Drawing.Size(143, 25);
            this.lblIncremento.TabIndex = 18;
            this.lblIncremento.Text = "Incremento";
            // 
            // skyLabel10
            // 
            this.skyLabel10.AutoSize = true;
            this.skyLabel10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.skyLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyLabel10.Location = new System.Drawing.Point(35, 80);
            this.skyLabel10.Name = "skyLabel10";
            this.skyLabel10.Size = new System.Drawing.Size(281, 25);
            this.skyLabel10.TabIndex = 21;
            this.skyLabel10.Text = "Frecuencia de los pagos";
            // 
            // cmbFrecPagos
            // 
            this.cmbFrecPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbFrecPagos.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.cmbFrecPagos.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.cmbFrecPagos.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.cmbFrecPagos.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbFrecPagos.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.cmbFrecPagos.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbFrecPagos.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbFrecPagos.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbFrecPagos.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbFrecPagos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFrecPagos.DropDownHeight = 100;
            this.cmbFrecPagos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrecPagos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbFrecPagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.cmbFrecPagos.FormattingEnabled = true;
            this.cmbFrecPagos.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbFrecPagos.IntegralHeight = false;
            this.cmbFrecPagos.ItemHeight = 20;
            this.cmbFrecPagos.Location = new System.Drawing.Point(301, 80);
            this.cmbFrecPagos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFrecPagos.Name = "cmbFrecPagos";
            this.cmbFrecPagos.Size = new System.Drawing.Size(265, 26);
            this.cmbFrecPagos.StartIndex = 0;
            this.cmbFrecPagos.TabIndex = 20;
            // 
            // txtInicio
            // 
            this.txtInicio.BackColor = System.Drawing.SystemColors.Window;
            this.txtInicio.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtInicio.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtInicio.BorderRadius = 0;
            this.txtInicio.BorderSize = 2;
            this.txtInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInicio.Location = new System.Drawing.Point(245, 508);
            this.txtInicio.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtInicio.Multiline = false;
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtInicio.PasswordChar = false;
            this.txtInicio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtInicio.PlaceholderText = "";
            this.txtInicio.Size = new System.Drawing.Size(286, 39);
            this.txtInicio.TabIndex = 23;
            this.txtInicio.Texts = "";
            this.txtInicio.UnderlinedStyle = false;
            this.txtInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPago_KeyPress);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.lblInicio.Location = new System.Drawing.Point(34, 525);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(77, 25);
            this.lblInicio.TabIndex = 22;
            this.lblInicio.Text = "Inicio";
            this.lblInicio.Click += new System.EventHandler(this.skyLabel12_Click);
            // 
            // txtFuturoGrad
            // 
            this.txtFuturoGrad.BackColor = System.Drawing.SystemColors.Window;
            this.txtFuturoGrad.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtFuturoGrad.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtFuturoGrad.BorderRadius = 0;
            this.txtFuturoGrad.BorderSize = 2;
            this.txtFuturoGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFuturoGrad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFuturoGrad.Location = new System.Drawing.Point(245, 653);
            this.txtFuturoGrad.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFuturoGrad.Multiline = false;
            this.txtFuturoGrad.Name = "txtFuturoGrad";
            this.txtFuturoGrad.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.txtFuturoGrad.PasswordChar = false;
            this.txtFuturoGrad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFuturoGrad.PlaceholderText = "";
            this.txtFuturoGrad.Size = new System.Drawing.Size(286, 39);
            this.txtFuturoGrad.TabIndex = 25;
            this.txtFuturoGrad.Texts = "";
            this.txtFuturoGrad.UnderlinedStyle = false;
            this.txtFuturoGrad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPago_KeyPress);
            // 
            // lblFuturoGrad
            // 
            this.lblFuturoGrad.AutoSize = true;
            this.lblFuturoGrad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFuturoGrad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.lblFuturoGrad.Location = new System.Drawing.Point(14, 671);
            this.lblFuturoGrad.Name = "lblFuturoGrad";
            this.lblFuturoGrad.Size = new System.Drawing.Size(241, 25);
            this.lblFuturoGrad.TabIndex = 24;
            this.lblFuturoGrad.Text = "Futuro del gradiente";
            // 
            // cmbIncremento
            // 
            this.cmbIncremento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbIncremento.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.cmbIncremento.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.cmbIncremento.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.cmbIncremento.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.cmbIncremento.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.cmbIncremento.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbIncremento.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbIncremento.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbIncremento.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbIncremento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbIncremento.DropDownHeight = 100;
            this.cmbIncremento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIncremento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbIncremento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.cmbIncremento.FormattingEnabled = true;
            this.cmbIncremento.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbIncremento.IntegralHeight = false;
            this.cmbIncremento.ItemHeight = 20;
            this.cmbIncremento.Location = new System.Drawing.Point(583, 592);
            this.cmbIncremento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbIncremento.Name = "cmbIncremento";
            this.cmbIncremento.Size = new System.Drawing.Size(265, 26);
            this.cmbIncremento.StartIndex = 0;
            this.cmbIncremento.TabIndex = 26;
            // 
            // FrmCalculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 791);
            this.Controls.Add(this.cmbIncremento);
            this.Controls.Add(this.txtFuturoGrad);
            this.Controls.Add(this.lblFuturoGrad);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.skyLabel10);
            this.Controls.Add(this.cmbFrecPagos);
            this.Controls.Add(this.txtIncremento);
            this.Controls.Add(this.lblIncremento);
            this.Controls.Add(this.txtPerGracia);
            this.Controls.Add(this.skyLabel8);
            this.Controls.Add(this.skyLabel7);
            this.Controls.Add(this.cmbTipoMovimiento);
            this.Controls.Add(this.skyLabel6);
            this.Controls.Add(this.cmbTipoCalculo);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtTasaInteres);
            this.Controls.Add(this.txtVF);
            this.Controls.Add(this.txtVP);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.skyLabel5);
            this.Controls.Add(this.skyLabel4);
            this.Controls.Add(this.lblVF);
            this.Controls.Add(this.lblVP);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chcGrafica);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCalculos";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmCalculos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Chart.ChartControl chcGrafica;
        private RJCodeAdvance.RJControls.RJButton btnAdd;
        private ReaLTaiizor.Controls.SkyLabel lblPago;
        private ReaLTaiizor.Controls.SkyLabel lblVP;
        private ReaLTaiizor.Controls.SkyLabel lblVF;
        private ReaLTaiizor.Controls.SkyLabel skyLabel4;
        private ReaLTaiizor.Controls.SkyLabel skyLabel5;
        private RJCodeAdvance.RJControls.RJTextBox txtPago;
        private RJCodeAdvance.RJControls.RJTextBox txtVP;
        private RJCodeAdvance.RJControls.RJTextBox txtVF;
        private RJCodeAdvance.RJControls.RJTextBox txtTasaInteres;
        private RJCodeAdvance.RJControls.RJTextBox txtDuracion;
        private ReaLTaiizor.Controls.DungeonComboBox cmbTipoCalculo;
        private ReaLTaiizor.Controls.SkyLabel skyLabel6;
        private ReaLTaiizor.Controls.SkyLabel skyLabel7;
        private ReaLTaiizor.Controls.DungeonComboBox cmbTipoMovimiento;
        private RJCodeAdvance.RJControls.RJTextBox txtPerGracia;
        private ReaLTaiizor.Controls.SkyLabel skyLabel8;
        private RJCodeAdvance.RJControls.RJTextBox txtIncremento;
        private ReaLTaiizor.Controls.SkyLabel lblIncremento;
        private ReaLTaiizor.Controls.SkyLabel skyLabel10;
        private ReaLTaiizor.Controls.DungeonComboBox cmbFrecPagos;
        private RJCodeAdvance.RJControls.RJTextBox txtInicio;
        private ReaLTaiizor.Controls.SkyLabel lblInicio;
        private RJCodeAdvance.RJControls.RJTextBox txtFuturoGrad;
        private ReaLTaiizor.Controls.SkyLabel lblFuturoGrad;
        private ReaLTaiizor.Controls.DungeonComboBox cmbIncremento;
    }
}