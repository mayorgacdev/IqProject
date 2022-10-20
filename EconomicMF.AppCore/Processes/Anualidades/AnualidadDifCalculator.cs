using EconomicMF.AppCore.Contracts.Calculos;
using EconomicMF.Domain.Entities.Calculos;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicMF.AppCore.Processes.Anualidades
{
    public class AnualidadDifCalculator : IAnualidadCalculator
    {
        public decimal CalcularPago(AnnuityDto anualidad)
        {
            double tasa = (double)anualidad.TasaInteres;
            double vp = (double)anualidad.PresentValue;
            double vf = (double)anualidad.FutureValue;
            double numPagos = (double)anualidad.NumPeriodos - (double)anualidad.PeriodoGracia;

            double resultado = Financial.Pmt(tasa, numPagos, vp, vf) * -1;
            resultado *= Math.Pow((1 + tasa), (double)anualidad.PeriodoGracia);
            return Math.Round((decimal)resultado, 4);
        }

        public decimal CalcularVF(AnnuityDto anualidad)
        {
            double tasa = (double)anualidad.TasaInteres;
            double pago = (double)anualidad.PagoAnual * -1;
            double vp = (double)anualidad.PresentValue;
            double numPagos = (double)anualidad.NumPeriodos - (double)anualidad.PeriodoGracia;
            vp = vp * Math.Pow((1 + tasa), (double)anualidad.PeriodoGracia);
            double resultado = Financial.FV(tasa, numPagos, pago, vp);
            return Math.Round((decimal)resultado, 4);
        }

        public decimal CalcularVP(AnnuityDto anualidad)
        {
            double tasa = (double)anualidad.TasaInteres;
            double pago = (double)anualidad.PagoAnual * -1;
            double vf = (double)anualidad.FutureValue;
            double numPagos = (double)anualidad.NumPeriodos - (double)anualidad.PeriodoGracia;
            double resultado = Financial.PV(tasa, numPagos, pago, vf);
            if (vf == 0)
            {
                resultado *= (1 / Math.Pow((1 + tasa), (double)anualidad.PeriodoGracia));
            }
            return Math.Round((decimal)resultado, 4);
        }

        public decimal CalcularGradiente(AnnuityDto series)
        {
            return 0;
        }

        public decimal CalcularFuturoGradiente(AnnuityDto serie)
        {
            return 0;
        }
        #region NoCalculso
        public decimal CalcularTasa(AnnuityDto anualidad)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularTiempo(AnnuityDto anualidad)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
