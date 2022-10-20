namespace EconomicMF.Forms.FormsCalculations
{
    partial class FrmAnnuaty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnnuaty));
            this.txtIncremento = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtPerGracia = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtVF = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtDuracion = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtTasa = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtVP = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtPago = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnAddFlow = new RJCodeAdvance.RJControls.RJButton();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.cmbCalculos = new ReaLTaiizor.Controls.DungeonComboBox();
            this.cmbPer = new ReaLTaiizor.Controls.DungeonComboBox();
            this.cmbTipo = new ReaLTaiizor.Controls.DungeonComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCalculos = new System.Windows.Forms.Label();
            this.lblFrec = new System.Windows.Forms.Label();
            this.pnlConvertTasa = new System.Windows.Forms.Panel();
            this.lblConvertRate = new System.Windows.Forms.Label();
            this.pbRate = new System.Windows.Forms.PictureBox();
            this.pnlConvertTime = new System.Windows.Forms.Panel();
            this.rbPerGracia = new ReaLTaiizor.Controls.HopeRadioButton();
            this.rbDuracion = new ReaLTaiizor.Controls.HopeRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConvertTime = new System.Windows.Forms.Label();
            this.pbTime = new System.Windows.Forms.PictureBox();
            this.lblPago = new System.Windows.Forms.Label();
            this.lblVP = new System.Windows.Forms.Label();
            this.lblVF = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblInteres = new System.Windows.Forms.Label();
            this.lblGrace = new System.Windows.Forms.Label();
            this.lblIncrement = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnlConvertTasa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRate)).BeginInit();
            this.pnlConvertTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTime)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIncremento
            // 
            this.txtIncremento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtIncremento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(150)))));
            this.txtIncremento.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIncremento.BorderRadius = 10;
            this.txtIncremento.BorderSize = 2;
            this.txtIncremento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIncremento.ForeColor = System.Drawing.Color.White;
            this.txtIncremento.Location = new System.Drawing.Point(367, 198);
            this.txtIncremento.Margin = new System.Windows.Forms.Padding(4);
            this.txtIncremento.Multiline = false;
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIncremento.PasswordChar = false;
            this.txtIncremento.PlaceholderColor = System.Drawing.Color.White;
            this.txtIncremento.PlaceholderText = "Incremento";
            this.txtIncremento.Size = new System.Drawing.Size(153, 31);
            this.txtIncremento.TabIndex = 49;
            this.txtIncremento.Texts = "";
            this.txtIncremento.UnderlinedStyle = false;
            this.txtIncremento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIncremento_KeyPress);
            // 
            // txtPerGracia
            // 
            this.txtPerGracia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtPerGracia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(150)))));
            this.txtPerGracia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPerGracia.BorderRadius = 10;
            this.txtPerGracia.BorderSize = 2;
            this.txtPerGracia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPerGracia.ForeColor = System.Drawing.Color.White;
            this.txtPerGracia.Location = new System.Drawing.Point(222, 198);
            this.txtPerGracia.Margin = new System.Windows.Forms.Padding(4);
            this.txtPerGracia.Multiline = false;
            this.txtPerGracia.Name = "txtPerGracia";
            this.txtPerGracia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPerGracia.PasswordChar = false;
            this.txtPerGracia.PlaceholderColor = System.Drawing.Color.White;
            this.txtPerGracia.PlaceholderText = "Período de gracia";
            this.txtPerGracia.Size = new System.Drawing.Size(139, 31);
            this.txtPerGracia.TabIndex = 48;
            this.txtPerGracia.Texts = "";
            this.txtPerGracia.UnderlinedStyle = false;
            this.txtPerGracia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuracion_KeyPress);
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
            this.txtVF.Location = new System.Drawing.Point(369, 127);
            this.txtVF.Margin = new System.Windows.Forms.Padding(4);
            this.txtVF.Multiline = false;
            this.txtVF.Name = "txtVF";
            this.txtVF.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtVF.PasswordChar = false;
            this.txtVF.PlaceholderColor = System.Drawing.Color.White;
            this.txtVF.PlaceholderText = "Valor futuro";
            this.txtVF.Size = new System.Drawing.Size(153, 31);
            this.txtVF.TabIndex = 47;
            this.txtVF.Texts = "";
            this.txtVF.UnderlinedStyle = false;
            this.txtVF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidationDecimal_KeyPress);
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
            this.txtDuracion.Location = new System.Drawing.Point(536, 127);
            this.txtDuracion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuracion.Multiline = false;
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDuracion.PasswordChar = false;
            this.txtDuracion.PlaceholderColor = System.Drawing.Color.White;
            this.txtDuracion.PlaceholderText = "Duración";
            this.txtDuracion.Size = new System.Drawing.Size(153, 31);
            this.txtDuracion.TabIndex = 46;
            this.txtDuracion.Texts = "";
            this.txtDuracion.UnderlinedStyle = false;
            this.txtDuracion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuracion_KeyPress);
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
            this.txtTasa.Location = new System.Drawing.Point(55, 198);
            this.txtTasa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTasa.Multiline = false;
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTasa.PasswordChar = false;
            this.txtTasa.PlaceholderColor = System.Drawing.Color.White;
            this.txtTasa.PlaceholderText = "Tasa de interés (%)";
            this.txtTasa.Size = new System.Drawing.Size(153, 31);
            this.txtTasa.TabIndex = 45;
            this.txtTasa.Texts = "";
            this.txtTasa.UnderlinedStyle = false;
            this.txtTasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidationDecimal_KeyPress);
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
            this.txtVP.Location = new System.Drawing.Point(217, 127);
            this.txtVP.Margin = new System.Windows.Forms.Padding(4);
            this.txtVP.Multiline = false;
            this.txtVP.Name = "txtVP";
            this.txtVP.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtVP.PasswordChar = false;
            this.txtVP.PlaceholderColor = System.Drawing.Color.White;
            this.txtVP.PlaceholderText = "Valor presente";
            this.txtVP.Size = new System.Drawing.Size(144, 31);
            this.txtVP.TabIndex = 44;
            this.txtVP.Texts = "";
            this.txtVP.UnderlinedStyle = false;
            this.txtVP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidationDecimal_KeyPress);
            // 
            // txtPago
            // 
            this.txtPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.txtPago.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(150)))));
            this.txtPago.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPago.BorderRadius = 10;
            this.txtPago.BorderSize = 2;
            this.txtPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPago.ForeColor = System.Drawing.Color.White;
            this.txtPago.Location = new System.Drawing.Point(55, 127);
            this.txtPago.Margin = new System.Windows.Forms.Padding(4);
            this.txtPago.Multiline = false;
            this.txtPago.Name = "txtPago";
            this.txtPago.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPago.PasswordChar = false;
            this.txtPago.PlaceholderColor = System.Drawing.Color.White;
            this.txtPago.PlaceholderText = "Pago";
            this.txtPago.Size = new System.Drawing.Size(153, 31);
            this.txtPago.TabIndex = 43;
            this.txtPago.Texts = "";
            this.txtPago.UnderlinedStyle = false;
            this.txtPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValidationDecimal_KeyPress);
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
            this.btnAddFlow.Location = new System.Drawing.Point(55, 236);
            this.btnAddFlow.Name = "btnAddFlow";
            this.btnAddFlow.Size = new System.Drawing.Size(634, 29);
            this.btnAddFlow.TabIndex = 53;
            this.btnAddFlow.Text = "Calcular";
            this.btnAddFlow.TextColor = System.Drawing.Color.White;
            this.btnAddFlow.UseVisualStyleBackColor = false;
            this.btnAddFlow.Click += new System.EventHandler(this.btnAddFlow_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(361, 306);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 38);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 54;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbCalculos
            // 
            this.cmbCalculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbCalculos.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbCalculos.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbCalculos.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbCalculos.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbCalculos.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbCalculos.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbCalculos.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbCalculos.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbCalculos.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbCalculos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCalculos.DropDownHeight = 100;
            this.cmbCalculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalculos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCalculos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.cmbCalculos.FormattingEnabled = true;
            this.cmbCalculos.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbCalculos.IntegralHeight = false;
            this.cmbCalculos.ItemHeight = 20;
            this.cmbCalculos.Location = new System.Drawing.Point(505, 59);
            this.cmbCalculos.Name = "cmbCalculos";
            this.cmbCalculos.Size = new System.Drawing.Size(200, 26);
            this.cmbCalculos.StartIndex = 0;
            this.cmbCalculos.TabIndex = 55;
            this.cmbCalculos.SelectionChangeCommitted += new System.EventHandler(this.cmbCalculos_SelectionChangeCommitted);
            // 
            // cmbPer
            // 
            this.cmbPer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbPer.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbPer.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbPer.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbPer.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbPer.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbPer.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbPer.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbPer.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbPer.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbPer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPer.DropDownHeight = 100;
            this.cmbPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbPer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.cmbPer.FormattingEnabled = true;
            this.cmbPer.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbPer.IntegralHeight = false;
            this.cmbPer.ItemHeight = 20;
            this.cmbPer.Location = new System.Drawing.Point(280, 59);
            this.cmbPer.Name = "cmbPer";
            this.cmbPer.Size = new System.Drawing.Size(200, 26);
            this.cmbPer.StartIndex = 0;
            this.cmbPer.TabIndex = 56;
            this.cmbPer.SelectedIndexChanged += new System.EventHandler(this.cmbPer_SelectedIndexChanged);
            this.cmbPer.SelectionChangeCommitted += new System.EventHandler(this.cmbPer_SelectionChangeCommitted);
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbTipo.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbTipo.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbTipo.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbTipo.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbTipo.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.cmbTipo.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cmbTipo.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.cmbTipo.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.cmbTipo.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.cmbTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipo.DropDownHeight = 100;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cmbTipo.IntegralHeight = false;
            this.cmbTipo.ItemHeight = 20;
            this.cmbTipo.Location = new System.Drawing.Point(53, 59);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(200, 26);
            this.cmbTipo.StartIndex = 0;
            this.cmbTipo.TabIndex = 57;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(65, 20);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(133, 21);
            this.lblType.TabIndex = 83;
            this.lblType.Text = "Tipo de anualidad";
            // 
            // lblCalculos
            // 
            this.lblCalculos.AutoSize = true;
            this.lblCalculos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCalculos.ForeColor = System.Drawing.Color.White;
            this.lblCalculos.Location = new System.Drawing.Point(556, 20);
            this.lblCalculos.Name = "lblCalculos";
            this.lblCalculos.Size = new System.Drawing.Size(66, 21);
            this.lblCalculos.TabIndex = 84;
            this.lblCalculos.Text = "Calcular";
            // 
            // lblFrec
            // 
            this.lblFrec.AutoSize = true;
            this.lblFrec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFrec.ForeColor = System.Drawing.Color.White;
            this.lblFrec.Location = new System.Drawing.Point(299, 20);
            this.lblFrec.Name = "lblFrec";
            this.lblFrec.Size = new System.Drawing.Size(144, 21);
            this.lblFrec.TabIndex = 85;
            this.lblFrec.Text = "Frecuencia de pago";
            // 
            // pnlConvertTasa
            // 
            this.pnlConvertTasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.pnlConvertTasa.Controls.Add(this.lblConvertRate);
            this.pnlConvertTasa.Controls.Add(this.pbRate);
            this.pnlConvertTasa.Location = new System.Drawing.Point(65, 294);
            this.pnlConvertTasa.Name = "pnlConvertTasa";
            this.pnlConvertTasa.Size = new System.Drawing.Size(218, 64);
            this.pnlConvertTasa.TabIndex = 88;
            // 
            // lblConvertRate
            // 
            this.lblConvertRate.AutoSize = true;
            this.lblConvertRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConvertRate.ForeColor = System.Drawing.Color.White;
            this.lblConvertRate.Location = new System.Drawing.Point(70, 22);
            this.lblConvertRate.Name = "lblConvertRate";
            this.lblConvertRate.Size = new System.Drawing.Size(107, 21);
            this.lblConvertRate.TabIndex = 85;
            this.lblConvertRate.Text = "Convertir tasa";
            // 
            // pbRate
            // 
            this.pbRate.Image = ((System.Drawing.Image)(resources.GetObject("pbRate.Image")));
            this.pbRate.Location = new System.Drawing.Point(9, 8);
            this.pbRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbRate.Name = "pbRate";
            this.pbRate.Size = new System.Drawing.Size(55, 48);
            this.pbRate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRate.TabIndex = 86;
            this.pbRate.TabStop = false;
            this.pbRate.Click += new System.EventHandler(this.pbRate_Click);
            // 
            // pnlConvertTime
            // 
            this.pnlConvertTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.pnlConvertTime.Controls.Add(this.rbPerGracia);
            this.pnlConvertTime.Controls.Add(this.rbDuracion);
            this.pnlConvertTime.Controls.Add(this.label1);
            this.pnlConvertTime.Controls.Add(this.lblConvertTime);
            this.pnlConvertTime.Controls.Add(this.pbTime);
            this.pnlConvertTime.Location = new System.Drawing.Point(476, 271);
            this.pnlConvertTime.Name = "pnlConvertTime";
            this.pnlConvertTime.Size = new System.Drawing.Size(228, 116);
            this.pnlConvertTime.TabIndex = 89;
            // 
            // rbPerGracia
            // 
            this.rbPerGracia.AutoSize = true;
            this.rbPerGracia.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.rbPerGracia.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.rbPerGracia.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.rbPerGracia.Enable = true;
            this.rbPerGracia.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.rbPerGracia.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.rbPerGracia.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.rbPerGracia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbPerGracia.ForeColor = System.Drawing.Color.White;
            this.rbPerGracia.Location = new System.Drawing.Point(70, 85);
            this.rbPerGracia.Name = "rbPerGracia";
            this.rbPerGracia.Size = new System.Drawing.Size(155, 20);
            this.rbPerGracia.TabIndex = 100;
            this.rbPerGracia.TabStop = true;
            this.rbPerGracia.Text = "Período de gracía";
            this.rbPerGracia.UseVisualStyleBackColor = true;
            // 
            // rbDuracion
            // 
            this.rbDuracion.AutoSize = true;
            this.rbDuracion.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.rbDuracion.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.rbDuracion.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.rbDuracion.Enable = true;
            this.rbDuracion.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.rbDuracion.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.rbDuracion.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.rbDuracion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbDuracion.ForeColor = System.Drawing.Color.White;
            this.rbDuracion.Location = new System.Drawing.Point(70, 59);
            this.rbDuracion.Name = "rbDuracion";
            this.rbDuracion.Size = new System.Drawing.Size(98, 20);
            this.rbDuracion.TabIndex = 97;
            this.rbDuracion.TabStop = true;
            this.rbDuracion.Text = "Duración";
            this.rbDuracion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 99;
            this.label1.Text = "para:";
            // 
            // lblConvertTime
            // 
            this.lblConvertTime.AutoSize = true;
            this.lblConvertTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConvertTime.ForeColor = System.Drawing.Color.White;
            this.lblConvertTime.Location = new System.Drawing.Point(70, 8);
            this.lblConvertTime.Name = "lblConvertTime";
            this.lblConvertTime.Size = new System.Drawing.Size(128, 21);
            this.lblConvertTime.TabIndex = 85;
            this.lblConvertTime.Text = "Convertir tiempo";
            // 
            // pbTime
            // 
            this.pbTime.Image = ((System.Drawing.Image)(resources.GetObject("pbTime.Image")));
            this.pbTime.Location = new System.Drawing.Point(9, 8);
            this.pbTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbTime.Name = "pbTime";
            this.pbTime.Size = new System.Drawing.Size(55, 48);
            this.pbTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTime.TabIndex = 86;
            this.pbTime.TabStop = false;
            this.pbTime.Click += new System.EventHandler(this.pbTime_Click);
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPago.ForeColor = System.Drawing.Color.White;
            this.lblPago.Location = new System.Drawing.Point(90, 102);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(44, 21);
            this.lblPago.TabIndex = 90;
            this.lblPago.Text = "Pago";
            // 
            // lblVP
            // 
            this.lblVP.AutoSize = true;
            this.lblVP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVP.ForeColor = System.Drawing.Color.White;
            this.lblVP.Location = new System.Drawing.Point(225, 102);
            this.lblVP.Name = "lblVP";
            this.lblVP.Size = new System.Drawing.Size(110, 21);
            this.lblVP.TabIndex = 91;
            this.lblVP.Text = "Valor presente";
            // 
            // lblVF
            // 
            this.lblVF.AutoSize = true;
            this.lblVF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVF.ForeColor = System.Drawing.Color.White;
            this.lblVF.Location = new System.Drawing.Point(389, 102);
            this.lblVF.Name = "lblVF";
            this.lblVF.Size = new System.Drawing.Size(93, 21);
            this.lblVF.TabIndex = 92;
            this.lblVF.Text = "Valor futuro";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDuration.ForeColor = System.Drawing.Color.White;
            this.lblDuration.Location = new System.Drawing.Point(541, 102);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(148, 21);
            this.lblDuration.TabIndex = 93;
            this.lblDuration.Text = "Duración (en  años):";
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInteres.ForeColor = System.Drawing.Color.White;
            this.lblInteres.Location = new System.Drawing.Point(65, 173);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(137, 21);
            this.lblInteres.TabIndex = 96;
            this.lblInteres.Text = "Tasa de interés(%):";
            // 
            // lblGrace
            // 
            this.lblGrace.AutoSize = true;
            this.lblGrace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGrace.ForeColor = System.Drawing.Color.White;
            this.lblGrace.Location = new System.Drawing.Point(225, 173);
            this.lblGrace.Name = "lblGrace";
            this.lblGrace.Size = new System.Drawing.Size(130, 21);
            this.lblGrace.TabIndex = 95;
            this.lblGrace.Text = "Período de gracia";
            // 
            // lblIncrement
            // 
            this.lblIncrement.AutoSize = true;
            this.lblIncrement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIncrement.ForeColor = System.Drawing.Color.White;
            this.lblIncrement.Location = new System.Drawing.Point(389, 173);
            this.lblIncrement.Name = "lblIncrement";
            this.lblIncrement.Size = new System.Drawing.Size(89, 21);
            this.lblIncrement.TabIndex = 94;
            this.lblIncrement.Text = "Incremento";
            // 
            // FrmAnnuaty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(748, 399);
            this.Controls.Add(this.lblInteres);
            this.Controls.Add(this.lblGrace);
            this.Controls.Add(this.lblIncrement);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblVF);
            this.Controls.Add(this.lblVP);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.pnlConvertTime);
            this.Controls.Add(this.pnlConvertTasa);
            this.Controls.Add(this.lblFrec);
            this.Controls.Add(this.lblCalculos);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmbPer);
            this.Controls.Add(this.cmbCalculos);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddFlow);
            this.Controls.Add(this.txtIncremento);
            this.Controls.Add(this.txtPerGracia);
            this.Controls.Add(this.txtVF);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtTasa);
            this.Controls.Add(this.txtVP);
            this.Controls.Add(this.txtPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAnnuaty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnnuaty";
            this.Load += new System.EventHandler(this.FrmAnnuaty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnlConvertTasa.ResumeLayout(false);
            this.pnlConvertTasa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRate)).EndInit();
            this.pnlConvertTime.ResumeLayout(false);
            this.pnlConvertTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RJCodeAdvance.RJControls.RJTextBox txtIncremento;
        private RJCodeAdvance.RJControls.RJTextBox txtPerGracia;
        private RJCodeAdvance.RJControls.RJTextBox txtVF;
        private RJCodeAdvance.RJControls.RJTextBox txtDuracion;
        private RJCodeAdvance.RJControls.RJTextBox txtTasa;
        private RJCodeAdvance.RJControls.RJTextBox txtVP;
        private RJCodeAdvance.RJControls.RJTextBox txtPago;
        private RJCodeAdvance.RJControls.RJButton btnAddFlow;
        private System.Windows.Forms.PictureBox btnClose;
        private ReaLTaiizor.Controls.DungeonComboBox cmbCalculos;
        private ReaLTaiizor.Controls.DungeonComboBox cmbPer;
        private ReaLTaiizor.Controls.DungeonComboBox cmbTipo;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCalculos;
        private System.Windows.Forms.Label lblFrec;
        private System.Windows.Forms.Panel pnlConvertTasa;
        private System.Windows.Forms.Label lblConvertRate;
        private System.Windows.Forms.PictureBox pbRate;
        private System.Windows.Forms.Panel pnlConvertTime;
        private System.Windows.Forms.Label lblConvertTime;
        private System.Windows.Forms.PictureBox pbTime;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Label lblVP;
        private System.Windows.Forms.Label lblVF;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.Label lblGrace;
        private System.Windows.Forms.Label lblIncrement;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.HopeRadioButton rbPerGracia;
        private ReaLTaiizor.Controls.HopeRadioButton rbDuracion;
    }
}