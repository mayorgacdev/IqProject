using EconomicMF.AppCore.Processes;
using EconomicMF.Domain.Enums;
using RJCodeAdvance.RJControls;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsCalculations
{
    public partial class FrmConvertTime : Form
    {
        #region move
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion
        private FrecuenciaTasa frecuenciaTasa;
        public decimal Time { get; set; }
        public FrmConvertTime(FrecuenciaTasa frecuenciaTasa)
        {
            InitializeComponent();
            this.frecuenciaTasa = frecuenciaTasa;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            Time = ConvertTime.GetTime(frecuenciaTasa, GetValue(txtAños), GetValue(txtMeses), GetValue(txtDias), GetValue(txtHoras));
            
            txtResultado.Text = Time.ToString();
            Equivalencia();
        }

        private void txtAños_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as RJTextBox).Texts.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void FrmConvertTime_Load(object sender, EventArgs e)
        {
            txtResultado.Text = "Conversion en";
            Equivalencia();
        }
        private void Equivalencia()
        {
            switch (frecuenciaTasa)
            {
                case FrecuenciaTasa.Anual: txtResultado.Text += " años"; break;
                case FrecuenciaTasa.Mensual: txtResultado.Text += " meses"; break;
                case FrecuenciaTasa.Semanal: txtResultado.Text += " semanas"; break;
                case FrecuenciaTasa.Semestral: txtResultado.Text += " semestres"; break;
                case FrecuenciaTasa.Diario: txtResultado.Text += " dias"; break;
                case FrecuenciaTasa.Bimestral: txtResultado.Text += " bimestres"; break;
                case FrecuenciaTasa.Trimestral: txtResultado.Text += " trimestres"; break;
                case FrecuenciaTasa.Cuatrimestral: txtResultado.Text += " cuatrimestres"; break;
            }
        }
        private decimal GetValue(RJTextBox rJTextBox)
        {
            if (string.IsNullOrWhiteSpace(rJTextBox.Texts))
            {
                return 0;
            }
            return decimal.Parse(rJTextBox.Texts);
        }

        private void FrmConvertTime_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
