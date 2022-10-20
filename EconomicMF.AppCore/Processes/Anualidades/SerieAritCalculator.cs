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
            decimal n = serie.NumPeriodos - serie.PeriodoGracia;
            decimal totalIncremento = (n - 1) * serie.Crecimiento;
            return Math.Round(serie.PagoAnual+totalIncremento,4);
        }

        public decimal CalcularGradiente(AnnuityDto series)
        {
            decimal n = series.NumPeriodos - series.PeriodoGracia;
            return Math.Round((series.FuturoGradiente - Math.Abs(series.PagoAnual)) / (n - 1), 4);
        }

        public decimal CalcularPago(AnnuityDto series)
        {
            if (series.NumPeriodos == 0)
            {
                throw new ArgumentException("El tiempo no puede ser cero");
            }
            double tasa = (double)series.TasaInteres;
            double vp = (double)series.PresentValue;
            double vf = (double)series.FutureValue;
            double n = (double)(series.NumPeriodos - series.PeriodoGracia);
            double pago = Financial.Pmt(tasa, n, vp, vf) * -1;
            double factor1 = 1 / tasa;
            double factor2 = n / ((Math.Pow((1 + tasa), n)) - 1);
            double anualidadGrad = (double)series.Crecimiento * (factor1 - factor2);
            return Math.Round((decimal)(pago + anualidadGrad), 4);
        }
        public decimal CalcularVF(AnnuityDto series)
        {
            double tasa = (double)series.TasaInteres;
            double pago = (double)series.PagoAnual * -1;
            double vp = (double)series.PresentValue;
            double n = (double)(series.NumPeriodos - series.PeriodoGracia);
            double vfAnualidad = Financial.FV(tasa, n, pago, vp);
            double factor = Math.Pow((1 + tasa), n);
            double primerTerm = (factor - 1) / (tasa * tasa);
            double segundoTerm = n / tasa;
            double vfGrad = (double)series.Crecimiento * (primerTerm - segundoTerm);
            vfGrad = (vfAnualidad < 0) ? vfGrad * -1 : vfGrad;
            return Math.Round((decimal)(vfAnualidad + vfGrad), 4);
        }

        public decimal CalcularVP(AnnuityDto series)
        {
            double tasa = (double)series.TasaInteres;
            double pago = (double)series.PagoAnual * -1;
            double vf = (double)series.FutureValue;
            double n = (double)(series.NumPeriodos - series.PeriodoGracia);
            double vpAnualidad = Financial.PV(tasa, n, pago, vf);
            double factor = Math.Pow((1 + tasa), n);
            double primerTerm = (factor - 1) / (tasa * factor);
            double segundoTerm = n / factor;
            double vpGrad = ((double)series.Crecimiento / tasa) * (primerTerm - segundoTerm);
            vpGrad = (vpAnualidad < 0) ? vpGrad * -1 : vpGrad;
            return Math.Round((decimal)(vpAnualidad + vpGrad), 4);
        }
        #region not imp
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
