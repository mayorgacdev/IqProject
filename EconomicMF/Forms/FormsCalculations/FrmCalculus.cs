using EconomicEF.Common.UserCache;
using EconomicMF.AppCore.Factories;
using EconomicMF.Domain.Contracts;
using EconomicMF.Domain.Entities.Calculos;
using EconomicMF.Domain.Enums;
using EconomicMF.Forms.FormsCalculations.FormsShowCalculus;
using EconomicMF.Helper;
using EconomicMF.UserControls.UCForGestor;
using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsCalculations
{
    public partial class FrmCalculus : Form
    {
        //private bool tasaFijada;

        private readonly IUnitOfWork unitOfWork;
        private readonly List<EconomicDto> flujo;
        private readonly string userEmail;
        private int nper;
        private readonly int idUser;

        public FrmCalculus(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.userEmail = DataOnMemory.Email;
            flujo = new List<EconomicDto>();
        }

        private void GetAll()
        {

        }
        private void btnAddFlow_Click(object sender, EventArgs e)
        {
            //UserDto user = userService.GetByEmail(userEmail);
            //if (user == null)
            //{
            //    throw new Exception("Este usuario no existe");
            //}
            //idUser = user.Id;
            ValidateFields();   
            /*
            switch (cmbTipoCalculo.SelectedItem)
            {
                case TipoCalculo.Anualidad:
                    Anualidad anualidad = CrearAnualidad();
                    UCFlow uCFlow = new UCFlow();
                    flpFlows.Controls.Add(uCFlow);
                    flujo.Add(anualidad);
                   
                    break;
                case TipoCalculo.ValorIndividual:
                    Interes interes = CrearIndividual();
                    UCFlow ucFlowInteres = new UCFlow();
                    flpFlows.Controls.Add(ucFlowInteres);
                    flujo.Add(interes);

                    break;
                case TipoCalculo.Serie:
                    if (int.Parse(txtInicio.Texts) <= 0)
                    {
                        throw new ArgumentException("Una serie no puede comenzar en el año 0");
                        //TODO: add mas codigo --> I don't want adding more code, XD
                    }
                    Serie serie = CrearSerie();
                    UCFlow uCFlowSerire = new UCFlow();
                    flpFlows.Controls.Add(uCFlowSerire);
                    flujo.Add(serie);
                    break;
            }
            tasaFijada = true;
            txtTasaInteres.Enabled = false;
            cmbFrecuenciaPago.Enabled = false;*/

            //UCFlow uCFlow = new UCFlow();

            //flpFlows.Controls.Add(uCFlow);

            //flujo.Add(uCFlow);

            switch (cmbTipoCalculo.SelectedItem)
            {
                case TipoCalculo.Anualidad:
                    AnnuityDto anualidad = CrearAnualidad();
                    UCAnnuaty uCAnnuaty = new UCAnnuaty(anualidad);
                    flpFlows.Controls.Add(uCAnnuaty);
                    flujo.Add(anualidad);
                    break;
                case TipoCalculo.ValorIndividual:
                    RateDto interes = CrearIndividual();
                    UCInteres uCInteres= new UCInteres(interes);
                    flpFlows.Controls.Add(uCInteres);
                    flujo.Add(interes);
                    break;
                case TipoCalculo.Serie:
                    if (int.Parse(txtInicio.Texts) <= 0)
                    {
                        throw new ArgumentException("Una serie no puede comenzar en el año 0");
                        //add mas codigo
                    }
                    Serie serie = CrearSerie();
                    uCAnnuaty = new UCAnnuaty(serie);
                    flpFlows.Controls.Add(uCAnnuaty);
                    flujo.Add(serie);
                    break;
            }

            txtTasaInteres.Enabled = false;
            cmbFrecuenciaPago.Enabled = false;
        }

        private Serie CrearSerie()
        {
            try
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
                TipoAnualidad tipoAnualidad = ((TipoCrecimiento)cmbIncremento.SelectedItem).Equals(TipoCrecimiento.Aritmetico) ? TipoAnualidad.SerieAritmetica : TipoAnualidad.SerieGeometrica;
                Serie serie = new Serie()
                {
                    IdUser = idUser,
                    NumPeriodos = int.Parse(txtDuracion.Texts),
                    TasaInteres = decimal.Parse(txtTasaInteres.Texts) / 100,
                    TipoAnualidad = tipoAnualidad,
                    //TODO: revisar bien si debe de ir o no el periodo de gracia
                    PeriodoGracia = (perGracia < 0) ? 0 : perGracia,
                    Periodo = (Periodo)cmbFrecuenciaPago.SelectedItem,
                    //PagoAnual = (cmbTipoMovimiento.SelectedItem.Equals(TipoMovimiento.Entrada)) ? decimal.Parse(txtPagoPeriodico.Texts) : decimal.Parse(txtPagoPeriodico.Texts) * -1,
                    PagoAnual = decimal.Parse(txtPagoPeriodico.Texts),
                    Crecimiento = (cmbIncremento.SelectedItem.Equals(TipoCrecimiento.Geometrico)) ? incremento / 100 : incremento,
                    TipoDeCrecimiento = ((TipoCrecimiento)cmbIncremento.SelectedItem),
                    FuturoGradiente = futuroGrad,
                };
                //TODO: Revisar el signo del pago, entre otras cosas
                if (serie.FuturoGradiente == 0)
                    serie.FuturoGradiente = AnualidadSeriesFactory.CreateInstance(serie.TipoAnualidad).CalcularFuturoGradiente(serie);
                if (serie.Crecimiento == 0)
                    serie.Crecimiento = AnualidadSeriesFactory.CreateInstance(serie.TipoAnualidad).CalcularGradiente(serie);
                decimal vp = AnualidadSeriesFactory.CreateInstance(serie.TipoAnualidad).CalcularVP(serie);
                serie.ValorFuturo = AnualidadSeriesFactory.CreateInstance(serie.TipoAnualidad).CalcularVF(serie);
                serie.ValorPresente = vp;
                VerificarMayor((int)serie.NumPeriodos);
                return serie;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Serie();
            }
        }

        private RateDto CrearIndividual()
        {
            try
            {

                int periodo = int.Parse(txtInicio.Texts);
                RateDto interes = new RateDto()
                {

                    NumPeriodos = periodo,
                    //ValorPresente = decimal.Parse(txtValorPresente.Texts),
                    //TODO : revisar si esto es correcto, y si se tiene que ocultar
                    ValorFuturo = decimal.Parse(txtValue.Texts),
                    TasaInteres = decimal.Parse(txtTasaInteres.Texts) / 100,
                    FrecuenciaTasa = (FrecuenciaTasa)cmbFrecuenciaPago.SelectedItem,
                    TipoInteres = TipoInteres.CompuestoConTasaEfectiva,
                    IdUser = idUser,
                };
                interes.ValorPresente = InteresFactory.CreateInstance(interes.TipoInteres).CalcularVP(interes);
                VerificarMayor((int)interes.NumPeriodos);
                return interes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new RateDto();
            }
        }

        private AnnuityDto CrearAnualidad()
        {
            try
            {
                int perGracia = int.Parse(txtInicio.Texts) - 1;

                AnnuityDto anualidad = new AnnuityDto()
                {
                    IdUser = idUser,
                    NumPeriodos = int.Parse(txtDuracion.Texts),
                    TasaInteres = decimal.Parse(txtTasaInteres.Texts) / 100,
                    TipoAnualidad = GetTipoAnualidad(),
                    PeriodoGracia = (perGracia < 0) ? 0 : perGracia,
                    Periodo = (Periodo)cmbFrecuenciaPago.SelectedItem,
                    PagoAnual = (cmbTipoMovimiento.SelectedItem.Equals(TipoMovimiento.Entrada)) ? decimal.Parse(txtPagoPeriodico.Texts) : decimal.Parse(txtPagoPeriodico.Texts) * -1
                };
                decimal vp = AnualidadSeriesFactory.CreateInstance(anualidad.TipoAnualidad).CalcularVP(anualidad);
                anualidad.ValorFuturo = AnualidadSeriesFactory.CreateInstance(anualidad.TipoAnualidad).CalcularVF(anualidad);
                anualidad.ValorPresente = vp;
                VerificarMayor((int)anualidad.NumPeriodos);
                return anualidad;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new AnnuityDto();
            }

        }

        private TipoAnualidad GetTipoAnualidad()
        {
            try
            {
                if (int.Parse(txtInicio.Texts) < 0)
                {
                    throw new ArgumentException("El inicio de la anualidad no puede ser menor a 0");
                }
                if (int.Parse(txtDuracion.Texts) <= 0)
                {
                    throw new ArgumentException("La duracion no puede ser menor o igual a 0");
                }
                if (int.Parse(txtInicio.Texts) > int.Parse(txtDuracion.Texts))
                {
                    throw new ArgumentException("El periodo de gracia no puede ser mayor que la duracion de la anualidad");
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
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return TipoAnualidad.AnualidadAnticipada;
            }

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

        private void btnCalculateFlow_Click(object sender, EventArgs e)
        {
            try
            {
                unitOfWork.EconomicClient.CreateCashFlowAsync(flujo, nper);
                nper = 0;
                txtTasaInteres.Enabled = true;
                cmbFrecuenciaPago.Enabled = true;
                flujo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            try
            {
                cmbTipoCalculo.DataSource = Enum.GetValues(typeof(TipoCalculo));
                //cmbTipoCalculo.DataSource = Enum.GetValues(typeof(TipoAnualidad));
                cmbTipoMovimiento.DataSource = Enum.GetValues(typeof(TipoMovimiento));
                cmbFrecuenciaPago.DataSource = Enum.GetValues(typeof(Periodo));
                cmbIncremento.DataSource = Enum.GetValues(typeof(TipoCrecimiento));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


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
                txtPeriodoDeGracia.Enabled = !cmbTipoCalculo.SelectedItem.Equals(TipoCalculo.ValorIndividual);
                //txtPagoPeriodico.Enabled = !cmbTipoCalculo.SelectedItem.Equals(TipoCalculo.ValorIndividual);
                txtPagoPeriodico.Visible = !cmbTipoCalculo.SelectedItem.Equals(TipoCalculo.ValorIndividual);
                txtFuturoGrad.Enabled = cmbTipoCalculo.SelectedItem.Equals(TipoCalculo.Serie);
                txtValorPresente.Enabled = !cmbTipoCalculo.SelectedItem.Equals(TipoCalculo.ValorIndividual);
                cmbIncremento.Enabled = cmbTipoCalculo.SelectedItem.Equals(TipoCalculo.Serie);
                txtValue.Visible = cmbTipoCalculo.SelectedItem.Equals(TipoCalculo.ValorIndividual);

                txtValue.Texts = string.Empty;
                if (cmbTipoCalculo.SelectedItem.Equals(TipoCalculo.ValorIndividual))
                    txtPagoPeriodico.Texts = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ValidateFields()
        {
            try
            {
                //TODO: se puede quitar el textbox de valor presente, valor futuro y del per de gracia
                if (string.IsNullOrWhiteSpace(txtDuracion.Texts) || string.IsNullOrWhiteSpace(txtTasaInteres.Texts) || string.IsNullOrWhiteSpace(txtInicio.Texts))
                    throw new Exception("Debe rellenar todos los campos necesarios");
                if (!cmbTipoCalculo.SelectedItem.Equals(TipoCalculo.ValorIndividual))
                {
                    //if (string.IsNullOrWhiteSpace(txtPagoPeriodico.Texts) || string.IsNullOrWhiteSpace(txtPeriodoDeGracia.Texts))
                    if (string.IsNullOrWhiteSpace(txtPagoPeriodico.Texts))
                        throw new Exception("Debe de rellenar todos los campos necesarios");
                }
                if (cmbTipoCalculo.SelectedItem.Equals(TipoCalculo.Serie))
                {
                    if (string.IsNullOrWhiteSpace(txtIncremento.Texts) && string.IsNullOrWhiteSpace(txtFuturoGrad.Texts))
                    {
                        throw new Exception("El campo de incremento y el campo del futuro del gradiente no pueden estar vacios al mismo tiempo");
                    }
                    if (!string.IsNullOrWhiteSpace(txtIncremento.Texts) && !string.IsNullOrWhiteSpace(txtFuturoGrad.Texts))
                    {
                        throw new Exception("El campo de incremento y el campo del futuro del gradiente no pueden estar llenos al mismo tiempo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }

        }
    }
}
