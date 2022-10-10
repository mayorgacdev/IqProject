using EconomicEF.Common.UserCache;
using EconomicMF.AppCore.Factories;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Calculos;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums;
using EconomicMF.Domain.Enums.Calculos;
using EconomicMF.Helper;
using RJCodeAdvance.RJControls;
using System;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsCalculations
{
    public partial class FrmAnnuaty : Form
    {
        private readonly IUnitOfWork unitOfWork;
        private string userEmail;

        public FrmAnnuaty(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.userEmail = DataOnMemory.Email;
        }

        private void FrmAnnuaty_Load(object sender, EventArgs e)
        {
            cmbTipo.DataSource = Enum.GetValues(typeof(TipoAnualidad));
            cmbPer.DataSource = Enum.GetValues(typeof(Periodo));
            cmbCalculos.DataSource = Enum.GetValues(typeof(CalculoAnualidad));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddFlow_Click(object sender, EventArgs e)
        {
            //TODO: Add annuaty to FRMSHOW
            Calculos cal = (Calculos)Enum.Parse(typeof(Calculos), cmbCalculos.SelectedValue.ToString());

            if (!cmbTipo.SelectedItem.Equals(TipoAnualidad.SerieGeometrica) && !cmbTipo.SelectedItem.Equals(TipoAnualidad.SerieAritmetica))
            {
                switch (cmbTipo.SelectedItem)
                {
                    case TipoAnualidad.AnualidadOrdinaria:
                    case TipoAnualidad.AnualidadAnticipada:
                    case TipoAnualidad.AnualidadDiferida:
                    case TipoAnualidad.AnualidadPerpetua:
                        TipoCalculoAnualidad(cal, (TipoAnualidad)cmbTipo.SelectedValue);
                        break;
                }
            }
            else
            {
                switch (cmbTipo.SelectedItem)
                {
                    case TipoAnualidad.SerieGeometrica:
                    case TipoAnualidad.SerieAritmetica:
                        TipoCalculoSerie(cal, (TipoAnualidad)cmbTipo.SelectedValue);
                        break;
                }
            }
        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
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
        private async void TipoCalculoAnualidad(Calculos calculo, TipoAnualidad tipo)
        {
            decimal vf = 0, nper = 0;
            int perGracia = 0;
            if (tipo.Equals(TipoAnualidad.AnualidadPerpetua))
            {
                vf = decimal.MaxValue;
                nper = decimal.MaxValue;
            }
            else
            {
                //MessageBox.Show(txtVF.Texts);
                //MessageBox.Show(txtVF.Text);
                if (!calculo.Equals(Calculos.ValorFuturo))
                {
                    vf = (string.IsNullOrWhiteSpace(txtVF.Texts)) ? decimal.Parse(txtVF.Text) : decimal.Parse(txtVF.Texts); 
                }
                if (!calculo.Equals(Calculos.NumeroDePeriodos))
                {
                    nper = (string.IsNullOrWhiteSpace(txtDuracion.Texts)) ? decimal.Parse(txtDuracion.Text) : decimal.Parse(txtDuracion.Texts); 
                }
            }
            if (tipo.Equals(TipoAnualidad.AnualidadDiferida))
            {
                perGracia = (string.IsNullOrWhiteSpace(txtPerGracia.Texts)) ? int.Parse(txtPerGracia.Text) : int.Parse(txtPerGracia.Texts);
            }
            User user = await unitOfWork.UserClient.GetByEmailAsync(userEmail);
            if (user == null)
            {
                throw new Exception("Este usuario no existe");
            }
            switch (calculo)
            {
                case Calculos.ValorPresente:
                    EconomicDto anualidad = new AnnuityDto()
                    {
                        ValorFuturo = vf,
                        PagoAnual = (string.IsNullOrWhiteSpace(txtPago.Texts)) ? decimal.Parse(txtPago.Text) : decimal.Parse(txtPago.Texts),
                        NumPeriodos = nper,
                        TasaInteres = (string.IsNullOrWhiteSpace(txtTasa.Texts)) ? decimal.Parse(txtTasa.Text)/100 : decimal.Parse(txtTasa.Texts) / 100,
                        TipoAnualidad = tipo,
                        PeriodoGracia = perGracia,
                        Periodo = (Periodo)cmbPer.SelectedItem,
                        IdUser = user.Id,
                    };
                    anualidad.ValorPresente = AnualidadSeriesFactory.CreateInstance((TipoAnualidad)cmbTipo.SelectedItem).CalcularVP(((AnnuityDto)anualidad));
                    txtVP.Texts = txtVP.Text = anualidad.ValorPresente.ToString();

                    await unitOfWork.EconomicClient.CreateAsync(anualidad);

                    break;
                case Calculos.ValorFuturo:
                    anualidad = new AnnuityDto()
                    {
                        ValorPresente = (string.IsNullOrWhiteSpace(txtVP.Texts)) ? decimal.Parse(txtVP.Text) : decimal.Parse(txtVP.Texts),
                        PagoAnual = (string.IsNullOrWhiteSpace(txtPago.Texts)) ? decimal.Parse(txtPago.Text) : decimal.Parse(txtPago.Texts),
                        NumPeriodos = nper,
                        TasaInteres = (string.IsNullOrWhiteSpace(txtTasa.Texts)) ? decimal.Parse(txtTasa.Text)/100 : decimal.Parse(txtTasa.Texts) / 100,
                        TipoAnualidad = tipo,
                        PeriodoGracia = perGracia,
                        Periodo = (Periodo)cmbPer.SelectedItem,
                        IdUser = user.Id,
                    };
                    anualidad.ValorFuturo = AnualidadSeriesFactory.CreateInstance((TipoAnualidad)cmbTipo.SelectedItem).CalcularVF(((AnnuityDto)anualidad));
                    txtVF.Texts = txtVF.Text = anualidad.ValorFuturo.ToString();

                    await unitOfWork.EconomicClient.CreateAsync(anualidad);

                    break;
                case Calculos.NumeroDePeriodos:
                    anualidad = new AnnuityDto()
                    {
                        ValorFuturo = vf,
                        PagoAnual = (string.IsNullOrWhiteSpace(txtPago.Texts)) ? decimal.Parse(txtPago.Text) : decimal.Parse(txtPago.Texts),
                        ValorPresente = (string.IsNullOrWhiteSpace(txtVP.Texts)) ? decimal.Parse(txtVP.Text) : decimal.Parse(txtVP.Texts),
                        TasaInteres = (string.IsNullOrWhiteSpace(txtTasa.Texts)) ? decimal.Parse(txtTasa.Text)/100 : decimal.Parse(txtTasa.Texts) / 100,
                        TipoAnualidad = tipo,
                        PeriodoGracia = perGracia,
                        Periodo = (Periodo)cmbPer.SelectedItem,
                        IdUser = user.Id,
                    };
                    anualidad.NumPeriodos = AnualidadSeriesFactory.CreateInstance((TipoAnualidad)cmbTipo.SelectedItem).CalcularTiempo(((AnnuityDto)anualidad));
                    txtDuracion.Texts =txtDuracion.Text= anualidad.NumPeriodos.ToString();

                    await unitOfWork.EconomicClient.CreateAsync(anualidad);

                    break;
                case Calculos.TasaDeInteres:
                    anualidad = new AnnuityDto()
                    {
                        ValorFuturo = vf,
                        PagoAnual = (string.IsNullOrWhiteSpace(txtPago.Texts)) ? decimal.Parse(txtPago.Text) : decimal.Parse(txtPago.Texts),
                        NumPeriodos = nper,
                        ValorPresente = (string.IsNullOrWhiteSpace(txtVP.Texts)) ? decimal.Parse(txtVP.Text) : decimal.Parse(txtVP.Texts),
                        TipoAnualidad = tipo,
                        PeriodoGracia = perGracia,
                        Periodo = (Periodo)cmbPer.SelectedItem,
                        IdUser = user.Id,
                    };
                    anualidad.TasaInteres = AnualidadSeriesFactory.CreateInstance((TipoAnualidad)cmbTipo.SelectedItem).CalcularTasa(((AnnuityDto)anualidad));
                    txtTasa.Texts = txtTasa.Text = (anualidad.TasaInteres*100).ToString();

                    await unitOfWork.EconomicClient.CreateAsync(anualidad);

                    break;
                case Calculos.Pago:
                    anualidad = new AnnuityDto()
                    {
                        ValorFuturo = vf,
                        ValorPresente = (string.IsNullOrWhiteSpace(txtVP.Texts)) ? decimal.Parse(txtVP.Text) : decimal.Parse(txtVP.Texts),
                        NumPeriodos = nper,
                        TasaInteres = (string.IsNullOrWhiteSpace(txtTasa.Texts)) ? decimal.Parse(txtTasa.Text)/100 : decimal.Parse(txtTasa.Texts) / 100,
                        TipoAnualidad = tipo,
                        PeriodoGracia = perGracia,
                        Periodo = (Periodo)cmbPer.SelectedItem,
                        IdUser = user.Id,
                    };
                    ((AnnuityDto)anualidad).PagoAnual = AnualidadSeriesFactory.CreateInstance((TipoAnualidad)cmbTipo.SelectedItem).CalcularPago(((AnnuityDto)anualidad));
                    txtPago.Texts =txtPago.Text =((AnnuityDto)anualidad).PagoAnual.ToString();

                    await unitOfWork.EconomicClient.CreateAsync(anualidad);

                    break;
            }
        }
        private async void TipoCalculoSerie(Calculos calculo, TipoAnualidad tipo)
        {
            int perGracia = 0;
            decimal incremento;
            //TODO: verificar este if
            if (tipo.Equals(TipoAnualidad.AnualidadDiferida))
            {
                perGracia = (string.IsNullOrWhiteSpace(txtPerGracia.Texts)) ? int.Parse(txtPerGracia.Text) : int.Parse(txtPerGracia.Texts);
            }
            incremento = (string.IsNullOrWhiteSpace(txtIncremento.Texts)) ? decimal.Parse(txtIncremento.Text) : decimal.Parse(txtIncremento.Texts); 
            User user = await unitOfWork.UserClient.GetByEmailAsync(userEmail);
            if (user == null)
            {
                throw new Exception("Este usuario no existe");
            }
            switch (calculo)
            {
                case Calculos.ValorPresente:
                    //cambio por economicClass
                    EconomicDto series = new Serie()
                    {
                        ValorFuturo = (string.IsNullOrWhiteSpace(txtVF.Texts)) ? decimal.Parse(txtVF.Text) : decimal.Parse(txtVF.Texts),
                        PagoAnual = (string.IsNullOrWhiteSpace(txtPago.Texts)) ? decimal.Parse(txtPago.Text) : decimal.Parse(txtPago.Texts),
                        NumPeriodos = (string.IsNullOrWhiteSpace(txtDuracion.Texts)) ? decimal.Parse(txtDuracion.Text) : decimal.Parse(txtDuracion.Texts),
                        TasaInteres = (string.IsNullOrWhiteSpace(txtTasa.Texts)) ? decimal.Parse(txtTasa.Text)/100 : decimal.Parse(txtTasa.Texts) / 100,
                        TipoAnualidad = tipo,
                        PeriodoGracia = perGracia,
                        Periodo = (Periodo)cmbPer.SelectedItem,
                        TipoDeCrecimiento = tipo.Equals(TipoAnualidad.SerieAritmetica) ? TipoCrecimiento.Aritmetico : TipoCrecimiento.Geometrico,
                        Crecimiento = tipo.Equals(TipoAnualidad.SerieAritmetica) ? incremento : incremento / 100,
                        IdUser = user.Id,
                    };
                    series.ValorPresente = AnualidadSeriesFactory.CreateInstance(tipo).CalcularVP((Serie)series);
                    txtVP.Texts = txtVP.Text = series.ValorPresente.ToString();

                    await unitOfWork.EconomicClient.CreateAsync(series);

                    break;
                case Calculos.ValorFuturo:
                    series = new Serie()
                    {
                        ValorPresente = (string.IsNullOrWhiteSpace(txtVP.Texts)) ? decimal.Parse(txtVP.Text) : decimal.Parse(txtVP.Texts),
                        PagoAnual = (string.IsNullOrWhiteSpace(txtPago.Texts)) ? decimal.Parse(txtPago.Text) : decimal.Parse(txtPago.Texts),
                        NumPeriodos = (string.IsNullOrWhiteSpace(txtDuracion.Texts)) ? decimal.Parse(txtDuracion.Text) : decimal.Parse(txtDuracion.Texts),
                        TasaInteres = (string.IsNullOrWhiteSpace(txtTasa.Texts)) ? decimal.Parse(txtTasa.Text) / 100 : decimal.Parse(txtTasa.Texts) / 100,
                        TipoAnualidad = tipo,
                        PeriodoGracia = perGracia,
                        Periodo = (Periodo)cmbPer.SelectedItem,
                        TipoDeCrecimiento = tipo.Equals(TipoAnualidad.SerieAritmetica) ? TipoCrecimiento.Aritmetico : TipoCrecimiento.Geometrico,
                        Crecimiento = tipo.Equals(TipoAnualidad.SerieAritmetica) ? incremento : incremento / 100,
                        IdUser = user.Id,
                    };
                    series.ValorFuturo = AnualidadSeriesFactory.CreateInstance(tipo).CalcularVF((Serie)series);
                    txtVF.Texts = txtVF.Text =series.ValorFuturo.ToString();

                    await unitOfWork.EconomicClient.CreateAsync(series);

                    break;
                case Calculos.Pago:
                    series = new Serie()
                    {
                        ValorFuturo = (string.IsNullOrWhiteSpace(txtVF.Texts)) ? decimal.Parse(txtVF.Text) : decimal.Parse(txtVF.Texts),
                        ValorPresente = (string.IsNullOrWhiteSpace(txtVP.Texts)) ? decimal.Parse(txtVP.Text) : decimal.Parse(txtVP.Texts),
                        NumPeriodos = (string.IsNullOrWhiteSpace(txtDuracion.Texts)) ? decimal.Parse(txtDuracion.Text) : decimal.Parse(txtDuracion.Texts),
                        TasaInteres = (string.IsNullOrWhiteSpace(txtTasa.Texts)) ? decimal.Parse(txtTasa.Text) / 100 : decimal.Parse(txtTasa.Texts) / 100,
                        TipoAnualidad = tipo,
                        PeriodoGracia = perGracia,
                        Periodo = (Periodo)cmbPer.SelectedItem,
                        TipoDeCrecimiento = tipo.Equals(TipoAnualidad.SerieAritmetica) ? TipoCrecimiento.Aritmetico : TipoCrecimiento.Geometrico,
                        Crecimiento = tipo.Equals(TipoAnualidad.SerieAritmetica) ? incremento : incremento / 100,
                        IdUser = user.Id,
                    };
                    ((Serie)series).PagoAnual = AnualidadSeriesFactory.CreateInstance(tipo).CalcularPago((Serie)series);
                    txtPago.Texts = txtPago.Text = ((Serie)series).PagoAnual.ToString();

                    await unitOfWork.EconomicClient.CreateAsync(series);

                    break;
                case Calculos.Incremento:
                    series = new Serie()
                    {
                        ValorFuturo = (string.IsNullOrWhiteSpace(txtVF.Texts)) ? decimal.Parse(txtVF.Text) : decimal.Parse(txtVF.Texts),
                        PagoAnual = (string.IsNullOrWhiteSpace(txtPago.Texts)) ? decimal.Parse(txtPago.Text) : decimal.Parse(txtPago.Texts),
                        NumPeriodos = (string.IsNullOrWhiteSpace(txtDuracion.Texts)) ? decimal.Parse(txtDuracion.Text) : decimal.Parse(txtDuracion.Texts),
                        TasaInteres = (string.IsNullOrWhiteSpace(txtTasa.Texts)) ? decimal.Parse(txtTasa.Text) / 100 : decimal.Parse(txtTasa.Texts) / 100,
                        TipoAnualidad = tipo,
                        PeriodoGracia = perGracia,
                        Periodo = (Periodo)cmbPer.SelectedItem,
                        TipoDeCrecimiento = tipo.Equals(TipoAnualidad.SerieAritmetica) ? TipoCrecimiento.Aritmetico : TipoCrecimiento.Geometrico,
                        ValorPresente = (string.IsNullOrWhiteSpace(txtVP.Texts)) ? decimal.Parse(txtVP.Text) : decimal.Parse(txtVP.Texts),
                        IdUser = user.Id
                    };
                    ((Serie)series).Crecimiento = AnualidadSeriesFactory.CreateInstance(tipo).CalcularGradiente((Serie)series);
                    txtIncremento.Texts =txtIncremento.Text = ((Serie)series).Crecimiento.ToString();

                    await unitOfWork.EconomicClient.CreateAsync(series);

                    break;
            }
        }

        private void cmbCalculos_SelectionChangeCommitted(object sender, EventArgs e)
        {

            VerificarSelecCalculos();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblGracia.Visible = (cmbTipo.SelectedValue.Equals(TipoAnualidad.AnualidadDiferida));

            //TODO: esta linea no estaba comentada
            //txtPerGracia.Visible = (cmbTipo.SelectedValue.Equals(TipoAnualidad.AnualidadDiferida));

            //lblDuracion.Visible = (!cmbTipo.SelectedValue.Equals(TipoAnualidad.AnualidadPerpetua));

            //TODO: esta linea no estaba comentada
            //txtDuracion.Visible = (!cmbTipo.SelectedValue.Equals(TipoAnualidad.AnualidadPerpetua)); ;

            //lblVF.Visible = (!cmbTipo.SelectedValue.Equals(TipoAnualidad.AnualidadPerpetua));

            //TODO: esta linea no estaba comentada
            //txtVF.Visible = (!cmbTipo.SelectedValue.Equals(TipoAnualidad.AnualidadPerpetua));

            //TODO: esta linea no estaba comentada
            //txtIncremento.Visible = (cmbTipo.SelectedValue.Equals(TipoAnualidad.SerieAritmetica) || cmbTipo.SelectedValue.Equals(TipoAnualidad.SerieGeometrica));
            //lblIncremento.Visible = (cmbTipo.SelectedValue.Equals(TipoAnualidad.SerieAritmetica) || cmbTipo.SelectedValue.Equals(TipoAnualidad.SerieGeometrica));

            cmbCalculos.DataSource = null;
            switch (cmbTipo.SelectedValue)
            {
                case TipoAnualidad.AnualidadOrdinaria:
                    cmbCalculos.DataSource = Enum.GetValues(typeof(CalculoAnualidad));
                    break;
                case TipoAnualidad.AnualidadAnticipada:
                    cmbCalculos.DataSource = Enum.GetValues(typeof(CalculoAnualidad));
                    break;
                case TipoAnualidad.AnualidadDiferida:
                    cmbCalculos.DataSource = Enum.GetValues(typeof(CalculoAnualidad));
                    break;
                case TipoAnualidad.AnualidadPerpetua:
                    cmbCalculos.DataSource = Enum.GetValues(typeof(CalculoAnualidadPerp));

                    break;
                case TipoAnualidad.SerieAritmetica:
                    cmbCalculos.DataSource = Enum.GetValues(typeof(CalculosSeries));
                    break;
                case TipoAnualidad.SerieGeometrica:
                    cmbCalculos.DataSource = Enum.GetValues(typeof(CalculosSeries));
                    break;
            }
            VerificarSelecCalculos();
        }
        private void VerificarSelecCalculos()
        {
            Calculos cal = (Calculos)Enum.Parse(typeof(Calculos), cmbCalculos.SelectedValue.ToString());

            txtVP.Enabled = !cal.Equals(Calculos.ValorPresente);
            txtTasa.Enabled = !cal.Equals(Calculos.TasaDeInteres);
            txtVF.Enabled = !cal.Equals(Calculos.ValorFuturo);
            txtDuracion.Enabled = !cal.Equals(Calculos.NumeroDePeriodos);
            txtPago.Enabled = !cal.Equals(Calculos.Pago);
            txtIncremento.Enabled = !cal.Equals(Calculos.Incremento);

            txtVP.Texts = (cal.Equals(Calculos.ValorPresente)) ? string.Empty : txtVP.Texts;
            txtVF.Texts = (cal.Equals(Calculos.ValorFuturo)) ? string.Empty : txtVF.Texts;
            txtTasa.Texts = (cal.Equals(Calculos.TasaDeInteres)) ? string.Empty : txtTasa.Texts;
            txtDuracion.Texts = (cal.Equals(Calculos.NumeroDePeriodos)) ? string.Empty : txtDuracion.Texts;
            txtPago.Texts = (cal.Equals(Calculos.Pago)) ? string.Empty : txtPago.Texts;
            txtIncremento.Texts = (cal.Equals(Calculos.Incremento)) ? string.Empty : txtIncremento.Texts;
        }
        private void LimpiarCalculos()
        {
            txtVP.Texts = string.Empty;
            txtVF.Texts = string.Empty;
            txtDuracion.Texts = string.Empty;
            txtIncremento.Texts = string.Empty;
            txtPago.Texts = string.Empty;
            txtPerGracia.Texts = string.Empty;
            txtTasa.Texts = string.Empty;
        }
        private void cmbCalculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //VerificarSelecCalculos();
        }
        public void VerificarPerGracia()
        {
            if (decimal.Parse(txtPerGracia.Texts) >= decimal.Parse(txtDuracion.Texts))
            {
                throw new ArgumentException("El periodo de gracia no puede ser igual o mayor que la duracion de la anualidad");
            }
        }
        public decimal ConvertToDecimal(RJTextBox TextsBox, string propertyName)
        {
            decimal result = decimal.Parse(TextsBox.Texts);
            if (result <= 0)
            {
                throw new ArgumentException($"El {propertyName} no puede ser menor o igual la 0");
            }
            return result;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calculos cal = (Calculos)Enum.Parse(typeof(Calculos), cmbCalculos.SelectedValue.ToString());

            if (!cmbTipo.SelectedItem.Equals(TipoAnualidad.SerieGeometrica) && !cmbTipo.SelectedItem.Equals(TipoAnualidad.SerieAritmetica))
            {
                switch (cmbTipo.SelectedItem)
                {
                    case TipoAnualidad.AnualidadOrdinaria:
                    case TipoAnualidad.AnualidadAnticipada:
                    case TipoAnualidad.AnualidadDiferida:
                    case TipoAnualidad.AnualidadPerpetua:
                        TipoCalculoAnualidad(cal, (TipoAnualidad)cmbTipo.SelectedValue);
                        break;
                }
            }
            else
            {
                switch (cmbTipo.SelectedItem)
                {
                    case TipoAnualidad.SerieGeometrica:
                    case TipoAnualidad.SerieAritmetica:
                        TipoCalculoSerie(cal, (TipoAnualidad)cmbTipo.SelectedValue);
                        break;
                }
            }
        }

        private void txtDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyNumbers(e);
        }

        private void txtIncremento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as RJTextBox).Texts.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as RJTextBox).Texts.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
            if ((sender as RJTextBox).Texts.Length > 0 && (e.KeyChar == '-') && (sender as RJTextBox).Texts.ToCharArray()[0] != '-')
            {
                e.Handled = true;
            }
        }

        private void pbTime_Click(object sender, EventArgs e)
        {
            FrecuenciaTasa frecuenciaTasa = (FrecuenciaTasa)Enum.Parse(typeof(FrecuenciaTasa), cmbPer.SelectedItem.ToString());
            FrmConvertTime frmConvertTime = new FrmConvertTime(frecuenciaTasa);
            frmConvertTime.ShowDialog();
            //este if seria opcional
            if (frmConvertTime.Time!=0)
            {
                txtDuracion.Focus();
                txtDuracion.Texts = frmConvertTime.Time.ToString(); 
            }
        }

        private void pbRate_Click(object sender, EventArgs e)
        {
            FrmConversor frmConversor = new FrmConversor((FrecuenciaTasa)cmbPer.SelectedIndex);
            frmConversor.ShowDialog();
            //este if seria opcional 
            if (frmConversor.tasaconvertida!=0)
            {
                txtTasa.Focus();
                txtTasa.Texts = frmConversor.tasaconvertida.ToString(); 
            }
        }

        private void txtDuracion__TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
        }
    }
}
