using EconomicEF.Common.UserCache;
using EconomicMF.AppCore.Factories;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Calculos;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums;
using EconomicMF.Domain.Enums.Calculos;
using EconomicMF.Domain.Enums.Conversiones;
using EconomicMF.Helper;
using EconomicMF.Services.Processes;
using RJCodeAdvance.RJControls;
using System;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsCalculations
{
    public partial class FrmInteresp : Form
    {
        private readonly IUnitOfWork unitOfWork;
        private int solutionId;
        public FrmInteresp(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.solutionId = DataOnMemory.SolutionId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInteresp_Load(object sender, EventArgs e)
        {
            cmbCalculus.DataSource = Enum.GetValues(typeof(CalculosInteres));
            cmbType.DataSource = Enum.GetValues(typeof(TipoInteres));
            cmbPaymentFrec.DataSource = Enum.GetValues(typeof(Periodo));
            lblDuracion.Text = "Duración\n(en años):";
        }

        private void btnAddFlow_Click(object sender, EventArgs e)
        {
            GetInteres();
        }

        private void txtTasa_KeyPress(object sender, KeyPressEventArgs e)
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
        private void VerificarSeleccion()
        {
            //Calculos cal = (Calculos)Enum.Parse(typeof(Calculos), cmbCalculus.SelectedItem.ToString());
            switch ((CalculosInteres)cmbCalculus.SelectedIndex)
            {
                case CalculosInteres.ValorPresente:
                    txtVP.Enabled = false;
                    txtTasa.Enabled = true;
                    txtVF.Enabled = true;
                    txtDuracion.Enabled = true;
                    txtVP.Texts = string.Empty;
                    break;
                case CalculosInteres.ValorFuturo:
                    txtVF.Texts = string.Empty;
                    txtVP.Enabled = true;
                    txtTasa.Enabled = true;
                    txtVF.Enabled = false;
                    txtDuracion.Enabled = true;
                    break;
                case CalculosInteres.TasaDeInteres:
                    txtTasa.Texts = string.Empty;
                    txtVP.Enabled = true;
                    txtTasa.Enabled = false;
                    txtVF.Enabled = true;
                    txtDuracion.Enabled = true;
                    break;
                case CalculosInteres.NumeroDePeriodos:
                    txtDuracion.Texts = string.Empty;
                    txtVP.Enabled = true;
                    txtTasa.Enabled = true;
                    txtVF.Enabled = true;
                    txtDuracion.Enabled = false;
                    break;
            }
        }
        //private void LimpiarCampos()
        //{
        //    txtDuracion.Texts = string.Empty;
        //    txtTasa.Texts = string.Empty;
        //    txtVF.Texts = string.Empty;
        //    txtVP.Texts = string.Empty;
        //}

        private void Validar(decimal valor1, decimal valor2, decimal valor3)
        {
            if (valor1 < 0 || valor2 < 0 || valor3 < 0)
            {
                throw new ArgumentException("No se pueden colocar valores menores o iguales a 0 en ninguno de los campos");
            }
        }

        public void ValidarCampos(string campo1, string campo2, string campo3)
        {
            if(string.IsNullOrWhiteSpace(campo1) || string.IsNullOrWhiteSpace(campo2) || string.IsNullOrWhiteSpace(campo3))
            {
                throw new ArgumentException("No se permiten campos vacios");
            }
            if (decimal.TryParse(campo1, out decimal valor1) || decimal.TryParse(campo2, out decimal valor2) || decimal.TryParse(campo3, out decimal valor3))
            {
                throw new ArgumentException("Los valores no se pudieron convertir para hacer los calculos");
            }
            if (valor1 < 0 || valor2 < 0 || valor3 < 0)
            {
                throw new ArgumentException("No se pueden colocar valores menores o iguales a 0 en ninguno de los campos");
            }
        }
        public void ValidarVacio(string campo1, string campo2, string campo3)
        {
            if (string.IsNullOrWhiteSpace(campo1) || string.IsNullOrWhiteSpace(campo2) || string.IsNullOrWhiteSpace(campo3))
            {
                throw new ArgumentException("No se permiten campos vacios");
            }
        }
        private FrecuenciaTasa ValorCmbPeriodo()
        {
            string nombre = cmbPaymentFrec.SelectedItem.ToString();
            return (FrecuenciaTasa)Enum.Parse(typeof(FrecuenciaTasa), nombre);
        }
        private void cmbCalculus_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarSeleccion();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPaymentFrec.DataSource = null;
            if (cmbType.SelectedItem.Equals(TipoInteres.CompuestoConTasaNominal))
            {
                cmbPaymentFrec.DataSource = Enum.GetValues(typeof(FrecTasaNom));
            }
            else
            {
                cmbPaymentFrec.DataSource = Enum.GetValues(typeof(Periodo));
            }
        }
        private decimal GetValue(RJTextBox rJTextBox)
        {
            if (string.IsNullOrWhiteSpace(rJTextBox.Texts) && string.IsNullOrWhiteSpace(rJTextBox.Text))
            {
                return 0;
            }
            if (string.IsNullOrWhiteSpace(rJTextBox.Texts))
            {
                return decimal.Parse(rJTextBox.Text);
            }
            return decimal.Parse(rJTextBox.Texts);
        }
        private async void GetInteres()
        {
            decimal vf, vp, tasa, nPer;
            Solution solution = await unitOfWork.SolutionClient.GetAsync(solutionId);
            if (solution == null)
            {
                throw new Exception($"La solucion con {solutionId} no existe");
            }
            vf = GetValue(txtVF);
            vp = GetValue(txtVP);
            tasa = GetValue(txtTasa) / 100;
            nPer = GetValue(txtDuracion);
            //ValidarVacio(vf, vp, nPer);
            switch ((CalculosInteres)cmbCalculus.SelectedIndex)
            {
                case CalculosInteres.TasaDeInteres:
                    Validar(vf, vp, nPer);
                    EconomicDto interes = new EconomicDto()
                    {
                        SolutionId = solutionId,
                        FutureValue = vf,
                        PresentValue = vp,
                        NumPeriodos = nPer,
                        TipoInteres = (TipoInteres)cmbType.SelectedItem,
                        FrecuenciaTasa = ValorCmbPeriodo(),
                        Discriminator = Discriminador.Interes.ToString(),
                    };
                    interes.TasaInteres = InteresFactory.CreateInstance((interes).TipoInteres).CalcularTasa(ConvertEconomicDTOS.ConvertRateDto(interes));
                    txtTasa.Texts = txtTasa.Text = (interes.TasaInteres * 100).ToString();

                    await unitOfWork.EconomicClient.CreateAsync(interes);

                    break;
                case CalculosInteres.NumeroDePeriodos:
                    Validar(vf, vp, tasa);
                    interes = new EconomicDto()
                    {
                        FutureValue = vf,
                        PresentValue = vp,
                        TasaInteres = tasa,
                        TipoInteres = (TipoInteres)cmbType.SelectedItem,
                        FrecuenciaTasa = ValorCmbPeriodo(),
                        SolutionId = solutionId,
                        Discriminator = Discriminador.Interes.ToString()
                    };
                    interes.NumPeriodos = InteresFactory.CreateInstance((interes).TipoInteres).CalcularTiempo(ConvertEconomicDTOS.ConvertRateDto(interes));

                    txtDuracion.Texts = txtDuracion.Texts = interes.NumPeriodos.ToString();
                    await unitOfWork.EconomicClient.CreateAsync(interes);

                    break;
                case CalculosInteres.ValorPresente:
                    Validar(vf, nPer, tasa);
                    interes = new EconomicDto()
                    {
                        FutureValue = vf,
                        TasaInteres = tasa,
                        NumPeriodos = nPer,
                        TipoInteres = (TipoInteres)cmbType.SelectedItem,
                        FrecuenciaTasa = ValorCmbPeriodo(),
                        Discriminator = Discriminador.Interes.ToString(),
                        SolutionId = solutionId,
                    };
                    interes.PresentValue = InteresFactory.CreateInstance((interes).TipoInteres).CalcularVP(ConvertEconomicDTOS.ConvertRateDto(interes));
                    txtVP.Texts = txtVP.Text = interes.PresentValue.ToString();
                    MessageBox.Show(txtVP.Texts);
                    await unitOfWork.EconomicClient.CreateAsync(interes);

                    break;
                case CalculosInteres.ValorFuturo:
                    Validar(tasa, vp, nPer);
                    interes = new EconomicDto()
                    {
                        TasaInteres = tasa,
                        PresentValue = vp,
                        NumPeriodos = nPer,
                        TipoInteres = (TipoInteres)cmbType.SelectedItem,
                        FrecuenciaTasa = ValorCmbPeriodo(),
                        SolutionId = solutionId,
                        Discriminator = Discriminador.Interes.ToString()
                    };
                    interes.FutureValue = InteresFactory.CreateInstance((interes).TipoInteres).CalcularVF(ConvertEconomicDTOS.ConvertRateDto(interes));
                    txtVF.Texts = txtVF.Text = interes.FutureValue.ToString();

                    await unitOfWork.EconomicClient.CreateAsync(interes);
                    break;
            }
        }

        private void btnConverTime_Click(object sender, EventArgs e)
        {
            FrecuenciaTasa frecuenciaTasa = (FrecuenciaTasa)Enum.Parse(typeof(FrecuenciaTasa), cmbPaymentFrec.SelectedItem.ToString());
            FrmConvertTime frmConvertTime = new FrmConvertTime(frecuenciaTasa);
            frmConvertTime.ShowDialog();
            //este if seria opcional
            if (frmConvertTime.Time != 0)
            {
                txtDuracion.Focus();
                txtDuracion.Texts = frmConvertTime.Time.ToString();
            }
        }

        private void cmbPaymentFrec_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if(!((TipoInteres)cmbType.SelectedIndex).Equals(TipoInteres.CompuestoConTasaNominal))
            {
                switch ((FrecuenciaTasa)cmbPaymentFrec.SelectedIndex)
                {
                    case FrecuenciaTasa.Anual:
                        lblDuracion.Text = "Duracion \n(en años):";
                        break;
                    case FrecuenciaTasa.Semestral:
                        lblDuracion.Text = "Duracion \n(en semestres):";
                        break;
                    case FrecuenciaTasa.Cuatrimestral:
                        lblDuracion.Text = "Duracion \n(en cuatrimestres):";
                        break;
                    case FrecuenciaTasa.Trimestral:
                        lblDuracion.Text = "Duracion \n(en trimestres):";
                        break;
                    case FrecuenciaTasa.Bimestral:
                        lblDuracion.Text = "Duracion \n(en bimestres):";
                        break;
                    case FrecuenciaTasa.Mensual:
                        lblDuracion.Text = "Duracion \n(en meses):";
                        break;
                    case FrecuenciaTasa.Semanal:
                        lblDuracion.Text = "Duracion \n(en semanas):";
                        break;
                    case FrecuenciaTasa.Diario:
                        lblDuracion.Text = "Duracion \n(en dias):";
                        break;
                } 
            }
        }

        private void cmbType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblDuracion.Text = "Duracion\n(en años): ";
        }
    }
}
