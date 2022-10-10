using EconomicMF.AppCore.Processes;
using EconomicMF.Domain.Enums;
using RJCodeAdvance.RJControls;
using System;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsCalculations
{
    public partial class FrmConvertTime : Form
    {
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
            txtResultado.Texts = Time.ToString();
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
            txtResultado.Texts = "Conversion in";
            Equivalencia();
        }
        private void Equivalencia()
        {
            switch (frecuenciaTasa)
            {
                case FrecuenciaTasa.Anual: txtResultado.Texts += " years"; break;
                case FrecuenciaTasa.Mensual: txtResultado.Texts += " months"; break;
                case FrecuenciaTasa.Semanal: txtResultado.Texts += " weeks"; break;
                case FrecuenciaTasa.Semestral: txtResultado.Texts += " semesters"; break;
                case FrecuenciaTasa.Diario: txtResultado.Texts += " days"; break;
                case FrecuenciaTasa.Bimestral: txtResultado.Texts += " bimesters"; break;
                case FrecuenciaTasa.Trimestral: txtResultado.Texts += " trimesters"; break;
                case FrecuenciaTasa.Cuatrimestral: txtResultado.Texts += " four-month period"; break;
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
    }
}
