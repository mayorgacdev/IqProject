using EconomicEF.Common.UserCache;
using EconomicMF.AppCore.Factories;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Calculos;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums;
using EconomicMF.Domain.Enums.Calculos;
using EconomicMF.Domain.Enums.Conversiones;
using EconomicMF.Helper;
using RJCodeAdvance.RJControls;
using System;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsCalculations
{
    public partial class FrmInteresp : Form
    {
        private readonly IUnitOfWork unitOfWork;
        private string userEmail;

        public FrmInteresp(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.userEmail = DataOnMemory.Email;
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
        }

        private void btnAddFlow_Click(object sender, EventArgs e)
        {
            ////TODO: Add interes to FRMSHOW
            //decimal vf, vp, tasa, nPer;

            ////Calculos cal = (Calculos)Enum.Parse(typeof(Calculos), cmbCalculus.SelectedItem.ToString());
            ////MessageBox.Show(cal.ToString());

            //Usuario user = userServices.GetByEmail(userEmail);
            //if (user == null)
            //{
            //    throw new Exception("Este usuario no existe");
            //}

            //switch ((CalculosInteres)cmbCalculus.SelectedIndex)
            //{
            //    case CalculosInteres.TasaDeInteres:
            //        vf = decimal.Parse(GetText(txtVF));
            //        vp = decimal.Parse(GetText(txtVP));
            //        nPer = decimal.Parse(GetText(txtDuracion));
            //        Validar(vf, vp, nPer);
            //        Interes interes = new Interes()
            //        {
            //            ValorFuturo = vf,
            //            ValorPresente = vp,
            //            NumPeriodos = nPer,
            //            //Periodo = (Periodo)cmbPer.SelectedItem,
            //            TipoInteres = (TipoInteres)cmbType.SelectedItem,
            //            FrecuenciaTasa = ValorCmbPeriodo(),
            //            IdUser = user.Id,

            //        };
            //        interes.TasaInteres = InteresFactory.CreateInstance(((Interes)interes).TipoInteres).CalcularTasa(((Interes)interes));
            //        txtTasa.Texts = txtTasa.Text = (interes.TasaInteres * 100).ToString();

            //        economicClassService.Create(interes);

            //        break;
            //    case CalculosInteres.NumeroDePeriodos:
            //        vf = decimal.Parse(GetText(txtVF));
            //        vp = decimal.Parse(GetText(txtVP));
            //        tasa = decimal.Parse(GetText(txtTasa))/100;
            //        Validar(vf, vp, tasa);
            //        interes = new Interes()
            //        {
            //            ValorFuturo = vf,
            //            ValorPresente = vp,
            //            TasaInteres = tasa,
            //            //Periodo = (Periodo)cmbPer.SelectedItem,
            //            TipoInteres = (TipoInteres)cmbType.SelectedItem,
            //            FrecuenciaTasa = ValorCmbPeriodo(),
            //            IdUser=user.Id,
            //        };
            //        interes.NumPeriodos = InteresFactory.CreateInstance(((Interes)interes).TipoInteres).CalcularTiempo(((Interes)interes));
            //        txtDuracion.Texts = txtDuracion.Texts =interes.NumPeriodos.ToString();


            //        economicClassService.Create(interes);

            //        break;
            //    case CalculosInteres.ValorPresente:
            //        //MessageBox.Show(txtVF.Texts);
            //        vf = decimal.Parse(GetText(txtVF));
            //        tasa = decimal.Parse(GetText(txtTasa))/100;
            //        nPer = decimal.Parse(GetText(txtDuracion));
            //        Validar(vf, nPer, tasa);
            //        interes = new Interes()
            //        {
            //            ValorFuturo = vf,
            //            TasaInteres = tasa,
            //            NumPeriodos = nPer,
            //            //Periodo = (Periodo)cmbPer.SelectedItem,
            //            TipoInteres = (TipoInteres)cmbType.SelectedItem,
            //            FrecuenciaTasa = ValorCmbPeriodo(),
            //            IdUser = user.Id,
            //        };
            //        interes.ValorPresente = InteresFactory.CreateInstance(((Interes)interes).TipoInteres).CalcularVP(((Interes)interes));
            //        //txtVP.Texts = interes.ValorPresente.ToString();
            //        //txtVP.Text = interes.ValorPresente.ToString();
            //        txtVP.Texts = txtVP.Text = interes.ValorPresente.ToString();

            //        //txtVP.Texts = txtVP.Text;
            //        MessageBox.Show(txtVP.Texts);
            //        economicClassService.Create(interes);
            //        break;
            //    case CalculosInteres.ValorFuturo:
            //        tasa = decimal.Parse(GetText(txtTasa))/100;
            //        //MessageBox.Show(txtVP.Text);
            //        vp = decimal.Parse(GetText(txtVP));
            //        nPer = decimal.Parse(GetText(txtDuracion));
            //        Validar(tasa, vp, nPer);
            //        interes = new Interes()
            //        {
            //            TasaInteres = tasa,
            //            ValorPresente = vp,
            //            NumPeriodos = nPer,
            //            //Periodo = (Periodo)cmbPer.SelectedItem,
            //            TipoInteres = (TipoInteres)cmbType.SelectedItem,
            //            FrecuenciaTasa = ValorCmbPeriodo(),
            //            IdUser =user.Id,
            //        };
            //        interes.ValorFuturo = InteresFactory.CreateInstance(((Interes)interes).TipoInteres).CalcularVF(((Interes)interes));
            //        txtVF.Texts = txtVF.Text = interes.ValorFuturo.ToString();

            //        economicClassService.Create(interes);
            //        break;
            //}

            ////calculando el tiempo total 

            ////decimal nper = ConvertTime.GetTime((Periodo)cmbPaymentFrec.SelectedValue, decimal.Parse(txtAños.Texts), decimal.Parse(txtMeses.Texts),
            ////    decimal.Parse(txtDias.Texts), decimal.Parse(txtHoras.Texts));
            ///

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
        private void LimpiarCampos()
        {
            txtDuracion.Texts = string.Empty;
            txtTasa.Texts = string.Empty;
            txtVF.Texts = string.Empty;
            txtVP.Texts = string.Empty;
        }
        private void Validar(decimal valor1, decimal valor2, decimal valor3)
        {
            if (valor1 < 0 || valor2 < 0 || valor3 < 0)
            {
                throw new ArgumentException("No se pueden colocar valores menores o iguales a 0 en ninguno de los campos");
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

        //creo que esto no se va a ocupar 
        private void txtDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyNumbers(e);
        }
        //private string GetText(RJTextBox rJTextBox)
        //{
        //    if (string.IsNullOrWhiteSpace(rJTextBox.Texts))
        //        return rJTextBox.Text;
        //    return rJTextBox.Texts;
        //}
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

            User user = await unitOfWork.UserClient.GetByEmailAsync(userEmail);
            if (user == null)
            {
                throw new Exception("Este usuario no existe");
            }
            vf = GetValue(txtVF);
            vp = GetValue(txtVP);
            tasa = GetValue(txtTasa) / 100;
            nPer = GetValue(txtDuracion);

            switch ((CalculosInteres)cmbCalculus.SelectedIndex)
            {
                case CalculosInteres.TasaDeInteres:
                    Validar(vf, vp, nPer);
                    RateDto interes = new RateDto()
                    {
                        ValorFuturo = vf,
                        ValorPresente = vp,
                        NumPeriodos = nPer,
                        TipoInteres = (TipoInteres)cmbType.SelectedItem,
                        FrecuenciaTasa = ValorCmbPeriodo(),
                        IdUser = user.Id,

                    };
                    interes.TasaInteres = InteresFactory.CreateInstance(((RateDto)interes).TipoInteres).CalcularTasa(((RateDto)interes));
                    txtTasa.Texts = txtTasa.Text = (interes.TasaInteres * 100).ToString();

                    await unitOfWork.EconomicClient.CreateAsync(interes);

                    break;
                case CalculosInteres.NumeroDePeriodos:
                    Validar(vf, vp, tasa);
                    interes = new RateDto()
                    {
                        ValorFuturo = vf,
                        ValorPresente = vp,
                        TasaInteres = tasa,
                        TipoInteres = (TipoInteres)cmbType.SelectedItem,
                        FrecuenciaTasa = ValorCmbPeriodo(),
                        IdUser = user.Id,
                    };
                    interes.NumPeriodos = InteresFactory.CreateInstance(((RateDto)interes).TipoInteres).CalcularTiempo(((RateDto)interes));

                    txtDuracion.Texts = txtDuracion.Texts = interes.NumPeriodos.ToString();
                    await unitOfWork.EconomicClient.CreateAsync(interes);

                    break;
                case CalculosInteres.ValorPresente:
                    Validar(vf, nPer, tasa);
                    interes = new RateDto()
                    {
                        ValorFuturo = vf,
                        TasaInteres = tasa,
                        NumPeriodos = nPer,
                        TipoInteres = (TipoInteres)cmbType.SelectedItem,
                        FrecuenciaTasa = ValorCmbPeriodo(),
                        IdUser = user.Id,
                    };
                    interes.ValorPresente = InteresFactory.CreateInstance(((RateDto)interes).TipoInteres).CalcularVP(((RateDto)interes));
                    txtVP.Texts = txtVP.Text = interes.ValorPresente.ToString();
                    MessageBox.Show(txtVP.Texts);
                    await unitOfWork.EconomicClient.CreateAsync(interes);

                    break;
                case CalculosInteres.ValorFuturo:
                    Validar(tasa, vp, nPer);
                    interes = new RateDto()
                    {
                        TasaInteres = tasa,
                        ValorPresente = vp,
                        NumPeriodos = nPer,
                        TipoInteres = (TipoInteres)cmbType.SelectedItem,
                        FrecuenciaTasa = ValorCmbPeriodo(),
                        IdUser = user.Id,
                    };
                    interes.ValorFuturo = InteresFactory.CreateInstance(((RateDto)interes).TipoInteres).CalcularVF(((RateDto)interes));
                    txtVF.Texts = txtVF.Text = interes.ValorFuturo.ToString();

                    await unitOfWork.EconomicClient.CreateAsync(interes);
                    break;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmConversor frmConversor = new FrmConversor((FrecuenciaTasa)cmbPaymentFrec.SelectedIndex);
            frmConversor.ShowDialog();
            //este if seria opcional 
            if (frmConversor.tasaconvertida != 0)
            {
                txtTasa.Focus();
                txtTasa.Texts = frmConversor.tasaconvertida.ToString();
            }
        }
        private async void añadirInteresPrueba()
        {
            //TODO: Add interes to FRMSHOW
            decimal vf, vp, tasa, nPer;

            User user = await unitOfWork.UserClient.GetByEmailAsync(userEmail);
            if (user == null)
            {
                throw new Exception("Este usuario no existe");
            }
            
            switch ((CalculosInteres)cmbCalculus.SelectedIndex)
            {
                case CalculosInteres.TasaDeInteres:
                    vf = decimal.Parse(txtVF.Texts);
                    vp = decimal.Parse(txtVP.Texts);
                    nPer = decimal.Parse(txtDuracion.Texts);
                    Validar(vf, vp, nPer);
                    RateDto interes = new RateDto()
                    {
                        ValorFuturo = vf,
                        ValorPresente = vp,
                        NumPeriodos = nPer,
                        //Periodo = (Periodo)cmbPer.SelectedItem,
                        TipoInteres = (TipoInteres)cmbType.SelectedItem,
                        FrecuenciaTasa = ValorCmbPeriodo(),
                        IdUser = user.Id,

                    };
                    //interes.TasaInteres = InteresFactory.CreateInstance(((Interes)interes).TipoInteres).CalcularTasa(((Interes)interes));
                    txtTasa.Texts = (interes.TasaInteres * 100).ToString();

                    await unitOfWork.EconomicClient.CreateAsync(interes);

                    break;
                case CalculosInteres.NumeroDePeriodos:
                    vf = decimal.Parse(txtVF.Texts);
                    vp = decimal.Parse(txtVP.Texts);
                    tasa = decimal.Parse(txtTasa.Texts) / 100;
                    Validar(vf, vp, tasa);
                    interes = new RateDto()
                    {
                        ValorFuturo = vf,
                        ValorPresente = vp,
                        TasaInteres = tasa,
                        //Periodo = (Periodo)cmbPer.SelectedItem,
                        TipoInteres = (TipoInteres)cmbType.SelectedItem,
                        FrecuenciaTasa = ValorCmbPeriodo(),
                        IdUser = user.Id,
                    };
                    //interes.NumPeriodos = InteresFactory.CreateInstance(((Interes)interes).TipoInteres).CalcularTiempo(((Interes)interes));
                    txtDuracion.Texts = interes.NumPeriodos.ToString();


                    await unitOfWork.EconomicClient.CreateAsync(interes);

                    break;
                case CalculosInteres.ValorPresente:
                    MessageBox.Show("VP: " + txtVP.Texts);
                    vf = decimal.Parse(txtVF.Texts);
                    tasa = decimal.Parse(txtTasa.Texts) / 100;
                    nPer = decimal.Parse(txtDuracion.Texts);
                    Validar(vf, nPer, tasa);
                    interes = new RateDto()
                    {
                        ValorFuturo = vf,
                        TasaInteres = tasa,
                        NumPeriodos = nPer,
                        //Periodo = (Periodo)cmbPer.SelectedItem,
                        TipoInteres = (TipoInteres)cmbType.SelectedItem,
                        FrecuenciaTasa = ValorCmbPeriodo(),
                        IdUser = user.Id,
                    };
                    interes.ValorPresente = InteresFactory.CreateInstance(((RateDto)interes).TipoInteres).CalcularVP(((RateDto)interes));
                    //txtVP.Texts = interes.ValorPresente.ToString();
                    //txtVP.Text = interes.ValorPresente.ToString();
                    txtVP.Texts = interes.ValorPresente.ToString();
                    //txtVP.Texts = txtVP.Text;
                    //MessageBox.Show(txtVP.Texts);
                    await unitOfWork.EconomicClient.CreateAsync(interes);
                    break;
                case CalculosInteres.ValorFuturo:
                    tasa = decimal.Parse(txtTasa.Texts) / 100;
                    //MessageBox.Show(txtVP.Text);
                    vp = decimal.Parse(txtVP.Texts);
                    nPer = decimal.Parse(txtDuracion.Texts);
                    Validar(tasa, vp, nPer);
                    interes = new RateDto()
                    {
                        TasaInteres = tasa,
                        ValorPresente = vp,
                        NumPeriodos = nPer,
                        //Periodo = (Periodo)cmbPer.SelectedItem,
                        TipoInteres = (TipoInteres)cmbType.SelectedItem,
                        FrecuenciaTasa = ValorCmbPeriodo(),
                        IdUser = user.Id,
                    };
                    interes.ValorFuturo = InteresFactory.CreateInstance(((RateDto)interes).TipoInteres).CalcularVF(((RateDto)interes));
                    txtVF.Texts = interes.ValorFuturo.ToString();

                    await unitOfWork.EconomicClient.CreateAsync(interes);
                    break;
            }
        }

        private void pbTime_Click(object sender, EventArgs e)
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
    }
}
