using EconomicEF.Common.UserCache;
using EconomicMF.AppCore.Factories;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Calculos;
using EconomicMF.Domain.Enums;
using EconomicMF.Forms.FormsCalculations.FormsShowCalculus;
using EconomicMF.Helper;
using EconomicMF.Services.Processes;
using EconomicMF.UserControls.UCForGestor;
using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsCalculations
{
    public partial class FrmCalculus : Form
    {
        private readonly IUnitOfWork unitOfWork;
        private int nper;
        private int solutionId;
        private int idflujo;
        private bool nuevoFlujo=true;
        public FrmCalculus(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.solutionId = DataOnMemory.SolutionId;
        }
        private async void btnAddFlow_Click(object sender, EventArgs e)
        {
            //try
            //{

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
            //}
            ValidateFields();
            if (nuevoFlujo)
            {
                FlujoDeCajaDto flujoDeCajaDto = new FlujoDeCajaDto()
                {
                    SolutionId = solutionId,
                };
                await unitOfWork.flujoClient.CreateAsync(flujoDeCajaDto);
                IEnumerable<FlujoDeCajaDto> cashflows = await unitOfWork.flujoClient.GetAllAsync();
                idflujo = cashflows.Last().Id;
            }
            switch (cmbTipoCalculo.SelectedItem)
            {
                case TipoCalculo.Anualidad:
                    EconomicDto anualidad = CrearAnualidad();
                    UCAnnuaty uCAnnuaty = new UCAnnuaty(ConvertEconomicDTOS.ConvertAnualidadDTO(anualidad));
                    await unitOfWork.EconomicClient.CreateAsync(anualidad);
                    flpFlows.Controls.Add(uCAnnuaty);

                    IEnumerable<EconomicDto> lstEconomic = await unitOfWork.EconomicClient.GetAllAsync();
                    int idEconomic = lstEconomic.Last().Id;

                    FlujoDeCajaDetalleDto detalleDto = new FlujoDeCajaDetalleDto()
                    {
                        IdFlujoDeCaja = idflujo,
                        IdEconomic = idEconomic,
                    };
                    await unitOfWork.flujoDetalleClient.CreateAsync(detalleDto);
                    break;
                case TipoCalculo.FlujoUnico:
                    EconomicDto interes = CrearIndividual();
                    UCInteres uCInteres = new UCInteres(ConvertEconomicDTOS.ConvertRateDto(interes));
                    await unitOfWork.EconomicClient.CreateAsync(interes);
                    flpFlows.Controls.Add(uCInteres);

                    lstEconomic = await unitOfWork.EconomicClient.GetAllAsync();
                    idEconomic = lstEconomic.Last().Id;

                    detalleDto = new FlujoDeCajaDetalleDto()
                    {
                        IdFlujoDeCaja = idflujo,
                        IdEconomic = idEconomic,
                    };
                    await unitOfWork.flujoDetalleClient.CreateAsync(detalleDto);
                    break;
                case TipoCalculo.Serie:
                    if (int.Parse(txtInicio.Texts) <= 0)
                    {
                        throw new ArgumentException("Una serie no puede comenzar en el año 0 o antes");
                    }
                    EconomicDto serie = CrearSerie();
                    uCAnnuaty = new UCAnnuaty(ConvertEconomicDTOS.ConvertAnualidadDTO(serie));
                    await unitOfWork.EconomicClient.CreateAsync(serie);
                    flpFlows.Controls.Add(uCAnnuaty);

                    lstEconomic = await unitOfWork.EconomicClient.GetAllAsync();
                    idEconomic = lstEconomic.Last().Id;

                    detalleDto = new FlujoDeCajaDetalleDto()
                    {
                        IdFlujoDeCaja = idflujo,
                        IdEconomic = idEconomic,
                    };
                    await unitOfWork.flujoDetalleClient.CreateAsync(detalleDto);
                    break;
            }
            txtTasaInteres.Enabled = false;
            cmbFrecuenciaPago.Enabled = false;
            btnConvert.Enabled = false;
            nuevoFlujo = false;
            lblNum.Text = $"Periodo del ultimo pago: {nper}";
        }

        private EconomicDto CrearSerie()
        {
            decimal incremento = 0, futuroGrad = 0;
            if (!string.IsNullOrWhiteSpace(txtIncremento.Texts))
            {
                incremento = decimal.Parse(txtIncremento.Texts);
            }
            if (!string.IsNullOrWhiteSpace(txtFuturoGrad.Texts))
            {
                futuroGrad = decimal.Parse(txtFuturoGrad.Texts);
            }
            int perGracia = int.Parse(txtInicio.Texts) - 1;
            int ultimoPago = int.Parse(txtDuracion.Texts);
            decimal tasa = decimal.Parse(txtTasaInteres.Texts) / 100;
            if (tasa <= 0)
            {
                throw new ArgumentException("La tasa de interés no puede ser menor o igual a 0%");
            }
            decimal pago = decimal.Parse(txtPagoPeriodico.Texts);
            if (pago <= 0)
            {
                throw new ArgumentException("El pago periodico no puede ser menor o igual a 0");
            }
            TipoAnualidad tipoAnualidad = ((TipoCrecimiento)cmbIncremento.SelectedItem).Equals(TipoCrecimiento.Aritmetico) ? TipoAnualidad.SerieAritmetica : TipoAnualidad.SerieGeometrica;
            EconomicDto serie = new EconomicDto()
            {
                SolutionId = solutionId,
                Discriminator = Discriminador.Anualidad.ToString(),
                //Discriminator = "Anualidad Flujo"
                NumPeriodos = ultimoPago,
                TasaInteres = tasa,
                TipoAnualidad = tipoAnualidad,
                //TODO: revisar bien si debe de ir o no el periodo de gracia
                PeriodoGracia = (perGracia < 0) ? 0 : perGracia,
                Periodo = (Periodo)cmbFrecuenciaPago.SelectedItem,
                //PagoAnual = (cmbTipoMovimiento.SelectedItem.Equals(TipoMovimiento.Entrada)) ? decimal.Parse(txtPagoPeriodico.Texts) : decimal.Parse(txtPagoPeriodico.Texts) * -1,
                PagoAnual = (cmbTipoMovimiento.SelectedItem.Equals(TipoMovimiento.Entrada)) ? pago : pago*-1,
                Crecimiento = (cmbIncremento.SelectedItem.Equals(TipoCrecimiento.Geometrico)) ? incremento / 100 : incremento,
                TipoDeCrecimiento = ((TipoCrecimiento)cmbIncremento.SelectedItem),
                FuturoGradiente = futuroGrad,

                //propiedad de economic 
                FrecuenciaTasa = (FrecuenciaTasa)cmbFrecuenciaPago.SelectedIndex
            };
            if (serie.FuturoGradiente == 0)
                serie.FuturoGradiente = AnualidadSeriesFactory.CreateInstance(serie.TipoAnualidad).CalcularFuturoGradiente(ConvertEconomicDTOS.ConvertAnualidadDTO(serie));
            if (serie.Crecimiento == 0)
                serie.Crecimiento = AnualidadSeriesFactory.CreateInstance(serie.TipoAnualidad).CalcularGradiente(ConvertEconomicDTOS.ConvertAnualidadDTO(serie));
            decimal vp = AnualidadSeriesFactory.CreateInstance(serie.TipoAnualidad).CalcularVP(ConvertEconomicDTOS.ConvertAnualidadDTO(serie));
            serie.FutureValue = AnualidadSeriesFactory.CreateInstance(serie.TipoAnualidad).CalcularVF(ConvertEconomicDTOS.ConvertAnualidadDTO(serie));
            serie.PresentValue = vp;
            VerificarMayor((int)serie.NumPeriodos);
            return serie;
        }

        private EconomicDto CrearIndividual()
        {
            int periodo = int.Parse(txtInicio.Texts);
            decimal tasa = decimal.Parse(txtTasaInteres.Texts) / 100;
            if (tasa <= 0)
            {
                throw new ArgumentException("La tasa de interés no puedo ser menor o igual a 0%");
            }
            decimal valor = decimal.Parse(txtValue.Texts);
            if (valor <= 0)
            {
                throw new ArgumentException("El valor ingresado no puede ser menor o igual a 0");
            }
            EconomicDto interes = new EconomicDto()
            {
                SolutionId = solutionId,
                Discriminator = Discriminador.Interes.ToString(),
                //Discriminator = "Interes Flujo",
                NumPeriodos = periodo,
                FutureValue = (cmbTipoMovimiento.SelectedItem.Equals(TipoMovimiento.Entrada)) ? valor: valor*-1,
                TasaInteres = tasa,
                FrecuenciaTasa = (FrecuenciaTasa)cmbFrecuenciaPago.SelectedIndex,
                TipoInteres = TipoInteres.CompuestoConTasaEfectiva,

                //propiedad de economic
                Periodo = (Periodo)cmbFrecuenciaPago.SelectedItem
            };
            interes.PresentValue = InteresFactory.CreateInstance(interes.TipoInteres).CalcularVP(ConvertEconomicDTOS.ConvertRateDto(interes));
            VerificarMayor((int)interes.NumPeriodos);
            return interes;
        }

        private EconomicDto CrearAnualidad()
        {
            int perGracia = int.Parse(txtInicio.Texts) - 1;
            int ultimoPago = int.Parse(txtDuracion.Texts);
            decimal tasa = decimal.Parse(txtTasaInteres.Texts) / 100;
            if (tasa <= 0)
            {
                throw new ArgumentException("La tasa de interés no puede ser menor o igual a 0%");
            }
            decimal pago = decimal.Parse(txtPagoPeriodico.Texts);
            if (pago <= 0)
            {
                throw new ArgumentException("El pago periodico no puede ser menor o igual a 0");
            }
            EconomicDto anualidad = new EconomicDto()
            {
                SolutionId = solutionId,
                Discriminator = Discriminador.Anualidad.ToString(),
                Crecimiento = 0,
                FuturoGradiente = 0,
                //Numero de periodos, aqui se refiere a cuando realizo se ultimo pago
                NumPeriodos = (perGracia<0)? (ultimoPago+1) : ultimoPago,
                TasaInteres = tasa,
                TipoAnualidad = GetTipoAnualidad(),
                PeriodoGracia = (perGracia < 0) ? 0 : perGracia,
                Periodo = (Periodo)cmbFrecuenciaPago.SelectedItem,
                PagoAnual = (cmbTipoMovimiento.SelectedItem.Equals(TipoMovimiento.Entrada)) ? pago : pago * -1,
                TipoDeCrecimiento = TipoCrecimiento.SinCrecimiento,

                //propiedad de economic 
                FrecuenciaTasa = (FrecuenciaTasa)cmbFrecuenciaPago.SelectedIndex
            };
            decimal vp = AnualidadSeriesFactory.CreateInstance(anualidad.TipoAnualidad).CalcularVP(ConvertEconomicDTOS.ConvertAnualidadDTO(anualidad));
            anualidad.FutureValue = AnualidadSeriesFactory.CreateInstance(anualidad.TipoAnualidad).CalcularVF(ConvertEconomicDTOS.ConvertAnualidadDTO(anualidad));
            anualidad.PresentValue = vp;
            VerificarMayor((int)anualidad.NumPeriodos);
            return anualidad;
        }

        private TipoAnualidad GetTipoAnualidad()
        {
            if (int.Parse(txtInicio.Texts) < 0)
            {
                throw new ArgumentException("El inicio de la anualidad no puede ser menor a 0");
            }
            if (int.Parse(txtDuracion.Texts) <= 0)
            {
                throw new ArgumentException("La duracion no puede ser menor o igual a 0");
            }
            else if (int.Parse(txtInicio.Texts) == 0)
            {
                return TipoAnualidad.AnualidadAnticipada;
            }
            else if (int.Parse(txtInicio.Texts) > 1)
            {
                return TipoAnualidad.AnualidadDiferida;
            }
            return TipoAnualidad.AnualidadOrdinaria;
        }

        private void btnAddAnnuity_Click(object sender, EventArgs e)
        {
            FrmAnnuaty frmAnualidad = new FrmAnnuaty(unitOfWork);
            frmAnualidad.ShowDialog();
        }

        private void btnAddAmount_Click(object sender, EventArgs e)
        {
            FrmInteresp frmInteres = new FrmInteresp(unitOfWork);
            frmInteres.ShowDialog();
        }

        private void btnAddConversor_Click(object sender, EventArgs e)
        {
            FrmConversor frmConversion = new FrmConversor(unitOfWork);
            frmConversion.ShowDialog();
        }

        private async void btnCalculateFlow_Click(object sender, EventArgs e)
        {
            //try
            //{

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //return;
            //}
            if (tgbUltimoN.Checked == true)
            {
                int n = int.Parse(txtN.Texts);
                if (n < nper)
                {
                    throw new ArgumentException($"No se puede calcular el futuro en el periodo {n} ya que esta antes del ultimo pago");
                }
                nper = n;
            }
            txtTasaInteres.Enabled = true;
            cmbFrecuenciaPago.Enabled = true;
            btnConvert.Enabled = true;
            IEnumerable<EconomicDto> clasesEconomicas = await unitOfWork.flujoDetalleClient.GetEconomics(idflujo);
            FlujoDeCajaDto flujo = CashFlowMethods.CreateCashFlow(clasesEconomicas.ToList(), nper, (Periodo)cmbFrecuenciaPago.SelectedItem);
            flujo.Id = idflujo;
            bool resultado = await unitOfWork.flujoClient.UpdateAsync(flujo);
            if (resultado)
            {
                MessageBox.Show("Registro añadido correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //TODO: Decidir si quitarlo o no
            else
            {
                await unitOfWork.flujoClient.DeleteAsync(idflujo);
            }
            nuevoFlujo = true;
            nper = 0;
            Limpiar();
            flpFlows.Controls.Clear();
        }

        private void btnShowAnnuity_Click(object sender, EventArgs e)
        {
            AnnuityDto anualidad = new AnnuityDto();
            FormShowAnnuaty frmShowAnnuaty = new FormShowAnnuaty(unitOfWork);
            frmShowAnnuaty.ShowDialog();
        }

        private void btnShowAmount_Click(object sender, EventArgs e)
        {
            RateDto interes = new RateDto();
            FrmShowRate frmShowRate = new FrmShowRate(unitOfWork);
            frmShowRate.ShowDialog();
        }

        private void btnShowConversor_Click(object sender, EventArgs e)
        {
            FrmShowConversor formConversor = new FrmShowConversor(unitOfWork);
            formConversor.ShowDialog();
        }

        private void FrmCalculus_Load(object sender, EventArgs e)
        {
            cmbTipoCalculo.DataSource = Enum.GetValues(typeof(TipoCalculo));
            cmbTipoMovimiento.DataSource = Enum.GetValues(typeof(TipoMovimiento));
            cmbFrecuenciaPago.DataSource = Enum.GetValues(typeof(Periodo));
            cmbIncremento.DataSource = Enum.GetValues(typeof(TipoCrecimiento)).Cast<TipoCrecimiento>()
                        .Where(i => i != TipoCrecimiento.SinCrecimiento).ToArray();

        }

        private void txtPagoPeriodico_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipoCalculo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtIncremento.Enabled = cmbTipoCalculo.SelectedItem.Equals(TipoCalculo.Serie);
                txtPagoPeriodico.Visible = !cmbTipoCalculo.SelectedItem.Equals(TipoCalculo.FlujoUnico);
                txtFuturoGrad.Enabled = cmbTipoCalculo.SelectedItem.Equals(TipoCalculo.Serie);
                cmbIncremento.Enabled = cmbTipoCalculo.SelectedItem.Equals(TipoCalculo.Serie);
                txtValue.Visible = cmbTipoCalculo.SelectedItem.Equals(TipoCalculo.FlujoUnico);
                txtValue.Texts = string.Empty;
                txtDuracion.Enabled = !cmbTipoCalculo.SelectedItem.Equals(TipoCalculo.FlujoUnico);
                if (cmbTipoCalculo.SelectedItem.Equals(TipoCalculo.FlujoUnico))
                    txtPagoPeriodico.Texts = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void ValidateFields()
        {

            if (string.IsNullOrWhiteSpace(txtTasaInteres.Texts) || string.IsNullOrWhiteSpace(txtInicio.Texts))
            {
                throw new ArgumentException("Debe de rellenar todos los campos necesarios");
            }
            if (!cmbTipoCalculo.SelectedItem.Equals(TipoCalculo.FlujoUnico))
            {
                if (string.IsNullOrWhiteSpace(txtPagoPeriodico.Texts) || string.IsNullOrWhiteSpace(txtDuracion.Texts))
                    throw new ArgumentException("Debe de rellenar todos los campos necesarios");

                int ini = int.Parse(txtInicio.Texts);
                int fin = int.Parse(txtDuracion.Texts);
                if (ini >= fin)
                {
                    throw new ArgumentException("El periodo de inicio no puede ser mayor al periodo del ultimo pago");
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtValue.Texts))
                {
                    throw new ArgumentException("Debe de rellenar todos los campos necesarios");
                }
            }
            if (cmbTipoCalculo.SelectedItem.Equals(TipoCalculo.Serie))
            {
                if (string.IsNullOrWhiteSpace(txtIncremento.Texts) && string.IsNullOrWhiteSpace(txtFuturoGrad.Texts))
                {
                    throw new ArgumentException("El campo de incremento y el campo del futuro del gradiente no pueden estar vacios al mismo tiempo");
                }
                if (!string.IsNullOrWhiteSpace(txtIncremento.Texts) && !string.IsNullOrWhiteSpace(txtFuturoGrad.Texts))
                {
                    throw new ArgumentException("El campo de incremento y el campo del futuro del gradiente no pueden estar llenos al mismo tiempo");
                }
            }
        }

        private void txtPeriodoDeGracia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyNumbers(e);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            FrmCashFlowHistory frmCash = new FrmCashFlowHistory(unitOfWork);
            frmCash.ShowDialog();
        }
        private void VerificarMayor(int num)
        {
            if(num>nper)
                nper = num;
        }

        private void txtIncremento_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void cmbIncremento_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (((TipoCrecimiento)cmbIncremento.SelectedItem).Equals(TipoCrecimiento.Geometrico))
            {
                lblPorc.Visible = true;
                txtIncremento.PlaceholderText += " (%)";
            }
            else
            {
                lblPorc.Visible = false;
                txtIncremento.PlaceholderText = "Incremento";
            }
        }

        private void cmbFrecuenciaPago_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((FrecuenciaTasa)cmbFrecuenciaPago.SelectedIndex)
            {
                case FrecuenciaTasa.Anual:
                    txtDuracion.PlaceholderText = "Año del último pago";
                    //txtInicio.PlaceholderText = "Año del primer pago";
                    break;
                case FrecuenciaTasa.Semestral:
                    txtDuracion.PlaceholderText = "Semestre del último pago";
                    //txtInicio.PlaceholderText = "Semestre del primer pago";
                    break;
                case FrecuenciaTasa.Cuatrimestral:
                    txtDuracion.PlaceholderText = "Cuatrimestre del último pago";
                    //txtInicio.PlaceholderText = "Cuatrimestre del primer pago";
                    break;
                case FrecuenciaTasa.Trimestral:
                    txtDuracion.PlaceholderText = "Trimestre del último pago";
                    //txtInicio.PlaceholderText = "Trimestre del primer pago";
                    break;
                case FrecuenciaTasa.Bimestral:
                    txtDuracion.PlaceholderText =  "Bimestre del último pago";
                    //txtInicio.PlaceholderText = "Bimestre del primer pago";
                    break;
                case FrecuenciaTasa.Mensual:
                    txtDuracion.PlaceholderText = "Mes del último pago";
                    //txtInicio.PlaceholderText = "Mes del primer pago";
                    break;
                case FrecuenciaTasa.Semanal:
                    txtDuracion.PlaceholderText = "Semana del último pago";
                    //txtInicio.PlaceholderText = "Semana del primer pago";
                    break;
                case FrecuenciaTasa.Diario:
                    txtDuracion.PlaceholderText = "Día del último pago";
                    //txtInicio.PlaceholderText = "Día del primer pago";
                    break;
            }
        }

        private void ConvertTasa(object sender, EventArgs e)
        {
            FrmConversor frmConversor = new FrmConversor((FrecuenciaTasa)cmbFrecuenciaPago.SelectedIndex, unitOfWork);
            frmConversor.ShowDialog();
            //este if seria opcional 
            if (frmConversor.tasaconvertida != 0)
            {
                txtTasaInteres.Focus();
                txtTasaInteres.Texts = frmConversor.tasaconvertida.ToString();
            }
        }
        public void Limpiar()
        {
            txtDuracion.Texts = string.Empty;
            txtFuturoGrad.Texts = string.Empty;
            txtIncremento.Texts = string.Empty;
            txtValue.Texts = string.Empty;
            txtPagoPeriodico.Texts = string.Empty;
            txtInicio.Texts = string.Empty;
            txtTasaInteres.Texts = string.Empty;
            lblNum.Text = "Periodo del último pago:";
            tgbUltimoN.Checked = false;

            cmbFrecuenciaPago.SelectedIndex = 0;
            cmbTipoMovimiento.SelectedIndex = 0;
            cmbTipoCalculo.SelectedIndex = 0;
            cmbIncremento.SelectedIndex = 0;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            IEnumerable<EconomicDto> clasesEconomicas = await unitOfWork.flujoDetalleClient.GetEconomics(6);
            FlujoDeCajaDto flujo = CashFlowMethods.CreateCashFlow(clasesEconomicas.ToList(), 12, (Periodo)cmbFrecuenciaPago.SelectedItem);
            flujo.Id = 6;
            bool resultado = await unitOfWork.flujoClient.UpdateAsync(flujo);
        }

        private void tgbUltimoN_CheckedChanged(object sender, EventArgs e)
        {
            if (tgbUltimoN.Checked == true)
            {
                txtN.Enabled = true;
            }
            else
            {
                txtN.Enabled = false;
                txtN.Texts = String.Empty;
            }
        }
    }
}
