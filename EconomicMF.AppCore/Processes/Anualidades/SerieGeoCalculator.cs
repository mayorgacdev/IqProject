using EconomicMF.AppCore.Contracts.Calculos;
using EconomicMF.Domain.Entities.Calculos;
using System;

namespace EconomicMF.AppCore.Processes.Anualidades
{
    public class SerieGeoCalculator : IAnualidadCalculator
    {
        public decimal CalcularFuturoGradiente(AnnuityDto serie)
        {
            double valor = Math.Pow((double)(1 + serie.Crecimiento),(double)serie.NumPeriodos-1);
            return Math.Round(serie.PagoAnual*(decimal)valor, 2);
        }

        public decimal CalcularGradiente(AnnuityDto series)
        {
            double valor = (double)(series.FuturoGradiente / series.PagoAnual);
            return Math.Round((decimal)Math.Pow(valor, 1 / ((double)series.NumPeriodos - 1)) - 1, 2);
        }

        public decimal CalcularPago(AnnuityDto series)
        {
            if (series.Crecimiento == series.TasaInteres)
            {
                double valor1 = (double)series.PagoAnual * (double)series.NumPeriodos * Math.Pow((1 + (double)(series.TasaInteres)), (double)series.NumPeriodos - 1);
                double valor2 = (double)series.TasaInteres / (Math.Pow((1 + (double)series.TasaInteres), (double)series.NumPeriodos) - 1);
                return Math.Round((decimal)(valor1 * valor2), 2);
            }
            else
            {
                double valor1 = Math.Pow((1 + (double)series.Crecimiento), (double)series.NumPeriodos);
                double valor2 = Math.Pow((1 + (double)series.TasaInteres), (double)series.NumPeriodos);
                return Math.Round((decimal)(((valor1 - valor2) / (double)(series.Crecimiento - series.TasaInteres)) * ((double)series.TasaInteres / (valor2 - 1))), 2);
            }
        }

        public decimal CalcularTasa(AnnuityDto economicClass)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularTiempo(AnnuityDto economicClass)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularVF(AnnuityDto series)
        {
            if (series.Crecimiento == series.TasaInteres)
            {
                return Math.Round(series.PagoAnual * series.NumPeriodos * (decimal)Math.Pow((1 + (double)series.TasaInteres), (double)series.NumPeriodos - 1), 2);
            }
            else
            {
                double valor1 = Math.Pow((1 + (double)series.Crecimiento), (double)series.NumPeriodos);
                double valor2 = Math.Pow((1 + (double)series.TasaInteres), (double)series.NumPeriodos);
                return Math.Round(series.PagoAnual * (decimal)(valor1 - valor2) / (series.Crecimiento - series.TasaInteres), 2);
            }
        }

        public decimal CalcularVP(AnnuityDto series)
        {
            if (series.Crecimiento == series.TasaInteres)
            {
                return Math.Round(series.PagoAnual * (series.NumPeriodos / (1 + series.TasaInteres)), 2);
            }
            else
            {
                double factor = Math.Pow((double)((1 + series.Crecimiento) / (1 + series.TasaInteres)), (int)series.NumPeriodos);
                return Math.Round(series.PagoAnual * ((decimal)factor - 1) / (series.Crecimiento - series.TasaInteres), 2);
            }
        }
    }
}
