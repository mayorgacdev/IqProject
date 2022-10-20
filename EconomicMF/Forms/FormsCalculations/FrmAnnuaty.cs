using EconomicEF.Common.UserCache;
using EconomicMF.AppCore.Factories;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Calculos;
using EconomicMF.Domain.Entities.Flows;
using EconomicMF.Domain.Enums;
using EconomicMF.Domain.Enums.Calculos;
using EconomicMF.Helper;
using EconomicMF.Services.Processes;
using RJCodeAdvance.RJControls;
using System;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsCalculations
{
    public partial class FrmAnnuaty : Form
    {
        private readonly IUnitOfWork unitOfWork;
        private int solutionId;
        public FrmAnnuaty(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            solutionId = DataOnMemory.SolutionId;
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
            try
            {
                Calculos cal = (Calculos)Enum.Parse(typeof(Calculos), cmbCalculos.SelectedValue.ToString());

                //TODO: metodo anterior 
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
        private void txtValidationDecimal_KeyPress(object sender, KeyPressEventArgs e)
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
            decimal vf = 0, nper = 0, crecimiento=0, futuroGradiente=0, perGracia = 0;
            if (tipo.Equals(TipoAnualidad.AnualidadPerpetua))
            {
                vf = 99999999;
                nper = 9999999;
            }
            else
            {
                if (!calculo.Equals(Calculos.ValorFuturo))
                {
                    vf = GetOpcionalValue(txtVF);
                }
                if (!calculo.Equals(Calculos.NumeroDePeriodos))
                {
                    nper = GetValue(txtDuracion);
                }
            }
            if (tipo.Equals(TipoAnualidad.AnualidadDiferida))
            {
                perGracia = GetValue(txtPerGracia);
            }
            Solution solution = await unitOfWork.SolutionClient.GetAsync(solutionId);
            if (solution == null)
            {
                throw new Exception($"La solucion con id {solutionId} no existe");
            }
            switch (calculo)
            {
                case Calculos.ValorPresente:
                    if (!tipo.Equals(TipoAnualidad.AnualidadPerpetua))
                    {
                        ValidarAnualidades(GetValue(txtTasa), GetValue(txtPago), GetValue(txtDuracion)); 
                    }
                    else
                    {
                        ValidarAnualidadPerp(GetValue(txtTasa), GetValue(txtPago));
                    }
                    EconomicDto anualidad = new EconomicDto()
                    {
                        FutureValue = vf,
                        PagoAnual = GetValue(txtPago),
                        NumPeriodos = nper,
                        TasaInteres = GetValue(txtTasa) / 100,
                        TipoAnualidad = tipo,
                        PeriodoGracia = perGracia,
                        Periodo = (Periodo)cmbPer.SelectedItem,
                        SolutionId = solution.Id,
                        Crecimiento = crecimiento,
                        FuturoGradiente = futuroGradiente,
                        Discriminator = Discriminador.Anualidad.ToString(),
                        TipoDeCrecimiento = TipoCrecimiento.SinCrecimiento,
                        TipoInteres = TipoInteres.CompuestoConTasaEfectiva,
                    };
                    anualidad.PresentValue = AnualidadSeriesFactory.CreateInstance((TipoAnualidad)cmbTipo.SelectedItem).CalcularVP(ConvertEconomicDTOS.ConvertAnualidadDTO(anualidad));
                    txtVP.Texts = txtVP.Text = anualidad.PresentValue.ToString();
                    await unitOfWork.EconomicClient.CreateAsync(anualidad);
                    break;
                case Calculos.ValorFuturo:
                    ValidarAnualidades(GetValue(txtTasa), GetValue(txtPago), GetValue(txtDuracion));
                    anualidad = new EconomicDto()
                    {
                        PresentValue = GetOpcionalValue(txtVP),
                        PagoAnual = GetValue(txtPago),
                        NumPeriodos = nper,
                        TasaInteres = GetValue(txtTasa)/100,
                        TipoAnualidad = tipo,
                        PeriodoGracia = perGracia,
                        Periodo = (Periodo)cmbPer.SelectedItem,
                        SolutionId = solution.Id,
                        Crecimiento = crecimiento,
                        FuturoGradiente = futuroGradiente,
                        Discriminator = Discriminador.Anualidad.ToString(),
                        TipoDeCrecimiento = TipoCrecimiento.SinCrecimiento,
                        TipoInteres = TipoInteres.CompuestoConTasaEfectiva
                    };
                    anualidad.FutureValue = AnualidadSeriesFactory.CreateInstance((TipoAnualidad)cmbTipo.SelectedItem).CalcularVF(ConvertEconomicDTOS.ConvertAnualidadDTO(anualidad));
                    txtVF.Texts = txtVF.Text = anualidad.FutureValue.ToString();
                    await unitOfWork.EconomicClient.CreateAsync(anualidad);
                    break;
                case Calculos.NumeroDePeriodos:
                    ValidarAnualidades(GetValue(txtTasa), GetValue(txtVP), GetValue(txtPago));
                    anualidad = new EconomicDto()
                    {
                        FutureValue = vf,
                        PagoAnual = GetValue(txtPago),
                        PresentValue = GetValue(txtVP),
                        TasaInteres = GetValue(txtTasa) / 100,
                        TipoAnualidad = tipo,
                        PeriodoGracia = perGracia,
                        Periodo = (Periodo)cmbPer.SelectedItem,
                        SolutionId = solution.Id,
                        Crecimiento = crecimiento,
                        FuturoGradiente = futuroGradiente,
                        Discriminator = Discriminador.Anualidad.ToString(),
                        TipoDeCrecimiento = TipoCrecimiento.SinCrecimiento,
                        TipoInteres = TipoInteres.CompuestoConTasaEfectiva
                    };
                    anualidad.NumPeriodos = AnualidadSeriesFactory.CreateInstance((TipoAnualidad)cmbTipo.SelectedItem).CalcularTiempo(ConvertEconomicDTOS.ConvertAnualidadDTO(anualidad));
                    txtDuracion.Texts =txtDuracion.Text= anualidad.NumPeriodos.ToString();
                    await unitOfWork.EconomicClient.CreateAsync(anualidad);
                    break;
                case Calculos.TasaDeInteres:
                    if (!tipo.Equals(TipoAnualidad.AnualidadPerpetua))
                    {
                        ValidarAnualidades(GetValue(txtDuracion), GetValue(txtVP), GetValue(txtPago));
                    }
                    else
                    {
                        ValidarAnualidadPerp(GetValue(txtVP), GetValue(txtPago));
                    }
                    anualidad = new EconomicDto()
                    {
                        FutureValue = vf,
                        PagoAnual = GetValue(txtPago),
                        NumPeriodos = nper,
                        PresentValue = GetValue(txtVP),
                        TipoAnualidad = tipo,
                        PeriodoGracia = perGracia,
                        Periodo = (Periodo)cmbPer.SelectedItem,
                        SolutionId = solution.Id,
                        Crecimiento = crecimiento,
                        FuturoGradiente = futuroGradiente,
                        Discriminator = Discriminador.Anualidad.ToString(),
                        TipoDeCrecimiento = TipoCrecimiento.SinCrecimiento,
                        TipoInteres = TipoInteres.CompuestoConTasaEfectiva
                    };
                    anualidad.TasaInteres = AnualidadSeriesFactory.CreateInstance((TipoAnualidad)cmbTipo.SelectedItem).CalcularTasa(ConvertEconomicDTOS.ConvertAnualidadDTO(anualidad));
                    txtTasa.Texts = txtTasa.Text = (anualidad.TasaInteres).ToString();
                    await unitOfWork.EconomicClient.CreateAsync(anualidad);
                    break;
                case Calculos.Pago:
                    if (!tipo.Equals(TipoAnualidad.AnualidadPerpetua))
                    {
                        ValidarAnualidades(GetValue(txtDuracion), GetValue(txtVP), GetValue(txtTasa));
                    }
                    else
                    {
                        ValidarAnualidadPerp(GetValue(txtVP), GetValue(txtTasa));
                    }
                    anualidad = new EconomicDto()
                    {
                        FutureValue = vf,
                        PresentValue = GetValue(txtVP),
                        NumPeriodos = nper,
                        TasaInteres = GetValue(txtTasa) / 100,
                        TipoAnualidad = tipo,
                        PeriodoGracia = perGracia,
                        Periodo = (Periodo)cmbPer.SelectedItem,
                        SolutionId = solution.Id,
                        Crecimiento = crecimiento,
                        FuturoGradiente = futuroGradiente,
                        Discriminator = Discriminador.Anualidad.ToString(),
                        TipoDeCrecimiento = TipoCrecimiento.SinCrecimiento,
                        TipoInteres = TipoInteres.CompuestoConTasaEfectiva,
                        PagoAnual = 0,
                    };
                    anualidad.PagoAnual = AnualidadSeriesFactory.CreateInstance((TipoAnualidad)cmbTipo.SelectedItem).CalcularPago(ConvertEconomicDTOS.ConvertAnualidadDTO(anualidad));
                    txtPago.Texts =txtPago.Text =(anualidad).PagoAnual.ToString();
                    await unitOfWork.EconomicClient.CreateAsync(anualidad);
                    break;
            }
        }
        private async void TipoCalculoSerie(Calculos calculo, TipoAnualidad tipo)
        {
            int perGracia = 0;
            decimal incremento=0, futurogradiente=0;
            incremento = GetValue(txtIncremento);
            Solution solution = await unitOfWork.SolutionClient.GetAsync(solutionId);
            if (solution == null)
            {
                throw new Exception($"La solucion con id {solutionId} no existe");
            }
            ValidarAnualidades(GetValue(txtPago), GetValue(txtTasa), GetValue(txtDuracion));
            switch (calculo)
            {
                case Calculos.ValorPresente:
                    EconomicDto series = new EconomicDto()
                    {
                        FutureValue = GetOpcionalValue(txtVF),
                        PagoAnual = GetValue(txtPago),
                        NumPeriodos = GetValue(txtDuracion),
                        TasaInteres = GetValue(txtTasa) / 100,
                        TipoAnualidad = tipo,
                        PeriodoGracia = perGracia,
                        Periodo = (Periodo)cmbPer.SelectedItem,
                        TipoDeCrecimiento = tipo.Equals(TipoAnualidad.SerieAritmetica) ? TipoCrecimiento.Aritmetico : TipoCrecimiento.Geometrico,
                        Crecimiento = tipo.Equals(TipoAnualidad.SerieAritmetica) ? incremento : incremento / 100,
                        SolutionId = solutionId,
                        FuturoGradiente = futurogradiente,
                        Discriminator = Discriminador.Anualidad.ToString(),
                    };
                    series.PresentValue = AnualidadSeriesFactory.CreateInstance(tipo).CalcularVP(ConvertEconomicDTOS.ConvertAnualidadDTO(series));
                    series.FuturoGradiente = AnualidadSeriesFactory.CreateInstance(tipo).CalcularFuturoGradiente(ConvertEconomicDTOS.ConvertAnualidadDTO(series));
                    txtVP.Texts = txtVP.Text = series.PresentValue.ToString();
                    await unitOfWork.EconomicClient.CreateAsync(series);
                    break;
                case Calculos.ValorFuturo:
                    series = new EconomicDto()
                    {
                        PresentValue = GetOpcionalValue(txtVP),
                        PagoAnual = GetValue(txtPago),
                        NumPeriodos = GetValue(txtDuracion),
                        TasaInteres = GetValue(txtTasa) / 100,
                        TipoAnualidad = tipo,
                        PeriodoGracia = perGracia,
                        Periodo = (Periodo)cmbPer.SelectedItem,
                        TipoDeCrecimiento = tipo.Equals(TipoAnualidad.SerieAritmetica) ? TipoCrecimiento.Aritmetico : TipoCrecimiento.Geometrico,
                        Crecimiento = tipo.Equals(TipoAnualidad.SerieAritmetica) ? incremento : incremento / 100,
                        SolutionId = solutionId,
                        FuturoGradiente = futurogradiente,
                        Discriminator = Discriminador.Anualidad.ToString(),
                    };
                    series.FutureValue = AnualidadSeriesFactory.CreateInstance(tipo).CalcularVF(ConvertEconomicDTOS.ConvertAnualidadDTO(series));
                    series.FuturoGradiente = AnualidadSeriesFactory.CreateInstance(tipo).CalcularFuturoGradiente(ConvertEconomicDTOS.ConvertAnualidadDTO(series));
                    txtVF.Texts = txtVF.Text =series.FutureValue.ToString();
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
            cmbCalculos.DataSource = null;
            switch (cmbTipo.SelectedValue)
            {
                case TipoAnualidad.AnualidadOrdinaria:
                case TipoAnualidad.AnualidadAnticipada:
                    cmbCalculos.DataSource = Enum.GetValues(typeof(CalculoAnualidad));
                    lblIncrement.Text = "Incremento";
                    break;
                case TipoAnualidad.AnualidadDiferida:
                    cmbCalculos.DataSource = Enum.GetValues(typeof(CalculosAnualidadDif));
                    lblIncrement.Text = "Incremento";
                    break;
                case TipoAnualidad.AnualidadPerpetua:
                    cmbCalculos.DataSource = Enum.GetValues(typeof(CalculoAnualidadPerp));
                    lblIncrement.Text = "Incremento";
                    break;
                case TipoAnualidad.SerieAritmetica:
                case TipoAnualidad.SerieGeometrica:
                    cmbCalculos.DataSource = Enum.GetValues(typeof(CalculosSeries));
                    lblIncrement.Text = (cmbTipo.SelectedValue.Equals(TipoAnualidad.SerieGeometrica)) ? "Incremento (%)" : "Incremento";
                    break;
            }
            VerificarSelecCalculos();
        }
        private void VerificarSelecCalculos()
        {
            Calculos cal = (Calculos)Enum.Parse(typeof(Calculos), cmbCalculos.SelectedValue.ToString());

            //las tres que si o si que estaran siempre habilitadas la mayor parte del tiempo
            txtVP.Enabled = true && !cal.Equals(Calculos.ValorPresente);
            txtTasa.Enabled = true && !cal.Equals(Calculos.TasaDeInteres);
            txtPago.Enabled = true && !cal.Equals(Calculos.Pago);

            switch ((TipoAnualidad)cmbTipo.SelectedIndex)
            {
                case TipoAnualidad.AnualidadDiferida:
                    txtPerGracia.Enabled = true;
                    txtIncremento.Enabled = false;
                    txtVF.Enabled = true && !cal.Equals(Calculos.ValorFuturo);
                    txtDuracion.Enabled = true && !cal.Equals(Calculos.NumeroDePeriodos);
                    break;
                case TipoAnualidad.AnualidadOrdinaria:
                case TipoAnualidad.AnualidadAnticipada:
                    txtPerGracia.Enabled = false;
                    txtIncremento.Enabled = false;
                    txtVF.Enabled = true && !cal.Equals(Calculos.ValorFuturo);
                    txtDuracion.Enabled = true && !cal.Equals(Calculos.NumeroDePeriodos);
                    break;
                case TipoAnualidad.AnualidadPerpetua:
                    txtPerGracia.Enabled = false;
                    txtIncremento.Enabled = false;
                    txtVF.Enabled = false;
                    txtDuracion.Enabled = false;
                    txtPerGracia.Text = txtPerGracia.Texts = String.Empty;
                    txtIncremento.Text = txtIncremento.Texts = String.Empty;
                    txtVF.Text = txtVF.Texts = String.Empty;
                    txtDuracion.Text = txtDuracion.Texts = String.Empty;
                    break;
                case TipoAnualidad.SerieAritmetica:
                case TipoAnualidad.SerieGeometrica: 
                    txtPerGracia.Enabled = false;
                    txtVF.Enabled = true && !cal.Equals(Calculos.ValorFuturo);
                    txtDuracion.Enabled = true;
                    txtTasa.Enabled = true;
                    txtIncremento.Enabled = true;
                    break;
                default:
                    throw new Exception("No se seleccionó que calcular");
            }
            txtVP.Text = txtVP.Texts = (cal.Equals(Calculos.ValorPresente)) ? string.Empty : txtVP.Texts;
            txtVF.Text = txtVF.Texts = (cal.Equals(Calculos.ValorFuturo)) ? string.Empty : txtVF.Texts;
            txtTasa.Text = txtTasa.Texts = (cal.Equals(Calculos.TasaDeInteres)) ? string.Empty : txtTasa.Texts;
            txtDuracion.Text = txtDuracion.Texts = (cal.Equals(Calculos.NumeroDePeriodos)) ? string.Empty : txtDuracion.Texts;
            txtPago.Text = txtPago.Texts = (cal.Equals(Calculos.Pago)) ? string.Empty : txtPago.Texts;
        }
        public void VerificarPerGracia()
        {
            if (decimal.Parse(txtPerGracia.Texts) >= decimal.Parse(txtDuracion.Texts))
            {
                throw new ArgumentException("El periodo de gracia no puede ser igual o mayor que la duracion de la anualidad");
            }
        }
        private decimal GetValue(RJTextBox rJTextBox)
        {
            if (string.IsNullOrWhiteSpace(rJTextBox.Texts) && string.IsNullOrWhiteSpace(rJTextBox.Text))
            {
                throw new ArgumentException("Debe de rellenar los campos de texto necesarios para poder realizar los cálculos");
            }
            if (string.IsNullOrWhiteSpace(rJTextBox.Texts))
            {
                return decimal.Parse(rJTextBox.Text);
            }
            return decimal.Parse(rJTextBox.Texts);
        }
        private decimal GetOpcionalValue(RJTextBox rJTextBox)
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
        private void ValidarAnualidadPerp(decimal valo1, decimal valor2)
        {
            if (valo1 <= 0 || valor2 <= 0)
            {
                throw new ArgumentException("No se pueden colocar valores menores o iguales a 0 en ninguno de los campos");
            }
        }
        private void ValidarAnualidades(decimal valor1, decimal valor2, decimal valor3)
        {
            if (valor1 <= 0 || valor2 <= 0 || valor3 <= 0)
            {
                throw new ArgumentException("No se pueden colocar valores menores o iguales a 0 en ninguno de los campos");
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
            
            if (rbDuracion.Checked==true || rbPerGracia.Checked==true)
            {
                if (rbPerGracia.Checked == true && (!cmbTipo.SelectedItem.Equals(TipoAnualidad.AnualidadDiferida)))
                {
                    MessageBox.Show("La conversion resulta inncesaria debido a que no se calculará una anualidad diferida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    FrecuenciaTasa frecuenciaTasa = (FrecuenciaTasa)Enum.Parse(typeof(FrecuenciaTasa), cmbPer.SelectedItem.ToString());
                    FrmConvertTime frmConvertTime = new FrmConvertTime(frecuenciaTasa);
                    frmConvertTime.ShowDialog();
                    if (frmConvertTime.Time != 0)
                    {
                        txtDuracion.Focus();
                        if (rbDuracion.Checked == true)
                        {
                            txtDuracion.Texts = frmConvertTime.Time.ToString();
                        }
                        else if (rbPerGracia.Checked == true && (cmbTipo.SelectedItem.Equals(TipoAnualidad.AnualidadDiferida)))
                        {
                            txtPerGracia.Texts = frmConvertTime.Time.ToString();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un criterio para hacer la conversion");
                return;
            }
        }

        private void pbRate_Click(object sender, EventArgs e)
        {
            FrmConversor frmConversor = new FrmConversor((FrecuenciaTasa)cmbPer.SelectedIndex, unitOfWork);
            frmConversor.ShowDialog();
            if (frmConversor.tasaconvertida!=0)
            {
                txtTasa.Focus();
                txtTasa.Texts = frmConversor.tasaconvertida.ToString(); 
            }
        }

        private void cmbPer_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((Periodo)cmbPer.SelectedItem)
            {
                case Periodo.Anual:
                    lblDuration.Text = "Duración (en años)";
                    break;
                case Periodo.Semestral:
                    lblDuration.Text = "Duración (en semestres)";
                    break;
                case Periodo.Cuatrimestral:
                    lblDuration.Text = "Duración (en cuatrimestres)";
                    break;
                case Periodo.Trimestral:
                    lblDuration.Text = "Duración (en trimestres)";
                    break;
                case Periodo.Bimestral:
                    lblDuration.Text = "Duración (en bimestres)";
                    break;
                case Periodo.Mensual:
                    lblDuration.Text = "Duración (en meses)";
                    break;
                case Periodo.Semanal:
                    lblDuration.Text = "Duración (en semanas)";
                    break;
                case Periodo.Diario:
                    lblDuration.Text = "Duración (en dias)";
                    break;
            }
        }

        private void cmbPer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }
    }
}
