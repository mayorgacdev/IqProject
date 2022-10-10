using EconomicMF.AppCore.Factories;
using EconomicMF.Domain.Entities.Calculos;
using EconomicMF.Domain.Enums;
using RJCodeAdvance.RJControls;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EconomicMF.Forms.FormsCalculations
{
    public partial class FrmCalculos : Form
    {
        private bool tasaFijada;


        private List<EconomicDto> flujo;
        public FrmCalculos()
        {
            InitializeComponent();

            flujo = new List<EconomicDto>();
        }

        private void FrmCalculos_Load(object sender, EventArgs e)
        {
            cmbTipoCalculo.DataSource = Enum.GetValues(typeof(TipoCalculo));
            //cmbTipoCalculo.DataSource = Enum.GetValues(typeof(TipoAnualidad));
            cmbTipoMovimiento.DataSource = Enum.GetValues(typeof(TipoMovimiento));
            cmbFrecPagos.DataSource = Enum.GetValues(typeof(Periodo));
            cmbIncremento.DataSource = Enum.GetValues(typeof(TipoCrecimiento));
            ChartConfiguration();
        }

        private void cmbTipoMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as RJTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (cmbTipoCalculo.SelectedItem)
            {
                case TipoCalculo.Anualidad:
                    AnnuityDto anualidad = CrearAnualidad();
                    flujo.Add(anualidad);
                    LLenarGrafico(anualidad.ValorPresente, (int)anualidad.NumPeriodos, anualidad.ValorFuturo, anualidad.PagoAnual, flujo.Count, anualidad.PeriodoGracia);
                    break;
                case TipoCalculo.ValorIndividual:
                    RateDto interes = CrearIndividual();
                    flujo.Add(interes);
                    LLenarGraficaIndividual(interes.ValorPresente, int.Parse(txtInicio.Texts));
                    break;
                case TipoCalculo.Serie:
                    if (int.Parse(txtInicio.Texts)<=0)
                    {
                        throw new ArgumentException("Una serie no puede comenzar en el año 0");
                        //add mas codigo
                    }
                    Serie serie = CrearSerie();
                    flujo.Add(serie);
                    //LLenarGraficoSerie();
                    LlenarGraficoSerie(serie.ValorPresente, (int)serie.NumPeriodos, serie.ValorFuturo, serie.PagoAnual, flujo.Count, serie.PeriodoGracia, serie.Crecimiento, serie.TipoDeCrecimiento);
                    break;
            }
            tasaFijada = true;
            txtTasaInteres.Enabled = false;
            cmbFrecPagos.Enabled = false;
        }
        private AnnuityDto CrearAnualidad()
        {
            if (!string.IsNullOrWhiteSpace(txtVF.Texts) && !string.IsNullOrWhiteSpace(txtVP.Texts))
            {
                throw new ArgumentException("Ambos textbox no pueden estar llenos a la vez");
            }
            TipoAnualidad tipoAnualidad= GetTipoAnualidad();
            int perGracia = int.Parse(txtInicio.Texts) - 1;

            //TipoMovimiento mov = (TipoMovimiento)cmbTipoMovimiento.SelectedItem;
            AnnuityDto anualidad = new AnnuityDto()
            {
                ValorFuturo = (txtVF.Texts != string.Empty) ? decimal.Parse(txtVF.Texts) : 0,
                ValorPresente = (txtVP.Texts != string.Empty) ? decimal.Parse(txtVP.Texts) : 0,

                NumPeriodos = int.Parse(txtDuracion.Texts),
                TasaInteres = decimal.Parse(txtTasaInteres.Texts) / 100,
                TipoAnualidad = tipoAnualidad,
                //PeriodoGracia = (tipoAnualidad.Equals(TipoAnualidad.AnualidadDiferida)) ? int.Parse(txtPerGracia.Text) : 0,
                PeriodoGracia = (perGracia<0) ? 0: perGracia,
                Periodo = (Periodo)cmbFrecPagos.SelectedValue,
                PagoAnual = (cmbTipoMovimiento.SelectedItem.Equals(TipoMovimiento.Entrada)) ? decimal.Parse(txtPago.Texts) : decimal.Parse(txtPago.Texts)*-1
                
                //PagoAnual = (mov.Equals(TipoMovimiento.Entrada) ? decimal.Parse(txtPago.Texts) : decimal.Parse(txtPago.Texts) * -1
            };
            if (anualidad.ValorFuturo ==0)
            {
                anualidad.ValorFuturo = AnualidadSeriesFactory.CreateInstance(tipoAnualidad).CalcularVF(anualidad); 
            }
            if (anualidad.ValorPresente==0)
            {
                anualidad.ValorPresente = AnualidadSeriesFactory.CreateInstance(tipoAnualidad).CalcularVP(anualidad); 
            }
            return anualidad;
        }
        private TipoAnualidad GetTipoAnualidad()
        {
            if (int.Parse(txtInicio.Texts) > int.Parse(txtDuracion.Texts))
            {
                throw new ArgumentException("El periodo de gracia no puede ser mayor que la duracion");
            }
            else if (int.Parse(txtInicio.Texts) == 0)
            {
                return TipoAnualidad.AnualidadAnticipada;
            }
            else if (int.Parse(txtInicio.Texts)>1)
            {
                return TipoAnualidad.AnualidadDiferida;
            }
            return TipoAnualidad.AnualidadOrdinaria;
        }
        private void CreateGraphic(ChartSeries chartSeries, decimal valor, decimal vf, decimal vp, int periodo)
        {
            chartSeries.Points.Add(periodo, (double)valor);
        }
        public void LLenarGrafico(decimal vp, int nPer, decimal Vf, decimal pago, int index, int perGracia)
        {
            ChartSeries series = new ChartSeries($"Anualidad {index}", ChartSeriesType.Column);
            series.Text = series.Name;


            //chcGrafica.PrimaryXAxis.LabelAlignment = StringAlignment.Center;
            //verificar si es una anualidad AnualidadOrdinaria                

            series.Points.Add(0, (double)vp);
            for(int i=perGracia+1; i<=nPer;i++)
            {
                series.Points.Add(i, (double)pago);
            }
            series.Points.Add(nPer, (double)Vf);
            chcGrafica.Series.Add(series);
            chcGrafica.Indexed = true;
            chcGrafica.Skins = Skins.Metro;

            //chcGrafica.Spacing = 5;
            series.Style.DisplayText = true;
            series.Style.TextOrientation = ChartTextOrientation.Smart;
            series.PrepareStyle += ChartSeries_PrepareStyle;
            chcGrafica.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.AutomaticMode;
            
            //this.chcGrafica.PrimaryYAxis.Range = new MinMaxInfo(-7500, 5000, 2000);
            
            //chcGrafica.PrimaryYAxis.Range = new MinMaxInfo(0,0, 10000);
            
            chcGrafica.SpacingBetweenSeries = 5;
            //chcGrafica.PrimaryYAxis.ValueType = ChartValueType.Custom;
        }

        
        public void LlenarGraficoSerie(decimal vp, int nPer, decimal Vf, decimal pago, int index, int perGracia, decimal incremento, TipoCrecimiento crecimiento)
        {
            ChartSeries series = new ChartSeries($"Serie {index}", ChartSeriesType.Column);
            series.Text = series.Name;

            //chcGrafica.PrimaryXAxis.LabelAlignment = StringAlignment.Center;
            double yValue;
            int j = 0;
            series.Points.Add(0, (double)vp);
            for (int i = perGracia + 1; i <= nPer; i++)
            {
                if (crecimiento.Equals(TipoCrecimiento.Aritmetico))
                {
                    yValue = (double)(pago+incremento * j); 
                }
                else
                {
                    yValue = (double)pago * Math.Pow((1+(double)incremento),j);
                }
                series.Points.Add(i, yValue);
                j++;
            }
            series.Points.Add(nPer, (double)Vf);
            chcGrafica.Series.Add(series);
            chcGrafica.Indexed = true;
            chcGrafica.Skins = Skins.Metro;

            //chcGrafica.Spacing = 5;
            series.Style.DisplayText = true;
            series.Style.TextOrientation = ChartTextOrientation.Smart;
            series.PrepareStyle += ChartSeries_PrepareStyle;
            chcGrafica.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.AutomaticMode;
            //this.chcGrafica.PrimaryYAxis.Range = new MinMaxInfo(-7500, 5000, 2000);
            //chcGrafica.PrimaryXAxis.Range = new MinMaxInfo(0,dataSource.Count, 20);
            chcGrafica.SpacingBetweenSeries = 5;

        }
        private void LLenarGraficaIndividual(decimal vp, int periodo)
        {
            ChartSeries series = chcGrafica.Series[0];
            //ChartSeries series = new ChartSeries($"Presente", ChartSeriesType.Column);
            series.Text = series.Name;

            //chcGrafica.PrimaryXAxis.LabelAlignment = StringAlignment.Center;

            series.Points.Add(periodo, (double)vp);
            series.Style.DisplayText = true;
            series.Style.TextOrientation = ChartTextOrientation.Smart;
            series.PrepareStyle += ChartSeries_PrepareStyle;
            chcGrafica.Series.Add(series);
        }
        public void ChartConfiguration()
        {
            chcGrafica.Spacing = 5;
            chcGrafica.PrimaryXAxis.Title = "Valor";
            chcGrafica.PrimaryYAxis.Title = "Periodo";

            chcGrafica.BackInterior = new BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.PaleTurquoise, System.Drawing.Color.LightBlue);
            chcGrafica.Legend.Visible = true;
            chcGrafica.LegendAlignment = ChartAlignment.Center;
            chcGrafica.Legend.Position = ChartDock.Top;
            chcGrafica.LegendsPlacement = ChartPlacement.Outside;
            chcGrafica.ShowToolTips = true;
            chcGrafica.Tooltip.BackgroundColor = new BrushInfo(Color.White);
            chcGrafica.Tooltip.BorderStyle = BorderStyle.FixedSingle;
            chcGrafica.Tooltip.Font = new Font("Segoe UI", 10);
            chcGrafica.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.AutomaticMode;
            //this.chcGrafica.PrimaryYAxis.Range = new MinMaxInfo(-7500, 5000, 2000);
            //chcGrafica.PrimaryXAxis.Range = new MinMaxInfo(0,dataSource.Count, 20);
            chcGrafica.EnableXZooming = true;
            chcGrafica.EnableYZooming = true;
            chcGrafica.MouseAction = ChartMouseAction.Panning;
            chcGrafica.PrimaryXAxis.ZoomActions = ChartZoomingAction.Panning;
            chcGrafica.PrimaryYAxis.ZoomActions = ChartZoomingAction.Panning;
            chcGrafica.ZoomType = ZoomType.MouseWheelZooming;
            chcGrafica.ChartFormatAxisLabel += chcGrafica_ChartFormatAxisLabel;
            AutoScroll = true;
        }
        private void txtVP__TextChanged(object sender, EventArgs e)
        {
        }

        private void txtVF__TextChanged(object sender, EventArgs e)
        {
        }
        private void chcGrafica_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            int index = (int)e.Value;
            if (e.AxisOrientation == ChartOrientation.Horizontal)
            {
                if (index >= 0 && index < flujo.Count)
                {
                    e.Label = index.ToString();
                }
            }

            e.Handled = true;
        }
        private void ChartSeries_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            ChartSeries series = sender as ChartSeries;
            int index = args.Index;
            ChartPoint point = series.Points[index];
            args.Style.ToolTip = "Año : " + point.Category + "\nValor : " + point.YValues[0];
            args.Handled = true;
        }

        private RateDto CrearIndividual()
        {
            RateDto interes = new RateDto()
            {
                NumPeriodos = int.Parse(txtDuracion.Texts),
                ValorPresente = decimal.Parse(txtVP.Texts),
                TasaInteres = decimal.Parse(txtTasaInteres.Texts),
                FrecuenciaTasa = (FrecuenciaTasa)cmbFrecPagos.SelectedValue,
                TipoInteres = TipoInteres.CompuestoConTasaEfectiva,
            };
            return interes;
        }
        private Serie CrearSerie()
        {
            decimal incremento=0;
            if (cmbIncremento.SelectedValue.Equals(TipoCrecimiento.Geometrico) || txtIncremento.Texts!=string.Empty)
            {
                incremento =decimal.Parse(txtIncremento.Texts) / 100;
            }
            int perGracia = int.Parse(txtInicio.Texts) - 1;
            TipoAnualidad tipoAnualidad = ((TipoCrecimiento)cmbIncremento.SelectedValue).Equals(TipoCrecimiento.Aritmetico) ? TipoAnualidad.SerieAritmetica : TipoAnualidad.SerieGeometrica;
            Serie serie = new Serie()
            {

                ValorFuturo = (txtVF.Texts != string.Empty) ? decimal.Parse(txtVF.Texts) : 0,
                ValorPresente = (txtVP.Texts != string.Empty) ? decimal.Parse(txtVP.Texts) : 0,

                NumPeriodos = int.Parse(txtDuracion.Texts),
                TasaInteres = decimal.Parse(txtTasaInteres.Texts) / 100,
                TipoAnualidad = tipoAnualidad,
                //PeriodoGracia = (tipoAnualidad.Equals(TipoAnualidad.AnualidadDiferida)) ? int.Parse(txtPerGracia.Text) : 0,
                PeriodoGracia = (perGracia < 0) ? 0 : perGracia,
                Periodo = (Periodo)cmbFrecPagos.SelectedValue,
                PagoAnual = (cmbTipoMovimiento.SelectedItem.Equals(TipoMovimiento.Entrada)) ? decimal.Parse(txtPago.Texts) : decimal.Parse(txtPago.Texts) * -1,
                Crecimiento = (txtIncremento.Texts != string.Empty) ? incremento : 0,
                TipoDeCrecimiento = ((TipoCrecimiento)cmbIncremento.SelectedValue)

               
            };
            return serie;
        }
        private void cmbTipoCalculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //VerifificarSeleccion();

            txtIncremento.Visible = cmbTipoCalculo.SelectedValue.Equals(TipoCalculo.Serie);
            txtPerGracia.Visible = !cmbTipoCalculo.SelectedValue.Equals(TipoCalculo.ValorIndividual);
            txtPago.Visible = !cmbTipoCalculo.SelectedValue.Equals(TipoCalculo.ValorIndividual); ;
            txtFuturoGrad.Visible = cmbTipoCalculo.SelectedValue.Equals(TipoCalculo.Serie);
            txtVP.Visible = !cmbTipoCalculo.SelectedValue.Equals(TipoCalculo.ValorIndividual);
            lblFuturoGrad.Visible = cmbTipoCalculo.SelectedValue.Equals(TipoCalculo.Serie);
            lblIncremento.Visible = cmbTipoCalculo.SelectedValue.Equals(TipoCalculo.Serie);
            lblPago.Visible = !cmbTipoCalculo.SelectedValue.Equals(TipoCalculo.ValorIndividual) ;
            lblVP.Visible = !cmbTipoCalculo.SelectedValue.Equals(TipoCalculo.ValorIndividual);
            cmbIncremento.Visible = cmbTipoCalculo.SelectedValue.Equals(TipoCalculo.Serie);
        }
        //private void VerifificarSeleccion()
        //{
        //    switch (cmbTipoCalculo.SelectedValue)
        //    {
        //        case TipoCalculo.ValorIndividual:
        //            txtIncremento.Visible = false;
        //            txtPerGracia.Visible = false;
        //            txtPago.Visible = false;
        //            txtFuturoGrad.Visible = false;
        //            txtVP.Visible = false;
        //            lblFuturoGrad.Visible = false;
        //            lblIncremento.Visible = false;
        //            lblPago.Visible = false;
        //            lblVP.Visible = false;
        //            cmbIncremento.Visible = false;
        //            break;
        //        case TipoCalculo.Anualidad:
        //            txtIncremento.Visible = false;
        //            txtPerGracia.Visible = false;
        //            txtPago.Visible = true;
        //            txtFuturoGrad.Visible = false;
        //            txtVP.Visible = true;
        //            lblFuturoGrad.Visible = false;
        //            lblIncremento.Visible = false;
        //            lblPago.Visible = true;
        //            lblVP.Visible = true;
        //            cmbIncremento.Visible = false;
        //            break;
        //        case TipoCalculo.Serie:
        //            txtIncremento.Visible = true;
        //            txtPerGracia.Visible = false;
        //            txtPago.Visible = true;
        //            txtFuturoGrad.Visible = true;
        //            txtVP.Visible = true;
        //            lblFuturoGrad.Visible = true;
        //            lblIncremento.Visible = true;
        //            lblPago.Visible = true;
        //            lblVP.Visible = true;
        //            cmbIncremento.Visible = true;
        //            break;
        //    }
        //}

        private void skyLabel12_Click(object sender, EventArgs e)
        {

        }
    }
}
