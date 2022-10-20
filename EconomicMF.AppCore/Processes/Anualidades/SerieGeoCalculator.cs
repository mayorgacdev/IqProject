using EconomicMF.AppCore.Contracts.Calculos;
using EconomicMF.Domain.Entities.Calculos;
using System;

namespace EconomicMF.AppCore.Processes.Anualidades
{
    public class SerieGeoCalculator : IAnualidadCalculator
    {
        public decimal CalcularFuturoGradiente(AnnuityDto serie)
        {
            double n = (double)(serie.NumPeriodos - serie.PeriodoGracia);
            double valor = Math.Pow((double)(1 + serie.Crecimiento),n-1);
            return Math.Round(serie.PagoAnual*(decimal)valor, 4);
        }

        public decimal CalcularGradiente(AnnuityDto series)
        {
            double n = (double)(series.NumPeriodos - series.PeriodoGracia);
            double valor = (double)(series.FuturoGradiente / Math.Abs(series.PagoAnual));
            return Math.Round((decimal)Math.Pow(valor, 1 / (n - 1)) - 1, 4);
        }

        public decimal CalcularPago(AnnuityDto series)
        {
            double n = (double)(series.NumPeriodos - series.PeriodoGracia);
            if (series.Crecimiento == series.TasaInteres)
            {
                double valor1 = (double)series.PagoAnual * n * Math.Pow((1 + (double)(series.TasaInteres)), n - 1);
                double valor2 = (double)series.TasaInteres / (Math.Pow((1 + (double)series.TasaInteres), n) - 1);
                return Math.Round((decimal)(valor1 * valor2), 4);
            }
            else
            {
                double valor1 = Math.Pow((1 + (double)series.Crecimiento), n);
                double valor2 = Math.Pow((1 + (double)series.TasaInteres), n);
                return Math.Round((decimal)(((valor1 - valor2) / (double)(series.Crecimiento - series.TasaInteres)) * ((double)series.TasaInteres / (valor2 - 1))), 4);
            }
        }
        public decimal CalcularVF(AnnuityDto series)
        {
            decimal n = (series.NumPeriodos - series.PeriodoGracia);
            if (series.Crecimiento == series.TasaInteres)
            {
                return Math.Round(series.PagoAnual * n * (decimal)Math.Pow((1 + (double)series.TasaInteres), (double)n - 1), 4);
            }
            else
            {
                double valor1 = Math.Pow((1 + (double)series.Crecimiento), (double)n);
                double valor2 = Math.Pow((1 + (double)series.TasaInteres), (double)n);
                return Math.Round(series.PagoAnual * (decimal)(valor1 - valor2) / (series.Crecimiento - series.TasaInteres), 4);
            }
        }
        public decimal CalcularVP(AnnuityDto series)
        {
            double n = (double)(series.NumPeriodos - series.PeriodoGracia);
            if (series.Crecimiento == series.TasaInteres)
            {
                return Math.Round(series.PagoAnual * ((decimal)n / (1 + series.TasaInteres)), 4);
            }
            else
            {
                double factor = Math.Pow((double)((1 + series.Crecimiento) / (1 + series.TasaInteres)), n);
                return Math.Round(series.PagoAnual * ((decimal)factor - 1) / (series.Crecimiento - series.TasaInteres), 4);
            }
        }
        #region not i
        public decimal CalcularTasa(AnnuityDto economicClass)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularTiempo(AnnuityDto economicClass)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
