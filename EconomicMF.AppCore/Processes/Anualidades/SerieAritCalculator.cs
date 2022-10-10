using EconomicMF.AppCore.Contracts.Calculos;
using EconomicMF.Domain.Entities.Calculos;
using Microsoft.VisualBasic;
using System;

namespace EconomicMF.AppCore.Processes.Anualidades
{
    public class SerieAritCalculator : IAnualidadCalculator
    {
        public decimal CalcularFuturoGradiente(AnnuityDto serie)
        {
            decimal totalIncremento = (serie.NumPeriodos - 1) * serie.Crecimiento;
            return Math.Round(serie.PagoAnual+totalIncremento,2);
        }


        public decimal CalcularGradiente(AnnuityDto series)
        {
            return Math.Round((series.FuturoGradiente - series.PagoAnual) / (series.NumPeriodos - 1), 2);
        }

        public decimal CalcularPago(AnnuityDto series)
        {
            if (series.NumPeriodos == 0)
            {
                throw new ArgumentException("El tiempo no puede ser cero");
            }
            double tasa = (double)series.TasaInteres;
            double vp = (double)series.ValorPresente;
            double vf = (double)series.ValorFuturo;
            double pago = Financial.Pmt(tasa, (double)series.NumPeriodos, vp, vf) * -1;
            double factor1 = 1 / tasa;
            double factor2 = (double)series.NumPeriodos / ((Math.Pow((1 + tasa), (double)series.NumPeriodos)) - 1);
            double anualidadGrad = (double)series.Crecimiento * (factor1 - factor2);
            return Math.Round((decimal)(pago + anualidadGrad), 2);
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
            double tasa = (double)series.TasaInteres;
            double pago = (double)series.PagoAnual * -1;
            double vp = (double)series.ValorPresente;
            double vfAnualidad = Financial.FV(tasa, (double)series.NumPeriodos, pago, vp);
            double factor = Math.Pow((1 + tasa), (double)series.NumPeriodos);
            double primerTerm = (factor - 1) / (tasa * tasa);
            double segundoTerm = (double)series.NumPeriodos / tasa;
            double vfGrad = (double)series.Crecimiento * (primerTerm - segundoTerm);
            return Math.Round((decimal)(vfAnualidad + vfGrad), 2);
        }

        public decimal CalcularVP(AnnuityDto series)
        {
            double tasa = (double)series.TasaInteres;
            double pago = (double)series.PagoAnual * -1;
            double vf = (double)series.ValorFuturo;
            double vpAnualidad = Financial.PV(tasa, (double)series.NumPeriodos, pago, vf);
            double factor = Math.Pow((1 + tasa), (double)series.NumPeriodos);
            double primerTerm = (factor - 1) / (tasa * factor);
            double segundoTerm = (double)series.NumPeriodos / factor;
            double vpGrad = ((double)series.Crecimiento / tasa) * (primerTerm - segundoTerm);
            return Math.Round((decimal)(vpAnualidad + vpGrad), 2);
        }
    }
}
